using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conris.DBA.ViewModel
{
    class AdminUser
    {
    }


    public class JobNewsSearch
    {
        public string JobName { get; set; }
        public string Department { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public int Pageindex { get; set; }
    }
   
    public class JobSearch
    {
        public string JobName { get; set; }

        public int Pageindex { get; set; }
    }
    //1
    public class ConsultSearch
    {
        public string UserID { get; set; }
        public string Title { get; set; }
        public string State { get; set; }
        public int Pageindex { get; set; }
    }
    //2
    public class UsersSearch
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public int Pageindex { get; set; }
    }
    //3
    public class DepartmentSearch
    {
        public string ComName { get; set; }

        public int Pageindex { get; set; }
    }
    //4
    public class ApplySearch
    {
        public string Str2 { get; set; }
        public string Major { get; set; }
        public string Name { get; set; }
        public string QWGZ { get; set; }
        public string ZYJN { get; set; }
        public int Pageindex { get; set; }
    }
    //5
    public class TitleSearch
    {
        public string Name { get; set; }

        public int Pageindex { get; set; }
    }
    //6
    public class BookSearch
    {
        public string BookName { get; set; }
        public string BookCBS { get; set; }
        public string ISBN { get; set; }
        public string BookZZ { get; set; }
        public string CategoryID { get; set; }
        public int Pageindex { get; set; }
    }
    public class CarSearch
    {
        public string CarNum { get; set; }
        public string CategoryID { get; set; }
        public string ComID { get; set; }
        public int Pageindex { get; set; }
    }

    public class CKRecordSearch
    {
        public string BookName { get; set; }
        public string ISBN { get; set; }
        public string BookZZ { get; set; }
        public int Pageindex { get; set; }
    }
}
