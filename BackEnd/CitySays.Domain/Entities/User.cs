using System.ComponentModel.DataAnnotations;

namespace CitySays.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string NickName {  get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        public ICollection<Art> Arts { get; set; }
    }
}
