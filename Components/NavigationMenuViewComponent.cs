using Assignment_5.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_5.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private BookstoreRepository repository;

        public NavigationMenuViewComponent (BookstoreRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectCategory = RouteData?.Values["category"];
            return View(repository.Pros
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
