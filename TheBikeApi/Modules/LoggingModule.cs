﻿using Autofac;
using Serilog;

namespace TheBikeApi.Modules
{
    public class LoggingModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(CreateLogger)
                .As<Serilog.ILogger>();
        }

        private Serilog.ILogger CreateLogger(IComponentContext context)
        {
            var config = context.Resolve<LoggerConfiguration>();
            return config.CreateLogger();
        }
    }
}
