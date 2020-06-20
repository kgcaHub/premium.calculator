using System;

namespace premium.calculator.api.Entity
{
    public class PremiumResponse
    {
        internal string monthOfBirth { get; set; }
        internal int age { get; set; }
        internal string state { get; set; }
        public decimal Premium { get; set; }
    }
}