using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDeskWebASP.Model;


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

        public async Task OnGetAsync()
        {
            
        IQueryable<DeskModel> desks = from d in _context.DeskModel
                                     select d;



            DeskModel = await desks.ToListAsync();
            
        }
    }
}
