//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace qingjia_MVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_New_LeaveList
    {
        public string ID { get; set; }
        public string StudentID { get; set; }
        public string Reason { get; set; }
        public Nullable<System.DateTime> SubmitTime { get; set; }
        public string StateLeave { get; set; }
        public string StateBack { get; set; }
        public string RejectReason { get; set; }
        public string LeaveType { get; set; }
        public string LeaveTypeChildrenID { get; set; }
        public Nullable<System.DateTime> LeaveTime { get; set; }
        public Nullable<System.DateTime> BackTime { get; set; }
        public string LeaveWay { get; set; }
        public string BackWay { get; set; }
        public string Address { get; set; }
        public string Lesson { get; set; }
        public string Teacher { get; set; }
        public string AuditTeacher { get; set; }
        public string PrintTimes { get; set; }
        public string IntershipCompany { get; set; }
        public string IntershipAddress { get; set; }
        public string PrincipalName { get; set; }
        public string PrincipalTel { get; set; }
        public string Pic_One { get; set; }
        public string Pic_Two { get; set; }
        public string Pic_Three { get; set; }
        public Nullable<int> IsDelete { get; set; }
    }
}