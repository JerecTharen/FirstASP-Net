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

        public static string helloThere = "Hello There";
        public void OnGet()
        {
            
        }
    }
}
