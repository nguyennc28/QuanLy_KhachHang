using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using QuanLy_KhachHang.BusinessObjects;

namespace QuanLy_KhachHang.DataAccess
{
	public class KhachHang_DichVuDA
	{

		#region ***** Init Methods ***** 
		public KhachHang_DichVuDA()
		{
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public KhachHang_DichVu Populate(IDataReader myReader)
		{
			KhachHang_DichVu obj = new KhachHang_DichVu();
			obj.MaKhachHang_DichVu = (int) myReader["MaKhachHang_DichVu"];
			obj.MaKhachHang = (int) myReader["MaKhachHang"];
			obj.MaDichVu = (Byte) myReader["MaDichVu"];
			obj.MaNguon = (int) myReader["MaNguon"];
			obj.GiaTriHopDong = (decimal) myReader["GiaTriHopDong"];
			obj.SoHopDong = (string) myReader["SoHopDong"];
			obj.TomTatHopDong = (string) myReader["TomTatHopDong"];
			obj.NgayThanhLyHD = (DateTime) myReader["NgayThanhLyHD"];
			obj.NgayBatDauDichVu = (DateTime) myReader["NgayBatDauDichVu"];
			obj.NgayKetThucDichVu = (DateTime) myReader["NgayKetThucDichVu"];
			return obj;
		}

		/// <summary>
		/// Get KhachHang_DichVu by makhachhang_dichvu
		/// </summary>
		/// <param name="makhachhang_dichvu">MaKhachHang_DichVu</param>
		/// <returns>KhachHang_DichVu</returns>
		public KhachHang_DichVu GetByMaKhachHang_DichVu(int makhachhang_dichvu)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_KhachHang_DichVu_GetByMaKhachHang_DichVu", Data.CreateParameter("MaKhachHang_DichVu", makhachhang_dichvu)))
			{
				if (reader.Read())
				{
					return Populate(reader);
				}
				return null;
			}
		}

		/// <summary>
		/// Get all of KhachHang_DichVu
		/// </summary>
		/// <returns>List<<KhachHang_DichVu>></returns>
		public List<KhachHang_DichVu> GetList()
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_KhachHang_DichVu_Get"))
			{
				List<KhachHang_DichVu> list = new List<KhachHang_DichVu>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of KhachHang_DichVu
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_KhachHang_DichVu_Get");
		}


		/// <summary>
		/// Get all of KhachHang_DichVu paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>List<<KhachHang_DichVu>></returns>
		public List<KhachHang_DichVu> GetListPaged(int recperpage, int pageindex)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_KhachHang_DichVu_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex)))
			{
				List<KhachHang_DichVu> list = new List<KhachHang_DichVu>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of KhachHang_DichVu paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_KhachHang_DichVu_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex));
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new KhachHang_DichVu within KhachHang_DichVu database table
		/// </summary>
		/// <param name="obj">KhachHang_DichVu</param>
		/// <returns>key of table</returns>
		public int Add(KhachHang_DichVu obj)
		{
			DbParameter parameterItemID = Data.CreateParameter("MaKhachHang_DichVu", obj.MaKhachHang_DichVu);
			parameterItemID.Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_KhachHang_DichVu_Add"
							,parameterItemID
							,Data.CreateParameter("MaKhachHang", obj.MaKhachHang)
							,Data.CreateParameter("MaDichVu", obj.MaDichVu)
							,Data.CreateParameter("MaNguon", obj.MaNguon)
							,Data.CreateParameter("GiaTriHopDong", obj.GiaTriHopDong)
							,Data.CreateParameter("SoHopDong", obj.SoHopDong)
							,Data.CreateParameter("TomTatHopDong", obj.TomTatHopDong)
							,Data.CreateParameter("NgayThanhLyHD", obj.NgayThanhLyHD)
							,Data.CreateParameter("NgayBatDauDichVu", obj.NgayBatDauDichVu)
							,Data.CreateParameter("NgayKetThucDichVu", obj.NgayKetThucDichVu)
			);
			return 0;
		}

		/// <summary>
		/// updates the specified KhachHang_DichVu
		/// </summary>
		/// <param name="obj">KhachHang_DichVu</param>
		/// <returns></returns>
		public void Update(KhachHang_DichVu obj)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_KhachHang_DichVu_Update"
							,Data.CreateParameter("MaKhachHang_DichVu", obj.MaKhachHang_DichVu)
							,Data.CreateParameter("MaKhachHang", obj.MaKhachHang)
							,Data.CreateParameter("MaDichVu", obj.MaDichVu)
							,Data.CreateParameter("MaNguon", obj.MaNguon)
							,Data.CreateParameter("GiaTriHopDong", obj.GiaTriHopDong)
							,Data.CreateParameter("SoHopDong", obj.SoHopDong)
							,Data.CreateParameter("TomTatHopDong", obj.TomTatHopDong)
							,Data.CreateParameter("NgayThanhLyHD", obj.NgayThanhLyHD)
							,Data.CreateParameter("NgayBatDauDichVu", obj.NgayBatDauDichVu)
							,Data.CreateParameter("NgayKetThucDichVu", obj.NgayKetThucDichVu)
			);
		}

		/// <summary>
		/// Delete the specified KhachHang_DichVu
		/// </summary>
		/// <param name="makhachhang_dichvu">MaKhachHang_DichVu</param>
		/// <returns></returns>
		public void Delete(int makhachhang_dichvu)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_KhachHang_DichVu_Delete", Data.CreateParameter("MaKhachHang_DichVu", makhachhang_dichvu));
		}
		#endregion
	}
}
