using System;
using System.Data;
using System.Collections.Generic;
using DBA.Model;
namespace DBA.BLL
{
    /// <summary>
    /// ExaminationItme
    /// </summary>
    public partial class ExaminationItme
    {
        private readonly DBA.DAL.ExaminationItme dal = new DBA.DAL.ExaminationItme();
        public ExaminationItme()
        { }
        #region  BasicMethod

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(DBA.Model.ExaminationItme model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(DBA.Model.ExaminationItme model)
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
        public bool DeleteList(string IDlist)
        {
            return dal.DeleteList(IDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public DBA.Model.ExaminationItme GetModel(int ID)
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
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<DBA.Model.ExaminationItme> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<DBA.Model.ExaminationItme> DataTableToList(DataTable dt)
        {
            List<DBA.Model.ExaminationItme> modelList = new List<DBA.Model.ExaminationItme>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                DBA.Model.ExaminationItme model;
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
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
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
        /// <summary>
        /// 获得Json数据列表
        /// </summary>
        public List<Conris.DBA.Model.JsonModel> GetExaminationItmeJsonList()
        {
            DataSet ds = dal.GetList("  len(DepartmentID)=6");
            return ds.Tables.Count > 0 ? DataTableToJsonList(ds.Tables[0]) : null;
        }
        public List<Conris.DBA.Model.JsonModel> DataTableToJsonList(DataTable dt, bool isNoCheck = false)
        {
           
            List<Conris.DBA.Model.JsonModel> modelList = new List<Conris.DBA.Model.JsonModel>();
            DataTable departmentList = dal.GetList(" len(DepartmentID)=3").Tables[0];
            int departmentrowsCount = departmentList.Rows.Count;
            if (departmentrowsCount > 0)
            {
                Conris.DBA.Model.JsonModel model;
                for (int n = 0; n < departmentrowsCount; n++)
                {
                    model = new Conris.DBA.Model.JsonModel();
                    if (departmentList.Rows[n]["ID"] != null && departmentList.Rows[n]["ID"].ToString() != "")
                    {
                        model.pId = "";
                        model.id = departmentList.Rows[n]["DepartmentID"].ToString();
                    }
                    if (departmentList.Rows[n]["Name"] != null && departmentList.Rows[n]["Name"].ToString() != "")
                    {
                        model.name = departmentList.Rows[n]["Name"].ToString();
                    }
                    model.isParent = true;
                    model.open = true;
                    model.@checked = false;
                    model.nocheck = true;
                    modelList.Add(model);
                }
            }
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Conris.DBA.Model.JsonModel model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Conris.DBA.Model.JsonModel();
                    if (dt.Rows[n]["ID"] != null && dt.Rows[n]["ID"].ToString() != "")
                    {
                        model.pId =  dt.Rows[n]["DepartmentID"].ToString().Substring(0,3);
                        model.id = dt.Rows[n]["ID"].ToString();
                    }
                    if (dt.Rows[n]["Name"] != null && dt.Rows[n]["Name"].ToString() != "")
                    {
                        model.name = dt.Rows[n]["Name"].ToString();
                    }
                   
                    model.isParent = false;
                    model.open = true;

                    model.@checked = false;

                    model.nocheck = isNoCheck;
                    modelList.Add(model);
                }
            }
            return modelList;
        }
        #endregion  ExtensionMethod
    }
}

