using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.ComponentModel.DataAnnotations.Schema;

namespace MTickets.Models
{
    public class Cinema
    {
        [Key]
        
        public int Id { get; set; }
  
        public string Logo { get; set; }

        public string Name { get; set; } 
        
        public string Description { get; set; }

        //Relationships ( Отношения )
        public List <Movie> Movies { get; set; } 

    }
}
