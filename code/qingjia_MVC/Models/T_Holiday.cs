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
    
    public partial class T_Holiday
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public string AutoAudit { get; set; }
        public string TeacherID { get; set; }
        public Nullable<System.DateTime> SubmitTime { get; set; }
        public Nullable<int> IsDelete { get; set; }
    }
}
