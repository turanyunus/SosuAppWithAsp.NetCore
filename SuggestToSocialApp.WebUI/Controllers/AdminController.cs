using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SuggestToSocialApp.WebUI.Models;
using SuggestToSocialApp.WebUI.Repository.Abstract;
using SuggestToSocialApp.WebUI.Entity;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Identity;
using SuggestToSocialApp.WebUI.IdentityCore;

namespace SuggestToSocialApp.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private UserManager<ApplicationUser> userManager;
        private IUnitOfWork unitOfWork;

        public AdminController(IUnitOfWork _unitOfWork, UserManager<ApplicationUser> _userManager)
        {
            unitOfWork = _unitOfWork;
            userManager = _userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PostList()
        {
            var model = new PostListModel()
            {
                Post = unitOfWork.postRepository.GetAll().ToList()
            };
            return View(model);
        }
        public IActionResult CategorySubjectList()
        {
            var model = new PostListModel()
            {
                Post = unitOfWork.postRepository.GetAll().ToList(),
                Category = unitOfWork.categoryRepository.GetAll().ToList(),
                Subject = unitOfWork.subjectRepository.GetAll().ToList()
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddPost(Post entity, IFormFile formFile)
        {
            if (ModelState.IsValid)
            {
                if (formFile != null)
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\imgposts", formFile.FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await formFile.CopyToAsync(stream);
                        entity.Image = formFile.FileName;
                    }
                }

                entity.Date = DateTime.Now;

                unitOfWork.postRepository.Add(entity);
                unitOfWork.SaveChanges();
                return RedirectToAction("PostList");
            }
            return View(entity);
        }

        [HttpGet]
        public IActionResult AddPost()
        {
            return View();
        }

        public IActionResult UserList()
        {
            return View(userManager.Users);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string Id)
        {
            var user = await userManager.FindByIdAsync(Id);
            if (user != null)
            {
                var result = await userManager.DeleteAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("UserList");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            else
            {
                ModelState.AddModelError("", "Kullanıcı Bulunamadı");
            }
            return View("UserList", userManager.Users);
        }
    }
}