using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace DBA.DAL
{
	/// <summary>
	/// 数据访问类:Consult
	/// </summary>
	public partial class Consult
	{
		public Consult()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "Consult"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Consult");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(DBA.Model.Consult model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Consult(");
			strSql.Append("Title,ConContent,UserID,UserName,ReTime,CreateTime,State,Reply,ReName,Str1,Str2,Str3,Str4,Str5)");
			strSql.Append(" values (");
			strSql.Append("@Title,@ConContent,@UserID,@UserName,@ReTime,@CreateTime,@State,@Reply,@ReName,@Str1,@Str2,@Str3,@Str4,@Str5)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Title", SqlDbType.NVarChar,200),
					new SqlParameter("@ConContent", SqlDbType.Text),
					new SqlParameter("@UserID", SqlDbType.NVarChar,200),
					new SqlParameter("@UserName", SqlDbType.NVarChar,200),
					new SqlParameter("@ReTime", SqlDbType.DateTime),
					new SqlParameter("@CreateTime", SqlDbType.DateTime),
					new SqlParameter("@State", SqlDbType.NVarChar,200),
					new SqlParameter("@Reply", SqlDbType.Text),
					new SqlParameter("@ReName", SqlDbType.NVarChar,200),
					new SqlParameter("@Str1", SqlDbType.NVarChar,200),
					new SqlParameter("@Str2", SqlDbType.NVarChar,200),
					new SqlParameter("@Str3", SqlDbType.NVarChar,200),
					new SqlParameter("@Str4", SqlDbType.NVarChar,200),
					new SqlParameter("@Str5", SqlDbType.NVarChar,200)};
			parameters[0].Value = model.Title;
			parameters[1].Value = model.ConContent;
			parameters[2].Value = model.UserID;
			parameters[3].Value = model.UserName;
			parameters[4].Value = model.ReTime;
			parameters[5].Value = model.CreateTime;
			parameters[6].Value = model.State;
			parameters[7].Value = model.Reply;
			parameters[8].Value = model.ReName;
			parameters[9].Value = model.Str1;
			parameters[10].Value = model.Str2;
			parameters[11].Value = model.Str3;
			parameters[12].Value = model.Str4;
			parameters[13].Value = model.Str5;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
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
		public bool Update(DBA.Model.Consult model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Consult set ");
			strSql.Append("Title=@Title,");
			strSql.Append("ConContent=@ConContent,");
			strSql.Append("UserID=@UserID,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("ReTime=@ReTime,");
			strSql.Append("CreateTime=@CreateTime,");
			strSql.Append("State=@State,");
			strSql.Append("Reply=@Reply,");
			strSql.Append("ReName=@ReName,");
			strSql.Append("Str1=@Str1,");
			strSql.Append("Str2=@Str2,");
			strSql.Append("Str3=@Str3,");
			strSql.Append("Str4=@Str4,");
			strSql.Append("Str5=@Str5");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Title", SqlDbType.NVarChar,200),
					new SqlParameter("@ConContent", SqlDbType.Text),
					new SqlParameter("@UserID", SqlDbType.NVarChar,200),
					new SqlParameter("@UserName", SqlDbType.NVarChar,200),
					new SqlParameter("@ReTime", SqlDbType.DateTime),
					new SqlParameter("@CreateTime", SqlDbType.DateTime),
					new SqlParameter("@State", SqlDbType.NVarChar,200),
					new SqlParameter("@Reply", SqlDbType.Text),
					new SqlParameter("@ReName", SqlDbType.NVarChar,200),
					new SqlParameter("@Str1", SqlDbType.NVarChar,200),
					new SqlParameter("@Str2", SqlDbType.NVarChar,200),
					new SqlParameter("@Str3", SqlDbType.NVarChar,200),
					new SqlParameter("@Str4", SqlDbType.NVarChar,200),
					new SqlParameter("@Str5", SqlDbType.NVarChar,200),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Title;
			parameters[1].Value = model.ConContent;
			parameters[2].Value = model.UserID;
			parameters[3].Value = model.UserName;
			parameters[4].Value = model.ReTime;
			parameters[5].Value = model.CreateTime;
			parameters[6].Value = model.State;
			parameters[7].Value = model.Reply;
			parameters[8].Value = model.ReName;
			parameters[9].Value = model.Str1;
			parameters[10].Value = model.Str2;
			parameters[11].Value = model.Str3;
			parameters[12].Value = model.Str4;
			parameters[13].Value = model.Str5;
			parameters[14].Value = model.ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Consult ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Consult ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
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
		public DBA.Model.Consult GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Title,ConContent,UserID,UserName,ReTime,CreateTime,State,Reply,ReName,Str1,Str2,Str3,Str4,Str5 from Consult ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			DBA.Model.Consult model=new DBA.Model.Consult();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
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
		public DBA.Model.Consult DataRowToModel(DataRow row)
		{
			DBA.Model.Consult model=new DBA.Model.Consult();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["Title"]!=null)
				{
					model.Title=row["Title"].ToString();
				}
				if(row["ConContent"]!=null)
				{
					model.ConContent=row["ConContent"].ToString();
				}
				if(row["UserID"]!=null)
				{
					model.UserID=row["UserID"].ToString();
				}
				if(row["UserName"]!=null)
				{
					model.UserName=row["UserName"].ToString();
				}
				if(row["ReTime"]!=null && row["ReTime"].ToString()!="")
				{
					model.ReTime=DateTime.Parse(row["ReTime"].ToString());
				}
				if(row["CreateTime"]!=null && row["CreateTime"].ToString()!="")
				{
					model.CreateTime=DateTime.Parse(row["CreateTime"].ToString());
				}
				if(row["State"]!=null)
				{
					model.State=row["State"].ToString();
				}
				if(row["Reply"]!=null)
				{
					model.Reply=row["Reply"].ToString();
				}
				if(row["ReName"]!=null)
				{
					model.ReName=row["ReName"].ToString();
				}
				if(row["Str1"]!=null)
				{
					model.Str1=row["Str1"].ToString();
				}
				if(row["Str2"]!=null)
				{
					model.Str2=row["Str2"].ToString();
				}
				if(row["Str3"]!=null)
				{
					model.Str3=row["Str3"].ToString();
				}
				if(row["Str4"]!=null)
				{
					model.Str4=row["Str4"].ToString();
				}
				if(row["Str5"]!=null)
				{
					model.Str5=row["Str5"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,Title,ConContent,UserID,UserName,ReTime,CreateTime,State,Reply,ReName,Str1,Str2,Str3,Str4,Str5 ");
			strSql.Append(" FROM Consult ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" ID,Title,ConContent,UserID,UserName,ReTime,CreateTime,State,Reply,ReName,Str1,Str2,Str3,Str4,Str5 ");
			strSql.Append(" FROM Consult ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM Consult ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.ID desc");
			}
			strSql.Append(")AS Row, T.*  from Consult T ");
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
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "Consult";
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

