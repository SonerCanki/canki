﻿using AutoMapper;
using Canki.Web.UI.APIs;
using Canki.Web.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Canki.Web.UI.Contollers
{
    public class HomeController : Controller
    {
        private readonly ICategoryApi _categoryApi;
        private readonly IMapper _mapper;
        public HomeController(ICategoryApi categoryApi, IMapper mapper)
        {
            _categoryApi = categoryApi;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            List<CategoryListViewModel> categoryList = new List<CategoryListViewModel>();
            var listResult = await _categoryApi.List();
            if (listResult.IsSuccessStatusCode && listResult.Content.IsSuccess && listResult.Content.ResultData.Any())
                categoryList = _mapper.Map<List<CategoryListViewModel>>(listResult.Content.ResultData);

            //TempData["ProductCount"] =;

            return View(categoryList);
        }
    }
}