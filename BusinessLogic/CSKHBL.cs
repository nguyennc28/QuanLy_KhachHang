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
	public class CSKHBL
	{

		#region ***** Init Methods ***** 
		CSKHDA objCSKHDA;
		public CSKHBL()
		{
			objCSKHDA = new CSKHDA();
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// Get CSKH by ma_cskh
		/// </summary>
		/// <param name="ma_cskh">Ma_CSKH</param>
		/// <returns>CSKH</returns>
		public CSKH GetByMa_CSKH(int ma_cskh)
		{
			return objCSKHDA.GetByMa_CSKH(ma_cskh);
		}

		/// <summary>
		/// Get all of CSKH
		/// </summary>
		/// <returns>List<<CSKH>></returns>
		public List<CSKH> GetList()
		{
			string cacheName = "lstCSKH";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objCSKHDA.GetList(), "CSKH");
			}
			return (List<CSKH>) ServerCache.Get(cacheName);
		}

		/// <summary>
		/// Get DataSet of CSKH
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			string cacheName = "dsCSKH";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objCSKHDA.GetDataSet(), "CSKH");
			}
			return (DataSet) ServerCache.Get(cacheName);
		}


		/// <summary>
		/// Get all of CSKH paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>List<<CSKH>></returns>
		public List<CSKH> GetListPaged(int recperpage, int pageindex)
		{
			return objCSKHDA.GetListPaged(recperpage, pageindex);
		}

		/// <summary>
		/// Get DataSet of CSKH paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return objCSKHDA.GetDataSetPaged(recperpage, pageindex);
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new CSKH within CSKH database table
		/// </summary>
		/// <param name="obj_cskh">CSKH</param>
		/// <returns>key of table</returns>
		public int Add(CSKH obj_cskh)
		{
			ServerCache.Remove("CSKH", true);
			return objCSKHDA.Add(obj_cskh);
		}

		/// <summary>
		/// updates the specified CSKH
		/// </summary>
		/// <param name="obj_cskh">CSKH</param>
		/// <returns></returns>
		public void Update(CSKH obj_cskh)
		{
			ServerCache.Remove("CSKH", true);
			objCSKHDA.Update(obj_cskh);
		}

		/// <summary>
		/// Delete the specified CSKH
		/// </summary>
		/// <param name="ma_cskh">Ma_CSKH</param>
		/// <returns></returns>
		public void Delete(int ma_cskh)
		{
			ServerCache.Remove("CSKH", true);
			objCSKHDA.Delete(ma_cskh);
		}
		#endregion
	}
}
