namespace OgrenciOtomasyonSistemi.api.DTOs
{

        public record StudentDto(int id, string firstName, string lastName; int number);

        public record CreateStudentDto(string firstName, string lastName, int number);

        public record UpdateStudentDto(string firstName,string lastName, int number);

}
