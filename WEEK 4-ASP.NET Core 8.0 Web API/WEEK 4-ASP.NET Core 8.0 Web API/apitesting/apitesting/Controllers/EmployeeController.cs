using apitesting.Models; // Adjust based on where your Employee, Department, Skill models are
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace apitesting.Controllers
{
    [Authorize(Roles = "Admin,POC")]
    [ApiController]
    [Route("api/emp")]
    [Authorize]
    public class EmployeeController : ControllerBase
    {
        private readonly ILogger<EmployeeController> _logger;
        private static List<Employee> _employees = GetStandardEmployeeList();

        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Employee>), 200)]
        [ProducesResponseType(500)]
        public ActionResult<List<Employee>> Get()
        {
            return Ok(_employees);
        }

        [HttpPut]
        [ProducesResponseType(typeof(Employee), 200)]
        [ProducesResponseType(400)]
        public ActionResult<Employee> Put([FromBody] Employee input)
        {
            if (input == null || input.Id <= 0)
            {
                return BadRequest("Invalid employee id");
            }

            var existingEmployee = _employees.FirstOrDefault(e => e.Id == input.Id);

            if (existingEmployee == null)
            {
                return BadRequest("Invalid employee id");
            }

            // Update fields
            existingEmployee.Name = input.Name;
            existingEmployee.Salary = input.Salary;
            existingEmployee.Permanent = input.Permanent;
            existingEmployee.Department = input.Department;
            existingEmployee.Skills = input.Skills;
            existingEmployee.DateOfBirth = input.DateOfBirth;

            return Ok(existingEmployee);
        }

        private static List<Employee> GetStandardEmployeeList()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "Alice",
                    Salary = 50000,
                    Permanent = true,
                    Department = new Department { Id = 1, Name = "HR" },
                    Skills = new List<Skill>
                    {
                        new Skill { Id = 1, Name = "Communication" },
                        new Skill { Id = 2, Name = "Recruitment" }
                    },
                    DateOfBirth = new DateTime(1990, 1, 1)
                },
                new Employee
                {
                    Id = 2,
                    Name = "Bob",
                    Salary = 60000,
                    Permanent = false,
                    Department = new Department { Id = 2, Name = "IT" },
                    Skills = new List<Skill>
                    {
                        new Skill { Id = 3, Name = "C#" },
                        new Skill { Id = 4, Name = "SQL" }
                    },
                    DateOfBirth = new DateTime(1988, 5, 10)
                }
            };
        }
    }
}
