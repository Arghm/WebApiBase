using Serilog;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.Common
{
    /// <summary>
    /// Ошибка сервиса WebApi
    /// </summary>
    public class WebApiServiceException : Exception
    {
        public WebApiServiceException(string message) : base(message) { }
        public WebApiServiceException(string message, Exception inner) : base (message, inner) { }
        public WebApiServiceException(string message, ILogger logger) : base(message) { logger?.Error(message, this); }
        public WebApiServiceException(string message, Exception inner, ILogger logger) : base(message, inner) { logger?.Error(message, this); }
    }
}
