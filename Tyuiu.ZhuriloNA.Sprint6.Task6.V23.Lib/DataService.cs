﻿using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ZhuriloNA.Sprint6.Task6.V23.Lib
{
    public class DataService : ISprint6Task6V23
    {
        public string CollectTextFromFile(string path)
        {
            var content = File.ReadAllText(path);
            var wordsWithR = content
                .Split(new[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                .Where(word => word.Contains("s"))
                .ToArray();
            return string.Join(" ", wordsWithR);
        }
    }
}
