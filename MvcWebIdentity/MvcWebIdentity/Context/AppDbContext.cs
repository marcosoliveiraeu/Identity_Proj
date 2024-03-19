using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MvcWebIdentity.Entities;

namespace MvcWebIdentity.Context
{
    public class AppDbContext: IdentityDbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {}

        public DbSet<Aluno> Alunos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Aluno>().HasData(

                new Aluno
                {
                    AlunoID = 1,
                    Nome = "Marcos",
                    Email= "marcosoliveiraeu@gmail.com",
                    Idade = 41 ,
                    Curso = "Química"

                }

                );
        }

    }
}
