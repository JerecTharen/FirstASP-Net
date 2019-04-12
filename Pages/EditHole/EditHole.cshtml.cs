using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Golf.Data;
using Scorecard.Core;
// using Scorecard.Core.GolfHole.TeeType;

namespace firstApp.Pages.EditHole
{
    public class EditHoleModel : PageModel
    {
        public readonly IGolfData golfData;
         public IHtmlHelper htmlHelper {get; set;}

        [BindProperty]
        public GolfHole Hole {get; set;}
        public IEnumerable<SelectListItem> Tees { get; set; }
        
        public EditHoleModel(IGolfData golfData, IHtmlHelper htmlHelper)
        {
            this.golfData = golfData;
            this.htmlHelper = htmlHelper;
        }

        public IActionResult OnGet(int holeNum)
        {

            Tees = htmlHelper.GetEnumSelectList<GolfHole.TeeType>();
            System.Console.WriteLine(Tees);
            System.Console.WriteLine(GolfHole.TeeType.Champion);

            Hole = golfData.GetHoleByNum(holeNum);
            System.Console.WriteLine(Hole.Tee);
            if(Hole == null){
                return RedirectToPage("/Scorecard/Scorecard");
            }

            return Page();
        }

        public IActionResult OnPost(){
            System.Console.WriteLine("Hello Once More");
            System.Console.WriteLine("Here is Model State");
            System.Console.WriteLine(ModelState["PlayerScore"].AttemptedValue);
            System.Console.WriteLine("After model state");
            System.Console.WriteLine(Hole.HoleNum);
            // if(Hole == null){
            //     Hole = new GolfHole();
            // }
            Hole = golfData.UpdateHole(Hole);
            golfData.Commit();
            return Page();
        }
    }
}