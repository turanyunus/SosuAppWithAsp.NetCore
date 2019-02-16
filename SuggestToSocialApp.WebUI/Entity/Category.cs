using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuggestToSocialApp.WebUI.Entity
{
    public class Category
    {
        public int Id { get; set; } // 1 - Book / 2- Film / 3- TvSeries
        public string Name { get; set; }

        public List<Post> Posts { get; set; }
    }
}
