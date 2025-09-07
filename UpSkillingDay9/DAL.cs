using Microsoft.Data.SqlClient;
using System.Data;
using UpSkillingDay9.Models;
//using System.Data.SqlClient;

//using System.Data.SqlClient;

namespace UpSkillingDay9
{
    public class DAL
    {
        //First connection / command / choose the mode 
        SqlConnection sqlConnection = new SqlConnection("Data Source=.;Initial Catalog=El3id;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");


        public DataTable GetAllInstructors()
        {
            //SqlDataAdapter Adapter = new SqlDataAdapter();
            var command = new SqlCommand("select * from Instructors", sqlConnection);
            var Adapter = new SqlDataAdapter(command);
            var InstructorsTable = new DataTable();
            Adapter.Fill(InstructorsTable);
            return InstructorsTable;
        }

        public DataTable GetInstructor(int id)
        {
            var command = new SqlCommand($"select * from Instructors where Id = {id}", sqlConnection);
            var Adapter = new SqlDataAdapter(command);
            var InstructorTable = new DataTable();
            Adapter.Fill(InstructorTable);
            return InstructorTable;
        }

        public void AddInstructor(Instructor instructor) 
        {
            sqlConnection.Open();
            var command = new SqlCommand($"INSERT INTO Instructors(Name, Email, Phone, Image,Salary,DepartmentId,CourseId)VALUES ('{instructor.Name}','{instructor.Email}','{instructor.Phone}','{instructor.Image}',{instructor.Salary},{instructor.DepartmentId},{instructor.CourseId}); ", sqlConnection);
            var result = command.ExecuteNonQuery();
            Console.WriteLine($"{result} row is affected");
            Console.WriteLine($"you Add a new instructor with Name:{instructor.Name} Successfully");
            sqlConnection.Close();
        }
        public void UpdateInstructorName(int id, string name)
        {
            sqlConnection.Open();
            var command = new SqlCommand($"Update Instructors set Name ='{name}' where Id = {id} ", sqlConnection);
            var result = command.ExecuteNonQuery();
            Console.WriteLine($"{result} row is affected");
            Console.WriteLine($"you Updated instructor Name with id :{id} Successfully");
            sqlConnection.Close();
        }

        public void DeleteInstructor(int id)
        { 
            sqlConnection.Open();
            var command = new SqlCommand($"DELETE FROM Instructors WHERE Id= {id} ", sqlConnection);
            var result = command.ExecuteNonQuery();
            Console.WriteLine($"{result} row is affected");
            Console.WriteLine($"you deleted instructor with id :{id} Successfully");
            sqlConnection.Close(); 
        }
    }
}

#region modes inplemantation 
#region Connected Mode 
//sqlConnection.Open();

//sqlCommand.CommandText = "Update Courses set Name = 'cs' where Id = 1";
//var result = sqlCommand.ExecuteNonQuery();
//Console.WriteLine($"{result} row is affected");

//var dataReader = sqlCommand.ExecuteReader();

//while (dataReader.Read())
//{
//    int id = (int)dataReader["Id"];
//    string name = (string)dataReader["Name"];

//    Console.WriteLine($"ID:{id}\nName:{name}");
//}

//sqlCommand.CommandText = "Select count(*) From Courses";
//var count = sqlCommand.ExecuteScalar();
//Console.WriteLine($"count:{count}");

//sqlConnection.Close();
#endregion

#region DisConnected Mode 
//var adapter = new SqlDataAdapter(sqlCommand);
//DataTable dataTable = new DataTable();
//adapter.Fill(dataTable);
//foreach (DataRow row in dataTable.Rows)
//{
//    int id = (int)row["Id"];
//    string name = (string)row["Name"];

//    Console.WriteLine($"ID:{id}\nName:{name}");
//}
#endregion
#endregion
