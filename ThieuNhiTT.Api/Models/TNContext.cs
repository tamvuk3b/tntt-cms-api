using System;
using Microsoft.EntityFrameworkCore;

namespace ThieuNhiTT.Api.Models
{
	public class TNContext:DbContext
	{
        public TNContext(DbContextOptions options) : base(options) { }
        DbSet<XuDoan> XuDoan
        {
            get;
            set;
        }
        DbSet<HiepDoan> HiepDoan
        {
            get;
            set;
        }
        DbSet<LienDoan> LienDoan
        {
            get;
            set;
        }
        DbSet<TongLienDoan> TongLienDoan
        {
            get;
            set;
        }
        DbSet<Profile> Profile
        {
            get;
            set;
        }
        DbSet<KetQuaHocTap> KetQuaHocTap
        {
            get;
            set;
        }
        DbSet<MonHoc> MonHoc
        {
            get;
            set;
        }
        DbSet<LopHoc> LopHoc
        {
            get;
            set;
        }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Profile>()
                .HasIndex(u => u.PIN)
                .IsUnique();
        }
    }
}

