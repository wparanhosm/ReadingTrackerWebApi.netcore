using Microsoft.Extensions.DependencyInjection;
using ReadingTracker.Domain.Interfaces;
using ReadingTracker.Repository.Context;
using ReadingTracker.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class InfraDependencyInjection
    {
        public static void ResolverDependenciasInfra(this IServiceCollection services)
        {
            RegisterMappings.Register();
            services.AddScoped<IPessoaRepository, PessoaRepository>();
        }
    }
}
