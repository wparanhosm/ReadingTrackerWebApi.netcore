using ReadingTracker.Application.Services;
using ReadingTracker.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServicesDependencyInjection
    {
        public static void RegisterServicesDependencyInjection(this IServiceCollection collection)
        {
            collection.AddScoped<ILoginService, LoginService>();
        }
    }
}
