using System;

namespace QuanLy_KhachHang.BusinessObjects
{
	public class PhiCSKH
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
		private string _NguoiNop;
		public string NguoiNop
		{ 
			get 
			{ 
				return _NguoiNop;
			}
			set 
			{ 
				_NguoiNop = value;
			}
		}
		private string _GhiChu;
		public string GhiChu
		{ 
			get 
			{ 
				return _GhiChu;
			}
			set 
			{ 
				_GhiChu = value;
			}
		}
		#endregion

		#region ***** Init Methods ***** 
		public PhiCSKH()
		{
		}
		public PhiCSKH(int ma_cskh, int manhanvien, DateTime ngaynop, decimal sotien, string nguoinop, string ghichu)
		{
			this.Ma_CSKH = ma_cskh;
			this.MaNhanVien = manhanvien;
			this.NgayNop = ngaynop;
			this.SoTien = sotien;
			this.NguoiNop = nguoinop;
			this.GhiChu = ghichu;
		}
		#endregion
	}
}
