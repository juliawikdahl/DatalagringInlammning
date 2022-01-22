using Entityframework_Inlamning.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entityframework_Inlamning.Data
{
    internal class SqlContext : DbContext

    {
        public SqlContext()
        {
        }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {
        }

     
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Errand> Errands { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\win21\Inlamning_datalagring\Entityframework_Inlamning\Entityframework_Inlamning\Data\Entityframework_WPF.mdf;Integrated Security=True;Connect Timeout=30");
        }
    }
}
