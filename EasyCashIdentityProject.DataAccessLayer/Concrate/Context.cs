using EasyCashIdentityProject.EntityLayer;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.DataAccessLayer.Concrate
{
    public class Context:IdentityDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-623S80S\\SQLEXPRESS;initial catalog=EasyCashDb;integrated Security=true");

        }
        public DbSet<CostumerAccount> CostumerAccounts { get; set; }
        public DbSet<CostumerAccountProcess> CostumerAccountProcesses { get; set; }


    }
}
