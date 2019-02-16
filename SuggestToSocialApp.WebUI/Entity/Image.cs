using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuggestToSocialApp.WebUI.Entity
{
    public class Image
    {
        public int Id { get; set; }
        public string ImageName { get; set; }
        public int ProductId { get; set; }
    }
}
