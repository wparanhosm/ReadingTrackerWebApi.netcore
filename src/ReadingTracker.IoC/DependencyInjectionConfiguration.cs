using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class DependencyInjectionConfiguration
    {
        public static void ResolverDependencias(this IServiceCollection collection, IConfiguration configuraton)
        {
            collection.AddSingleton(configuraton);
            collection.ResolverDependenciasInfra();
            collection.RegisterServicesDependencyInjection();
        }
    }
}
