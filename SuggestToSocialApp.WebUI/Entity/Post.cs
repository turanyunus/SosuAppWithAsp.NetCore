using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuggestToSocialApp.WebUI.Entity
{
    public class Post
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }

        public bool Status { get; set; }
        [Required]
        public string Author { get; set; }
        public DateTime Date { get; set; }
        public int Like { get; set; }
        public string Image { get; set; }
        public int DisLike { get; set; }
        public int View { get; set; }
        public bool IsApproved { get; set; }
        public string Tag { get; set; }
        public string Language { get; set; }

        public int ImageId { get; set; }
        public int SubjectId { get; set; }
        public int CategoryId { get; set; }

        public List<Image> Images { get; set; }
        public Category Category { get; set; }
        public Subject Subject { get; set; }
    }
}
