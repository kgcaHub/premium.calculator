using System;
using System.Net;

namespace premium.calculator.api
{
    public class HttpException : Exception
    {
        internal HttpStatusCode StatusCode { get; set; }
        public HttpException(HttpStatusCode statusCode, string message) : base(message)
        {
            this.StatusCode = statusCode;
        }
    }
}