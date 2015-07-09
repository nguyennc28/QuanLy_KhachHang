using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using QuanLy_KhachHang.BusinessObjects;
using QuanLy_KhachHang.DataAccess;

namespace QuanLy_KhachHang.BusinessLogic
{
	public class NhanVienBL
	{

		#region ***** Init Methods ***** 
		NhanVienDA objNhanVienDA;
		public NhanVienBL()
		{
			objNhanVienDA = new NhanVienDA();
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// Get NhanVien by manhanvien
		/// </summary>
		/// <param name="manhanvien">MaNhanVien</param>
		/// <returns>NhanVien</returns>
		public NhanVien GetByMaNhanVien(int manhanvien)
		{
			return objNhanVienDA.GetByMaNhanVien(manhanvien);
		}

		/// <summary>
		/// Get all of NhanVien
		/// </summary>
		/// <returns>List<<NhanVien>></returns>
		public List<NhanVien> GetList()
		{
			string cacheName = "lstNhanVien";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objNhanVienDA.GetList(), "NhanVien");
			}
			return (List<NhanVien>) ServerCache.Get(cacheName);
		}

		/// <summary>
		/// Get DataSet of NhanVien
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			string cacheName = "dsNhanVien";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objNhanVienDA.GetDataSet(), "NhanVien");
			}
			return (DataSet) ServerCache.Get(cacheName);
		}


		/// <summary>
		/// Get all of NhanVien paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>List<<NhanVien>></returns>
		public List<NhanVien> GetListPaged(int recperpage, int pageindex)
		{
			return objNhanVienDA.GetListPaged(recperpage, pageindex);
		}

		/// <summary>
		/// Get DataSet of NhanVien paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return objNhanVienDA.GetDataSetPaged(recperpage, pageindex);
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new NhanVien within NhanVien database table
		/// </summary>
		/// <param name="obj_nhanvien">NhanVien</param>
		/// <returns>key of table</returns>
		public int Add(NhanVien obj_nhanvien)
		{
			ServerCache.Remove("NhanVien", true);
			return objNhanVienDA.Add(obj_nhanvien);
		}

		/// <summary>
		/// updates the specified NhanVien
		/// </summary>
		/// <param name="obj_nhanvien">NhanVien</param>
		/// <returns></returns>
		public void Update(NhanVien obj_nhanvien)
		{
			ServerCache.Remove("NhanVien", true);
			objNhanVienDA.Update(obj_nhanvien);
		}

		/// <summary>
		/// Delete the specified NhanVien
		/// </summary>
		/// <param name="manhanvien">MaNhanVien</param>
		/// <returns></returns>
		public void Delete(int manhanvien)
		{
			ServerCache.Remove("NhanVien", true);
			objNhanVienDA.Delete(manhanvien);
		}
		#endregion
	}
}
