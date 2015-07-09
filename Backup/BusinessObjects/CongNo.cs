using System;

namespace QuanLy_KhachHang.BusinessObjects
{
	public class CongNo
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
		private DateTime _NgayThongBao;
		public DateTime NgayThongBao
		{ 
			get 
			{ 
				return _NgayThongBao;
			}
			set 
			{ 
				_NgayThongBao = value;
			}
		}
		private decimal _Sotien;
		public decimal Sotien
		{ 
			get 
			{ 
				return _Sotien;
			}
			set 
			{ 
				_Sotien = value;
			}
		}
		private DateTime _HanNop;
		public DateTime HanNop
		{ 
			get 
			{ 
				return _HanNop;
			}
			set 
			{ 
				_HanNop = value;
			}
		}
		#endregion

		#region ***** Init Methods ***** 
		public CongNo()
		{
		}
		public CongNo(int makhachhang_dichvu, int manhanvien, DateTime ngaythongbao, decimal sotien, DateTime hannop)
		{
			this.MaKhachHang_DichVu = makhachhang_dichvu;
			this.MaNhanVien = manhanvien;
			this.NgayThongBao = ngaythongbao;
			this.Sotien = sotien;
			this.HanNop = hannop;
		}
		#endregion
	}
}
