using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using QuanLy_KhachHang.BusinessObjects;

namespace QuanLy_KhachHang.DataAccess
{
	public class DM_KetQuaDA
	{

		#region ***** Init Methods ***** 
		public DM_KetQuaDA()
		{
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public DM_KetQua Populate(IDataReader myReader)
		{
			DM_KetQua obj = new DM_KetQua();
			obj.MaKetQua = (Byte) myReader["MaKetQua"];
			obj.TenKetQua = (string) myReader["TenKetQua"];
			return obj;
		}

		/// <summary>
		/// Get DM_KetQua by maketqua
		/// </summary>
		/// <param name="maketqua">MaKetQua</param>
		/// <returns>DM_KetQua</returns>
		public DM_KetQua GetByMaKetQua(Byte maketqua)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_DM_KetQua_GetByMaKetQua", Data.CreateParameter("MaKetQua", maketqua)))
			{
				if (reader.Read())
				{
					return Populate(reader);
				}
				return null;
			}
		}

		/// <summary>
		/// Get all of DM_KetQua
		/// </summary>
		/// <returns>List<<DM_KetQua>></returns>
		public List<DM_KetQua> GetList()
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_DM_KetQua_Get"))
			{
				List<DM_KetQua> list = new List<DM_KetQua>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of DM_KetQua
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_DM_KetQua_Get");
		}


		/// <summary>
		/// Get all of DM_KetQua paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>List<<DM_KetQua>></returns>
		public List<DM_KetQua> GetListPaged(int recperpage, int pageindex)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_DM_KetQua_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex)))
			{
				List<DM_KetQua> list = new List<DM_KetQua>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of DM_KetQua paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_DM_KetQua_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex));
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new DM_KetQua within DM_KetQua database table
		/// </summary>
		/// <param name="obj">DM_KetQua</param>
		/// <returns>key of table</returns>
		public int Add(DM_KetQua obj)
		{
			DbParameter parameterItemID = Data.CreateParameter("MaKetQua", obj.MaKetQua);
			parameterItemID.Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_DM_KetQua_Add"
							,parameterItemID
							,Data.CreateParameter("TenKetQua", obj.TenKetQua)
			);
			return 0;
		}

		/// <summary>
		/// updates the specified DM_KetQua
		/// </summary>
		/// <param name="obj">DM_KetQua</param>
		/// <returns></returns>
		public void Update(DM_KetQua obj)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_DM_KetQua_Update"
							,Data.CreateParameter("MaKetQua", obj.MaKetQua)
							,Data.CreateParameter("TenKetQua", obj.TenKetQua)
			);
		}

		/// <summary>
		/// Delete the specified DM_KetQua
		/// </summary>
		/// <param name="maketqua">MaKetQua</param>
		/// <returns></returns>
		public void Delete(Byte maketqua)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_DM_KetQua_Delete", Data.CreateParameter("MaKetQua", maketqua));
		}
		#endregion
	}
}
