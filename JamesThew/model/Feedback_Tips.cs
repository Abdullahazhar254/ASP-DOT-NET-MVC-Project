//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Feedback_Tips
    {
        public int Id { get; set; }
        public int Tip_ID { get; set; }
        public string User_Id { get; set; }
        public string Feedback { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual Tip Tip { get; set; }
    }
}
