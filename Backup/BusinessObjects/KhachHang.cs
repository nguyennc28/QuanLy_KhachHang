using System;

namespace QuanLy_KhachHang.BusinessObjects
{
	public class KhachHang
	{
		#region ***** Fields & Properties ***** 
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
		private string _TenKhachHang;
		public string TenKhachHang
		{ 
			get 
			{ 
				return _TenKhachHang;
			}
			set 
			{ 
				_TenKhachHang = value;
			}
		}
		private string _DiaChiLienHe;
		public string DiaChiLienHe
		{ 
			get 
			{ 
				return _DiaChiLienHe;
			}
			set 
			{ 
				_DiaChiLienHe = value;
			}
		}
		private string _DiaChiVAT;
		public string DiaChiVAT
		{ 
			get 
			{ 
				return _DiaChiVAT;
			}
			set 
			{ 
				_DiaChiVAT = value;
			}
		}
		private string _Email;
		public string Email
		{ 
			get 
			{ 
				return _Email;
			}
			set 
			{ 
				_Email = value;
			}
		}
		private string _DienThoai;
		public string DienThoai
		{ 
			get 
			{ 
				return _DienThoai;
			}
			set 
			{ 
				_DienThoai = value;
			}
		}
		private string _NguoiLienHe;
		public string NguoiLienHe
		{ 
			get 
			{ 
				return _NguoiLienHe;
			}
			set 
			{ 
				_NguoiLienHe = value;
			}
		}
		#endregion

		#region ***** Init Methods ***** 
		public KhachHang()
		{
		}
		public KhachHang(int makhachhang)
		{
			this.MaKhachHang = makhachhang;
		}
		public KhachHang(int makhachhang, string tenkhachhang, string diachilienhe, string diachivat, string email, string dienthoai, string nguoilienhe)
		{
			this.MaKhachHang = makhachhang;
			this.TenKhachHang = tenkhachhang;
			this.DiaChiLienHe = diachilienhe;
			this.DiaChiVAT = diachivat;
			this.Email = email;
			this.DienThoai = dienthoai;
			this.NguoiLienHe = nguoilienhe;
		}
		#endregion
	}
}
