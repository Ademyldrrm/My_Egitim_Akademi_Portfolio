﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyEğitimAkademi_Portfolio.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MyPortfolioDbEntities : DbContext
    {
        public MyPortfolioDbEntities()
            : base("name=MyPortfolioDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<About> About { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<Testimonial> Testimonial { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Skill> Skill { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<Adress> Adress { get; set; }
        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<CustomerAndPartners> CustomerAndPartners { get; set; }
        public virtual DbSet<Sosyal> Sosyal { get; set; }
        public virtual DbSet<QuickContact> QuickContact { get; set; }
        public virtual DbSet<Award> Award { get; set; }
        public virtual DbSet<CompaniesImages> CompaniesImages { get; set; }
    }
}
