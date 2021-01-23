using ReadingTracker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ReadingTracker.Domain.Model
{
    [Table("tb_rt_clientes")]
    public class PessoaModel : Entity
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string DataNascimento { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string ApiId { get; set; }
        public bool isAtivo { get; set; }
    }
}
