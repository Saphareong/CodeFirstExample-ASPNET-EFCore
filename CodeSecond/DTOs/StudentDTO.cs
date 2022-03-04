using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace CodeSecond.DTOs
{
    public class StudentDTO
    {
        [Key]
        public int GradeId { get; set; }
        [Required]
        public string GradeName { get; set; }
        [Required]
        public string Section { get; set; }
        [Required]
        public ICollection<StudentDTO> Students { get; set; }
    }
}
