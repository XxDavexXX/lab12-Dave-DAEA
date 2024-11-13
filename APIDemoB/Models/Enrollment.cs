namespace APIDemoB.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }

        // Relación con `Student`
        public int StudentID { get; set; }
        public Student Student { get; set; }  // Propiedad de navegación

        // Relación con `Course`
        public int CourseID { get; set; }
        public Course Course { get; set; }  

        public DateTime Date { get; set; }
    }
}
