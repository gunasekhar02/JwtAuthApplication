namespace JwtAuthApplication.Models
{
    public class User
    {
        public int Id { get; set; }
        public string userName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
