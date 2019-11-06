using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace Bodhi.XYLib
{
    public class XYLibWebTestStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<XYLibWebTestModule>();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            app.InitializeApplication();
        }
    }
}