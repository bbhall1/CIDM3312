using Microsoft.VisualBasic;
using Microsoft.EntityFrameworkCore;

namespace CIDM3312
{
    public class Review
    {
        public int ReviewID {get;set;} //PK
        public int Rating {get;set;}
        public string ReviewText {get;set;} = string.Empty;

        public int BookID {get;set;} //FK
        public Book? Book {get;set;}
                
    }
}