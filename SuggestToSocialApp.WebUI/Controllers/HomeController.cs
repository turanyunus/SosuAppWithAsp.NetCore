using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SuggestToSocialApp.WebUI.Entity;
using SuggestToSocialApp.WebUI.Models;
using SuggestToSocialApp.WebUI.Repository.Abstract;

namespace SuggestToSocialApp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IPostRepository postRepository;
        public HomeController(IPostRepository _postRepository)
        {
            postRepository = _postRepository;
        }
        public IActionResult Index()
        {
            var results = postRepository
                .GetAll()
                .Include(i => i.Category)
                .Include(i => i.Images)
                .Select(i => new HomeModels()
                {
                    Post = i,
                    Category = i.Category,
                    PostImage = i.Images
                }).OrderByDescending(i => i.Post.Date).Take(6).ToList();
            return View(results);
        }

    }
}