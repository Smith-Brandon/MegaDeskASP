using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDeskWebASP.Model
{
    public class DeskModel
    {
        public int ID { get; set; }

        [Display(Name = "Customer Name")]
        [StringLength(120, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }

        [Required]
        [Range(24, 96)]
        public double Width { get; set; }

        [Required]
        [Range(12, 48)]
        public double Depth { get; set; }

        public double Area { get; set; }

        [Display(Name = "Number of Drawers")]
        [Range(0, 7)]
        public double Drawers { get; set; }

        public double DrawerCost;
        public string Material { get; set; }

        public double MaterialCost;
        public double Rush { get; set; }
        public double RushCost { get; set; }
        public double BasePrice = 200;

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public string Date { get; set; }
        public double TotalCost { get; set; }

        public DeskModel()
        { 
        
        }
    }
   
}
