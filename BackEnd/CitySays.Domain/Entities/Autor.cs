namespace CitySays.Domain.Entities
{
    public class Autor
    {
        public int Id { get; set; }
        public string NickName {  get; set; }
        public ICollection<Art> Arts { get; set; }
    }
}
