//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BeeHRM.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class LeaveMonthlyAssgnement
    {
        public int AssignId { get; set; }
        public int AssignMonth { get; set; }
        public int AssignLeaveYearId { get; set; }
        public int AssignedByEmpCode { get; set; }
        public Nullable<System.DateTime> AssignedDate { get; set; }
        public Nullable<bool> AssignStatus { get; set; }
    }
}
