using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CitySays.Api.Dtos
{
    public class ArtDto
    {
        public int UserId { get; set; }
        public string City { get; set; }
        public string Name { get; set; }

        //bu bazaga qo'shilmaydi
        [NotMapped]
        public IFormFile? Image { get; set; }
    }
}
