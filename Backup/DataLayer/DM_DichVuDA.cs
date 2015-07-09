using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using QuanLy_KhachHang.BusinessObjects;

namespace QuanLy_KhachHang.DataAccess
{
	public class DM_DichVuDA
	{

		#region ***** Init Methods ***** 
		public DM_DichVuDA()
		{
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public DM_DichVu Populate(IDataReader myReader)
		{
			DM_DichVu obj = new DM_DichVu();
			obj.MaDichVu = (Byte) myReader["MaDichVu"];
			obj.TenDichVu = (string) myReader["TenDichVu"];
			return obj;
		}

		/// <summary>
		/// Get DM_DichVu by madichvu
		/// </summary>
		/// <param name="madichvu">MaDichVu</param>
		/// <returns>DM_DichVu</returns>
		public DM_DichVu GetByMaDichVu(Byte madichvu)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_DM_DichVu_GetByMaDichVu", Data.CreateParameter("MaDichVu", madichvu)))
			{
				if (reader.Read())
				{
					return Populate(reader);
				}
				return null;
			}
		}

		/// <summary>
		/// Get all of DM_DichVu
		/// </summary>
		/// <returns>List<<DM_DichVu>></returns>
		public List<DM_DichVu> GetList()
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_DM_DichVu_Get"))
			{
				List<DM_DichVu> list = new List<DM_DichVu>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of DM_DichVu
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_DM_DichVu_Get");
		}


		/// <summary>
		/// Get all of DM_DichVu paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>List<<DM_DichVu>></returns>
		public List<DM_DichVu> GetListPaged(int recperpage, int pageindex)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_DM_DichVu_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex)))
			{
				List<DM_DichVu> list = new List<DM_DichVu>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of DM_DichVu paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_DM_DichVu_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex));
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new DM_DichVu within DM_DichVu database table
		/// </summary>
		/// <param name="obj">DM_DichVu</param>
		/// <returns>key of table</returns>
		public int Add(DM_DichVu obj)
		{
			DbParameter parameterItemID = Data.CreateParameter("MaDichVu", obj.MaDichVu);
			parameterItemID.Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_DM_DichVu_Add"
							,parameterItemID
							,Data.CreateParameter("TenDichVu", obj.TenDichVu)
			);
			return 0;
		}

		/// <summary>
		/// updates the specified DM_DichVu
		/// </summary>
		/// <param name="obj">DM_DichVu</param>
		/// <returns></returns>
		public void Update(DM_DichVu obj)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_DM_DichVu_Update"
							,Data.CreateParameter("MaDichVu", obj.MaDichVu)
							,Data.CreateParameter("TenDichVu", obj.TenDichVu)
			);
		}

		/// <summary>
		/// Delete the specified DM_DichVu
		/// </summary>
		/// <param name="madichvu">MaDichVu</param>
		/// <returns></returns>
		public void Delete(Byte madichvu)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_DM_DichVu_Delete", Data.CreateParameter("MaDichVu", madichvu));
		}
		#endregion
	}
}
