using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDeskWebASP.Model;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MegaDeskWebASP.Pages.DeskPages
{
    public class IndexModel : PageModel
    {
        private readonly MegaDeskWebASP.Model.MegaDeskWebASPContext _context;

        public IndexModel(MegaDeskWebASP.Model.MegaDeskWebASPContext context)
        {
            _context = context;
        }

        public IList<DeskModel> DeskModel { get; set; }
        public List<DeskModel> Desk { get; set; }



        public string SearchString { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList Names { get; set; }
        [BindProperty(SupportsGet = true)]
        public string CustName { get; set; }

        public SelectList Date { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SortOrder { get; set; }
        public async Task OnGetAsync()
        {

            IQueryable<DeskModel> desks = from d in _context.DeskModel
                                          select d;
            IQueryable<string> nameQuery = from m in _context.DeskModel
                                           orderby m.Name
                                           select m.Name;

            if (!string.IsNullOrEmpty(CustName))
            {
                desks = desks.Where(s => s.Name == CustName);
            }
            if (SortOrder == "Oldest")
            {
                desks = desks.OrderBy(s => s.Date);
            }
            if (SortOrder == "Newest")
            {
                desks = desks.OrderByDescending(s => s.Date);
            }
            if (SortOrder == "Name Descending")
            {
                desks = desks.OrderByDescending(s => s.Name);
            }
            if (SortOrder == "Name Ascending")
            {
                desks = desks.OrderBy(s => s.Name);
            }

            Names = new SelectList(await nameQuery.Distinct().ToListAsync());
            DeskModel = await desks.ToListAsync();

        }

    }
}
