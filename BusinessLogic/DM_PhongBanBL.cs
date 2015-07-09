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
	public class DM_PhongBanBL
	{

		#region ***** Init Methods ***** 
		DM_PhongBanDA objDM_PhongBanDA;
		public DM_PhongBanBL()
		{
			objDM_PhongBanDA = new DM_PhongBanDA();
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// Get DM_PhongBan by maphong
		/// </summary>
		/// <param name="maphong">MaPhong</param>
		/// <returns>DM_PhongBan</returns>
		public DM_PhongBan GetByMaPhong(Byte maphong)
		{
			return objDM_PhongBanDA.GetByMaPhong(maphong);
		}

		/// <summary>
		/// Get all of DM_PhongBan
		/// </summary>
		/// <returns>List<<DM_PhongBan>></returns>
		public List<DM_PhongBan> GetList()
		{
			string cacheName = "lstDM_PhongBan";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objDM_PhongBanDA.GetList(), "DM_PhongBan");
			}
			return (List<DM_PhongBan>) ServerCache.Get(cacheName);
		}

		/// <summary>
		/// Get DataSet of DM_PhongBan
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			string cacheName = "dsDM_PhongBan";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objDM_PhongBanDA.GetDataSet(), "DM_PhongBan");
			}
			return (DataSet) ServerCache.Get(cacheName);
		}


		/// <summary>
		/// Get all of DM_PhongBan paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>List<<DM_PhongBan>></returns>
		public List<DM_PhongBan> GetListPaged(int recperpage, int pageindex)
		{
			return objDM_PhongBanDA.GetListPaged(recperpage, pageindex);
		}

		/// <summary>
		/// Get DataSet of DM_PhongBan paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return objDM_PhongBanDA.GetDataSetPaged(recperpage, pageindex);
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new DM_PhongBan within DM_PhongBan database table
		/// </summary>
		/// <param name="obj_dm_phongban">DM_PhongBan</param>
		/// <returns>key of table</returns>
		public int Add(DM_PhongBan obj_dm_phongban)
		{
			ServerCache.Remove("DM_PhongBan", true);
			return objDM_PhongBanDA.Add(obj_dm_phongban);
		}

		/// <summary>
		/// updates the specified DM_PhongBan
		/// </summary>
		/// <param name="obj_dm_phongban">DM_PhongBan</param>
		/// <returns></returns>
		public void Update(DM_PhongBan obj_dm_phongban)
		{
			ServerCache.Remove("DM_PhongBan", true);
			objDM_PhongBanDA.Update(obj_dm_phongban);
		}

		/// <summary>
		/// Delete the specified DM_PhongBan
		/// </summary>
		/// <param name="maphong">MaPhong</param>
		/// <returns></returns>
		public void Delete(Byte maphong)
		{
			ServerCache.Remove("DM_PhongBan", true);
			objDM_PhongBanDA.Delete(maphong);
		}
		#endregion
	}
}
