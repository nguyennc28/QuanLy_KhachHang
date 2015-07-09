using System;

namespace QuanLy_KhachHang.BusinessObjects
{
	public class NhanVien_Phong
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
		private Byte _MaPhong;
		public Byte MaPhong
		{ 
			get 
			{ 
				return _MaPhong;
			}
			set 
			{ 
				_MaPhong = value;
			}
		}
		private DateTime _ThoiGianBatDau;
		public DateTime ThoiGianBatDau
		{ 
			get 
			{ 
				return _ThoiGianBatDau;
			}
			set 
			{ 
				_ThoiGianBatDau = value;
			}
		}
		private DateTime _ThowiGianKetThuc;
		public DateTime ThowiGianKetThuc
		{ 
			get 
			{ 
				return _ThowiGianKetThuc;
			}
			set 
			{ 
				_ThowiGianKetThuc = value;
			}
		}
		#endregion

		#region ***** Init Methods ***** 
		public NhanVien_Phong()
		{
		}
		public NhanVien_Phong(int manhanvien, Byte maphong, DateTime thoigianbatdau, DateTime thowigianketthuc)
		{
			this.MaNhanVien = manhanvien;
			this.MaPhong = maphong;
			this.ThoiGianBatDau = thoigianbatdau;
			this.ThowiGianKetThuc = thowigianketthuc;
		}
		#endregion
	}
}
