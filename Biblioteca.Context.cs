﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BibliotecaN
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BibliotecaEntities : DbContext
    {
        public BibliotecaEntities()
            : base("name=BibliotecaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Person> People { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Domain> Domains { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Lend> Lends { get; set; }
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
    
        public virtual ObjectResult<return_card_Result2> return_card(Nullable<int> id_membru)
        {
            var id_membruParameter = id_membru.HasValue ?
                new ObjectParameter("id_membru", id_membru) :
                new ObjectParameter("id_membru", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<return_card_Result2>("return_card", id_membruParameter);
        }
=======
        public DbSet<booksView> booksViews { get; set; }
>>>>>>> a67c77aaf975614773554114d907f6855b8480e3
=======
>>>>>>> parent of 26695d7... Library card form
=======
>>>>>>> parent of 26695d7... Library card form
    }
}
