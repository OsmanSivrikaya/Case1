namespace Case1.Entity
{
    public class User : BaseEntity
    {
        public required string Username { get; set; }
        public required string Password { get; set; }
        public required Role Role { get; set; }
    }
}
