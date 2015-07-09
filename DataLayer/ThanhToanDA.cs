using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using QuanLy_KhachHang.BusinessObjects;

namespace QuanLy_KhachHang.DataAccess
{
	public class ThanhToanDA
	{

		#region ***** Init Methods ***** 
		public ThanhToanDA()
		{
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public ThanhToan Populate(IDataReader myReader)
		{
			ThanhToan obj = new ThanhToan();
			obj.MaKhachHang_DichVu = (int) myReader["MaKhachHang_DichVu"];
			obj.NgayThanhToan = (DateTime) myReader["NgayThanhToan"];
			obj.SoTien = (decimal) myReader["SoTien"];
			obj.MaNhanVien = (int) myReader["MaNhanVien"];
			obj.NgayNop = (DateTime) myReader["NgayNop"];
			return obj;
		}


		/// <summary>
		/// Get all of ThanhToan
		/// </summary>
		/// <returns>List<<ThanhToan>></returns>
		public List<ThanhToan> GetList()
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_ThanhToan_Get"))
			{
				List<ThanhToan> list = new List<ThanhToan>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of ThanhToan
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_ThanhToan_Get");
		}


		/// <summary>
		/// Get all of ThanhToan paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>List<<ThanhToan>></returns>
		public List<ThanhToan> GetListPaged(int recperpage, int pageindex)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_ThanhToan_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex)))
			{
				List<ThanhToan> list = new List<ThanhToan>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of ThanhToan paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_ThanhToan_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex));
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new ThanhToan within ThanhToan database table
		/// </summary>
		/// <param name="obj">ThanhToan</param>
		/// <returns>key of table</returns>
		public int Add(ThanhToan obj)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_ThanhToan_Add"
							,Data.CreateParameter("MaKhachHang_DichVu", obj.MaKhachHang_DichVu)
							,Data.CreateParameter("NgayThanhToan", obj.NgayThanhToan)
							,Data.CreateParameter("SoTien", obj.SoTien)
							,Data.CreateParameter("MaNhanVien", obj.MaNhanVien)
							,Data.CreateParameter("NgayNop", obj.NgayNop)
			);
			return 0;
		}

//No key Found
		#endregion
	}
}
