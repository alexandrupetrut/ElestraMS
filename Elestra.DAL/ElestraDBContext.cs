using Elestra.BOL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Annotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elestra.DAL
{
    public class ElestraDBContext : DbContext
    {
        public ElestraDBContext():base("Elestra")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ElestraDBContext, Elestra.DAL.Migrations.Configuration>());
        }

        public DbSet<Role> Roles { get; set; }
        public DbSet<Employee> Employees { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Employee>().Property(p => p.Email).HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute() { IsUnique = true }));
        //}
    }
}
