using System;
using System.Collections.Generic;

namespace premium.calculator.api
{
    internal static class Constants
    {
        internal static List<Entity.CriteriaWildcard> CriteriaWildcards;

        internal static int GetAge(this DateTime me)
        {
            int _result = 0;

            _result = DateTime.Now.Year - me.Year;
            if (DateTime.Now.DayOfYear < me.DayOfYear)
                _result = _result - 1;

            return _result;
        }

        internal static bool IsFuture(this DateTime me)
        {
            return me > DateTime.Now;
        }
    }
}