using System;
namespace DBA.Model
{
	/// <summary>
	/// Consult:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Consult
	{
		public Consult()
		{}
		#region Model
		private int _id;
		private string _title;
		private string _concontent;
		private string _userid;
		private string _username;
		private DateTime? _retime;
		private DateTime? _createtime;
		private string _state;
		private string _reply;
		private string _rename;
		private string _str1;
		private string _str2;
		private string _str3;
		private string _str4;
		private string _str5;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ConContent
		{
			set{ _concontent=value;}
			get{return _concontent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? ReTime
		{
			set{ _retime=value;}
			get{return _retime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string State
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Reply
		{
			set{ _reply=value;}
			get{return _reply;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReName
		{
			set{ _rename=value;}
			get{return _rename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Str1
		{
			set{ _str1=value;}
			get{return _str1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Str2
		{
			set{ _str2=value;}
			get{return _str2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Str3
		{
			set{ _str3=value;}
			get{return _str3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Str4
		{
			set{ _str4=value;}
			get{return _str4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Str5
		{
			set{ _str5=value;}
			get{return _str5;}
		}
		#endregion Model

	}
}

