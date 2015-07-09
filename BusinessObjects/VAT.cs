using System;

namespace QuanLy_KhachHang.BusinessObjects
{
	public class VAT
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
		private DateTime _NgayXuatVAT;
		public DateTime NgayXuatVAT
		{ 
			get 
			{ 
				return _NgayXuatVAT;
			}
			set 
			{ 
				_NgayXuatVAT = value;
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
		#endregion

		#region ***** Init Methods ***** 
		public VAT()
		{
		}
		public VAT(int makhachhang_dichvu, int manhanvien, DateTime ngayxuatvat, decimal sotien)
		{
			this.MaKhachHang_DichVu = makhachhang_dichvu;
			this.MaNhanVien = manhanvien;
			this.NgayXuatVAT = ngayxuatvat;
			this.SoTien = sotien;
		}
		#endregion
	}
}
