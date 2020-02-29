using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDeskWebASP.Model;


namespace MegaDeskWebASP
{
    public class DetailsModel : PageModel
    {
        private readonly MegaDeskWebASP.Model.MegaDeskWebASPContext _context;

        public DetailsModel(MegaDeskWebASP.Model.MegaDeskWebASPContext context)
        {
            _context = context;
        }

        public DeskModel DeskModel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DeskModel = await _context.DeskModel.FirstOrDefaultAsync(m => m.ID == id);

            if (DeskModel == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
