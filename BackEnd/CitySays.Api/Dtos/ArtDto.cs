using System.ComponentModel.DataAnnotations.Schema;

namespace CitySays.Api.Dtos
{
    public class ArtDto
    {
        public int UserId { get; set; }
        public string City { get; set; }
        public string Name { get; set; }
        public string Inform { get; set; }

        [NotMapped]
        public IFormFile? Image { get; set; }
    }
}
