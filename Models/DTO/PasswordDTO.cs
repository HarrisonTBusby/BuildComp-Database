namespace BuildComp___Database.Models.DTO
{
    public class PasswordDTO
    {
        public string? Salt { get; set; }
        public string? Hash { get; set; }
    }
}