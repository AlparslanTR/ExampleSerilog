using Serilog;
using Serilog.Core;

namespace ExampleSerilog.Logging
{
    public class SerilogConfigure
    {
        // Log Ayarları dinamik olarak burada yapılmalıdır.
        public static Logger ConfigureLogger()
        {
            return new LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo.Console()
                .WriteTo.File("Log Kayıtları/HavaTahminLog-.txt", rollingInterval: RollingInterval.Minute)
                .CreateLogger();
        }
    }
}
