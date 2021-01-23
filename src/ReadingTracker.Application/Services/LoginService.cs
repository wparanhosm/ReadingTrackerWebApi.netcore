using ReadingTracker.Domain.Interfaces;
using ReadingTracker.Domain.Services;
using System;
using System.Text;
using System.Collections.Generic;
using System.Linq.Expressions;
using ReadingTracker.Domain.Model;
using System.Linq;

namespace ReadingTracker.Application.Services
{
    public class LoginService : ILoginService
    {
        private readonly IPessoaRepository pessoaRepository;
        public LoginService(IPessoaRepository pessoaRepository)
        {
            this.pessoaRepository = pessoaRepository;
        }
        public int doLogin(string email, string senha)
        {

            List<PessoaModel> model = pessoaRepository.GetAll().ToList();


            string a = senha.ToMD5String();

            return pessoaRepository.GetAll().Where(
                e =>
                    e.isAtivo &&
                    e.Email.Equals(email) &&
                    e.Senha.ToUpper().Equals(senha.ToMD5String().ToUpper())
                )
            .Select(e => e.Id)
            .FirstOrDefault();
        }
    }
}
