using UnityEngine;

namespace Wazash.Localizash
{
    /// <summary>
    /// Populates the LocalizationData with the data from the JSON document
    /// </summary>
    public class LocalizationDataPopulator : MonoBehaviour
    {
        [SerializeField] private LocalizationData localizationData;
        [SerializeField] private string jsonPath = "Assets/_Wazash/Localizash/JSONs/ExampleJSON.json";

        private readonly DataParser dataParser = new();

        public void PopulateLocalizationData(string json, LocalizationData data)
        {
            dataParser.ParseData(System.IO.File.ReadAllText(json), data);
        }

        public void PopulateLocalizationData()
        {
            if(localizationData == null)
            {
                Debug.LogError("LocalizationData is not assigned");
                return;
            }

            if(string.IsNullOrEmpty(jsonPath))
            {
                Debug.LogError("JSON path is not assigned");
                return;
            }

            PopulateLocalizationData(jsonPath, localizationData);
        }
    }
}

