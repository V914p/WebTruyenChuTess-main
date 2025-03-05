namespace WebTruyenChu_210BANED.Models
{
	using Microsoft.EntityFrameworkCore;
	using System.Collections.Generic;

	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options) { }

		public DbSet<Sach> Saches { get; set; }
		public DbSet<Chuong> Chuongs { get; set; }
	}

}
