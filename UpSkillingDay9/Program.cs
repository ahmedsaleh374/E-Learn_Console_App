namespace UpSkillingDay9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BLL bLL = new BLL();
            while (true)
            {
                Console.WriteLine("\t\tWelcome To ADO Test App");
                Console.WriteLine("\t\t=======================\n");
                Console.WriteLine("\tchoose your option:");
                Console.WriteLine("1-Get all instructors");
                Console.WriteLine("2-Get  instructor");
                Console.WriteLine("3-Add  instructor");
                Console.WriteLine("4-Update Instructor Name");
                Console.WriteLine("5-delete Instructor \n");
                int optionNumber = Convert.ToInt32(Console.ReadLine());
                switch (optionNumber)
                {
                    case 1:
                        GetAllInstructors();
                        break;
                    case 2:
                        GetInstructor();
                        break;
                    case 3:
                        AddInstructor();
                        break;
                    case 4:
                        UpdateInstructorName();
                        break;
                    case 5:
                        DeleteInstructor();
                        break;
                    default:
                        GetAllInstructors();
                        break;
                }

            }

            void GetInstructor()
            {
                Console.Write("please enter instructor id:");
                int id = Convert.ToInt32(Console.ReadLine());
                var instructor = bLL.GetInstructor(id);
                foreach (var item in instructor)
                {
                    Console.WriteLine($"ID:{item.Id}\tName:{item.Name}");
                }
                Console.WriteLine("=========================================================");
            }
            void GetAllInstructors()
            {
                var instructors = bLL.GetAllInstructors();
                foreach (var item in instructors)
                {
                    Console.WriteLine($"ID:{item.Id}\tName:{item.Name}");
                }
                Console.WriteLine("=========================================================");
            }
            void AddInstructor() 
            {
                Console.Write("please enter instructor Name:");
                string name = Console.ReadLine();
                Console.Write("please enter instructor Email:");
                string email = Console.ReadLine();
                Console.Write("please enter instructor Phone:");
                string phone = Console.ReadLine();
                Console.Write("please enter instructor ImageUrl:");
                string imageUrl = Console.ReadLine();
                Console.Write("please enter instructor Salary:");
                int salary = Convert.ToInt32(Console.ReadLine());
                Console.Write("please enter instructor DepartmentId:");
                int departmentId = Convert.ToInt32(Console.ReadLine());
                Console.Write("please enter instructor CourseId:");
                int courseId = Convert.ToInt32(Console.ReadLine());
                bLL.AddInstructor(new Models.Instructor
                {
                    Name = name,
                    Email = email,
                    Phone = phone,
                    Image = imageUrl,
                    Salary = salary,
                    DepartmentId = departmentId,
                    CourseId = courseId
                });
                Console.WriteLine("=========================================================");
            }
            void UpdateInstructorName() 
            {
                Console.Write("please enter instructor id:");
                int id1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("please enter instructor Name:");
                string name1 = Console.ReadLine();
                bLL.UpdateInstructorName(id1, name1);
                Console.WriteLine("=========================================================");
            }
            void DeleteInstructor() 
            {
                Console.Write("please enter instructor id:");
                int id2 = Convert.ToInt32(Console.ReadLine());
                bLL.DeleteInstructor(id2);
                Console.WriteLine("=========================================================");
            }
        }

    }
}




