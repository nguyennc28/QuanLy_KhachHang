using System;

namespace QuanLy_KhachHang.BusinessObjects
{
	public class ThanhToan
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
		private DateTime _NgayThanhToan;
		public DateTime NgayThanhToan
		{ 
			get 
			{ 
				return _NgayThanhToan;
			}
			set 
			{ 
				_NgayThanhToan = value;
			}
		}
		private decimal _SoTien;
		public decimal SoTien
		{ 
			get 
			{ 
				return _SoTien;
			}
			set 
			{ 
				_SoTien = value;
			}
		}
		private int _MaNhanVien;
		public int MaNhanVien
		{ 
			get 
			{ 
				return _MaNhanVien;
			}
			set 
			{ 
				_MaNhanVien = value;
			}
		}
		private DateTime _NgayNop;
		public DateTime NgayNop
		{ 
			get 
			{ 
				return _NgayNop;
			}
			set 
			{ 
				_NgayNop = value;
			}
		}
		#endregion

		#region ***** Init Methods ***** 
		public ThanhToan()
		{
		}
		public ThanhToan(int makhachhang_dichvu, DateTime ngaythanhtoan, decimal sotien, int manhanvien, DateTime ngaynop)
		{
			this.MaKhachHang_DichVu = makhachhang_dichvu;
			this.NgayThanhToan = ngaythanhtoan;
			this.SoTien = sotien;
			this.MaNhanVien = manhanvien;
			this.NgayNop = ngaynop;
		}
		#endregion
	}
}
