using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class OfficeAssignment
    {
        [Key]
        public int InstructorID { get; set; }
        [StringLength(100)]
        [DisplayName("Office Location")]

        public string Location { get; set; }
        public Instructor Instructor { get; set; }
    }
}
