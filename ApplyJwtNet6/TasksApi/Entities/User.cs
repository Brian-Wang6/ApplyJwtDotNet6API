namespace TasksApi.Entities
{
    public class User
    {
        public User()
        {
            RefreshTokens = new HashSet<RefreshToken>();
            Tasks = new HashSet<Task>();
        }

        public int Id { get; set; }

        public string Email { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public string PasswordSalt { get; set; } = string.Empty;

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public DateTime Ts { get; set; }

        public bool Active { get; set; }

        public virtual ICollection<RefreshToken> RefreshTokens { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }
    }
}
