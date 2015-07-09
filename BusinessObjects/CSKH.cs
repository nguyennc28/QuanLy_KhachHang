using System;

namespace QuanLy_KhachHang.BusinessObjects
{
	public class CSKH
	{
		#region ***** Fields & Properties ***** 
		private int _Ma_CSKH;
		public int Ma_CSKH
		{ 
			get 
			{ 
				return _Ma_CSKH;
			}
			set 
			{ 
				_Ma_CSKH = value;
			}
		}
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
		private Byte _MaKetQua;
		public Byte MaKetQua
		{ 
			get 
			{ 
				return _MaKetQua;
			}
			set 
			{ 
				_MaKetQua = value;
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
		private DateTime _NgayThucHien;
		public DateTime NgayThucHien
		{ 
			get 
			{ 
				return _NgayThucHien;
			}
			set 
			{ 
				_NgayThucHien = value;
			}
		}
		private string _NoiDung;
		public string NoiDung
		{ 
			get 
			{ 
				return _NoiDung;
			}
			set 
			{ 
				_NoiDung = value;
			}
		}
		#endregion

		#region ***** Init Methods ***** 
		public CSKH()
		{
		}
		public CSKH(int ma_cskh)
		{
			this.Ma_CSKH = ma_cskh;
		}
		public CSKH(int ma_cskh, int makhachhang_dichvu, Byte maketqua, int manhanvien, DateTime ngaythuchien, string noidung)
		{
			this.Ma_CSKH = ma_cskh;
			this.MaKhachHang_DichVu = makhachhang_dichvu;
			this.MaKetQua = maketqua;
			this.MaNhanVien = manhanvien;
			this.NgayThucHien = ngaythuchien;
			this.NoiDung = noidung;
		}
		#endregion
	}
}
