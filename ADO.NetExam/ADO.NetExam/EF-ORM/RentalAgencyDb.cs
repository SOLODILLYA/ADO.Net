using System;
using System.Data.Entity;
using System.Linq;
using ADO.NetExam.Models;
namespace ADO.NetExam.EF_ORM
{
    public class RentalAgencyDb : DbContext
    {
        public RentalAgencyDb()
            : base("name=RentalAgencyDb")
        {
        }

        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Contract> Contracts { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<Flat> Flats { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
    }
}