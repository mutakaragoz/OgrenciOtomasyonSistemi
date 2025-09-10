namespace OgrenciOtomasyonSistemi.api.Entities
{
    public class Comment
    {
        public int id {  get; set; }

        public string comment { get; set; }

        public int studentId { get; set; }

        public Student Student { get; set; }

        public int teacherId { get; set; }

        public Teacher Teacher { get; set; }

        public int courseId { get; set; }

        public Course Course { get; set; }



    }
}
