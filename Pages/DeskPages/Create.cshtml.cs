using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MegaDeskWebASP.Model;


namespace MegaDeskWebASP
{
    public class CreateModel : PageModel
    {
        private readonly MegaDeskWebASP.Model.MegaDeskWebASPContext _context;

        public CreateModel(MegaDeskWebASPContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public DeskModel Desk { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            getArea();
            getDrawerCost();
            getMaterialCost();
            getRushCost();
            getTotalCost();

            Desk.Date = DateTime.Now.ToString("MM/dd/yyyy");

            _context.DeskModel.Add(Desk);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
        private void getTotalCost()
        {
            Desk.TotalCost = Desk.MaterialCost + Desk.BasePrice + Desk.DrawerCost + Desk.RushCost + Desk.Area;
        }
        private void getArea()
        {
            Desk.Area = Desk.Width * Desk.Depth;
        }
        private void getMaterialCost()
        {
            if (Desk.Material == "Laminate")
            {
                Desk.MaterialCost = 100;
            }
            else if (Desk.Material == "Oak")
            {
                Desk.MaterialCost = 200;
            }
            else if (Desk.Material == "Pine")
            {
                Desk.MaterialCost = 50;
            }
            else if (Desk.Material == "Rosewood")
            {
                Desk.MaterialCost = 100;
            }
            else if (Desk.Material == "Veneer")
            {
                Desk.MaterialCost = 125;
            }

        }
        private void getDrawerCost()
        {
            Desk.DrawerCost = Desk.Drawers * 50;
        }
        private void getRushCost()
        {
            switch (Desk.Rush)
            {
                case 3:
                    if (Desk.Area < 1000)
                    { Desk.RushCost = 60; }
                    if (Desk.Area < 2000 && Desk.Area > 1000)
                    { Desk.RushCost = 70; }
                    if (Desk.Area > 2000)
                    { Desk.RushCost = 80; }
                    break;
                case 5:
                    if (Desk.Area < 1000)
                    { Desk.RushCost = 40; }
                    if (Desk.Area < 2000 && Desk.Area > 1000)
                    { Desk.RushCost = 50; }
                    if (Desk.Area > 2000)
                    { Desk.RushCost = 60; }
                    break;
                case 7:
                    if (Desk.Area < 1000)
                    { Desk.RushCost = 30; }
                    if (Desk.Area < 2000 && Desk.Area > 1000)
                    { Desk.RushCost = 35; }
                    if (Desk.Area > 2000)
                    { Desk.RushCost = 40; }
                    break;
            }
        }
    }
}

