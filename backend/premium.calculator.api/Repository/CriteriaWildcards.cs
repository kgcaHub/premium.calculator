using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace premium.calculator.api.Repository
{
    internal class CriteriaWildcards
    {
        internal List<Entity.CriteriaWildcard> Read()
        {
            List<Entity.CriteriaWildcard> _result = new List<Entity.CriteriaWildcard>();
            string _jsonString = File.ReadAllText(@".\db\CriteriaWildcard.json");
            _result = JsonSerializer.Deserialize<List<Entity.CriteriaWildcard>>(_jsonString);
            return _result;
        }
    }
}