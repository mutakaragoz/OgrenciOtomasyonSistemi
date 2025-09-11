namespace OgrenciOtomasyonSistemi.api.DTOs
{
        public record TeacherDto(int id, string firstName, string lastName);

        public record CreateTeacherDto(string firstName, string lastName);
        
        public record UpdateTeacherDto(string firstName,string lastName);

}
