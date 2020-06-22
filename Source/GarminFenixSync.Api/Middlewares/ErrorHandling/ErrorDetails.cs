﻿using Newtonsoft.Json;

namespace MyGarmin.Dashboard.Api.Middlewares.ErrorHandling
{
    internal class ErrorDetails
    {
        public int StatusCode { get; set; }

        public string Message { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
