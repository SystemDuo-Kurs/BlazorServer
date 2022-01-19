using Microsoft.EntityFrameworkCore;

namespace BlazorServer
{
    public class Db : DbContext
    {
        public Db(DbContextOptions<Db> o) : base(o)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Test>().HasKey(t => t.Id);

            modelBuilder.Entity<Test>().HasData
            (
                new Test[]
                {
                    new Test{ Id = -1, NekiTekst="abc", NekiBroj=123},
                    new Test{ Id = -2, NekiTekst="dsa", NekiBroj=234},
                    new Test{ Id = -3, NekiTekst="zxc", NekiBroj=345},
                    new Test{ Id = -4, NekiTekst="dfg", NekiBroj=456},
                    new Test{ Id = -5, NekiTekst="rty", NekiBroj=567},
                }
            );
        }

        public DbSet<Test> Tests { get; set; }
    }
}