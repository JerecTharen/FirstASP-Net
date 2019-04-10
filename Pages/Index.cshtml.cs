using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace firstApp.Pages
{
    public class IndexModel : PageModel
    {
        public string hello = "Hello There";
        public void OnGet()
        {
            // PageModel.hello = "Hello There";
            Console.Write("This is where the fun begins!");
            // Console.BackgroundColor = "red";
        }
    }
}
