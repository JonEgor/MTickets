using System.ComponentModel.DataAnnotations;

namespace MTickets.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }

        public string ProfilePictureURL { get; set; }

        public string FullName { get; set; }

        public string Bio { get; set; }

        //Отношения (Relationships) 
        public List<Movie> Movies { get; set; }

    }


}
