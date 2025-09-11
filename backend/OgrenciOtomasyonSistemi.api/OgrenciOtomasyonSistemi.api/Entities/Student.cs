namespace OgrenciOtomasyonSistemi.api.Entities
{
    public class Student
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int number { get; set; }


        public ICollection<Course> Courses { get; set; } = new List<Course>();

        public ICollection<Grade> Grades { get; set; } = new List<Grade>();

        public ICollection<Attendance> Attendance { get; set; } = new List<Attendance>();

        public ICollection<Comment> Comments { get; set; } = new List<Comment>();

    }
}
