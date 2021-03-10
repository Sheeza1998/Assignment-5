using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment_5.Infrastructure;
using Assignment_5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Assignment_5.Pages
{
    public class DonateModel : PageModel
    {
            private BookstoreRepository repository;

        //Constructor
            public DonateModel (BookstoreRepository repo, Cart cart )
        {
            repository = repo;
            Cart = cart;
        }

        //Properties
        public Cart Cart { get; set; }

        public string ReturnUrl { get; set; }

        //Methods
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            //Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        }

        public IActionResult OnPost(long Bookid, string returnUrl)
        {
            Project project = repository.Pros.FirstOrDefault(p => p.Bookid == Bookid);

            //Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();

            Cart.AddItem(project, 1);
            //HttpContext.Session.SetJson("cart", Cart);

            return RedirectToPage(new { returnUrl = returnUrl });
        }



        public IActionResult OnPostRemove(long Bookid, string returnUrl)
        {
            //Project project = repository.Projects.FirstOrDefault(p => p.BookId == BookId);
            Cart.RemoveLine(Cart.Lines.First(cl =>
            cl.Project.Bookid == Bookid).Project);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
