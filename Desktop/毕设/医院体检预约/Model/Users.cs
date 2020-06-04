using System;
namespace DBA.Model
{
	/// <summary>
	/// Users:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Users
	{
		public Users()
		{}
		#region Model
		private int _id;
		private string _username;
		private string _userpsd;
		private string _usertype;
		private string _depname;
		private string _age;
		private string _major;
		private string _bysj;
		private string _sex;
		private string _userjg;
		private string _usersfz;
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
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserPSD
		{
			set{ _userpsd=value;}
			get{return _userpsd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserType
		{
			set{ _usertype=value;}
			get{return _usertype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DepName
		{
			set{ _depname=value;}
			get{return _depname;}
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
		public string Major
		{
			set{ _major=value;}
			get{return _major;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BYSJ
		{
			set{ _bysj=value;}
			get{return _bysj;}
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
		public string UserJG
		{
			set{ _userjg=value;}
			get{return _userjg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserSFZ
		{
			set{ _usersfz=value;}
			get{return _usersfz;}
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

