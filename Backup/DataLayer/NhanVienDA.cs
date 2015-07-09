using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using QuanLy_KhachHang.BusinessObjects;

namespace QuanLy_KhachHang.DataAccess
{
	public class NhanVienDA
	{

		#region ***** Init Methods ***** 
		public NhanVienDA()
		{
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public NhanVien Populate(IDataReader myReader)
		{
			NhanVien obj = new NhanVien();
			obj.MaNhanVien = (int) myReader["MaNhanVien"];
			obj.HoTen = (string) myReader["HoTen"];
			obj.NgaySinh = (DateTime) myReader["NgaySinh"];
			obj.DienThoai = (string) myReader["DienThoai"];
			obj.Email = (string) myReader["Email"];
			return obj;
		}

		/// <summary>
		/// Get NhanVien by manhanvien
		/// </summary>
		/// <param name="manhanvien">MaNhanVien</param>
		/// <returns>NhanVien</returns>
		public NhanVien GetByMaNhanVien(int manhanvien)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_NhanVien_GetByMaNhanVien", Data.CreateParameter("MaNhanVien", manhanvien)))
			{
				if (reader.Read())
				{
					return Populate(reader);
				}
				return null;
			}
		}

		/// <summary>
		/// Get all of NhanVien
		/// </summary>
		/// <returns>List<<NhanVien>></returns>
		public List<NhanVien> GetList()
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_NhanVien_Get"))
			{
				List<NhanVien> list = new List<NhanVien>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of NhanVien
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_NhanVien_Get");
		}


		/// <summary>
		/// Get all of NhanVien paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>List<<NhanVien>></returns>
		public List<NhanVien> GetListPaged(int recperpage, int pageindex)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_NhanVien_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex)))
			{
				List<NhanVien> list = new List<NhanVien>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of NhanVien paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_NhanVien_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex));
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new NhanVien within NhanVien database table
		/// </summary>
		/// <param name="obj">NhanVien</param>
		/// <returns>key of table</returns>
		public int Add(NhanVien obj)
		{
			DbParameter parameterItemID = Data.CreateParameter("MaNhanVien", obj.MaNhanVien);
			parameterItemID.Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_NhanVien_Add"
							,parameterItemID
							,Data.CreateParameter("HoTen", obj.HoTen)
							,Data.CreateParameter("NgaySinh", obj.NgaySinh)
							,Data.CreateParameter("DienThoai", obj.DienThoai)
							,Data.CreateParameter("Email", obj.Email)
			);
			return 0;
		}

		/// <summary>
		/// updates the specified NhanVien
		/// </summary>
		/// <param name="obj">NhanVien</param>
		/// <returns></returns>
		public void Update(NhanVien obj)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_NhanVien_Update"
							,Data.CreateParameter("MaNhanVien", obj.MaNhanVien)
							,Data.CreateParameter("HoTen", obj.HoTen)
							,Data.CreateParameter("NgaySinh", obj.NgaySinh)
							,Data.CreateParameter("DienThoai", obj.DienThoai)
							,Data.CreateParameter("Email", obj.Email)
			);
		}

		/// <summary>
		/// Delete the specified NhanVien
		/// </summary>
		/// <param name="manhanvien">MaNhanVien</param>
		/// <returns></returns>
		public void Delete(int manhanvien)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_NhanVien_Delete", Data.CreateParameter("MaNhanVien", manhanvien));
		}
		#endregion
	}
}
