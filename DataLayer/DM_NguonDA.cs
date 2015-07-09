using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using QuanLy_KhachHang.BusinessObjects;

namespace QuanLy_KhachHang.DataAccess
{
	public class DM_NguonDA
	{

		#region ***** Init Methods ***** 
		public DM_NguonDA()
		{
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public DM_Nguon Populate(IDataReader myReader)
		{
			DM_Nguon obj = new DM_Nguon();
			obj.MaNguon = (int) myReader["MaNguon"];
			obj.TenNguon = (string) myReader["TenNguon"];
			return obj;
		}

		/// <summary>
		/// Get DM_Nguon by manguon
		/// </summary>
		/// <param name="manguon">MaNguon</param>
		/// <returns>DM_Nguon</returns>
		public DM_Nguon GetByMaNguon(int manguon)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_DM_Nguon_GetByMaNguon", Data.CreateParameter("MaNguon", manguon)))
			{
				if (reader.Read())
				{
					return Populate(reader);
				}
				return null;
			}
		}

		/// <summary>
		/// Get all of DM_Nguon
		/// </summary>
		/// <returns>List<<DM_Nguon>></returns>
		public List<DM_Nguon> GetList()
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_DM_Nguon_Get"))
			{
				List<DM_Nguon> list = new List<DM_Nguon>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of DM_Nguon
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_DM_Nguon_Get");
		}


		/// <summary>
		/// Get all of DM_Nguon paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>List<<DM_Nguon>></returns>
		public List<DM_Nguon> GetListPaged(int recperpage, int pageindex)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_DM_Nguon_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex)))
			{
				List<DM_Nguon> list = new List<DM_Nguon>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of DM_Nguon paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_DM_Nguon_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex));
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new DM_Nguon within DM_Nguon database table
		/// </summary>
		/// <param name="obj">DM_Nguon</param>
		/// <returns>key of table</returns>
		public int Add(DM_Nguon obj)
		{
			DbParameter parameterItemID = Data.CreateParameter("MaNguon", obj.MaNguon);
			parameterItemID.Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_DM_Nguon_Add"
							,parameterItemID
							,Data.CreateParameter("TenNguon", obj.TenNguon)
			);
			return 0;
		}

		/// <summary>
		/// updates the specified DM_Nguon
		/// </summary>
		/// <param name="obj">DM_Nguon</param>
		/// <returns></returns>
		public void Update(DM_Nguon obj)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_DM_Nguon_Update"
							,Data.CreateParameter("MaNguon", obj.MaNguon)
							,Data.CreateParameter("TenNguon", obj.TenNguon)
			);
		}

		/// <summary>
		/// Delete the specified DM_Nguon
		/// </summary>
		/// <param name="manguon">MaNguon</param>
		/// <returns></returns>
		public void Delete(int manguon)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_DM_Nguon_Delete", Data.CreateParameter("MaNguon", manguon));
		}
		#endregion
	}
}
