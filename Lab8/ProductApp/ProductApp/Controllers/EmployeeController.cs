using System;
using System.Web.Http;
using ProductApp.Models;
using ProductApp.Repository;

namespace ProductApp.Controllers
{
    [RoutePrefix("api/Employee")]
    public class EmployeeController : ApiController
    {
        private readonly EmployeeRepository _empRepo = new EmployeeRepository();

        // GET: api/Employee/GetAllEmpDetails
        [HttpGet]
        [Route("GetAllEmpDetails")]
        public IHttpActionResult GetAllEmpDetails()
        {
            try
            {
                var employees = _empRepo.GetAllEmployees();
                return Ok(employees);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // POST: api/Employee/AddEmployee
        [HttpPost]
        [Route("AddEmployee")]
        public IHttpActionResult AddEmployee([FromBody] EmployeeModel emp)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            bool added = _empRepo.AddEmployee(emp);
            if (added)
            {
                return Ok("Employee added successfully");
            }
            else
            {
                return InternalServerError(new Exception("Failed to add employee"));
            }
        }

        // PUT: api/Employee/EditEmpDetails/5
        [HttpPut]
        [Route("EditEmpDetails/{id}")]
        public IHttpActionResult EditEmpDetails(int id, [FromBody] EmployeeModel emp)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            emp.Empid = id;
            bool updated = _empRepo.UpdateEmployee(emp);
            if (updated)
            {
                return Ok("Employee updated successfully");
            }
            else
            {
                return NotFound();
            }
        }

        // DELETE: api/Employee/DeleteEmp/5
        [HttpDelete]
        [Route("DeleteEmp/{id}")]
        public IHttpActionResult DeleteEmp(int id)
        {
            bool deleted = _empRepo.DeleteEmployee(id);
            if (deleted)
            {
                return Ok("Employee deleted successfully");
            }
            else
            {
                return NotFound();
            }
        }
    }
}