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
    using System.ComponentModel.DataAnnotations;

    public partial class Tip
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tip()
        {
            this.Feedback_Tips = new HashSet<Feedback_Tips>();
        }
    
        public int Tips_Id { get; set; }
        [Display(Name = "Tips")]
        public string Tips_Name { get; set; }
        [Display(Name = "Direction")]
        public string Description { get; set; }
        [Display(Name = "User Role")]
        public string Label { get; set; }
        [Display(Name = "Posted By")]
        public string Posted_by { get; set; }
    
        public virtual AspNetRole AspNetRole { get; set; }
        public virtual AspNetUser AspNetUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Feedback_Tips> Feedback_Tips { get; set; }
    }
}
