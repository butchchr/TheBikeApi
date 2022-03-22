using Serilog;

namespace TheBikeApi.Services
{
    public interface ILocationService
    {
        
    }

    public class LocationService : ILocationService
    {
        private Serilog.ILogger Log { get; }

        public LocationService(Serilog.ILogger log)
        {
            Log = log;
        }

        public void GetTrailSystemLocation()
        {
           
        }
    }
}
