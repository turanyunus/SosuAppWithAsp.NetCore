using Microsoft.AspNetCore.Mvc;
using SuggestToSocialApp.WebUI.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuggestToSocialApp.WebUI.Components
{
    public class MostReadPost:ViewComponent
    {
        private IPostRepository postRepository;
        public MostReadPost(IPostRepository _postRepository)
        {
            postRepository = _postRepository;
        }
        public IViewComponentResult Invoke()
        {
            return View(postRepository.GetAll().OrderByDescending(i => i.Date).Take(4));
        }
    }
}
