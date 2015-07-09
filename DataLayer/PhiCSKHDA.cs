using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using QuanLy_KhachHang.BusinessObjects;

namespace QuanLy_KhachHang.DataAccess
{
	public class PhiCSKHDA
	{

		#region ***** Init Methods ***** 
		public PhiCSKHDA()
		{
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public PhiCSKH Populate(IDataReader myReader)
		{
			PhiCSKH obj = new PhiCSKH();
			obj.Ma_CSKH = (int) myReader["Ma_CSKH"];
			obj.MaNhanVien = (int) myReader["MaNhanVien"];
			obj.NgayNop = (DateTime) myReader["NgayNop"];
			obj.SoTien = (decimal) myReader["SoTien"];
			obj.NguoiNop = (string) myReader["NguoiNop"];
			obj.GhiChu = (string) myReader["GhiChu"];
			return obj;
		}


		/// <summary>
		/// Get all of PhiCSKH
		/// </summary>
		/// <returns>List<<PhiCSKH>></returns>
		public List<PhiCSKH> GetList()
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_PhiCSKH_Get"))
			{
				List<PhiCSKH> list = new List<PhiCSKH>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of PhiCSKH
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_PhiCSKH_Get");
		}


		/// <summary>
		/// Get all of PhiCSKH paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>List<<PhiCSKH>></returns>
		public List<PhiCSKH> GetListPaged(int recperpage, int pageindex)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_PhiCSKH_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex)))
			{
				List<PhiCSKH> list = new List<PhiCSKH>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of PhiCSKH paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_PhiCSKH_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex));
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new PhiCSKH within PhiCSKH database table
		/// </summary>
		/// <param name="obj">PhiCSKH</param>
		/// <returns>key of table</returns>
		public int Add(PhiCSKH obj)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_PhiCSKH_Add"
							,Data.CreateParameter("Ma_CSKH", obj.Ma_CSKH)
							,Data.CreateParameter("MaNhanVien", obj.MaNhanVien)
							,Data.CreateParameter("NgayNop", obj.NgayNop)
							,Data.CreateParameter("SoTien", obj.SoTien)
							,Data.CreateParameter("NguoiNop", obj.NguoiNop)
							,Data.CreateParameter("GhiChu", obj.GhiChu)
			);
			return 0;
		}

//No key Found
		#endregion
	}
}
