namespace TasksApi.Options
{
    public class JwtOption
    {
        public string? Issuer { get; set; }
        public string? Audience { get; set; }
        public string? Key { get; set; }
        public int AccessValidity { get; set; }
        public int RefreshValidity { get; set; }

    }
}
