using System;
namespace DBA.Model
{
	/// <summary>
	/// Department:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Department
	{
		public Department()
		{}
		#region Model
		private int _id;
		private string _Departmentname;
		private string _str1;
		private string _str2;
		private string _str3;
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
		public string DepartmentName
		{
			set{ _Departmentname=value;}
			get{return _Departmentname;}
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
		#endregion Model

	}
}

