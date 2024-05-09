using Microsoft.VisualBasic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CIDM3312
{
    public class Book
    {
        public int BookID {get;set;} //PK

        
        [StringLength(60, MinimumLength = 2)]
        [Required]
        public string Title {get;set;} = string.Empty;
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Author {get;set;} = string.Empty;

        [StringLength(20, MinimumLength = 4)]
        [Required]
        public string Genre {get;set;} = string.Empty;

        [Display(Name = "Publication Date")]
        [DataType(DataType.Date)]
        public  DateOnly PublicationYear {get;set;}

        public List<Review> Reviews {get;set;} = new List<Review>(); //book can have many reviews
        //public List<Shelf> Shelves {get;set;} = new List<Shelf>();
               
    }
}