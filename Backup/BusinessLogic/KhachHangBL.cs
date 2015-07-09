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
	public class KhachHangBL
	{

		#region ***** Init Methods ***** 
		KhachHangDA objKhachHangDA;
		public KhachHangBL()
		{
			objKhachHangDA = new KhachHangDA();
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// Get KhachHang by makhachhang
		/// </summary>
		/// <param name="makhachhang">MaKhachHang</param>
		/// <returns>KhachHang</returns>
		public KhachHang GetByMaKhachHang(int makhachhang)
		{
			return objKhachHangDA.GetByMaKhachHang(makhachhang);
		}

		/// <summary>
		/// Get all of KhachHang
		/// </summary>
		/// <returns>List<<KhachHang>></returns>
		public List<KhachHang> GetList()
		{
			string cacheName = "lstKhachHang";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objKhachHangDA.GetList(), "KhachHang");
			}
			return (List<KhachHang>) ServerCache.Get(cacheName);
		}

		/// <summary>
		/// Get DataSet of KhachHang
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			string cacheName = "dsKhachHang";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objKhachHangDA.GetDataSet(), "KhachHang");
			}
			return (DataSet) ServerCache.Get(cacheName);
		}


		/// <summary>
		/// Get all of KhachHang paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>List<<KhachHang>></returns>
		public List<KhachHang> GetListPaged(int recperpage, int pageindex)
		{
			return objKhachHangDA.GetListPaged(recperpage, pageindex);
		}

		/// <summary>
		/// Get DataSet of KhachHang paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return objKhachHangDA.GetDataSetPaged(recperpage, pageindex);
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new KhachHang within KhachHang database table
		/// </summary>
		/// <param name="obj_khachhang">KhachHang</param>
		/// <returns>key of table</returns>
		public int Add(KhachHang obj_khachhang)
		{
			ServerCache.Remove("KhachHang", true);
			return objKhachHangDA.Add(obj_khachhang);
		}

		/// <summary>
		/// updates the specified KhachHang
		/// </summary>
		/// <param name="obj_khachhang">KhachHang</param>
		/// <returns></returns>
		public void Update(KhachHang obj_khachhang)
		{
			ServerCache.Remove("KhachHang", true);
			objKhachHangDA.Update(obj_khachhang);
		}

		/// <summary>
		/// Delete the specified KhachHang
		/// </summary>
		/// <param name="makhachhang">MaKhachHang</param>
		/// <returns></returns>
		public void Delete(int makhachhang)
		{
			ServerCache.Remove("KhachHang", true);
			objKhachHangDA.Delete(makhachhang);
		}
		#endregion
	}
}
