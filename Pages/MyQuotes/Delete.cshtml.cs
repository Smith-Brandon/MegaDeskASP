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
    public class DeleteModel : PageModel
    {
        private readonly MegaDeskWebASP.Model.MegaDeskWebASPContext _context;

        public DeleteModel(MegaDeskWebASP.Model.MegaDeskWebASPContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DeskModel = await _context.DeskModel.FindAsync(id);

            if (DeskModel != null)
            {
                _context.DeskModel.Remove(DeskModel);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
