using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuggestToSocialApp.WebUI.Entity;

namespace SuggestToSocialApp.WebUI.Models
{
    public class PostListModel
    {
        public List<Post> Post { get; set; }
        public List<Category> Category { get; set; }
        public List<Subject> Subject { get; set; }
    }
}
