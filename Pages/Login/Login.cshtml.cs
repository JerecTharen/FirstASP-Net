using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace firstApp.Pages.Login
{
    public class LoginModel : PageModel
    {
        public void OnGet()
        {
            System.Console.WriteLine("Let's try spinning. That's a good trick");
        }
    }
}