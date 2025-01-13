using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace KoreanHanjaDictionary
{
    public static class DictionaryFileHandler
    {
        public static void SaveToJson(string path, List<DictionaryEntry> dictionary)
        {
            string json = JsonConvert.SerializeObject(dictionary, Formatting.Indented);
            File.WriteAllText(path, json);
        }

        public static List<DictionaryEntry> LoadFromJson(string path)
        {
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                return JsonConvert.DeserializeObject<List<DictionaryEntry>>(json) ?? new List<DictionaryEntry>();
            }
            return new List<DictionaryEntry>();
        }
    }
}