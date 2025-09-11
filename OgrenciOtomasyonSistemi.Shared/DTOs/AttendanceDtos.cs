namespace OgrenciOtomasyonSistemi.api.DTOs
{
        public record AttendanceDto(int id, DateTime date, bool isJoined, string StudentFullName);
        public record AddAttendanceDto(DateTime date, bool isJoined, int studentId, int courseId);
        public record UpdateAttendanceDto(bool isJoined);

}
