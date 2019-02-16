using Microsoft.AspNetCore.Mvc;
using SuggestToSocialApp.WebUI.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuggestToSocialApp.WebUI.Components
{
    public class FeaturedPost:ViewComponent
    {
        private IPostRepository postRepository;
        public FeaturedPost(IPostRepository _postRepository)
        {
            postRepository = _postRepository;
        }
        public IViewComponentResult Invoke()
        {
            var list = postRepository.GetAll().OrderByDescending(i => i.Like).Take(3);
            return View(list);
        }
    }
}
