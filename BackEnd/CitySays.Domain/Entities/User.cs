namespace CitySays.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string NickName {  get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public ICollection<Art> Arts { get; set; }
    }
}
