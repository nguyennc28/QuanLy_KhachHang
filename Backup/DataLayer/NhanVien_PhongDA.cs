using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using QuanLy_KhachHang.BusinessObjects;

namespace QuanLy_KhachHang.DataAccess
{
	public class NhanVien_PhongDA
	{

		#region ***** Init Methods ***** 
		public NhanVien_PhongDA()
		{
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public NhanVien_Phong Populate(IDataReader myReader)
		{
			NhanVien_Phong obj = new NhanVien_Phong();
			obj.MaNhanVien = (int) myReader["MaNhanVien"];
			obj.MaPhong = (Byte) myReader["MaPhong"];
			obj.ThoiGianBatDau = (DateTime) myReader["ThoiGianBatDau"];
			obj.ThowiGianKetThuc = (DateTime) myReader["ThowiGianKetThuc"];
			return obj;
		}


		/// <summary>
		/// Get all of NhanVien_Phong
		/// </summary>
		/// <returns>List<<NhanVien_Phong>></returns>
		public List<NhanVien_Phong> GetList()
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_NhanVien_Phong_Get"))
			{
				List<NhanVien_Phong> list = new List<NhanVien_Phong>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of NhanVien_Phong
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_NhanVien_Phong_Get");
		}


		/// <summary>
		/// Get all of NhanVien_Phong paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>List<<NhanVien_Phong>></returns>
		public List<NhanVien_Phong> GetListPaged(int recperpage, int pageindex)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_NhanVien_Phong_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex)))
			{
				List<NhanVien_Phong> list = new List<NhanVien_Phong>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of NhanVien_Phong paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_NhanVien_Phong_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex));
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new NhanVien_Phong within NhanVien_Phong database table
		/// </summary>
		/// <param name="obj">NhanVien_Phong</param>
		/// <returns>key of table</returns>
		public int Add(NhanVien_Phong obj)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_NhanVien_Phong_Add"
							,Data.CreateParameter("MaNhanVien", obj.MaNhanVien)
							,Data.CreateParameter("MaPhong", obj.MaPhong)
							,Data.CreateParameter("ThoiGianBatDau", obj.ThoiGianBatDau)
							,Data.CreateParameter("ThowiGianKetThuc", obj.ThowiGianKetThuc)
			);
			return 0;
		}

//No key Found
		#endregion
	}
}
