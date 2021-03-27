using System;
using System.IO;
using System.Reflection;
using log4net;
using log4net.Config;

namespace ReadText
{
    class Program
    {
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod()?.DeclaringType);
        static void Main(string[] args)
        {
            // Load configuration
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));
 
            Console.WriteLine("Hello world!");
 
            // Log some things
            _log.Info("Hello logging world!");
            _log.Error("Error!");
            _log.Warn("Warn!");
 
            Console.ReadLine();
        }
    }
}