using System;

namespace QuanLy_KhachHang.BusinessObjects
{
	public class DM_PhongBan
	{
		#region ***** Fields & Properties ***** 
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
		private string _TenPhong;
		public string TenPhong
		{ 
			get 
			{ 
				return _TenPhong;
			}
			set 
			{ 
				_TenPhong = value;
			}
		}
		#endregion

		#region ***** Init Methods ***** 
		public DM_PhongBan()
		{
		}
		public DM_PhongBan(Byte maphong)
		{
			this.MaPhong = maphong;
		}
		public DM_PhongBan(Byte maphong, string tenphong)
		{
			this.MaPhong = maphong;
			this.TenPhong = tenphong;
		}
		#endregion
	}
}
