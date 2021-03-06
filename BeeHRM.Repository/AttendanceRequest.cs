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
    
    public partial class AttendanceRequest
    {
        public int RequestId { get; set; }
        public int RequestEmpCode { get; set; }
        public Nullable<System.DateTime> CheckInDate { get; set; }
        public Nullable<System.DateTime> CheckOutDate { get; set; }
        public Nullable<System.DateTime> RequestedDate { get; set; }
        public Nullable<int> ApproverEmpCode { get; set; }
        public Nullable<int> RecommendarEmpCode { get; set; }
        public byte ApproveStatus { get; set; }
        public Nullable<System.DateTime> ApproveStatusDate { get; set; }
        public byte RecommendStatus { get; set; }
        public Nullable<System.DateTime> RecommendStatusDate { get; set; }
        public string RequestDescription { get; set; }
        public string RequestType { get; set; }
        public string ApproverMessage { get; set; }
        public string RecommedarMessage { get; set; }
        public string RequestIPAddress { get; set; }
        public Nullable<System.DateTime> RequestCreatedDate { get; set; }
    }
}
