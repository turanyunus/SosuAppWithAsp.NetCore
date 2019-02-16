using Microsoft.AspNetCore.Mvc;
using SuggestToSocialApp.WebUI.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuggestToSocialApp.WebUI.Components
{
    public class Categories: ViewComponent
    {
        private ICategoryRepository categoryRepository;
        public Categories(ICategoryRepository _categoryRepository)
        {
            categoryRepository = _categoryRepository;
        }
        public IViewComponentResult Invoke()
        {
            var list = categoryRepository.GetAll();
            return View(list);
        }
    }
}
