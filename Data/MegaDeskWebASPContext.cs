using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MegaDeskWebASP.Model;

namespace MegaDeskWebASP.Model
{
    public class MegaDeskWebASPContext : DbContext
    {
        public MegaDeskWebASPContext (DbContextOptions<MegaDeskWebASPContext> options)
            : base(options)
        {
        }

        public DbSet<MegaDeskWebASP.Model.DeskModel> DeskModel { get; set; }
    }
}
