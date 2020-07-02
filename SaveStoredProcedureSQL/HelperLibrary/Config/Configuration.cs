using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace HelperLibrary.Config
{
    public class Configuration
    {
        private readonly string _fileName;

        public Configuration(string fileName)
        {
            _fileName = fileName;
        }

        public ConfigurationModel GetConfiguration()
        {
            var jsonString = File.ReadAllText(_fileName);
            ConfigurationModel model = JsonSerializer.Deserialize<ConfigurationModel>(jsonString);

            return model;
        }
    }
}
