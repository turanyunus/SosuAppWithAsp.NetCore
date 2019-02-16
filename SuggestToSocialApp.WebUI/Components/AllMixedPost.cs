using Microsoft.AspNetCore.Mvc;
using SuggestToSocialApp.WebUI.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuggestToSocialApp.WebUI.Components
{
    public class AllMixedPost:ViewComponent
    {
        private IPostRepository postRepository;
        public AllMixedPost(IPostRepository _postRepository)
        {
            postRepository = _postRepository;
        }
        public IViewComponentResult Invoke()
        {
            var list = postRepository.GetAll().Take(8);
            return View(list);
        }
    }
}
