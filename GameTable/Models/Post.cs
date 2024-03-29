//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GameTable.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Post
    {
        public Post()
        {
            this.Comments = new HashSet<Comment>();
        }
    
        public int PostID { get; set; }
        public string Thumbnail { get; set; }
        public System.DateTime postedOn { get; set; }
        public int CategoryID { get; set; }
        public int AuthorID { get; set; }
        public string Body { get; set; }
        public int Approval { get; set; }
        public int timesViewed { get; set; }
        public string wordKeys { get; set; }
    
        public virtual Author Author { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
