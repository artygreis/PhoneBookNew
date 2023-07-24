﻿using System.Text.Json;

namespace PhoneBook.Types
{
    public class AppSettings<T> where T : new()
    {
        private const string DEFAULT_FILENAME = @"..\settings.data";
        
        public AppSettings()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
        }
        public void Save(string fileName = DEFAULT_FILENAME)
        {
            var t = this as Settings.Settings;
            File.WriteAllText(fileName, JsonSerializer.Serialize(t));
        }

        public static T Load(string fileName = DEFAULT_FILENAME)
        {
            T t = new T();
            if (File.Exists(fileName))
            {
                t = JsonSerializer.Deserialize<T>(File.ReadAllText(fileName))!;
            }   
            return t;
        }
        public static void DeleteFileSettings(string fileName = DEFAULT_FILENAME)
        {
            if (File.Exists(fileName))
                File.Delete(fileName);
        }
    }
}
