using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;


namespace Api3Prac.Model
{
    public class BooksGenre
    {
        [Key]
        public int ID_Genre { get; set; }

        public string Name { get; set; }
    }
}
