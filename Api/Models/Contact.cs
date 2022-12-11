namespace Api.Models
{
    public class Contact
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Fullname { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
        public string Address { get; set; }
    }
}
