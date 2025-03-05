using System.ComponentModel.DataAnnotations;

namespace WebTruyenChu_210BANED.Models
{
	public class Sach
	{
		[Key]
		public int maSach { get; set; }
		public string tenSach { get; set; }
		public string tinhTrang { get; set; }
		public string moTa { get; set; }
		public int namSX { get; set; }
		public string biaSach { get; set; }
		public string maTacGia { get; set; }
	}

	public class Chuong
	{
		[Key]
		public int maChuong { get; set; }
		public int soChuong { get; set; }
		public string tenChuong { get; set; }
		public string ngayDang { get; set; }
		public string noiDung { get; set; }
		public string maSach { get; set; }
	}
}
