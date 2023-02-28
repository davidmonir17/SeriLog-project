using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SeriLogLoggining_project.Data;
using SeriLogLoggining_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeriLogLoggining_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly SeriLoggingContext _context;

        public EmployeesController(SeriLoggingContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<List<Employee>> Get()
        {
            return await _context.Employee.ToListAsync();
        }
    }
}