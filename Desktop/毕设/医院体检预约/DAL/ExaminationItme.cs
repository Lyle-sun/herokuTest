using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace DBA.DAL
{
    /// <summary>
    /// 数据访问类:ExaminationItme
    /// </summary>
    public partial class ExaminationItme
    {
        public ExaminationItme()
        { }
        #region  BasicMethod


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(DBA.Model.ExaminationItme model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ExaminationItme(");
            strSql.Append("Name,NormalValue,DepartmentID,Price,Str1,Str2,Str3,Str4,Str5,Str6)");
            strSql.Append(" values (");
            strSql.Append("SQL2012Name,SQL2012NormalValue,SQL2012DepartmentID,SQL2012Price,SQL2012Str1,SQL2012Str2,SQL2012Str3,SQL2012Str4,SQL2012Str5,SQL2012Str6)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("SQL2012Name", SqlDbType.NVarChar,200),
					new SqlParameter("SQL2012NormalValue", SqlDbType.NVarChar,200),
					new SqlParameter("SQL2012DepartmentID", SqlDbType.NVarChar,200),
					new SqlParameter("SQL2012Price", SqlDbType.NVarChar,200),
					new SqlParameter("SQL2012Str1", SqlDbType.NVarChar,200),
					new SqlParameter("SQL2012Str2", SqlDbType.NVarChar,200),
					new SqlParameter("SQL2012Str3", SqlDbType.NVarChar,200),
					new SqlParameter("SQL2012Str4", SqlDbType.NVarChar,200),
					new SqlParameter("SQL2012Str5", SqlDbType.NVarChar,200),
					new SqlParameter("SQL2012Str6", SqlDbType.NVarChar,200)};
            parameters[0].Value = model.Name;
            parameters[1].Value = model.NormalValue;
            parameters[2].Value = model.DepartmentID;
            parameters[3].Value = model.Price;
            parameters[4].Value = model.Str1;
            parameters[5].Value = model.Str2;
            parameters[6].Value = model.Str3;
            parameters[7].Value = model.Str4;
            parameters[8].Value = model.Str5;
            parameters[9].Value = model.Str6;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(DBA.Model.ExaminationItme model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ExaminationItme set ");
            strSql.Append("Name=SQL2012Name,");
            strSql.Append("NormalValue=SQL2012NormalValue,");
            strSql.Append("DepartmentID=SQL2012DepartmentID,");
            strSql.Append("Price=SQL2012Price,");
            strSql.Append("Str1=SQL2012Str1,");
            strSql.Append("Str2=SQL2012Str2,");
            strSql.Append("Str3=SQL2012Str3,");
            strSql.Append("Str4=SQL2012Str4,");
            strSql.Append("Str5=SQL2012Str5,");
            strSql.Append("Str6=SQL2012Str6");
            strSql.Append(" where ID=SQL2012ID");
            SqlParameter[] parameters = {
					new SqlParameter("SQL2012Name", SqlDbType.NVarChar,200),
					new SqlParameter("SQL2012NormalValue", SqlDbType.NVarChar,200),
					new SqlParameter("SQL2012DepartmentID", SqlDbType.NVarChar,200),
					new SqlParameter("SQL2012Price", SqlDbType.NVarChar,200),
					new SqlParameter("SQL2012Str1", SqlDbType.NVarChar,200),
					new SqlParameter("SQL2012Str2", SqlDbType.NVarChar,200),
					new SqlParameter("SQL2012Str3", SqlDbType.NVarChar,200),
					new SqlParameter("SQL2012Str4", SqlDbType.NVarChar,200),
					new SqlParameter("SQL2012Str5", SqlDbType.NVarChar,200),
					new SqlParameter("SQL2012Str6", SqlDbType.NVarChar,200),
					new SqlParameter("SQL2012ID", SqlDbType.Int,4)};
            parameters[0].Value = model.Name;
            parameters[1].Value = model.NormalValue;
            parameters[2].Value = model.DepartmentID;
            parameters[3].Value = model.Price;
            parameters[4].Value = model.Str1;
            parameters[5].Value = model.Str2;
            parameters[6].Value = model.Str3;
            parameters[7].Value = model.Str4;
            parameters[8].Value = model.Str5;
            parameters[9].Value = model.Str6;
            parameters[10].Value = model.ID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ExaminationItme ");
            strSql.Append(" where ID=SQL2012ID");
            SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ExaminationItme ");
            strSql.Append(" where ID in (" + IDlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public DBA.Model.ExaminationItme GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Name,NormalValue,DepartmentID,Price,Str1,Str2,Str3,Str4,Str5,Str6 from ExaminationItme ");
            strSql.Append(" where ID=SQL2012ID");
            SqlParameter[] parameters = {
					new SqlParameter("SQL2012ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            DBA.Model.ExaminationItme model = new DBA.Model.ExaminationItme();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public DBA.Model.ExaminationItme DataRowToModel(DataRow row)
        {
            DBA.Model.ExaminationItme model = new DBA.Model.ExaminationItme();
            if (row != null)
            {
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }
                if (row["Name"] != null)
                {
                    model.Name = row["Name"].ToString();
                }
                if (row["NormalValue"] != null)
                {
                    model.NormalValue = row["NormalValue"].ToString();
                }
                if (row["DepartmentID"] != null)
                {
                    model.DepartmentID = row["DepartmentID"].ToString();
                }
                if (row["Price"] != null)
                {
                    model.Price = row["Price"].ToString();
                }
                if (row["Str1"] != null)
                {
                    model.Str1 = row["Str1"].ToString();
                }
                if (row["Str2"] != null)
                {
                    model.Str2 = row["Str2"].ToString();
                }
                if (row["Str3"] != null)
                {
                    model.Str3 = row["Str3"].ToString();
                }
                if (row["Str4"] != null)
                {
                    model.Str4 = row["Str4"].ToString();
                }
                if (row["Str5"] != null)
                {
                    model.Str5 = row["Str5"].ToString();
                }
                if (row["Str6"] != null)
                {
                    model.Str6 = row["Str6"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,Name,NormalValue,DepartmentID,Price,Str1,Str2,Str3,Str4,Str5,Str6 ");
            strSql.Append(" FROM ExaminationItme ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" ID,Name,NormalValue,DepartmentID,Price,Str1,Str2,Str3,Str4,Str5,Str6 ");
            strSql.Append(" FROM ExaminationItme ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM ExaminationItme ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.ID desc");
            }
            strSql.Append(")AS Row, T.*  from ExaminationItme T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        {
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012tblName", SqlDbType.VarChar, 255),
                    new SqlParameter("SQL2012fldName", SqlDbType.VarChar, 255),
                    new SqlParameter("SQL2012PageSize", SqlDbType.Int),
                    new SqlParameter("SQL2012PageIndex", SqlDbType.Int),
                    new SqlParameter("SQL2012IsReCount", SqlDbType.Bit),
                    new SqlParameter("SQL2012OrderType", SqlDbType.Bit),
                    new SqlParameter("SQL2012strWhere", SqlDbType.VarChar,1000),
                    };
            parameters[0].Value = "ExaminationItme";
            parameters[1].Value = "ID";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

