using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationWithMySQL.Models;


namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public DepartmentController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public JsonResult Get()
        {
            // Updated query to use the database name in the connection string
            string query = @"
                        select DepartmentId, DepartmentName from 
                        justinDb.Department
            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DepartmentAppCon");
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(sqlDataSource))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    mycon.Close();
                }
            }

            return new JsonResult(table);
        }


        [HttpPost]
        public JsonResult Post(Department dep)
        {
            // Updated query to use the database name in the connection string
            string query = @"
                        insert into justinDb.Department (DepartmentName) values
                                                    (@DepartmentName);
                        
            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DepartmentAppCon");
            using (MySqlConnection mycon = new MySqlConnection(sqlDataSource))
            {
                // Removed unnecessary variable and updated using statement
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myCommand.Parameters.AddWithValue("@DepartmentName", dep.DepartmentName);

                    myCommand.ExecuteNonQuery(); // Use ExecuteNonQuery for insert statements

                    mycon.Close();
                }
            }

            return new JsonResult("Added Successfully");
        }


        [HttpPut]
        public JsonResult Put(Department dep)
        {
            // Updated query to use the database name in the connection string
            string query = @"
                        update justinDb.Department set 
                        DepartmentName = @DepartmentName
                        where DepartmentId = @DepartmentId;
                        
            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DepartmentAppCon");
            using (MySqlConnection mycon = new MySqlConnection(sqlDataSource))
            {
                // Removed unnecessary variable and updated using statement
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myCommand.Parameters.AddWithValue("@DepartmentId", dep.DepartmentId);
                    myCommand.Parameters.AddWithValue("@DepartmentName", dep.DepartmentName);

                    myCommand.ExecuteNonQuery(); // Use ExecuteNonQuery for update statements

                    mycon.Close();
                }
            }

            return new JsonResult("Updated Successfully");
        }



        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            // Updated query to use the database name in the connection string
            string query = @"
                        delete from justinDb.Department 
                        where DepartmentId = @DepartmentId;
                        
            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DepartmentAppCon");
            using (MySqlConnection mycon = new MySqlConnection(sqlDataSource))
            {
                // Removed unnecessary variable and updated using statement
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myCommand.Parameters.AddWithValue("@DepartmentId", id);

                    myCommand.ExecuteNonQuery(); // Use Execute

                    mycon.Close();

                }
            }
            return new JsonResult("Deleted Successfully");
        }
    }
}
