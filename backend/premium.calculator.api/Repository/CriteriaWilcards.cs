using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace premium.calculator.api.Repository
{
    internal class CriteriaWilcards
    {
        internal List<Entity.CriteriaWilcard> Read()
        {
            List<Entity.CriteriaWilcard> _result = new List<Entity.CriteriaWilcard>();
            string _jsonString = File.ReadAllText(@".\db\CriteriaWilcard.json");
            _result = JsonSerializer.Deserialize<List<Entity.CriteriaWilcard>>(_jsonString);
            return _result;
        }
    }
}