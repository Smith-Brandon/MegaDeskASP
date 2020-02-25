using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MegaDeskWebASP.Model;


namespace MegaDeskWebASP
{
    public class EditModel : PageModel
    {
        private readonly MegaDeskWebASP.Model.MegaDeskWebASPContext _context;

        public EditModel(MegaDeskWebASP.Model.MegaDeskWebASPContext context)
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

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(DeskModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeskModelExists(DeskModel.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool DeskModelExists(int id)
        {
            return _context.DeskModel.Any(e => e.ID == id);
        }
    }
}
