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
	public class ThanhToanBL
	{

		#region ***** Init Methods ***** 
		ThanhToanDA objThanhToanDA;
		public ThanhToanBL()
		{
			objThanhToanDA = new ThanhToanDA();
		}
		#endregion

		#region ***** Get Methods ***** 

		/// <summary>
		/// Get all of ThanhToan
		/// </summary>
		/// <returns>List<<ThanhToan>></returns>
		public List<ThanhToan> GetList()
		{
			string cacheName = "lstThanhToan";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objThanhToanDA.GetList(), "ThanhToan");
			}
			return (List<ThanhToan>) ServerCache.Get(cacheName);
		}

		/// <summary>
		/// Get DataSet of ThanhToan
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			string cacheName = "dsThanhToan";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objThanhToanDA.GetDataSet(), "ThanhToan");
			}
			return (DataSet) ServerCache.Get(cacheName);
		}


		/// <summary>
		/// Get all of ThanhToan paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>List<<ThanhToan>></returns>
		public List<ThanhToan> GetListPaged(int recperpage, int pageindex)
		{
			return objThanhToanDA.GetListPaged(recperpage, pageindex);
		}

		/// <summary>
		/// Get DataSet of ThanhToan paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return objThanhToanDA.GetDataSetPaged(recperpage, pageindex);
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new ThanhToan within ThanhToan database table
		/// </summary>
		/// <param name="obj_thanhtoan">ThanhToan</param>
		/// <returns>key of table</returns>
		public int Add(ThanhToan obj_thanhtoan)
		{
			ServerCache.Remove("ThanhToan", true);
			return objThanhToanDA.Add(obj_thanhtoan);
		}

//No key Found
		#endregion
	}
}
