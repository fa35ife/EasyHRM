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
    
    public partial class sp_AttendanceTotalDaysReportsSummary_Result
    {
        public int AttEmpCode { get; set; }
        public string EmployeeName { get; set; }
        public string DesignationName { get; set; }
        public int present { get; set; }
        public int weekend { get; set; }
        public int leave { get; set; }
        public int holiday { get; set; }
        public Nullable<int> LateEntry { get; set; }
        public Nullable<int> EarlyExit { get; set; }
    }
}