﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SwiftyNames.V1._0
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SwiftyNamesEntities : DbContext
    {
        public SwiftyNamesEntities()
            : base("name=SwiftyNamesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Delivery> Deliveries { get; set; }
        public virtual DbSet<NewsPapersPrice> NewsPapersPrices { get; set; }
    }
}
