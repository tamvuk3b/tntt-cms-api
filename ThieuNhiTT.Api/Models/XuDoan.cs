using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThieuNhiTT.Api.Models
{
	public class XuDoan
	{
		[Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
		public int HiepDoanId { get; set; }
		public string? TenXuDoan { get; set; }
		public string? GiaoXu { get; set; }
		
        public XuDoan()
		{
			
		}
	}
}

