using aspnetcrud.Data;
using aspnetcrud.Models;
using aspnetcrud.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace aspnetcrud.Controllers
{
    public class StudentsController : Controller
    {
        private readonly AplicationDbContext dbContext;
        public StudentsController(AplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Add() 
        {
            return View(); 
        }
        [HttpPost]
        public async  Task<IActionResult> Add(AddStudentViewModel viewModel)
        {
            var student = new Student
            {
                Name = viewModel.Name,
                Email = viewModel.Email,
                Phone = viewModel.Phone,
                Subscribe = viewModel.Subscribe,
            };
           await dbContext.Students.AddAsync(student);
            await dbContext.SaveChangesAsync(); 

            return View();
        }
        [HttpGet]
        public async  Task<IActionResult> List()
        {
            var students =await dbContext.Students.ToListAsync();
        }
    }
}
