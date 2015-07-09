using System;

namespace QuanLy_KhachHang.BusinessObjects
{
	public class DM_Nguon
	{
		#region ***** Fields & Properties ***** 
		private int _MaNguon;
		public int MaNguon
		{ 
			get 
			{ 
				return _MaNguon;
			}
			set 
			{ 
				_MaNguon = value;
			}
		}
		private string _TenNguon;
		public string TenNguon
		{ 
			get 
			{ 
				return _TenNguon;
			}
			set 
			{ 
				_TenNguon = value;
			}
		}
		#endregion

		#region ***** Init Methods ***** 
		public DM_Nguon()
		{
		}
		public DM_Nguon(int manguon)
		{
			this.MaNguon = manguon;
		}
		public DM_Nguon(int manguon, string tennguon)
		{
			this.MaNguon = manguon;
			this.TenNguon = tennguon;
		}
		#endregion
	}
}
