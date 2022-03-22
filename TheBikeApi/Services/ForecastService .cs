using Serilog;

namespace TheBikeApi.Services
{
    public interface IForecastService
    {

    }

    public class ForecastService : IForecastService
    {
        private Serilog.ILogger Log { get; }

        public ForecastService(Serilog.ILogger log)
        {
            Log = log;
        }
    }
}
