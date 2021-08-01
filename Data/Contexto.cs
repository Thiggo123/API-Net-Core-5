using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Net_Core;

namespace API_Net_Core
{
    public class ContextDB : DbContext
    {


        public ContextDB(DbContextOptions<ContextDB> options) : base(options)
        {

        }



        public DbSet<Pessoa> Pessoa { get; set; }

        public DbSet<Tarefa> Tarefa { get; set; }





        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>().HasData(
                new Pessoa { Id = 1, Nome = "Adam1", Email = "teste123@.com" },
                new Pessoa { Id = 2, Nome = "Adam2", Email = "teste123@.com" },
                new Pessoa { Id = 3, Nome = "Adam3", Email = "teste123@.com" }
                );

            modelBuilder.Entity<Tarefa>().HasData(
                new Tarefa { Id = 1, Descr = "teste" },
                new Tarefa { Id = 2, Descr = "teste2" },
                new Tarefa { Id = 3, Descr = "teste3" }
                );




        }




    }
}
