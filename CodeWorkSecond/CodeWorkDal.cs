using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.Linq;

namespace CodeWorkSecond
{

    class CodeWorkDal
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-BQSMLU9;Initial Catalog=CodeWorkDatabase;Integrated Security=True");

        public List<CodeWork> GetAll()
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("Select * From Codework", sqlConnection);
            SqlDataReader reader = command.ExecuteReader();
            List<CodeWork> codeWorks = new List<CodeWork>();
            while (reader.Read())
            {
                CodeWork codeWork = new CodeWork
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    Surname = reader["Surname"].ToString(),
                    Gender = reader["Gender"].ToString(),
                    Salary = Convert.ToDecimal(reader["Salary"]),
                    Time = Convert.ToDateTime(reader["Time"])

                };
                codeWorks.Add(codeWork);
            }
            reader.Close();
            sqlConnection.Close();
            return codeWorks;
        }

        public List<CodeWork> GetMale()
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("Select * From Codework Where Gender='Male'", sqlConnection);
            SqlDataReader reader = command.ExecuteReader();
            List<CodeWork> codeWorks = new List<CodeWork>();
            while (reader.Read())
            {
                CodeWork codeWork = new CodeWork
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    Surname = reader["Surname"].ToString(),
                    Gender = reader["Gender"].ToString(),
                    Salary = Convert.ToDecimal(reader["Salary"]),
                    Time = Convert.ToDateTime(reader["Time"])

                };
                codeWorks.Add(codeWork);
            }
            reader.Close();
            sqlConnection.Close();
            return codeWorks;
        }

        public List<CodeWork> GetFemale()
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("Select * From Codework Where Gender='Female'", sqlConnection);
            SqlDataReader reader = command.ExecuteReader();
            List<CodeWork> codeWorks = new List<CodeWork>();
            while (reader.Read())
            {
                CodeWork codeWork = new CodeWork
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    Surname = reader["Surname"].ToString(),
                    Gender = reader["Gender"].ToString(),
                    Salary = Convert.ToDecimal(reader["Salary"]),
                    Time = Convert.ToDateTime(reader["Time"])

                };
                codeWorks.Add(codeWork);
            }
            reader.Close();
            sqlConnection.Close();
            return codeWorks;
        }

        
        public void UpdateTime(CodeWork codeWork)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Codework set Name=@Name, Surname=@Surname, Gender=@Gender, Salary=@Salary, Time=@Time  where Id=@Id",sqlConnection);
            command.Parameters.AddWithValue("@Id",codeWork.Id);
            command.Parameters.AddWithValue("@Name",codeWork.Name);
            command.Parameters.AddWithValue("@Surname",codeWork.Surname);
            command.Parameters.AddWithValue("@Gender",codeWork.Gender);
            command.Parameters.AddWithValue("@Salary",codeWork.Salary);
            command.Parameters.AddWithValue("@Time",codeWork.Time);
            command.ExecuteNonQuery();
            sqlConnection.Close();
        }
        private void ConnectionControl()
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }
    }


}
