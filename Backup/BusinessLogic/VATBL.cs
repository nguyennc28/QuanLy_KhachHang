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
	public class VATBL
	{

		#region ***** Init Methods ***** 
		VATDA objVATDA;
		public VATBL()
		{
			objVATDA = new VATDA();
		}
		#endregion

		#region ***** Get Methods ***** 

		/// <summary>
		/// Get all of VAT
		/// </summary>
		/// <returns>List<<VAT>></returns>
		public List<VAT> GetList()
		{
			string cacheName = "lstVAT";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objVATDA.GetList(), "VAT");
			}
			return (List<VAT>) ServerCache.Get(cacheName);
		}

		/// <summary>
		/// Get DataSet of VAT
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			string cacheName = "dsVAT";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objVATDA.GetDataSet(), "VAT");
			}
			return (DataSet) ServerCache.Get(cacheName);
		}


		/// <summary>
		/// Get all of VAT paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>List<<VAT>></returns>
		public List<VAT> GetListPaged(int recperpage, int pageindex)
		{
			return objVATDA.GetListPaged(recperpage, pageindex);
		}

		/// <summary>
		/// Get DataSet of VAT paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return objVATDA.GetDataSetPaged(recperpage, pageindex);
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new VAT within VAT database table
		/// </summary>
		/// <param name="obj_vat">VAT</param>
		/// <returns>key of table</returns>
		public int Add(VAT obj_vat)
		{
			ServerCache.Remove("VAT", true);
			return objVATDA.Add(obj_vat);
		}

//No key Found
		#endregion
	}
}
