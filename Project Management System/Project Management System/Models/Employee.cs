using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_Management_System.Models
{
    public enum Gender
    {
        Male,
        Female
    }
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "The name must not exceed 50 characters.")]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password must be between 6 and 20 characters.")]
        public string Password { get; set; }
        [Required]
        [Phone]
        public string Phone { get; set; }
        [Required]
        public Gender Gender { get; set; }

        //RelationShip [1(Projects) : M(Employee)]
        [ForeignKey("Project")]
        public int? ProjectId { get; set; }
        public virtual Project Project { get; set; }

        //RelationShip [1(Employee) : M(taskItems)]
        public virtual ICollection<TaskItem> taskItems { get; set; } = new List<TaskItem>();
    }
}
