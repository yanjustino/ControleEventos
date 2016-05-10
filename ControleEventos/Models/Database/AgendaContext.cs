using ControleEventos.Migrations;
using System.Data.Entity;
using System.Linq;
using System.Collections.Generic;

namespace ControleEventos.Models.Database
{
    public class AgendaContext : DbContext
    {
        public DbSet<Agenda> Agendas { get; set; }
        public DbSet<Evento> Eventos { get; set; }

        public AgendaContext() : base("myConnection")
        {
            System.Data.Entity.Database.SetInitializer(new MigrateDatabaseToLatestVersion<AgendaContext, Configuration>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agenda>().ToTable("Agendas");
            modelBuilder.Entity<Evento>().ToTable("Eventos");

            base.OnModelCreating(modelBuilder);
        }
    }
}
