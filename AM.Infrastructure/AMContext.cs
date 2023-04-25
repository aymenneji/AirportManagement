using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure
{
    //instal Entity Framework Core : ORM offre des outils pour génerer DB
    public class AMContext : DbContext
    {
        // les entités qui vont etre des tab au nv DB
        //DbSet < Entity > Tables : un itermediaire entre entity et table
        //une liste d'entité
        public DbSet<Flight>  Flights { get; set; }

        public DbSet<Plane> Planes { get; set; }

        public DbSet<Passenger> Passengers{ get; set; }

        public DbSet<Traveller> Travellers{ get; set; }

        public DbSet<Staff> Staffs { get; set; }

        //3 Chaine de cnx : 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
            Initial Catalog=AymenNEJI;
            Integrated Security=true;MultipleActiveResultSets=true");
        }
        //4 lancement des commandes 
        /*
         * 1- Add-migrration Nom_Mig : enregistrer les modification ds code 
         * 2- Update-Database 
         * 
         */
        
    }
}
