using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using QuanLy_KhachHang.BusinessObjects;

namespace QuanLy_KhachHang.DataAccess
{
	public class VATDA
	{

		#region ***** Init Methods ***** 
		public VATDA()
		{
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public VAT Populate(IDataReader myReader)
		{
			VAT obj = new VAT();
			obj.MaKhachHang_DichVu = (int) myReader["MaKhachHang_DichVu"];
			obj.MaNhanVien = (int) myReader["MaNhanVien"];
			obj.NgayXuatVAT = (DateTime) myReader["NgayXuatVAT"];
			obj.SoTien = (decimal) myReader["SoTien"];
			return obj;
		}


		/// <summary>
		/// Get all of VAT
		/// </summary>
		/// <returns>List<<VAT>></returns>
		public List<VAT> GetList()
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_VAT_Get"))
			{
				List<VAT> list = new List<VAT>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of VAT
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_VAT_Get");
		}


		/// <summary>
		/// Get all of VAT paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>List<<VAT>></returns>
		public List<VAT> GetListPaged(int recperpage, int pageindex)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_VAT_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex)))
			{
				List<VAT> list = new List<VAT>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of VAT paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_VAT_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex));
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new VAT within VAT database table
		/// </summary>
		/// <param name="obj">VAT</param>
		/// <returns>key of table</returns>
		public int Add(VAT obj)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_VAT_Add"
							,Data.CreateParameter("MaKhachHang_DichVu", obj.MaKhachHang_DichVu)
							,Data.CreateParameter("MaNhanVien", obj.MaNhanVien)
							,Data.CreateParameter("NgayXuatVAT", obj.NgayXuatVAT)
							,Data.CreateParameter("SoTien", obj.SoTien)
			);
			return 0;
		}

//No key Found
		#endregion
	}
}
