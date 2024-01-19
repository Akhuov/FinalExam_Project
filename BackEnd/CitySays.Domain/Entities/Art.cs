namespace CitySays.Domain.Entities
{
    public class Art
    {
        public int Id { get; set; }
        public int AutorId { get; set; }
        public string Name { get; set; }
        public Autor Autor { get; set; }
        public string City { get; set; }
        public string? ImageUrl { get; set; }

    }
}
