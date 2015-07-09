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
	public class DM_KetQuaBL
	{

		#region ***** Init Methods ***** 
		DM_KetQuaDA objDM_KetQuaDA;
		public DM_KetQuaBL()
		{
			objDM_KetQuaDA = new DM_KetQuaDA();
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// Get DM_KetQua by maketqua
		/// </summary>
		/// <param name="maketqua">MaKetQua</param>
		/// <returns>DM_KetQua</returns>
		public DM_KetQua GetByMaKetQua(Byte maketqua)
		{
			return objDM_KetQuaDA.GetByMaKetQua(maketqua);
		}

		/// <summary>
		/// Get all of DM_KetQua
		/// </summary>
		/// <returns>List<<DM_KetQua>></returns>
		public List<DM_KetQua> GetList()
		{
			string cacheName = "lstDM_KetQua";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objDM_KetQuaDA.GetList(), "DM_KetQua");
			}
			return (List<DM_KetQua>) ServerCache.Get(cacheName);
		}

		/// <summary>
		/// Get DataSet of DM_KetQua
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			string cacheName = "dsDM_KetQua";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objDM_KetQuaDA.GetDataSet(), "DM_KetQua");
			}
			return (DataSet) ServerCache.Get(cacheName);
		}


		/// <summary>
		/// Get all of DM_KetQua paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>List<<DM_KetQua>></returns>
		public List<DM_KetQua> GetListPaged(int recperpage, int pageindex)
		{
			return objDM_KetQuaDA.GetListPaged(recperpage, pageindex);
		}

		/// <summary>
		/// Get DataSet of DM_KetQua paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return objDM_KetQuaDA.GetDataSetPaged(recperpage, pageindex);
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new DM_KetQua within DM_KetQua database table
		/// </summary>
		/// <param name="obj_dm_ketqua">DM_KetQua</param>
		/// <returns>key of table</returns>
		public int Add(DM_KetQua obj_dm_ketqua)
		{
			ServerCache.Remove("DM_KetQua", true);
			return objDM_KetQuaDA.Add(obj_dm_ketqua);
		}

		/// <summary>
		/// updates the specified DM_KetQua
		/// </summary>
		/// <param name="obj_dm_ketqua">DM_KetQua</param>
		/// <returns></returns>
		public void Update(DM_KetQua obj_dm_ketqua)
		{
			ServerCache.Remove("DM_KetQua", true);
			objDM_KetQuaDA.Update(obj_dm_ketqua);
		}

		/// <summary>
		/// Delete the specified DM_KetQua
		/// </summary>
		/// <param name="maketqua">MaKetQua</param>
		/// <returns></returns>
		public void Delete(Byte maketqua)
		{
			ServerCache.Remove("DM_KetQua", true);
			objDM_KetQuaDA.Delete(maketqua);
		}
		#endregion
	}
}
