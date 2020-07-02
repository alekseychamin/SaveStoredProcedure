using HelperLibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Text;

namespace HelperLibrary.EF
{
    public class DBContext : DbContext
    {
        public DbSet<OfferDb> Offers { get; set; }

        public DBContext(string connectionString) : base(connectionString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OfferDb>().Property(t => t.Id)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            modelBuilder.Entity<OfferDb>().MapToStoredProcedures(s => s.Insert(u => u.HasName("InsertOffer", "dbo"))
                                                                       .Update(u => u.HasName("UpdateOffer", "dbo"))
                                                                       .Delete(u => u.HasName("DeleteOffer", "dbo")));
        }
    }
}
