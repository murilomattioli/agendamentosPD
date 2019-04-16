using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AgendamentosPD.Models
{
    public class Sala
    {
        [Key]
        public int id { get; set; }
        public int numero { get; set; }
        public int bloco { get; set; }
    }
}