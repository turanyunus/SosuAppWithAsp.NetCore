using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuggestToSocialApp.WebUI.Entity
{
    public class Comment
    {
        public int Id { get; set; }
        public string CommentDesc { get; set; }
        public DateTime Date { get; set; }

        public int PostId { get; set; }
        public int UserId { get; set; }
        public int CategoryToPost { get; set; }
        public int SubjectId { get; set; }

    }
}
