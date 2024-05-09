using Microsoft.VisualBasic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CIDM3312
{
    public class Shelf
    {
        public int ShelfID {get;set;} //PK

        [Display(Name = "Shelf Name")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string ShelfName {get;set;} = string.Empty;

        public int BookID {get;set;} 

                
    }
}