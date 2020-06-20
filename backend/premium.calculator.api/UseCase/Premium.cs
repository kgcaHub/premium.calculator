using System;
using System.Net;
using System.Globalization;

namespace premium.calculator.api.UseCase
{
    internal class Premium
    {
        internal Entity.PremiumResponse Get(DateTime DateOfBirth, string State, int Age)
        {
            Entity.PremiumResponse _result = new Entity.PremiumResponse();

            this.ValidateParams(_result, DateOfBirth, State, Age);

            this.SearchPremium(_result);

            if(_result.Premium <= 0)
            {
                 throw new HttpException(HttpStatusCode.NotFound,
                                            "There is not a Premium");
            }

            return _result;
        }

        private void ValidateParams(Entity.PremiumResponse response, DateTime dateOfBirth,
                                        string state, int age)
        {
            if(dateOfBirth.IsFuture())
            {
                throw new HttpException(HttpStatusCode.BadRequest,
                                            "Date of birth can not be in future");
            }

            if (age == dateOfBirth.GetAge())
            {
                response.age = age;
                response.monthOfBirth = dateOfBirth.ToString("MMMM",
                                    CultureInfo.CreateSpecificCulture("en")).ToUpper();
            }
            else
            {
                throw new HttpException(HttpStatusCode.BadRequest,
                                            "Age does not match with the date of birth");
            }

            if (string.IsNullOrEmpty(state))
            {
                throw new HttpException(HttpStatusCode.BadRequest, "State is empty");
            }
            else
            {
                response.state = state.ToUpper();
            }
        }

        private void SearchPremium(Entity.PremiumResponse response)
        {
            foreach (var _criteria in Constants.CriteriaWildcards)
            {
                if (_criteria.State.ToUpper() != response.state)
                {
                    if (_criteria.State != "*")
                    {
                        continue;
                    }
                }
                if (_criteria.MonthOfBirth.ToUpper() != response.monthOfBirth)
                {
                    if (_criteria.MonthOfBirth != "*")
                    {
                        continue;
                    }
                }
                if (_criteria.MinAge.HasValue)
                {
                    if (_criteria.MinAge.Value > response.age)
                    {
                        continue;
                    }
                }
                if (_criteria.MaxAge.HasValue)
                {
                    if (_criteria.MaxAge.Value <= response.age)
                    {
                        continue;
                    }
                }
                response.Premium = _criteria.Premium;
                break;
            }
        }
    }
}