//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace webapi2
{
    using System;
    using System.Collections.Generic;
    
    public partial class mailQueue
    {
        public int id { get; set; }
        public string content { get; set; }
        public string toUser { get; set; }
        public Nullable<byte> stat { get; set; }
    }
}
