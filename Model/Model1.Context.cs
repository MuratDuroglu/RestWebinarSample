﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestWebinarSample.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TIGERENTEntities1 : DbContext
    {
        public TIGERENTEntities1()
            : base("name=TIGERENTEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<LG_990_01_EBOOKDETAILDOC> LG_990_01_EBOOKDETAILDOC { get; set; }
        public virtual DbSet<LG_990_01_EMFICHE> LG_990_01_EMFICHE { get; set; }
        public virtual DbSet<LG_990_01_EMFLINE> LG_990_01_EMFLINE { get; set; }
        public virtual DbSet<LG_990_EMUHACC> LG_990_EMUHACC { get; set; }
    }
}
