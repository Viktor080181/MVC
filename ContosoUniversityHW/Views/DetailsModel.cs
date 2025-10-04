using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContosoUniversityHW.Data;
using ContosoUniversityHW.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace ContosoUniversityHW.Pages
{
    public class DetailsModel1 : PageModel
    {
        private readonly UniversityContext _context;

        public DetailsModel1(UniversityContext context)
        {
            _context = context;
        }

        public Student Student { get; set; } = null!;
        public List<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

        public async Task OnGetAsync(int id)
        {
            Student = await _context.Students.FindAsync(id);

            if (Student == null)
            {
                // Обработка отсутствия студента, например:
                // return NotFound();
            }

            Enrollments = await _context.Enrollments
                .Where(e => e.StudentID == id)
                .Include(e => e.Course)
                .ToListAsync();
        }
    }
}
