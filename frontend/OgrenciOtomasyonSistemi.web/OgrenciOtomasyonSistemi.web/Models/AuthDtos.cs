namespace OgrenciOtomasyonSistemi.web.Models
{
    public class LoginDto
    {
        public string email { get; set; }
        public string password { get; set; }
    }

    public class LoginResponseDto
    {
        public string Token { get; set; }
    }
}

