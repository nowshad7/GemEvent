﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EventPlanner_
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GemDBEntities1 : DbContext
    {
        public GemDBEntities1()
            : base("name=GemDBEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Director> Directors { get; set; }
        public virtual DbSet<EventManager> EventManagers { get; set; }
        public virtual DbSet<OrderEvent> OrderEvents { get; set; }
        public virtual DbSet<OrganizeEvent> OrganizeEvents { get; set; }
        public virtual DbSet<Photographer> Photographers { get; set; }
        public virtual DbSet<Vanue> Vanues { get; set; }
    }
}
