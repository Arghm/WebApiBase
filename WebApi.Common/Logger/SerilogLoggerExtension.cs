using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Core;
using Serilog.Events;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace WebApi.Common
{
    public static class SerilogLoggerExtension
    {
        public static ILoggerFactory UseSerilogLogger(this ILoggerFactory logFactory, IConfiguration config)
        {
            SerilogLogger.InitLogger(config);

            return logFactory.AddSerilog();
        }
    }

    public class DemystifiedStackTraceEnricher : ILogEventEnricher
    {
        public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
        {
            logEvent.Exception?.Demystify();
        }
    }
}
