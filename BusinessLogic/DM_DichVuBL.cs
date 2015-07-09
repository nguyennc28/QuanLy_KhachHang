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
	public class DM_DichVuBL
	{

		#region ***** Init Methods ***** 
		DM_DichVuDA objDM_DichVuDA;
		public DM_DichVuBL()
		{
			objDM_DichVuDA = new DM_DichVuDA();
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// Get DM_DichVu by madichvu
		/// </summary>
		/// <param name="madichvu">MaDichVu</param>
		/// <returns>DM_DichVu</returns>
		public DM_DichVu GetByMaDichVu(Byte madichvu)
		{
			return objDM_DichVuDA.GetByMaDichVu(madichvu);
		}

		/// <summary>
		/// Get all of DM_DichVu
		/// </summary>
		/// <returns>List<<DM_DichVu>></returns>
		public List<DM_DichVu> GetList()
		{
			string cacheName = "lstDM_DichVu";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objDM_DichVuDA.GetList(), "DM_DichVu");
			}
			return (List<DM_DichVu>) ServerCache.Get(cacheName);
		}

		/// <summary>
		/// Get DataSet of DM_DichVu
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			string cacheName = "dsDM_DichVu";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objDM_DichVuDA.GetDataSet(), "DM_DichVu");
			}
			return (DataSet) ServerCache.Get(cacheName);
		}


		/// <summary>
		/// Get all of DM_DichVu paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>List<<DM_DichVu>></returns>
		public List<DM_DichVu> GetListPaged(int recperpage, int pageindex)
		{
			return objDM_DichVuDA.GetListPaged(recperpage, pageindex);
		}

		/// <summary>
		/// Get DataSet of DM_DichVu paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return objDM_DichVuDA.GetDataSetPaged(recperpage, pageindex);
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new DM_DichVu within DM_DichVu database table
		/// </summary>
		/// <param name="obj_dm_dichvu">DM_DichVu</param>
		/// <returns>key of table</returns>
		public int Add(DM_DichVu obj_dm_dichvu)
		{
			ServerCache.Remove("DM_DichVu", true);
			return objDM_DichVuDA.Add(obj_dm_dichvu);
		}

		/// <summary>
		/// updates the specified DM_DichVu
		/// </summary>
		/// <param name="obj_dm_dichvu">DM_DichVu</param>
		/// <returns></returns>
		public void Update(DM_DichVu obj_dm_dichvu)
		{
			ServerCache.Remove("DM_DichVu", true);
			objDM_DichVuDA.Update(obj_dm_dichvu);
		}

		/// <summary>
		/// Delete the specified DM_DichVu
		/// </summary>
		/// <param name="madichvu">MaDichVu</param>
		/// <returns></returns>
		public void Delete(Byte madichvu)
		{
			ServerCache.Remove("DM_DichVu", true);
			objDM_DichVuDA.Delete(madichvu);
		}
		#endregion
	}
}
