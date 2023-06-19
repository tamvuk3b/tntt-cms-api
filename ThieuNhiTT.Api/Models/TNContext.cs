using System;
using Microsoft.EntityFrameworkCore;

namespace ThieuNhiTT.Api.Models
{
	public class TNContext:DbContext
	{
        public TNContext(DbContextOptions options) : base(options) { }
        DbSet<XuDoan> XuDoans
        {
            get;
            set;
        }
        DbSet<HiepDoan> HiepDoans
        {
            get;
            set;
        }
    }
}

