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
                Console.WriteLine("3-Update Instructor Name");
                Console.WriteLine("4-delete Instructor \n");
                int optionNumber = Convert.ToInt32(Console.ReadLine());
                switch (optionNumber)
                {
                    case 1:
                        GetAllInstructors();
                        break;
                    case 2:
                        Console.Write("please enter instructor id:");
                        int id = Convert.ToInt32(Console.ReadLine());
                        GetInstructor(id);
                        break;
                    case 3:
                        Console.Write("please enter instructor id:");
                        int id1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("please enter instructor Name:");
                        string name = Console.ReadLine();
                        bLL.UpdateInstructorName(id1, name);
                        Console.WriteLine("=========================================================");
                        break;
                    case 4:
                        Console.Write("please enter instructor id:");
                        int id2 = Convert.ToInt32(Console.ReadLine());
                        bLL.DeleteInstructor(id2);
                        Console.WriteLine("=========================================================");
                        break;
                    default:
                        GetAllInstructors();
                        break;
                }

            }
            void GetInstructor(int id)
            {
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
        }

    }
}




