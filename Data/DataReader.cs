using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Collections.Generic;

namespace PersonalDev.Data
{
    public class DataReader
    {
        private static readonly Dictionary<string, string> TestData = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.OpenText(AppDomain.CurrentDomain.BaseDirectory + "//Data//TestData.json").ReadToEnd());

        public static string ReadItem(string fileName, string itemName)
        {
            if (fileName == "TestData.json")
            {
                return TestData[itemName];
            }
            throw new Exception($"Value {itemName} not found in file {fileName}");
        }
    }
}
