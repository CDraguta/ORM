using Microsoft.EntityFrameworkCore;

namespace ORM__Entity_Framework_Core_.DataModels
{
    public class Context : DbContext
    {
        public DbSet<angajat> Angajat { get; set; }
        public DbSet<angajat_proiect> AngajatProiect { get; set; }
        public DbSet<departament> Departament { get; set; }
        public DbSet<partenerAngajat> PartenerAngajat { get; set; }
        public DbSet<proiect> Proiect { get; set; }
        public DbSet<sector> Sector { get; set; }

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-TDUTIBB;Database=Companie;Trusted_Connection=True;") ;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<angajat_proiect>()
                .HasKey(c => new { c.id_angajat, c.id_proiect });
        }
    }
}
