namespace CodeFirstWithEfCore.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime EnrolmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
