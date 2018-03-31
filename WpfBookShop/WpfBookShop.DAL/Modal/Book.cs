namespace WpfBookShop.DAL.Modal
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Book : DbContext
    {
        public Book()
            : base("name=Book")
        {
        }

        public virtual DbSet<TableUsers> TableUsers { get; set; }
        public virtual DbSet<TableCity> TableCity { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
