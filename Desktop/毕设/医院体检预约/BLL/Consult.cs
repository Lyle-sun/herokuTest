using System;
using System.Data;
using System.Collections.Generic;

using DBA.Model;
using System.Text;
using System.Linq;
using MVC;
namespace DBA.BLL
{
	/// <summary>
	/// Consult
	/// </summary>
	public partial class Consult
	{
		private readonly DBA.DAL.Consult dal=new DBA.DAL.Consult();
		public Consult()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			return dal.Exists(ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(DBA.Model.Consult model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(DBA.Model.Consult model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int ID)
		{
			
			return dal.Delete(ID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string IDlist )
		{
			return dal.DeleteList(Maticsoft.Common.PageValidate.SafeLongFilter(IDlist,0) );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public DBA.Model.Consult GetModel(int ID)
		{
			
			return dal.GetModel(ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public DBA.Model.Consult GetModelByCache(int ID)
		{
			
			string CacheKey = "ConsultModel-" + ID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(ID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (DBA.Model.Consult)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<DBA.Model.Consult> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<DBA.Model.Consult> DataTableToList(DataTable dt)
		{
			List<DBA.Model.Consult> modelList = new List<DBA.Model.Consult>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				DBA.Model.Consult model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
        #region  ExtensionMethod
        public bool Edit(DBA.Model.Consult model)
        {
            if (model.ID == 0)
            {
                model.CreateTime = DateTime.Now;
                model.UserID = DBA.BLL.Users.GetNowUserID().ToString();
                model.State = "未回复";
                model.UserName = DBA.BLL.Users.GetNowUserName();
                Add(model);
                return true;
            }
            else 
            {
                DBA.Model.Consult model2 = dal.GetModel(model.ID);
                model2.Reply = model.Reply;
                model2.State = "已回复";
                model2.ReTime = DateTime.Now;
                
                return Update(model2);
            }
        }

        public bool ZEdit(DBA.Model.Consult model)
        {
          
                DBA.Model.Consult model2 = dal.GetModel(model.ID);
                model2.Reply = model.Reply;
                model2.State = "未回复";
                model2.ReName = model.ReName;
                model2.ReTime = DateTime.Now;
                return Update(model2);
           
        }

        public List<DBA.Model.Consult> SearchProject(Conris.DBA.ViewModel.ConsultSearch model)
        {
            if (model == null)
                return null;
            StringBuilder sb = new StringBuilder(" 1=1");
            if (DBA.BLL.Users.GetNowUserType() == "用户")
            {
                sb.Append(" And UserID='" + DBA.BLL.Users.GetNowUserID() + "'");
            }
           
            if (!string.IsNullOrEmpty(model.State))
            {

                sb.Append(" And State like '%" + model.State + "%'");
            }
            if (!string.IsNullOrEmpty(model.UserID))
            {

                sb.Append(" And UserID = '" + model.UserID + "'");
            }
            return GetPapedList(sb.ToString(), "ID desc", model.Pageindex);
        }

        public PagedList<DBA.Model.Consult> GetPapedList(string strWhere, string orderby, int pageIndex)
        {
            int pageSize = 10;
            int totalItemCount = GetRecordCount(strWhere);
            int startIndex = pageIndex <= 1 ? 1 : ((pageIndex - 1) * pageSize) + 1;
            int endIndex = pageIndex <= 1 ? pageSize : ((pageIndex) * pageSize);
            List<DBA.Model.Consult> modelList = DataTableToList(GetListByPage(strWhere, orderby, startIndex, endIndex).Tables[0]);
            IQueryable<DBA.Model.Consult> list = modelList.AsQueryable();
            PagedList<DBA.Model.Consult> pageList = list.OrderByDescending(m => m.ID).ToPagedList(pageIndex, pageSize, totalItemCount);
            return pageList;
        }
        #endregion  ExtensionMethod
	}
}

