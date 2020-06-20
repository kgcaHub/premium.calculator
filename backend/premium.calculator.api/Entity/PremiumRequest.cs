using System;

namespace premium.calculator.api.Entity
{
    public class PremiumRequest
    {
        public DateTime DateOfBirth { get; set; }
        public string State {get; set;}
        public int Age {get; set;}
    }
}