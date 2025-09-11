namespace OgrenciOtomasyonSistemi.api.Entities
{
    public class Teacher
    {
        public int id { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public ICollection<Course> Courses { get; set; } = new List<Course>();

        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}
