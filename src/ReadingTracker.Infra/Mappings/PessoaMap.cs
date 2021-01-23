using Dapper.Dommel.FluentMapping;
using ReadingTracker.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReadingTracker.Repository.Mappings
{
    public class PessoaMap : DommelEntityMap<PessoaModel>
    {
        public PessoaMap()
        {
            ToTable("tb_rt_clientes");
            Map(e => e.Id).ToColumn("id_cliente").IsKey();
            Map(e => e.Nome).ToColumn("nome");
            Map(e => e.Email).ToColumn("email");
            Map(e => e.Senha).ToColumn("senha");
            Map(e => e.ApiId).ToColumn("apiId");
            Map(e => e.isAtivo).ToColumn("statusPessoa");
        }
    }
}
