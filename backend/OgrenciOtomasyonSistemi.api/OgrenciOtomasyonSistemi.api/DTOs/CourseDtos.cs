namespace OgrenciOtomasyonSistemi.api.DTOs
{ 
        public record CourseDto(int id, string name, string status, int teacherId);

        public record CreateCourseDto(string name, string status, int teacherId);

        public record UpdateCourseDto(string name, string status);
  
}
