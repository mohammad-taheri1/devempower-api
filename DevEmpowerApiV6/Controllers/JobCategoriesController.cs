using DevEmpowerApiV6.Core.Context;
using DevEmpowerApiV6.Core.DTO.JobCategories;
using DevEmpowerApiV6.Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DevEmpowerApiV6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobCategoriesController : ControllerBase
    {
        #region Constructor & Dependency Injection 
        private readonly ApplicationDbContext _context;

        public JobCategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }
        #endregion

        // CRUD
        #region HttpPost CreateNewJobCategory 
        [HttpPost]
        public async Task<ActionResult<JobCategory>> CreateNewJobCategory([FromBody] CreateJobCategoryDto dto)
        {
            var newJobCategory = new JobCategory()
            {
                Title = dto.Title,
            };

            await _context.JobCategories.AddAsync(newJobCategory);
            await _context.SaveChangesAsync();

            return Ok(newJobCategory);
        }
        #endregion

        #region HttpGet GetAllJobCategories
        [HttpGet]
        public async Task<ActionResult<List<JobCategory>>> GetAllJobCategories()
        {
            var jobCategories = await _context.JobCategories.ToListAsync();

            return Ok(jobCategories);
        }
        #endregion

    }
}
