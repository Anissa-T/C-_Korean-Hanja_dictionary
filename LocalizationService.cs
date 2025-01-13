using System;
using System.Collections.Generic;

namespace KoreanHanjaDictionary
{
    public class LocalizationService
    {
        private Dictionary<string, Dictionary<string, string>> translations;
        private string currentLanguage;

        public LocalizationService()
        {
            currentLanguage = "en"; 
            translations = new Dictionary<string, Dictionary<string, string>>()
            {
                { "en", new Dictionary<string, string>
                    {
                        { "help", "help" },
                        { "search", "search" },
                        { "save", "save" },
                        { "load", "load" },
                        { "changeLang", "changeLang" },
                        { "exit", "exit" }
                    }
                },
                { "fr", new Dictionary<string, string>
                    {
                        { "aide", "help" },
                        { "recherche", "search" },
                        { "sauvegarder", "save" },
                        { "charger", "load" },
                        { "changerLangue", "changeLang" },
                        { "sortie", "exit" }
                    }
                }
            };
        }

        public string TranslateCommand(string input)
        {

            input = input.ToLowerInvariant();

            if (translations[currentLanguage].TryGetValue(input, out string translated))
            {
                Console.WriteLine($"Translated '{input}' to '{translated}' in '{currentLanguage}'.");
                return translated;
            }

            Console.WriteLine($"Unknown command '{input}' in '{currentLanguage}'.");
            return "unknown";
        }

        public void ChangeLanguage(string newLang)
        {
            if (translations.ContainsKey(newLang))
            {
                currentLanguage = newLang;
                Console.WriteLine($"Language changed to {newLang}.");
            }
            else
            {
                Console.WriteLine("Requested language not supported.");
            }
        }
    }
}