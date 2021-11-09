using System.Text.Json.Serialization;

namespace StatisticsAnalysisTool.Avalonia.Models.ItemSearch
{
    public class ItemSearchJsonObject
    {
        [JsonPropertyName("LocalizationNameVariable")]
        public string? LocalizationNameVariable { get; set; }

        [JsonPropertyName("LocalizationDescriptionVariable")]
        public string? LocalizationDescriptionVariable { get; set; }

        [JsonPropertyName("LocalizedNames")] 
        public LocalizedNames? LocalizedNames { get; set; }

        [JsonPropertyName("Index")] 
        public int Index { get; set; }

        [JsonPropertyName("UniqueName")] 
        public string? UniqueName { get; set; }
    }
}