using Dapper.FluentMap;
using Dapper.FluentMap.Dommel;
using ReadingTracker.Repository.Mappings;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReadingTracker.Repository.Context
{
    public static class RegisterMappings
    {
        public static void Register()
        {
            FluentMapper.Initialize(config =>
            {
                config.AddMap(new PessoaMap());
                config.ForDommel();
            });
        }
    }
}
