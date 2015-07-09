using System;
using QuanLy_KhachHang.BusinessLogic;

namespace QuanLy_KhachHang.BusinessLogic
{
	public class QuanLy_KhachHangFacade
	{
		#region ***** Static Methods ***** 
		public static CongNoBL GetCongNoBL()
		{ 
			return new CongNoBL();
		}
		public static CSKHBL GetCSKHBL()
		{ 
			return new CSKHBL();
		}
		public static DM_DichVuBL GetDM_DichVuBL()
		{ 
			return new DM_DichVuBL();
		}
		public static DM_KetQuaBL GetDM_KetQuaBL()
		{ 
			return new DM_KetQuaBL();
		}
		public static DM_NguonBL GetDM_NguonBL()
		{ 
			return new DM_NguonBL();
		}
		public static DM_PhongBanBL GetDM_PhongBanBL()
		{ 
			return new DM_PhongBanBL();
		}
		public static KhachHangBL GetKhachHangBL()
		{ 
			return new KhachHangBL();
		}
		public static KhachHang_DichVuBL GetKhachHang_DichVuBL()
		{ 
			return new KhachHang_DichVuBL();
		}
		public static NhanVienBL GetNhanVienBL()
		{ 
			return new NhanVienBL();
		}
		public static NhanVien_PhongBL GetNhanVien_PhongBL()
		{ 
			return new NhanVien_PhongBL();
		}
		public static PhiCSKHBL GetPhiCSKHBL()
		{ 
			return new PhiCSKHBL();
		}
		public static ThanhToanBL GetThanhToanBL()
		{ 
			return new ThanhToanBL();
		}
		public static VATBL GetVATBL()
		{ 
			return new VATBL();
		}
		
		#endregion
	}
}
