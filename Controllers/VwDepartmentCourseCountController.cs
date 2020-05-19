using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VwDepartmentCourseCountController : ControllerBase
    {
        private readonly ContosouniversityContext _context;

        public VwDepartmentCourseCountController(ContosouniversityContext context)
        {
            _context = context;
        }

        // GET: api/VwCourseStudentCount
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VwDepartmentCourseCount>>> GetVwDepartmentCourse()
        {
            return await _context.VwDepartmentCourseCount.FromSqlRaw("Select * From VwDepartmentCourseCount").ToListAsync();
            //return await _context.VwDepartmentCourseCount.ToListAsync();
        }
    }
}
