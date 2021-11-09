using StatisticsAnalysisTool.Avalonia.Common;

namespace StatisticsAnalysisTool.Avalonia.Models.ItemSearch
{
    public class ItemSearchObject
    {
        public string LocalizationNameVariable { get; set; } = "";

        public string LocalizationDescriptionVariable { get; set; } = "";

        public LocalizedNames? LocalizedNames { get; set; }
        
        public int Index { get; set; }
        
        public string UniqueName { get; set; } = "UNKNOWN";

        public string LocalizedNameAndEnglish => LanguageController.CurrentCultureInfo?.TextInfo.CultureName.ToUpper() == "EN-US"
            ? $"{ItemController.LocalizedName(LocalizedNames, LanguageController.CurrentCultureInfo?.TextInfo.CultureName.ToUpper(), UniqueName)}{GetUniqueNameIfDebug()}"
            : $"{ItemController.LocalizedName(LocalizedNames, LanguageController.CurrentCultureInfo?.TextInfo.CultureName.ToUpper(), UniqueName)}" +
              $"\n{ItemController.LocalizedName(LocalizedNames, "EN-US", string.Empty)}{GetUniqueNameIfDebug()}";

        public string LocalizedName => ItemController.LocalizedName(LocalizedNames, LanguageController.CurrentCultureInfo?.TextInfo.CultureName.ToUpper(), UniqueName);

        private string GetUniqueNameIfDebug()
        {
#if DEBUG
            return $"\n{UniqueName}";
#else
            return string.Empty;
#endif
        }
    }
}