using System;

namespace QuanLy_KhachHang.BusinessObjects
{
	public class KhachHang_DichVu
	{
		#region ***** Fields & Properties ***** 
		private int _MaKhachHang_DichVu;
		public int MaKhachHang_DichVu
		{ 
			get 
			{ 
				return _MaKhachHang_DichVu;
			}
			set 
			{ 
				_MaKhachHang_DichVu = value;
			}
		}
		private int _MaKhachHang;
		public int MaKhachHang
		{ 
			get 
			{ 
				return _MaKhachHang;
			}
			set 
			{ 
				_MaKhachHang = value;
			}
		}
		private Byte _MaDichVu;
		public Byte MaDichVu
		{ 
			get 
			{ 
				return _MaDichVu;
			}
			set 
			{ 
				_MaDichVu = value;
			}
		}
		private int _MaNguon;
		public int MaNguon
		{ 
			get 
			{ 
				return _MaNguon;
			}
			set 
			{ 
				_MaNguon = value;
			}
		}
		private decimal _GiaTriHopDong;
		public decimal GiaTriHopDong
		{ 
			get 
			{ 
				return _GiaTriHopDong;
			}
			set 
			{ 
				_GiaTriHopDong = value;
			}
		}
		private string _SoHopDong;
		public string SoHopDong
		{ 
			get 
			{ 
				return _SoHopDong;
			}
			set 
			{ 
				_SoHopDong = value;
			}
		}
		private string _TomTatHopDong;
		public string TomTatHopDong
		{ 
			get 
			{ 
				return _TomTatHopDong;
			}
			set 
			{ 
				_TomTatHopDong = value;
			}
		}
		private DateTime _NgayThanhLyHD;
		public DateTime NgayThanhLyHD
		{ 
			get 
			{ 
				return _NgayThanhLyHD;
			}
			set 
			{ 
				_NgayThanhLyHD = value;
			}
		}
		private DateTime _NgayBatDauDichVu;
		public DateTime NgayBatDauDichVu
		{ 
			get 
			{ 
				return _NgayBatDauDichVu;
			}
			set 
			{ 
				_NgayBatDauDichVu = value;
			}
		}
		private DateTime _NgayKetThucDichVu;
		public DateTime NgayKetThucDichVu
		{ 
			get 
			{ 
				return _NgayKetThucDichVu;
			}
			set 
			{ 
				_NgayKetThucDichVu = value;
			}
		}
		#endregion

		#region ***** Init Methods ***** 
		public KhachHang_DichVu()
		{
		}
		public KhachHang_DichVu(int makhachhang_dichvu)
		{
			this.MaKhachHang_DichVu = makhachhang_dichvu;
		}
		public KhachHang_DichVu(int makhachhang_dichvu, int makhachhang, Byte madichvu, int manguon, decimal giatrihopdong, string sohopdong, string tomtathopdong, DateTime ngaythanhlyhd, DateTime ngaybatdaudichvu, DateTime ngayketthucdichvu)
		{
			this.MaKhachHang_DichVu = makhachhang_dichvu;
			this.MaKhachHang = makhachhang;
			this.MaDichVu = madichvu;
			this.MaNguon = manguon;
			this.GiaTriHopDong = giatrihopdong;
			this.SoHopDong = sohopdong;
			this.TomTatHopDong = tomtathopdong;
			this.NgayThanhLyHD = ngaythanhlyhd;
			this.NgayBatDauDichVu = ngaybatdaudichvu;
			this.NgayKetThucDichVu = ngayketthucdichvu;
		}
		#endregion
	}
}
