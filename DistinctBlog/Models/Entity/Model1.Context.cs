﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DistinctBlog.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DistinctMvcDbEntities1 : DbContext
    {
        public DistinctMvcDbEntities1()
            : base("name=DistinctMvcDbEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TBLHAKKINDA> TBLHAKKINDA { get; set; }
        public virtual DbSet<TBLILETISIM> TBLILETISIM { get; set; }
    }
}
