using System;

namespace ControleEventos.Models
{
    public class Periodo
    {
        private DateTime? _database;

        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }

        public Periodo(DateTime inicio, DateTime fim, DateTime? database = null)
        {
            Inicio = inicio;
            Fim = fim;

            _database = database ?? DateTime.Today;
        }
    }
}
