using System;

namespace QuanLy_KhachHang.BusinessObjects
{
	public class DM_DichVu
	{
		#region ***** Fields & Properties ***** 
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
		private string _TenDichVu;
		public string TenDichVu
		{ 
			get 
			{ 
				return _TenDichVu;
			}
			set 
			{ 
				_TenDichVu = value;
			}
		}
		#endregion

		#region ***** Init Methods ***** 
		public DM_DichVu()
		{
		}
		public DM_DichVu(Byte madichvu)
		{
			this.MaDichVu = madichvu;
		}
		public DM_DichVu(Byte madichvu, string tendichvu)
		{
			this.MaDichVu = madichvu;
			this.TenDichVu = tendichvu;
		}
		#endregion
	}
}
