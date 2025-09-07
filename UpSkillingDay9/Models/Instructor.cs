namespace UpSkillingDay9.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Image { get; set; }
        public int Salary { get; set; }
        public int DepartmentId { get; set; }
        public int CourseId { get; set; }
    }
}
