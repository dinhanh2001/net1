﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BTL_NET1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QuanLiTuyenSinhDB : DbContext
    {
        public QuanLiTuyenSinhDB()
            : base("name=QuanLiTuyenSinhDB")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DanhMucLopThi> DanhMucLopThis { get; set; }
        public virtual DbSet<DanhMucMonThi> DanhMucMonThis { get; set; }
        public virtual DbSet<HoSoThiSinh> HoSoThiSinhs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
