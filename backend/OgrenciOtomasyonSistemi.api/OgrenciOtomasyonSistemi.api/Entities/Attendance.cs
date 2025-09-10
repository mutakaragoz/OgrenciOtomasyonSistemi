namespace OgrenciOtomasyonSistemi.api.Entities
{
    public class Attendance
    {
        public int id {  get; set; }

        public DateTime date { get; set; }

        public bool isJoined { get; set; }

        public int studentId { get; set; } 

        public Student Student { get; set; } 

        public string courseId {  get; set; }

        public Course Course { get; set; }

    }
}
