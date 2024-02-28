using curso_asp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace curso_asp.Data
{
    public class ContextApp : DbContext
    {
        // definir conexao dentro do db
        public ContextApp()
            :base("DefaultConnection")
        {
        }
        public virtual DbSet<Product> Product { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // definir o id
            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties()
                .Where(p => p.Name == "Id").Configure(p => p.IsKey());
        }
    }
}