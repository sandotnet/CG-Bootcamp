using System;
using System.Collections.Generic;

#nullable disable

namespace HandsOnEFDbFirst.Entities
{
    public partial class EmployeeDetail
    {
        public int? EmpId { get; set; }
        public string EmpName { get; set; }
        public string DeptCode { get; set; }

        public virtual Department DeptCodeNavigation { get; set; }
    }
}
