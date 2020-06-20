using System;
using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace premium.calculator.api.Controllers
{
    public class PremiumController : ControllerBase
    {
        [HttpGet("/api/cignium/v1/premium-calculator")]
        public IActionResult Get([FromHeader] DateTime DateOfBirth,
                                            [FromHeader] string State,
                                            [FromHeader] int Age)
        {

            Entity.PremiumResponse _result = new Entity.PremiumResponse();
            try
            {
                UseCase.Premium _premium = new UseCase.Premium();
                _result = _premium.Get(DateOfBirth, State, Age);
            }
            catch(HttpException ex)
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