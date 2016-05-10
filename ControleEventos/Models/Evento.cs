using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEventos.Models
{
    public class Evento
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public Endereco Local { get; set; }
        public Periodo PeriodoEvento { get; set; }
    }
}
