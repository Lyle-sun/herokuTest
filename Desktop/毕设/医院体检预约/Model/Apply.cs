using System;
namespace DBA.Model
{
	/// <summary>
	/// Apply:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Apply
	{
		public Apply()
		{}
		#region Model
		private int _id;
		private string _name;
		private string _age;
		private string _sex;
		private string _major;
		private string _cshy;
		private string _jzd;
		private string _qwgz;
		private string _zyjn;
		private string _detail;
		private DateTime? _createtime;
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
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Age
		{
			set{ _age=value;}
			get{return _age;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Sex
		{
			set{ _sex=value;}
			get{return _sex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Major
		{
			set{ _major=value;}
			get{return _major;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CSHY
		{
			set{ _cshy=value;}
			get{return _cshy;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JZD
		{
			set{ _jzd=value;}
			get{return _jzd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QWGZ
		{
			set{ _qwgz=value;}
			get{return _qwgz;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZYJN
		{
			set{ _zyjn=value;}
			get{return _zyjn;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Detail
		{
			set{ _detail=value;}
			get{return _detail;}
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

