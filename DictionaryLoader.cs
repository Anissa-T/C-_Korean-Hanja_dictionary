using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace KoreanHanjaDictionary
{
    public static class DictionaryLoader
    {
        public static List<DictionaryEntry> LoadDictionary(string filePath)
        {
            List<DictionaryEntry> entries = new List<DictionaryEntry>();

            try
            {
                var lines = File.ReadAllLines(filePath, Encoding.UTF8).Skip(1);
                foreach (var line in lines)
                {
                    var parts = line.Split('\t');
                    if (parts.Length >= 4)
                    {
                        entries.Add(new DictionaryEntry
                        {
                            Id = int.Parse(parts[0]),
                            Korean = parts[1],
                            Hanja = parts[2],
                            Definition = parts[3]
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to load dictionary: {ex.Message}");
            }

            return entries;
        }
    }
}