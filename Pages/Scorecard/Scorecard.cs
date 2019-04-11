using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Scorecard.Core;
using Golf.Data;

namespace firstApp.Pages.Scorecard
{
    public class ScorecardModel : PageModel
    {

        private readonly IConfiguration config;
        private readonly IGolfData golfData;

        public ScorecardModel(IConfiguration config, IGolfData golfData){
            this.config = config;
            this.golfData = golfData;
        }
        public string hello = "Hello There";
        // [BindProperty]
        public string UserSearchTerm{get; set;}

        public IEnumerable<GolfHole> Holes {get; set;}
        public void OnGet(string searchTerm)
        {
            UserSearchTerm = searchTerm;
            // HttpContext.Request.QueryString
            // PageModel.hello = "Hello There";
            Console.Write("This is where the fun begins!");
            // Console.BackgroundColor = "red";
            if(!string.IsNullOrEmpty(searchTerm)){
                Holes = golfData.GetHolesByName(Int32.Parse(searchTerm));
            }
            else{
                Holes = golfData.GetAll();
            }
        }
    }
}