using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlackedinSite.Models
{
    public class Profissional
    {
        [Key]
        public int ProfissionalId { get; set; }
        public String Nome { get; set; }
        public String CPF { get; set; }
        public String Email { get; set; }
        public String Senha { get; set; }
        public String DtNascimento { get; set; }
        public String Endereco { get; set; }
        public String Escolaridade { get; set; }
        public String Telefone { get; set; }
        public String Experiencia { get; set; }
    }
}
