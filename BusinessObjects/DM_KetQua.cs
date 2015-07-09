using System;

namespace QuanLy_KhachHang.BusinessObjects
{
	public class DM_KetQua
	{
		#region ***** Fields & Properties ***** 
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
		private string _TenKetQua;
		public string TenKetQua
		{ 
			get 
			{ 
				return _TenKetQua;
			}
			set 
			{ 
				_TenKetQua = value;
			}
		}
		#endregion

		#region ***** Init Methods ***** 
		public DM_KetQua()
		{
		}
		public DM_KetQua(Byte maketqua)
		{
			this.MaKetQua = maketqua;
		}
		public DM_KetQua(Byte maketqua, string tenketqua)
		{
			this.MaKetQua = maketqua;
			this.TenKetQua = tenketqua;
		}
		#endregion
	}
}
