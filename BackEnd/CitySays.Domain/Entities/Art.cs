namespace CitySays.Domain.Entities
{
    public class Art
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public User User { get; set; }
        public string City { get; set; }
        public string? ImageUrl { get; set; }

    }
}
