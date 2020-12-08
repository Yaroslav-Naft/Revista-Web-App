using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace net_project_Revista.Pages
{
    public class moviedetailsModel : PageModel
    {
        public void OnGet()
        {
        }

        //Need to add Movies testMovie inside Onpost
        public IActionResult OnPost()
        {
            //Add If statement to redirect to home page
            //if item id is null

            //Otherwise if there is an id
            //redirect to correct page
            return RedirectToPage();
        }

    }
}
