using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Modelo.entidades;

namespace ModeloDB
{
    public class PruebaDB : DbContext 
    {

        public DbSet<Actor> actors { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Film_Actor> film_Actors { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connSQL = "server=DESKTOP-R1P6HVR; database=Biblioteca; user id=sa; password=Admin123";


            optionsBuilder.UseSqlServer(connSQL);

        }



    }
}
