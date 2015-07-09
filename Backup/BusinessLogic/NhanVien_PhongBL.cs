using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using QuanLy_KhachHang.BusinessObjects;
using QuanLy_KhachHang.DataAccess;

namespace QuanLy_KhachHang.BusinessLogic
{
	public class NhanVien_PhongBL
	{

		#region ***** Init Methods ***** 
		NhanVien_PhongDA objNhanVien_PhongDA;
		public NhanVien_PhongBL()
		{
			objNhanVien_PhongDA = new NhanVien_PhongDA();
		}
		#endregion

		#region ***** Get Methods ***** 

		/// <summary>
		/// Get all of NhanVien_Phong
		/// </summary>
		/// <returns>List<<NhanVien_Phong>></returns>
		public List<NhanVien_Phong> GetList()
		{
			string cacheName = "lstNhanVien_Phong";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objNhanVien_PhongDA.GetList(), "NhanVien_Phong");
			}
			return (List<NhanVien_Phong>) ServerCache.Get(cacheName);
		}

		/// <summary>
		/// Get DataSet of NhanVien_Phong
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			string cacheName = "dsNhanVien_Phong";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objNhanVien_PhongDA.GetDataSet(), "NhanVien_Phong");
			}
			return (DataSet) ServerCache.Get(cacheName);
		}


		/// <summary>
		/// Get all of NhanVien_Phong paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>List<<NhanVien_Phong>></returns>
		public List<NhanVien_Phong> GetListPaged(int recperpage, int pageindex)
		{
			return objNhanVien_PhongDA.GetListPaged(recperpage, pageindex);
		}

		/// <summary>
		/// Get DataSet of NhanVien_Phong paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return objNhanVien_PhongDA.GetDataSetPaged(recperpage, pageindex);
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new NhanVien_Phong within NhanVien_Phong database table
		/// </summary>
		/// <param name="obj_nhanvien_phong">NhanVien_Phong</param>
		/// <returns>key of table</returns>
		public int Add(NhanVien_Phong obj_nhanvien_phong)
		{
			ServerCache.Remove("NhanVien_Phong", true);
			return objNhanVien_PhongDA.Add(obj_nhanvien_phong);
		}

//No key Found
		#endregion
	}
}
