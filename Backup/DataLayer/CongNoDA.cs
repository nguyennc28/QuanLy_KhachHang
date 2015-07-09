using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using QuanLy_KhachHang.BusinessObjects;

namespace QuanLy_KhachHang.DataAccess
{
	public class CongNoDA
	{

		#region ***** Init Methods ***** 
		public CongNoDA()
		{
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public CongNo Populate(IDataReader myReader)
		{
			CongNo obj = new CongNo();
			obj.MaKhachHang_DichVu = (int) myReader["MaKhachHang_DichVu"];
			obj.MaNhanVien = (int) myReader["MaNhanVien"];
			obj.NgayThongBao = (DateTime) myReader["NgayThongBao"];
			obj.Sotien = (decimal) myReader["Sotien"];
			obj.HanNop = (DateTime) myReader["HanNop"];
			return obj;
		}


		/// <summary>
		/// Get all of CongNo
		/// </summary>
		/// <returns>List<<CongNo>></returns>
		public List<CongNo> GetList()
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_CongNo_Get"))
			{
				List<CongNo> list = new List<CongNo>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of CongNo
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_CongNo_Get");
		}


		/// <summary>
		/// Get all of CongNo paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>List<<CongNo>></returns>
		public List<CongNo> GetListPaged(int recperpage, int pageindex)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_CongNo_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex)))
			{
				List<CongNo> list = new List<CongNo>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of CongNo paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_CongNo_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex));
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new CongNo within CongNo database table
		/// </summary>
		/// <param name="obj">CongNo</param>
		/// <returns>key of table</returns>
		public int Add(CongNo obj)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_CongNo_Add"
							,Data.CreateParameter("MaKhachHang_DichVu", obj.MaKhachHang_DichVu)
							,Data.CreateParameter("MaNhanVien", obj.MaNhanVien)
							,Data.CreateParameter("NgayThongBao", obj.NgayThongBao)
							,Data.CreateParameter("Sotien", obj.Sotien)
							,Data.CreateParameter("HanNop", obj.HanNop)
			);
			return 0;
		}

//No key Found
		#endregion
	}
}
