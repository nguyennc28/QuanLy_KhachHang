using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using QuanLy_KhachHang.BusinessObjects;

namespace QuanLy_KhachHang.DataAccess
{
	public class DM_PhongBanDA
	{

		#region ***** Init Methods ***** 
		public DM_PhongBanDA()
		{
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public DM_PhongBan Populate(IDataReader myReader)
		{
			DM_PhongBan obj = new DM_PhongBan();
			obj.MaPhong = (Byte) myReader["MaPhong"];
			obj.TenPhong = (string) myReader["TenPhong"];
			return obj;
		}

		/// <summary>
		/// Get DM_PhongBan by maphong
		/// </summary>
		/// <param name="maphong">MaPhong</param>
		/// <returns>DM_PhongBan</returns>
		public DM_PhongBan GetByMaPhong(Byte maphong)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_DM_PhongBan_GetByMaPhong", Data.CreateParameter("MaPhong", maphong)))
			{
				if (reader.Read())
				{
					return Populate(reader);
				}
				return null;
			}
		}

		/// <summary>
		/// Get all of DM_PhongBan
		/// </summary>
		/// <returns>List<<DM_PhongBan>></returns>
		public List<DM_PhongBan> GetList()
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_DM_PhongBan_Get"))
			{
				List<DM_PhongBan> list = new List<DM_PhongBan>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of DM_PhongBan
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_DM_PhongBan_Get");
		}


		/// <summary>
		/// Get all of DM_PhongBan paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>List<<DM_PhongBan>></returns>
		public List<DM_PhongBan> GetListPaged(int recperpage, int pageindex)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_DM_PhongBan_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex)))
			{
				List<DM_PhongBan> list = new List<DM_PhongBan>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of DM_PhongBan paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_DM_PhongBan_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex));
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new DM_PhongBan within DM_PhongBan database table
		/// </summary>
		/// <param name="obj">DM_PhongBan</param>
		/// <returns>key of table</returns>
		public int Add(DM_PhongBan obj)
		{
			DbParameter parameterItemID = Data.CreateParameter("MaPhong", obj.MaPhong);
			parameterItemID.Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_DM_PhongBan_Add"
							,parameterItemID
							,Data.CreateParameter("TenPhong", obj.TenPhong)
			);
			return 0;
		}

		/// <summary>
		/// updates the specified DM_PhongBan
		/// </summary>
		/// <param name="obj">DM_PhongBan</param>
		/// <returns></returns>
		public void Update(DM_PhongBan obj)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_DM_PhongBan_Update"
							,Data.CreateParameter("MaPhong", obj.MaPhong)
							,Data.CreateParameter("TenPhong", obj.TenPhong)
			);
		}

		/// <summary>
		/// Delete the specified DM_PhongBan
		/// </summary>
		/// <param name="maphong">MaPhong</param>
		/// <returns></returns>
		public void Delete(Byte maphong)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_DM_PhongBan_Delete", Data.CreateParameter("MaPhong", maphong));
		}
		#endregion
	}
}
