using Microsoft.Extensions.Configuration;
using ReadingTracker.Domain.Interfaces;
using ReadingTracker.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReadingTracker.Repository.Repository
{
    public class PessoaRepository : RepositoryBase<PessoaModel>, IPessoaRepository
    {
        public PessoaRepository(IConfiguration configuration) : base(configuration)
        {

        }
    }
}
