//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Penthouse.Dbs
{
    using System;
    using System.Collections.Generic;
    
    public partial class P_bannner_homepage
    {
        public int id { get; set; }
        public string projectname { get; set; }
        public string province { get; set; }
        public string link { get; set; }
        public Nullable<int> C_index { get; set; }
        public Nullable<System.DateTime> createdate { get; set; }
        public string createby { get; set; }
        public Nullable<System.DateTime> updatedate { get; set; }
        public string updateby { get; set; }
        public Nullable<int> status { get; set; }
        public string image_url { get; set; }
    }
}