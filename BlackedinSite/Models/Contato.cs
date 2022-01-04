using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlackedinSite.Models
{
    public class Contato
    {
        [Key]
        public int Id { get; set; }

        public Vaga Vaga { get; set; }

        public Profissional Profissional { get; set; }

        public int ResultadoContato { get; set; }
    }
}
