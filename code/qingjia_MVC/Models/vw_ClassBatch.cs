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
    
    public partial class vw_ClassBatch
    {
        public string ID { get; set; }
        public string ClassName { get; set; }
        public string Grade { get; set; }
        public Nullable<int> Batch { get; set; }
        public Nullable<System.DateTime> Datetime { get; set; }
        public string TeacherID { get; set; }
        public string Location { get; set; }
        public string AutoUpdateTime { get; set; }
        public Nullable<int> AutoUpdateTimeSpan { get; set; }
        public string TeacherName { get; set; }
        public string TeacherTel { get; set; }
        public string TeacherEmail { get; set; }
        public Nullable<System.DateTime> DeadLine { get; set; }
    }
}
