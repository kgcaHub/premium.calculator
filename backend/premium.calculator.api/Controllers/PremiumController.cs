using System;
using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace premium.calculator.api.Controllers
{

    public class PremiumController : ControllerBase
    {
        /// <summary>
        /// Match the premium value with criteria wildcard data
        /// </summary>
        /// <param name="dateOfBirth">Date Of Birth</param>
        /// <param name="state">State of U.S.</param>
        /// <param name="age">Age</param>
        [HttpGet("/api/cignium/v1/premium-calculator")]
        public IActionResult Get([FromHeader] DateTime dateOfBirth,
                                            [FromHeader] string state,
                                            [FromHeader] int age)
        {

            Entity.PremiumResponse _result = new Entity.PremiumResponse();
            try
            {
                UseCase.Premium _premium = new UseCase.Premium();
                _result = _premium.Get(dateOfBirth, state, age);
            }
            catch (HttpException ex)
            {
                return this.StatusCode((int)ex.StatusCode, ex.Message);
            }
            catch (Exception ex)
            {
                return this.StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
            return this.Ok(_result);
        }
    }
}