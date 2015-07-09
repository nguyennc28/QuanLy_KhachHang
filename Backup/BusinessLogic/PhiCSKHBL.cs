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
	public class PhiCSKHBL
	{

		#region ***** Init Methods ***** 
		PhiCSKHDA objPhiCSKHDA;
		public PhiCSKHBL()
		{
			objPhiCSKHDA = new PhiCSKHDA();
		}
		#endregion

		#region ***** Get Methods ***** 

		/// <summary>
		/// Get all of PhiCSKH
		/// </summary>
		/// <returns>List<<PhiCSKH>></returns>
		public List<PhiCSKH> GetList()
		{
			string cacheName = "lstPhiCSKH";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objPhiCSKHDA.GetList(), "PhiCSKH");
			}
			return (List<PhiCSKH>) ServerCache.Get(cacheName);
		}

		/// <summary>
		/// Get DataSet of PhiCSKH
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			string cacheName = "dsPhiCSKH";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objPhiCSKHDA.GetDataSet(), "PhiCSKH");
			}
			return (DataSet) ServerCache.Get(cacheName);
		}


		/// <summary>
		/// Get all of PhiCSKH paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>List<<PhiCSKH>></returns>
		public List<PhiCSKH> GetListPaged(int recperpage, int pageindex)
		{
			return objPhiCSKHDA.GetListPaged(recperpage, pageindex);
		}

		/// <summary>
		/// Get DataSet of PhiCSKH paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return objPhiCSKHDA.GetDataSetPaged(recperpage, pageindex);
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new PhiCSKH within PhiCSKH database table
		/// </summary>
		/// <param name="obj_phicskh">PhiCSKH</param>
		/// <returns>key of table</returns>
		public int Add(PhiCSKH obj_phicskh)
		{
			ServerCache.Remove("PhiCSKH", true);
			return objPhiCSKHDA.Add(obj_phicskh);
		}

//No key Found
		#endregion
	}
}
