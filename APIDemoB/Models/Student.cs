namespace APIDemoB.Models
{
    public class Student
    {
        public int StudentID { get; set; } // Primary Key
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; } = true;
        public int GradeID { get; set; }
        public Grade Grade { get; set; } 

    }
}
