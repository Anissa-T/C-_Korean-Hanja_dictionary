using System;
using System.Collections.Generic;

namespace KoreanHanjaDictionary
{
    class Program
    {
        static LocalizationService localizationService = new LocalizationService();
        static List<DictionaryEntry> dictionary = new List<DictionaryEntry>();
        static CommandHistory history = new CommandHistory();

        static void Main(string[] args)
        {
            dictionary = DictionaryLoader.LoadDictionary("./data/kengdic.tsv");
            Console.WriteLine("Welcome to the Multilingual Hanja Dictionary! Type 'help' for command options.");

            string commandLine;
            while (true)
            {
                commandLine = Console.ReadLine().Trim();
                string[] parts = commandLine.Split(' ', 2); 
                string commandKey = parts[0].ToLower();
                string command = localizationService.TranslateCommand(commandKey);

                switch (command)
                {
                    case "help":
                        DisplayHelp();
                        break;
                    case "search":
                        if (parts.Length > 1)
                            SearchDictionary(parts[1]);
                        else
                            Console.WriteLine("Please specify a keyword to search.");
                        break;
                    case "save":
                        if (parts.Length > 1)
                            SaveNewWord(parts[1]);
                        else
                            Console.WriteLine("Please specify the word to save.");
                        break;
                    case "load":
                        history.LoadFromTextFile("search_history.json");
                        Console.WriteLine("Command history loaded.");
                        break;
                    case "changeLang":
                        if (parts.Length > 1)
                        {
                            ChangeLanguageCommand changeLanguageCommand = new ChangeLanguageCommand(localizationService, parts[1]);
                            changeLanguageCommand.Execute();
                        }
                        else
                        {
                            Console.WriteLine("Please specify a language ISO code (e.g., 'en', 'fr').");
                        }
                        break;
                    case "exit":
                        Console.WriteLine("Exiting the dictionary application.");
                        return;
                    default:
                        Console.WriteLine("Unknown command, try again.");
                        break;
                }
            }
        }

        static void DisplayHelp()
        {
            Console.WriteLine("Available Commands:");
            Console.WriteLine("help - Lists all available commands.");
            Console.WriteLine("search [word] - Searches for words in the dictionary.");
            Console.WriteLine("save [word] - Adds a new word to the TSV file.");
            Console.WriteLine("load - Loads the history of commands from a JSON file.");
            Console.WriteLine("changeLang - Changes the application language (e.g., 'en', 'fr').");
            Console.WriteLine("exit - Exits the application.");
        }

        static void SearchDictionary(string searchTerm)
        {
            searchTerm = searchTerm.Trim();
            var results = dictionary.FindAll(entry =>
                entry.Korean.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                entry.Hanja.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                entry.Definition.Contains(searchTerm, StringComparison.OrdinalIgnoreCase));

            if (results.Count > 0)
            {
                foreach (var entry in results)
                {
                    Console.WriteLine($"{entry.Korean} ({entry.Hanja}): {entry.Definition}");
                }
            }
            else
            {
                Console.WriteLine($"No entries found for your search: '{searchTerm}'.");
            }
        }

        static void SaveNewWord(string word)
        {
            Console.WriteLine($"New word '{word}' added to the dictionary (stubbed functionality).");
            history.AddCommand($"save {word}");
        }
    }
}