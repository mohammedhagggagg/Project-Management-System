using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_Management_System.Models
{
    public enum TaskPriority
    {
        Low,
        Medium,
        High
    }
    public class TaskItem
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [StringLength(500, ErrorMessage = "The description must not exceed 500 characters.")]
        public string Description { get; set; }
        public DateTime DueDate { get; set; } = DateTime.Now.AddDays(7);
        public TaskPriority Priority { get; set; } = TaskPriority.Medium;
        public TaskStatus Status { get; set; }

        //RelationShip [1(Employee) : M(TaskItem)]
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }

        //RelationShip [1(Project) : M(TaskItem)]
        [ForeignKey("Project")]
        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }

        //RelationShip [1(TaskItem) : M(Reports)]
        public virtual ICollection<Reports> Reports { get; set; } = new List<Reports>();

    }
}
