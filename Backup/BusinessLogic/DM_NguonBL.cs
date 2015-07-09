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
	public class DM_NguonBL
	{

		#region ***** Init Methods ***** 
		DM_NguonDA objDM_NguonDA;
		public DM_NguonBL()
		{
			objDM_NguonDA = new DM_NguonDA();
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// Get DM_Nguon by manguon
		/// </summary>
		/// <param name="manguon">MaNguon</param>
		/// <returns>DM_Nguon</returns>
		public DM_Nguon GetByMaNguon(int manguon)
		{
			return objDM_NguonDA.GetByMaNguon(manguon);
		}

		/// <summary>
		/// Get all of DM_Nguon
		/// </summary>
		/// <returns>List<<DM_Nguon>></returns>
		public List<DM_Nguon> GetList()
		{
			string cacheName = "lstDM_Nguon";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objDM_NguonDA.GetList(), "DM_Nguon");
			}
			return (List<DM_Nguon>) ServerCache.Get(cacheName);
		}

		/// <summary>
		/// Get DataSet of DM_Nguon
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			string cacheName = "dsDM_Nguon";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objDM_NguonDA.GetDataSet(), "DM_Nguon");
			}
			return (DataSet) ServerCache.Get(cacheName);
		}


		/// <summary>
		/// Get all of DM_Nguon paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>List<<DM_Nguon>></returns>
		public List<DM_Nguon> GetListPaged(int recperpage, int pageindex)
		{
			return objDM_NguonDA.GetListPaged(recperpage, pageindex);
		}

		/// <summary>
		/// Get DataSet of DM_Nguon paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return objDM_NguonDA.GetDataSetPaged(recperpage, pageindex);
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new DM_Nguon within DM_Nguon database table
		/// </summary>
		/// <param name="obj_dm_nguon">DM_Nguon</param>
		/// <returns>key of table</returns>
		public int Add(DM_Nguon obj_dm_nguon)
		{
			ServerCache.Remove("DM_Nguon", true);
			return objDM_NguonDA.Add(obj_dm_nguon);
		}

		/// <summary>
		/// updates the specified DM_Nguon
		/// </summary>
		/// <param name="obj_dm_nguon">DM_Nguon</param>
		/// <returns></returns>
		public void Update(DM_Nguon obj_dm_nguon)
		{
			ServerCache.Remove("DM_Nguon", true);
			objDM_NguonDA.Update(obj_dm_nguon);
		}

		/// <summary>
		/// Delete the specified DM_Nguon
		/// </summary>
		/// <param name="manguon">MaNguon</param>
		/// <returns></returns>
		public void Delete(int manguon)
		{
			ServerCache.Remove("DM_Nguon", true);
			objDM_NguonDA.Delete(manguon);
		}
		#endregion
	}
}
