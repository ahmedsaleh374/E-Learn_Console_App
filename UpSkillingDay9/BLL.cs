using System.Data;
using UpSkillingDay9.Models;

namespace UpSkillingDay9
{
    public class BLL
    {
        DAL dAL = new DAL();
        public ICollection<Instructor> GetAllInstructors()
        {
            var instructors = dAL.GetAllInstructors();

            var instructorsList = new List<Instructor>();

            foreach (DataRow row in instructors.Rows)
            {
                instructorsList.Add(new Instructor
                {
                    Id = (int)row["ID"],
                    Name = (string)row["Name"],
                });
            }
            return instructorsList;
        }

        public ICollection<Instructor> GetInstructor(int id)
        {
            var instructor = dAL.GetInstructor(id);
            var instructorModel = new List<Instructor>();
            foreach (DataRow row in instructor.Rows)
            {
                instructorModel.Add(new Instructor
                {
                    Id = (int)row["ID"],
                    Name = (string)row["Name"],
                });
            }
            return instructorModel;
        }

        public void AddInstructor(Instructor instructor) 
        { 
            dAL.AddInstructor(instructor);
        }
        public void UpdateInstructorName(int id, string name) 
        {
            dAL.UpdateInstructorName(id, name);
        }

        public void DeleteInstructor(int id)
        {
            dAL.DeleteInstructor(id);
        }

    }
}
