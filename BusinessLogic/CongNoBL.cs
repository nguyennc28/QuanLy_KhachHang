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
	public class CongNoBL
	{

		#region ***** Init Methods ***** 
		CongNoDA objCongNoDA;
		public CongNoBL()
		{
			objCongNoDA = new CongNoDA();
		}
		#endregion

		#region ***** Get Methods ***** 

		/// <summary>
		/// Get all of CongNo
		/// </summary>
		/// <returns>List<<CongNo>></returns>
		public List<CongNo> GetList()
		{
			string cacheName = "lstCongNo";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objCongNoDA.GetList(), "CongNo");
			}
			return (List<CongNo>) ServerCache.Get(cacheName);
		}

		/// <summary>
		/// Get DataSet of CongNo
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			string cacheName = "dsCongNo";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objCongNoDA.GetDataSet(), "CongNo");
			}
			return (DataSet) ServerCache.Get(cacheName);
		}


		/// <summary>
		/// Get all of CongNo paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>List<<CongNo>></returns>
		public List<CongNo> GetListPaged(int recperpage, int pageindex)
		{
			return objCongNoDA.GetListPaged(recperpage, pageindex);
		}

		/// <summary>
		/// Get DataSet of CongNo paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return objCongNoDA.GetDataSetPaged(recperpage, pageindex);
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new CongNo within CongNo database table
		/// </summary>
		/// <param name="obj_congno">CongNo</param>
		/// <returns>key of table</returns>
		public int Add(CongNo obj_congno)
		{
			ServerCache.Remove("CongNo", true);
			return objCongNoDA.Add(obj_congno);
		}

//No key Found
		#endregion
	}
}
