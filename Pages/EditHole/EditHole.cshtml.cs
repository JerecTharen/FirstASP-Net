using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Golf.Data;
using Scorecard.Core;

namespace firstApp.Pages.EditHole
{
    public class EditHoleModel : PageModel
    {
        public readonly IGolfData golfData;
        public GolfHole Hole {get; set;}

        public IEnumerable<SelectListItem> Tees { get; set; }
        public IHtmlHelper htmlHelper {get; set;}

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
    }
}