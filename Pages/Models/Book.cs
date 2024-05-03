using Microsoft.VisualBasic;
using Microsoft.EntityFrameworkCore;

namespace CIDM3312
{
    public class Book
    {
        public int BookID {get;set;} //PK
        public string Title {get;set;} = string.Empty;
        public string Genre {get;set;} = string.Empty;
        public  DateOnly PublicationYear {get;set;}

        public List<Review> Reviews {get;set;} = default!;
        public List<Shelf> Shelves {get;set;} = default!;


        
    }
}