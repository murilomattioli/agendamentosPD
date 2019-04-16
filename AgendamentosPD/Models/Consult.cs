using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AgendamentosPD.Models
{
    public class Consult: DbContext
    {
        public DbSet<Sala> Salas { get; set; }
        public DbSet<Agendamento> Agendamentos { get; set; }
    }
}