using Autofac;
using TheBikeApi.Services;

namespace TheBikeApi.ContainerProvider
{
    public class ServicesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<LocationService>()
                .As<ILocationService>()
                .SingleInstance();

            builder.RegisterType<ForecastService>()
                .As<IForecastService>()
                .SingleInstance();
        }
    }
}
