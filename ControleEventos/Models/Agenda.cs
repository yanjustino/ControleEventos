using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEventos.Models
{
    public class Agenda
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Evento> Eventos { get; set; }
    }
}
