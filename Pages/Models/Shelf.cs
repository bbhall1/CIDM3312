using Microsoft.VisualBasic;
using Microsoft.EntityFrameworkCore;

namespace CIDM3312
{
    public class Shelf
    {
        public int ShelfID {get;set;} //PK
        public string ShelfName {get;set;} = string.Empty;

        public List<Book> Books {get;set;} = default!;
                
    }
}