using System;
using System.Collections.Generic;
using System.IO;

namespace KoreanHanjaDictionary
{
    public class CommandHistory
    {
        private List<string> commands = new List<string>();

        public void AddCommand(string command)
        {
            commands.Add(command);
        }

        public void SaveToTextFile(string filePath)
        {
            File.WriteAllLines(filePath, commands);
        }

        public void LoadFromTextFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                commands = new List<string>(File.ReadAllLines(filePath));
            }
        }
    }
}