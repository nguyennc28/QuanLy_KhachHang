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
	public class KhachHang_DichVuBL
	{

		#region ***** Init Methods ***** 
		KhachHang_DichVuDA objKhachHang_DichVuDA;
		public KhachHang_DichVuBL()
		{
			objKhachHang_DichVuDA = new KhachHang_DichVuDA();
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// Get KhachHang_DichVu by makhachhang_dichvu
		/// </summary>
		/// <param name="makhachhang_dichvu">MaKhachHang_DichVu</param>
		/// <returns>KhachHang_DichVu</returns>
		public KhachHang_DichVu GetByMaKhachHang_DichVu(int makhachhang_dichvu)
		{
			return objKhachHang_DichVuDA.GetByMaKhachHang_DichVu(makhachhang_dichvu);
		}

		/// <summary>
		/// Get all of KhachHang_DichVu
		/// </summary>
		/// <returns>List<<KhachHang_DichVu>></returns>
		public List<KhachHang_DichVu> GetList()
		{
			string cacheName = "lstKhachHang_DichVu";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objKhachHang_DichVuDA.GetList(), "KhachHang_DichVu");
			}
			return (List<KhachHang_DichVu>) ServerCache.Get(cacheName);
		}

		/// <summary>
		/// Get DataSet of KhachHang_DichVu
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			string cacheName = "dsKhachHang_DichVu";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objKhachHang_DichVuDA.GetDataSet(), "KhachHang_DichVu");
			}
			return (DataSet) ServerCache.Get(cacheName);
		}


		/// <summary>
		/// Get all of KhachHang_DichVu paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>List<<KhachHang_DichVu>></returns>
		public List<KhachHang_DichVu> GetListPaged(int recperpage, int pageindex)
		{
			return objKhachHang_DichVuDA.GetListPaged(recperpage, pageindex);
		}

		/// <summary>
		/// Get DataSet of KhachHang_DichVu paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return objKhachHang_DichVuDA.GetDataSetPaged(recperpage, pageindex);
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new KhachHang_DichVu within KhachHang_DichVu database table
		/// </summary>
		/// <param name="obj_khachhang_dichvu">KhachHang_DichVu</param>
		/// <returns>key of table</returns>
		public int Add(KhachHang_DichVu obj_khachhang_dichvu)
		{
			ServerCache.Remove("KhachHang_DichVu", true);
			return objKhachHang_DichVuDA.Add(obj_khachhang_dichvu);
		}

		/// <summary>
		/// updates the specified KhachHang_DichVu
		/// </summary>
		/// <param name="obj_khachhang_dichvu">KhachHang_DichVu</param>
		/// <returns></returns>
		public void Update(KhachHang_DichVu obj_khachhang_dichvu)
		{
			ServerCache.Remove("KhachHang_DichVu", true);
			objKhachHang_DichVuDA.Update(obj_khachhang_dichvu);
		}

		/// <summary>
		/// Delete the specified KhachHang_DichVu
		/// </summary>
		/// <param name="makhachhang_dichvu">MaKhachHang_DichVu</param>
		/// <returns></returns>
		public void Delete(int makhachhang_dichvu)
		{
			ServerCache.Remove("KhachHang_DichVu", true);
			objKhachHang_DichVuDA.Delete(makhachhang_dichvu);
		}
		#endregion
	}
}
