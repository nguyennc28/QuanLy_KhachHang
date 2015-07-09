using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using QuanLy_KhachHang.BusinessObjects;

namespace QuanLy_KhachHang.DataAccess
{
	public class CSKHDA
	{

		#region ***** Init Methods ***** 
		public CSKHDA()
		{
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public CSKH Populate(IDataReader myReader)
		{
			CSKH obj = new CSKH();
			obj.Ma_CSKH = (int) myReader["Ma_CSKH"];
			obj.MaKhachHang_DichVu = (int) myReader["MaKhachHang_DichVu"];
			obj.MaKetQua = (Byte) myReader["MaKetQua"];
			obj.MaNhanVien = (int) myReader["MaNhanVien"];
			obj.NgayThucHien = (DateTime) myReader["NgayThucHien"];
			obj.NoiDung = (string) myReader["NoiDung"];
			return obj;
		}

		/// <summary>
		/// Get CSKH by ma_cskh
		/// </summary>
		/// <param name="ma_cskh">Ma_CSKH</param>
		/// <returns>CSKH</returns>
		public CSKH GetByMa_CSKH(int ma_cskh)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_CSKH_GetByMa_CSKH", Data.CreateParameter("Ma_CSKH", ma_cskh)))
			{
				if (reader.Read())
				{
					return Populate(reader);
				}
				return null;
			}
		}

		/// <summary>
		/// Get all of CSKH
		/// </summary>
		/// <returns>List<<CSKH>></returns>
		public List<CSKH> GetList()
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_CSKH_Get"))
			{
				List<CSKH> list = new List<CSKH>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of CSKH
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_CSKH_Get");
		}


		/// <summary>
		/// Get all of CSKH paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>List<<CSKH>></returns>
		public List<CSKH> GetListPaged(int recperpage, int pageindex)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_CSKH_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex)))
			{
				List<CSKH> list = new List<CSKH>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of CSKH paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_CSKH_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex));
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new CSKH within CSKH database table
		/// </summary>
		/// <param name="obj">CSKH</param>
		/// <returns>key of table</returns>
		public int Add(CSKH obj)
		{
			DbParameter parameterItemID = Data.CreateParameter("Ma_CSKH", obj.Ma_CSKH);
			parameterItemID.Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_CSKH_Add"
							,parameterItemID
							,Data.CreateParameter("MaKhachHang_DichVu", obj.MaKhachHang_DichVu)
							,Data.CreateParameter("MaKetQua", obj.MaKetQua)
							,Data.CreateParameter("MaNhanVien", obj.MaNhanVien)
							,Data.CreateParameter("NgayThucHien", obj.NgayThucHien)
							,Data.CreateParameter("NoiDung", obj.NoiDung)
			);
			return 0;
		}

		/// <summary>
		/// updates the specified CSKH
		/// </summary>
		/// <param name="obj">CSKH</param>
		/// <returns></returns>
		public void Update(CSKH obj)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_CSKH_Update"
							,Data.CreateParameter("Ma_CSKH", obj.Ma_CSKH)
							,Data.CreateParameter("MaKhachHang_DichVu", obj.MaKhachHang_DichVu)
							,Data.CreateParameter("MaKetQua", obj.MaKetQua)
							,Data.CreateParameter("MaNhanVien", obj.MaNhanVien)
							,Data.CreateParameter("NgayThucHien", obj.NgayThucHien)
							,Data.CreateParameter("NoiDung", obj.NoiDung)
			);
		}

		/// <summary>
		/// Delete the specified CSKH
		/// </summary>
		/// <param name="ma_cskh">Ma_CSKH</param>
		/// <returns></returns>
		public void Delete(int ma_cskh)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_CSKH_Delete", Data.CreateParameter("Ma_CSKH", ma_cskh));
		}
		#endregion
	}
}
