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
    
    public partial class sp_GetChildMenuList_Result
    {
        public int ModuleId { get; set; }
        public int ModuleParentId { get; set; }
        public string MOduleName { get; set; }
        public string ModuleCssClass { get; set; }
        public string MduleLink { get; set; }
        public Nullable<int> Order { get; set; }
        public string Controller { get; set; }
        public bool IsDefault { get; set; }
        public Nullable<bool> ModuleStatus { get; set; }
    }
}