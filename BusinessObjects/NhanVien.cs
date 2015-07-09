using System;

namespace QuanLy_KhachHang.BusinessObjects
{
	public class NhanVien
	{
		#region ***** Fields & Properties ***** 
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
		private string _HoTen;
		public string HoTen
		{ 
			get 
			{ 
				return _HoTen;
			}
			set 
			{ 
				_HoTen = value;
			}
		}
		private DateTime _NgaySinh;
		public DateTime NgaySinh
		{ 
			get 
			{ 
				return _NgaySinh;
			}
			set 
			{ 
				_NgaySinh = value;
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
		#endregion

		#region ***** Init Methods ***** 
		public NhanVien()
		{
		}
		public NhanVien(int manhanvien)
		{
			this.MaNhanVien = manhanvien;
		}
		public NhanVien(int manhanvien, string hoten, DateTime ngaysinh, string dienthoai, string email)
		{
			this.MaNhanVien = manhanvien;
			this.HoTen = hoten;
			this.NgaySinh = ngaysinh;
			this.DienThoai = dienthoai;
			this.Email = email;
		}
		#endregion
	}
}
