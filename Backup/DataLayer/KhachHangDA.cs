using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using QuanLy_KhachHang.BusinessObjects;

namespace QuanLy_KhachHang.DataAccess
{
	public class KhachHangDA
	{

		#region ***** Init Methods ***** 
		public KhachHangDA()
		{
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public KhachHang Populate(IDataReader myReader)
		{
			KhachHang obj = new KhachHang();
			obj.MaKhachHang = (int) myReader["MaKhachHang"];
			obj.TenKhachHang = (string) myReader["TenKhachHang"];
			obj.DiaChiLienHe = (string) myReader["DiaChiLienHe"];
			obj.DiaChiVAT = (string) myReader["DiaChiVAT"];
			obj.Email = (string) myReader["Email"];
			obj.DienThoai = (string) myReader["DienThoai"];
			obj.NguoiLienHe = (string) myReader["NguoiLienHe"];
			return obj;
		}

		/// <summary>
		/// Get KhachHang by makhachhang
		/// </summary>
		/// <param name="makhachhang">MaKhachHang</param>
		/// <returns>KhachHang</returns>
		public KhachHang GetByMaKhachHang(int makhachhang)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_KhachHang_GetByMaKhachHang", Data.CreateParameter("MaKhachHang", makhachhang)))
			{
				if (reader.Read())
				{
					return Populate(reader);
				}
				return null;
			}
		}

		/// <summary>
		/// Get all of KhachHang
		/// </summary>
		/// <returns>List<<KhachHang>></returns>
		public List<KhachHang> GetList()
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_KhachHang_Get"))
			{
				List<KhachHang> list = new List<KhachHang>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of KhachHang
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_KhachHang_Get");
		}


		/// <summary>
		/// Get all of KhachHang paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>List<<KhachHang>></returns>
		public List<KhachHang> GetListPaged(int recperpage, int pageindex)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_KhachHang_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex)))
			{
				List<KhachHang> list = new List<KhachHang>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of KhachHang paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_KhachHang_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex));
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new KhachHang within KhachHang database table
		/// </summary>
		/// <param name="obj">KhachHang</param>
		/// <returns>key of table</returns>
		public int Add(KhachHang obj)
		{
			DbParameter parameterItemID = Data.CreateParameter("MaKhachHang", obj.MaKhachHang);
			parameterItemID.Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_KhachHang_Add"
							,parameterItemID
							,Data.CreateParameter("TenKhachHang", obj.TenKhachHang)
							,Data.CreateParameter("DiaChiLienHe", obj.DiaChiLienHe)
							,Data.CreateParameter("DiaChiVAT", obj.DiaChiVAT)
							,Data.CreateParameter("Email", obj.Email)
							,Data.CreateParameter("DienThoai", obj.DienThoai)
							,Data.CreateParameter("NguoiLienHe", obj.NguoiLienHe)
			);
			return 0;
		}

		/// <summary>
		/// updates the specified KhachHang
		/// </summary>
		/// <param name="obj">KhachHang</param>
		/// <returns></returns>
		public void Update(KhachHang obj)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_KhachHang_Update"
							,Data.CreateParameter("MaKhachHang", obj.MaKhachHang)
							,Data.CreateParameter("TenKhachHang", obj.TenKhachHang)
							,Data.CreateParameter("DiaChiLienHe", obj.DiaChiLienHe)
							,Data.CreateParameter("DiaChiVAT", obj.DiaChiVAT)
							,Data.CreateParameter("Email", obj.Email)
							,Data.CreateParameter("DienThoai", obj.DienThoai)
							,Data.CreateParameter("NguoiLienHe", obj.NguoiLienHe)
			);
		}

		/// <summary>
		/// Delete the specified KhachHang
		/// </summary>
		/// <param name="makhachhang">MaKhachHang</param>
		/// <returns></returns>
		public void Delete(int makhachhang)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_KhachHang_Delete", Data.CreateParameter("MaKhachHang", makhachhang));
		}
		#endregion
	}
}
