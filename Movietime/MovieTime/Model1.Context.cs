﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Webapplikasjoner_Del_1_2018
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DBFilm> DBFilms { get; set; }
        public virtual DbSet<DBKunde> DBKundes { get; set; }
        public virtual DbSet<DBOrdre> DBOrdres { get; set; }
        public virtual DbSet<DBOrdrelinje> DBOrdrelinjes { get; set; }
        public virtual DbSet<DBPoststed> DBPoststeds { get; set; }
        public virtual DbSet<DBSjanger> DBSjangers { get; set; }
    }
}