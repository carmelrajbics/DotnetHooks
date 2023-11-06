using Serilog;

namespace HookProxy
{
    public class LogRedirctor
    {
        public LogRedirctor()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.File("logs/weatherapi.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();
            Console.SetOut(new LogWritter());
        }
    }
}
