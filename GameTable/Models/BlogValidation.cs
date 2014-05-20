using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GameTable.Models
{
    [MetadataType(typeof(AuthorMetadata))]
    public partial class Author
    {
    }

    public class AuthorMetadata
    {
        [Display(Name = "Profile Picture")
        , MaxLength(200, ErrorMessage = "Don't pull it straight from google!")]
        public string personalPic;
        
        [Required(ErrorMessage = "You must have a name.")
        , Display(Name = "Name")]
        public string Name;
    }

    [MetadataType(typeof(CategoryMetadata))]
    public partial class Category
    {
    }

    public class CategoryMetadata
    {
        [Required(ErrorMessage = "No blank categories, please.")
        , Display(Name = "Category")]
        public string Category1;

        [Required(ErrorMessage = "You have to have a when, buddy.")
        , Display(Name = "Created On")]
        public DateTime dateCreated;

        [Required(ErrorMessage = "Every category has a creator.")
        , Display(Name = "Created By")]
        public string categoryStarter;
    }

    [MetadataType(typeof(PostMetadata))]
    public partial class Post
    {
    }

    public class PostMetadata
    {
        [Display(Name = "Photo")
        , MaxLength(200, ErrorMessage = "Download the picture or view it by itself. Avoid pulling from google.")]
        public string Thumbnail;

        [Required(ErrorMessage = "The when is needed, friend.")
        , Display(Name = "Posted On")]
        public DateTime postedOn;

        [Required(ErrorMessage = "This post must have a category.")
        , Display(Name = "Category")]
        public string CategoryID;

        [Required(ErrorMessage = "Writer's name is necessary.")
        , Display(Name = "Author")]
        public string AuthorID;

        [Required(ErrorMessage = "Gotta have something to say!")
        , Display(Name = "Content")]
        public string Body;

        [Display(Name = "Keywords")]
        public string wordKeys;
    }
}