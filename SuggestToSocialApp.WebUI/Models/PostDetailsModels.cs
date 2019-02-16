using SuggestToSocialApp.WebUI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuggestToSocialApp.WebUI.Models
{
    public class PostDetailsModels
    {
        public Post Post { get; set; }
        public List<Image> PostImage { get; set; }
        public Category Category { get; set; }
    }
}
