using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Scorecard.Core;
using Golf.Data;

namespace firstApp.Pages.HolePage
{
    public class HolePageModel : PageModel
    {

        private readonly IGolfData golfData;

        public HolePageModel(IGolfData golfData){
            this.golfData = golfData;
        }

        public GolfHole Hole { get; set; }

        public int PlayerScore {get; set;}

        public IActionResult OnGet(string ViewPlayerScore, int holeNum)
        {

            Hole = golfData.GetHoleByNum(holeNum);
            System.Console.WriteLine("HOle is:");
            System.Console.WriteLine(Hole);
            if(Hole == null){
                System.Console.WriteLine("In the thingy!");
                return RedirectToPage("/Scorecard/Scorecard");
            }
            // Hole = new GolfHole();
            Hole.HoleNum = holeNum;
            if(!string.IsNullOrEmpty(ViewPlayerScore)){
                PlayerScore = Int32.Parse(ViewPlayerScore);
            }
            return Page();
            // string test = "no";
        }
    }
}