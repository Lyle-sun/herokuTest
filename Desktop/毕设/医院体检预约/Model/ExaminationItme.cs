using System;
namespace DBA.Model
{
    /// <summary>
    /// ExaminationItme:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ExaminationItme
    {
        public ExaminationItme()
        { }
        #region Model
        private int _id;
        private string _name;
        private string _normalvalue;
        private string _departmentid;
        private string _price;
        private string _str1;
        private string _str2;
        private string _str3;
        private string _str4;
        private string _str5;
        private string _str6;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string NormalValue
        {
            set { _normalvalue = value; }
            get { return _normalvalue; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DepartmentID
        {
            set { _departmentid = value; }
            get { return _departmentid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Price
        {
            set { _price = value; }
            get { return _price; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Str1
        {
            set { _str1 = value; }
            get { return _str1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Str2
        {
            set { _str2 = value; }
            get { return _str2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Str3
        {
            set { _str3 = value; }
            get { return _str3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Str4
        {
            set { _str4 = value; }
            get { return _str4; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Str5
        {
            set { _str5 = value; }
            get { return _str5; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Str6
        {
            set { _str6 = value; }
            get { return _str6; }
        }
        #endregion Model

    }
}

