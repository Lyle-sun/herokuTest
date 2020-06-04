using System;
using System.Data;
using System.Collections.Generic;

using DBA.Model;
using System.Text;
using Conris.Utility;
using System.Linq;
using MVC;

namespace DBA.BLL
{
	/// <summary>
	/// Users
	/// </summary>
	public partial class Users
	{
		private readonly DBA.DAL.Users dal=new DBA.DAL.Users();
		public Users()
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
		public int  Add(DBA.Model.Users model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(DBA.Model.Users model)
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
		public DBA.Model.Users GetModel(int ID)
		{
			
			return dal.GetModel(ID);
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
		public List<DBA.Model.Users> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<DBA.Model.Users> DataTableToList(DataTable dt)
		{
			List<DBA.Model.Users> modelList = new List<DBA.Model.Users>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				DBA.Model.Users model;
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
        public bool Edit(DBA.Model.Users model)
        {
            if (model.ID == 0)
            {
                Add(model);
                return true;
            }
            else
            {
                return Update(model);
            }
        }
        public List<DBA.Model.Users> SearchProject(Conris.DBA.ViewModel.UsersSearch model)
        {
            if (model == null)
                return null;
            StringBuilder sb = new StringBuilder(" 1=1");
            if (!string.IsNullOrEmpty(model.UserName))
            {

                sb.Append(" And UserName like '%" + model.Name + "%'");
            }
            if (!string.IsNullOrEmpty(model.Name))
            {

                sb.Append(" And Str1 like '%" + model.Name + "%'");
            }
            return GetPapedList(sb.ToString(), "ID desc", model.Pageindex);
        }

        public PagedList<DBA.Model.Users> GetPapedList(string strWhere, string orderby, int pageIndex)
        {
            int pageSize = 10;
            int totalItemCount = GetRecordCount(strWhere);
            int startIndex = pageIndex <= 1 ? 1 : ((pageIndex - 1) * pageSize) + 1;
            int endIndex = pageIndex <= 1 ? pageSize : ((pageIndex) * pageSize);
            List<DBA.Model.Users> modelList = DataTableToList(GetListByPage(strWhere, orderby, startIndex, endIndex).Tables[0]);
            IQueryable<DBA.Model.Users> list = modelList.AsQueryable();
            PagedList<DBA.Model.Users> pageList = list.OrderByDescending(m => m.ID).ToPagedList(pageIndex, pageSize, totalItemCount);
            return pageList;
        }

        /// 登录
        /// </summary>
        public string Login(string LoginName, string LoginPsd, bool IsStay)
        {
            string str = string.Format(" UserName='{0}' and UserPSD='{1}'  ", LoginName, LoginPsd);
            List<DBA.Model.Users> list = GetModelList(str);
            if (list.Count != 0)
            {
                AuthenHelper.Logout();
                AuthenHelper.CreateTicket(list[0].UserName, list[0].ID.ToString(), IsStay, DateTime.Now.AddHours(2), "");
                return "1";
            }
            else
                return "0";
        }

        /// 注册
        /// </summary>
        public string Regist(string LoginName, string LoginPsd)
        {
            List<Model.Users> list = GetModelList(" UserName='" + LoginName + "'");
            if (list!=null&&list.Count>0)
            {
                return "0";
            }
            Model.Users model = new Model.Users();
            model.UserType = "用户";
            model.UserName = LoginName;
            model.UserPSD = LoginPsd;
            model.Str2 = "0";
            Add(model);
            return "1";
        }

        //登出
        public bool LogOut()
        {
            try
            {
                AuthenHelper.Logout();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static string GetNowUserName()
        {
            return AuthenHelper.GetLoginUserName();
        }

        public static string GetNowUserID()
        {
            return AuthenHelper.GetLoginUserData();
        }
        public static string GetNowUserDep()
        {
            string ID = AuthenHelper.GetLoginUserData();
            DBA.DAL.Users dale = new DAL.Users();
            return dale.GetModel(Convert.ToInt32(ID)).DepName.Trim();


        }

        public static string GetNowUserNum()
        {
            string ID = AuthenHelper.GetLoginUserData();
            DBA.DAL.Users dale = new DAL.Users();
            return dale.GetModel(Convert.ToInt32(ID)).Str2.Trim();


        }

        public static string GetNowUserType()
        {
            string ID = AuthenHelper.GetLoginUserData();
            DBA.DAL.Users dale = new DAL.Users();
            return dale.GetModel(Convert.ToInt32(ID)).UserType.Trim();


        }
        #endregion  ExtensionMethod
	}
}

