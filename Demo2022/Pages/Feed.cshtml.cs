using Demo2022.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Net.Http.Headers;

namespace Demo2022.Pages
{
    public class FeedModel : PageModel
    {
        public JsonResult OnGet()
        {
            IList<Shortcut> shortcuts  = new List<Shortcut>();

            Shortcut controlV = new Shortcut();
            controlV.FirstName = "Brandan";
            controlV.LastName = "Jones";
            controlV.Software = "Microsoft";
            controlV.KeyboardShortcut = "Control V";
            controlV.WhatDo = "Paste";
            shortcuts.Add(controlV);

            Shortcut controlC = new Shortcut();
            controlC.FirstName = "Betty";
            controlC.LastName = "White";
            controlC.Software = "Microsoft";
            controlC.KeyboardShortcut = "Control C";
            controlC.WhatDo = "Copy";
            shortcuts.Add(controlC);

            return new JsonResult(shortcuts);
        }
    }
}
