
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvrakYonetimSistemi.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("DESKTOP-J1IDSF4\\SQLEXPRESS; database=EvrakDB; integrated security=true");
        }
        public DbSet<EvrakTipi> EvrakTipis { get; set; }
        public DbSet<Evrak> Evraks { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
