using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using ProductApp.Models;

namespace ProductApp.Repository
{
    public class EmployeeRepository
    {
        private SqlConnection con;

        private void Connection()
        {
            var constr = ConfigurationManager.ConnectionStrings["GetConn"].ToString();
            con = new SqlConnection(constr);
        }

        public bool AddEmployee(EmployeeModel obj)
        {
            Connection();
            SqlCommand com = new SqlCommand("AddNewEmpDetails", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            com.Parameters.AddWithValue("@Name", obj.Name);
            com.Parameters.AddWithValue("@City", obj.City);
            com.Parameters.AddWithValue("@Address", obj.Address);

            con.Open();
            int i = com.ExecuteNonQuery();
            con.Close();
            return i > 0;
        }

        public List<EmployeeModel> GetAllEmployees()
        {
            Connection();
            List<EmployeeModel> empList = new List<EmployeeModel>();

            SqlCommand com = new SqlCommand("GetEmployees", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();

            con.Open();
            da.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                empList.Add(new EmployeeModel
                {
                    Empid = Convert.ToInt32(dr["Id"]),
                    Name = Convert.ToString(dr["Name"]),
                    City = Convert.ToString(dr["City"]),
                    Address = Convert.ToString(dr["Address"])
                });
            }
            return empList;
        }

        public bool UpdateEmployee(EmployeeModel obj)
        {
            Connection();
            SqlCommand com = new SqlCommand("UpdateEmpDetails", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            com.Parameters.AddWithValue("@EmpId", obj.Empid);
            com.Parameters.AddWithValue("@Name", obj.Name);
            com.Parameters.AddWithValue("@City", obj.City);
            com.Parameters.AddWithValue("@Address", obj.Address);

            con.Open();
            int i = com.ExecuteNonQuery();
            con.Close();
            return i > 0;
        }

        public bool DeleteEmployee(int id)
        {
            Connection();
            SqlCommand com = new SqlCommand("DeleteEmpById", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            com.Parameters.AddWithValue("@EmpId", id);

            con.Open();
            int i = com.ExecuteNonQuery();
            con.Close();
            return i > 0;
        }
    }
}
