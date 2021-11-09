using StatisticsAnalysisTool.Avalonia.Models.ItemSearch;
using StatisticsAnalysisTool.Common.AppSettings;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using log4net;
using StatisticsAnalysisTool.Avalonia.Enums;

namespace StatisticsAnalysisTool.Avalonia.Common
{
    public class ItemController
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod()?.DeclaringType);
        public static ObservableCollection<ItemSearchObject> ItemSearchObjects;

        #region Item search list

        public static async Task<bool> GetItemListFromJsonAsync()
        {
            var url = GetItemListSourceUrlIfExist();
            var localFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, SettingsDefault.ItemListFileName);

            if (string.IsNullOrEmpty(url))
            {
                return false;
            }

            if (File.Exists(localFilePath))
            {
                var fileDateTime = File.GetLastWriteTime(localFilePath);

                if (fileDateTime.AddDays(SettingsController.CurrentSettings.UpdateItemListByDays) < DateTime.Now)
                {
                    if (await GetItemListFromWebAsync(url))
                    {
                        ItemSearchObjects = await GetItemListFromLocal();
                    }
                    return ItemSearchObjects?.Count > 0;
                }

                ItemSearchObjects = await GetItemListFromLocal();
                return ItemSearchObjects?.Count > 0;
            }

            if (await GetItemListFromWebAsync(url))
            {
                ItemSearchObjects = await GetItemListFromLocal();
            }
            return ItemSearchObjects?.Count > 0;
        }

        private static string GetItemListSourceUrlIfExist()
        {
            var url = SettingsController.CurrentSettings.ItemListSourceUrl;

            if (string.IsNullOrEmpty(url))
            {
                url = SettingsDefault.DefaultItemListSourceUrl;

                if (!string.IsNullOrEmpty(url))
                {
                    SettingsController.CurrentSettings.ItemListSourceUrl = SettingsDefault.DefaultItemListSourceUrl;
                    //_ = MessageBox.Show(LanguageController.Translation("DEFAULT_ITEMLIST_HAS_BEEN_LOADED"), LanguageController.Translation("NOTE"));
                }
            }

            return url;
        }

        private static async Task<ObservableCollection<ItemSearchObject>> GetItemListFromLocal()
        {
            try
            {
                var options = new JsonSerializerOptions()
                {
                    NumberHandling = JsonNumberHandling.AllowReadingFromString |
                                     JsonNumberHandling.WriteAsString
                };

                var localItemString = await File.ReadAllTextAsync($"{AppDomain.CurrentDomain.BaseDirectory}{SettingsDefault.ItemListFileName}", Encoding.UTF8);
                return ConvertItemJsonObjectToItem(JsonSerializer.Deserialize<IEnumerable<ItemSearchJsonObject>>(localItemString, options));
            }
            catch
            {
                DeleteItemList();
                return new ObservableCollection<ItemSearchObject>();
            }
        }

        private static void DeleteItemList()
        {
            if (File.Exists($"{AppDomain.CurrentDomain.BaseDirectory}{SettingsDefault.ItemListFileName}"))
            {
                try
                {
                    File.Delete($"{AppDomain.CurrentDomain.BaseDirectory}{SettingsDefault.ItemListFileName}");
                }
                catch (Exception e)
                {
                    Log.Error(MethodBase.GetCurrentMethod()?.Name, e);
                }
            }
        }

        private static ObservableCollection<ItemSearchObject> ConvertItemJsonObjectToItem(IEnumerable<ItemSearchJsonObject>? itemJsonObjectList)
        {
            var result = itemJsonObjectList?.Select(item => new ItemSearchObject
            {
                LocalizationNameVariable = item.LocalizationNameVariable ?? "",
                LocalizationDescriptionVariable = item.LocalizationDescriptionVariable ?? "",
                LocalizedNames = item.LocalizedNames,
                Index = item.Index,
                UniqueName = item.UniqueName ?? ""
            }).ToList();

            return new ObservableCollection<ItemSearchObject>(result ?? new List<ItemSearchObject>());
        }

        private static async Task<bool> GetItemListFromWebAsync(string url)
        {
            using var client = new HttpClient
            {
                Timeout = TimeSpan.FromSeconds(300)
            };
            try
            {
                using var response = await client.GetAsync(url);
                using var content = response.Content;

                var fileString = await content.ReadAsStringAsync();
                await File.WriteAllTextAsync($"{AppDomain.CurrentDomain.BaseDirectory}{SettingsDefault.ItemListFileName}", fileString, Encoding.UTF8);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //public static async Task SetFavoriteItemsFromLocalFileAsync()
        //{
        //    var localFilePath = $"{AppDomain.CurrentDomain.BaseDirectory}{SettingsDefault.FavoriteItemsFileName}";
        //    if (File.Exists(localFilePath))
        //    {
        //        try
        //        {
        //            var localItemString = await File.ReadAllTextAsync(localFilePath, Encoding.UTF8);

        //            var favoriteItemList = JsonSerializer.Deserialize<List<string>>(localItemString);

        //            if (favoriteItemList != null)
        //            {
        //                foreach (var uniqueName in favoriteItemList)
        //                {
        //                    var item = ItemSearchObjects.FirstOrDefault(i => i.UniqueName == uniqueName);
        //                    if (item != null)
        //                    {
        //                        item.IsFavorite = true;
        //                    }
        //                }
        //            }
        //        }
        //        catch (Exception e)
        //        {
        //        }
        //    }
        //}

        //public static void SaveFavoriteItemsToLocalFile()
        //{
        //    var localFilePath = $"{AppDomain.CurrentDomain.BaseDirectory}{SettingsDefault.FavoriteItemsFileName}";
        //    var favoriteItems = ItemSearchObjects?.Where(x => x.IsFavorite);
        //    var toSaveFavoriteItems = favoriteItems?.Select(x => x.UniqueName);
        //    var fileString = JsonSerializer.Serialize(toSaveFavoriteItems);

        //    try
        //    {
        //        File.WriteAllText(localFilePath, fileString, Encoding.UTF8);
        //    }
        //    catch (Exception e)
        //    {
        //    }
        //}

        #endregion

        #region Helper methods

        public static string LocalizedName(LocalizedNames? localizedNames, string? currentLanguage = null, string alternativeName = "NO_ITEM_NAME")
        {
            if (localizedNames == null)
            {
                return alternativeName;
            }

            if (string.IsNullOrEmpty(currentLanguage))
            {
                currentLanguage = LanguageController.CurrentCultureInfo?.TextInfo.CultureName.ToUpper();
            }

            return FrequentlyValues.GameLanguages.FirstOrDefault(x => string.Equals(x.Value, currentLanguage, StringComparison.CurrentCultureIgnoreCase)).Key switch
            {
                GameLanguage.UnitedStates => localizedNames.EnUs,
                GameLanguage.Germany => localizedNames.DeDe,
                GameLanguage.Russia => localizedNames.RuRu,
                GameLanguage.Poland => localizedNames.PlPl,
                GameLanguage.Brazil => localizedNames.PtBr,
                GameLanguage.France => localizedNames.FrFr,
                GameLanguage.Spain => localizedNames.EsEs,
                GameLanguage.Chinese => localizedNames.ZhCn,
                _ => alternativeName
            };
        }

        #endregion
    }
}