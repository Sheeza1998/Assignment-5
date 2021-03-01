﻿using Assignment_5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Assignment_5.Models.ViewModels;

namespace Assignment_5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private BookstoreRepository _repository;

        //crating a variable to create 5 items per page

        public int ItemsPerPage = 5;

        public HomeController(ILogger<HomeController> logger, BookstoreRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        //default page
        public IActionResult Index(string Category, int Page = 1)
        {
            return View(new ProjectListViewModel
            {
                Projects = _repository.Pros
                .Where(p => Category == null || p.Category == Category)
                .OrderBy(p => p.Bookid)
                .Skip((Page - 1) * ItemsPerPage)
                .Take(ItemsPerPage)
                ,
                PagingInfo = new PagingInfo
                {
                    CurrentPage = Page,
                    ItemsPerPage = ItemsPerPage,
                    TotalNumItems = Category == null? _repository.Pros.Count():
                    _repository.Pros.Where(x => x.Category == Category).Count()
                },
                CurrentCategory = Category
            }); ;

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
