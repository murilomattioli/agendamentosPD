using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AgendamentosPD.Models
{
    public class Agendamento
    {
        [Key]
        public int id { get; set; }
        public string titulo { get; set; }
        public int idSala { get; set; }
        [ForeignKey("idSala")]
        public Sala Sala { get; set; }
        public DateTime inicio { get; set; }
        public DateTime fim { get; set; }
    }
}