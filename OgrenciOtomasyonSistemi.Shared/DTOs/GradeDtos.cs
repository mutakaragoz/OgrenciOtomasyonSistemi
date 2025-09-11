namespace OgrenciOtomasyonSistemi.api.DTOs
{

        public record GradeDto(int id, int score, string CourseName, string StudentFullName);

        public record AddGradeDto(double score, int studentId, int CourseId);

        public record UpdateGradeDto(int score);
}
