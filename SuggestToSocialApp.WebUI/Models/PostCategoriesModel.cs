using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuggestToSocialApp.WebUI.Entity;

namespace SuggestToSocialApp.WebUI.Models
{
    public class PostCategoriesModel
    {
        public Post PostCategories { get; set; }
        public List<Image> PostImage { get; set; }
        public Category Category { get; set; }
    }
}
