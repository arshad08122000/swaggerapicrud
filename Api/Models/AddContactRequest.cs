namespace Api.Models
{
    public class AddContactRequest
    {
        public string Fullname { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
        public string Address { get; set; }
    }
}
