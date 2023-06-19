using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThieuNhiTT.Api.Models
{
	public class HiepDoan
	{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int LienDoanId { get; set; }
        public string? TenHiepDoan { get; set; }
        public string? GiaoHat { get; set; }
    }
}

