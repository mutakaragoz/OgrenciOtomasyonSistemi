namespace OgrenciOtomasyonSistemi.api.DTOs

{
        public record CommentDto(int id, string comment, string teacherName, string studentFullName);
        public record AddCommentDto(string comment, int studentId, int courseId);
        public record UpdateCommentDto(string comment); 
}
