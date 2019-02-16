using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SuggestToSocialApp.WebUI.Models;
using SuggestToSocialApp.WebUI.Repository.Abstract;

namespace SuggestToSocialApp.WebUI.Controllers
{
    public class PostController : Controller
    {
        private IPostRepository postRepository;
        public int PageSize = 2;

        public PostController(IPostRepository _postRepository)
        {
            postRepository = _postRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            return View(postRepository
                .GetAll()
                .Where(i => i.Id == id)
                .Include(i => i.Images)
                .Include(i => i.Category)
                .Select(i => new PostDetailsModels()
                {
                    Post = i,
                    PostImage = i.Images,
                    Category = i.Category
                }).FirstOrDefault());
        }

        public IActionResult Books()
        {
            var results = postRepository
              .GetAll()
              .Where(i => i.CategoryId == 1)
              .Include(i => i.Category)
              .Include(i => i.Images)
              .Select(i => new PostCategoriesModel()
              {
                  PostCategories = i,
                  Category = i.Category,
                  PostImage = i.Images
              }).OrderByDescending(i => i.PostCategories.Like).ToList();
            return View(results);
        }

        public IActionResult Flim()
        {
            var results = postRepository
              .GetAll()
              .Where(i => i.CategoryId == 2)
              .Include(i => i.Category)
              .Include(i => i.Images)
              .Select(i => new PostCategoriesModel()
              {
                  PostCategories = i,
                  Category = i.Category,
                  PostImage = i.Images
              }).OrderByDescending(i => i.PostCategories.Like).ToList();
            return View(results);
        }

        public IActionResult TvSeries()
        {
            var results = postRepository
              .GetAll()
              .Where(i => i.CategoryId == 3)
              .Include(i => i.Category)
              .Include(i => i.Images)
              .Select(i => new PostCategoriesModel()
              {
                  PostCategories = i,
                  Category = i.Category,
                  PostImage = i.Images
              }).OrderByDescending(i => i.PostCategories.Like).ToList();
            return View(results);
        }

        public IActionResult Populer()
        {
            var results = postRepository
              .GetAll()
              .Include(i => i.Category)
              .Include(i => i.Images)
              .Select(i => new PostCategoriesModel()
              {
                  PostCategories = i,
                  Category = i.Category,
                  PostImage = i.Images
              }).OrderByDescending(i => i.PostCategories.Like).ToList();
            return View(results);
        }
    }
}