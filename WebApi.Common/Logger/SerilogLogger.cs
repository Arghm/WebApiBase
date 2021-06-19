using Microsoft.Extensions.Configuration;
using Serilog;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.Common
{
    public static class SerilogLogger
    {
        private static bool _isRun;
        public static void InitLogger(IConfiguration config)
        {
            //var options = GetConfigFromAppSettings(config);
            //InitLogger(options);
        }

        //public static void InitLogger(SerilogOptions options)
        //{
        //    CheckSingleRun();
        //    Log.Logger = GetLoggerConfig(options);
        //}

        //private static ILogger GetLoggerConfig(SerilogOptions options)
        //{
        //    const long _fileSize10MB = 10385760;
        //    const string outputTemp = "{Timestamp:yyyy-MM-dd HH:mm:ss.fff} [{Level:u3}] {Message:lj}{NewLine}{Exception}";

        //    if (options == null)
        //        throw new ArgumentNullException(nameof(SerilogOptions));

        //    var lgConfig = new LoggerConfiguration();

        //    lgConfig.Enrich.With(new DemystifiedStackTraceEnricher());


        //}

        //private static void CheckSingleRun()
        //{
        //    if (_isRun)
        //        throw new ApplicationException("Повторная инициализация логгера.");

        //    _isRun = true;
        //}
    }
}
