namespace OgrenciOtomasyonSistemi.api.Entities
{
    public class Course
    {
        public string id { get; set; }

        public string name { get; set; }

        public string status { get; set; }

        public int teacherId { get; set; }

        public Teacher Teacher { get; set; }

        public ICollection<Student> Students { get; set; } = new List<Student>();

        public ICollection<Grade> Grades { get; set; } = new List<Grade>();

        public ICollection<Attendance> Courses { get; set; } = new List<Attendance>();

        public ICollection<Comment> Courses { get; set; } = new List<Comment>();
    }
}
