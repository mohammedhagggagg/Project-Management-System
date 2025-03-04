using System.ComponentModel.DataAnnotations;

namespace Project_Management_System.Models
{
    public enum TaskStatus
    {
        Pending,
        InProgress,
        Completed
    }
    public enum ProjectStatus
    {
        Pending,
        InProgress,
        Completed
    }
    public class Project
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "The project name must not exceed 100 characters.")]
        public string Name { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "The description must not exceed 500 characters.")]
        public string Description { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; } = DateTime.Now.AddMonths(1);
        public ProjectStatus Status { get; set; }
        //RelationShip [1(Projects) : M(Employee)]
        public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

        //RelationShip [1(Projects) : M(Reports)]
        public ICollection<Reports> Reports { get; set; } = new List<Reports>();

        //RelationShip [1(Projects) : M(TaskItem)]
        public ICollection<TaskItem> taskItems { get; set; } = new List<TaskItem>();
    }
}
