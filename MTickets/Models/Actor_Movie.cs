using System.ComponentModel.DataAnnotations;

namespace MTickets.Models
{
    public class Actor_Movie
    {
        [Key]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
       
        
        public int ActorId { get; set; }
        public Actor Actor {get; set; }

        
        


    }
}
