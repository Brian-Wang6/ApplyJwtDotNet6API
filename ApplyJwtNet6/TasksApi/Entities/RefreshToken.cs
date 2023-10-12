namespace TasksApi.Entities
{
    public class RefreshToken
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string TokenHash { get; set; } = string.Empty;

        public string TokenSalt { get; set; } = string.Empty;

        public DateTime Ts { get; set; }

        public DateTime ExpiryDate { get; set; }

        public virtual User? User { get; set; }
    }
}
