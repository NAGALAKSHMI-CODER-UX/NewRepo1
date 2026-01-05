using Core123.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core123.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveController : ControllerBase
    {

        private readonly AppDbContext _context;

        public LeaveController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult ApplyLeave(Leave leave)
        {
            leave.Status = "Pending";
            _context.LeaveRequests.Add(leave);
            _context.SaveChanges();
            return Ok(leave);
        }

        [HttpGet]
        public IActionResult GetLeaves()
        {
            return Ok(_context.LeaveRequests.ToList());
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStatus(int id, string status)
        {
            var leave = _context.LeaveRequests.Find(id);
            if (leave == null) return NotFound();

            leave.Status = status;
            _context.SaveChanges();
            return Ok(leave);
        }
    }
}
    

