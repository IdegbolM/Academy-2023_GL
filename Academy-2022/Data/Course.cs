using System.ComponentModel.DataAnnotations;

namespace Academy_2022.Data
{
    public class Course
    {
        [Required]
        public int? Id { get; set; }
        [StringLength(25)]
        public string? Name { get; set; }

        [StringLength(50)]
        public string? Description { get; set; }
    }
}
