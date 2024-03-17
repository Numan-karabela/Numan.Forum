using Serilog;

namespace N_ForumApi.Middlewares
{
   static public  class ConfigureSerilogExtension
    {
        public static void AddSeriLogHandler(this IServiceCollection services)
        {

            Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
           .WriteTo.File("logs/log.txt").CreateLogger();

        }

    }
}
