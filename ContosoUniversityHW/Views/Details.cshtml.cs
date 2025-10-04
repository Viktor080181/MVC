using ContosoUniversityHW.Data;
using ContosoUniversityHW.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContosoUniversityHW.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly UniversityContext _context;

        public DetailsModel(UniversityContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public Student? Student { get; set; }  // Сделано nullable
        public List<Enrollment>? Enrollments { get; set; } = new List<Enrollment>();  // Инициализировано и nullable

        public async Task<IActionResult> OnGetAsync(int id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            // остальной код
            return Page();
        }

    }
}
