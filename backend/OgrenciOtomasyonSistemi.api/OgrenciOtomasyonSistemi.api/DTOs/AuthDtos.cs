namespace OgrenciOtomasyonSistemi.api.DTOs
{
        public record RegisterDto(string email, string password, string role);

        public record LoginDto(string email, string password);

        public record LoginResponseDto(string Token);
}
