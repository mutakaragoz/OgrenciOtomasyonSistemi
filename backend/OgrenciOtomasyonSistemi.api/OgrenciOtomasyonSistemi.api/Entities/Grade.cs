namespace OgrenciOtomasyonSistemi.api.Entities
{
    public class Grade
    {
        public int id { get; set; }

        public int score { get; set; }

        public int studentId { get; set; }
        public Student Student { get; set; }    

        public int courseId { get; set; }
        public Course Course { get; set; }




    }
}
