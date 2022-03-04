using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace CodeSecond.DTOs
{
    public class GradeDTO
    {
        [Key]
        public int StudentID { get; set; }
        [Required]
        public string StudentName { get; set; }
        [Required]
        public DateTime? DateOfBirth { get; set; }
        [Required]
        public byte[] Photo { get; set; }
        [Required]
        public float Weight { get; set; }
        [NotMapped]
        public GradeDTO Grade { get; set; }
        public string xamlz { get; set; }
        public string xoamedi { get; set; }
        [Required]
        public string diemotherfuck { get; set; }
    }
}
