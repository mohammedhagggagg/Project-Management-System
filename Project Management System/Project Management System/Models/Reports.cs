using System.ComponentModel.DataAnnotations.Schema;

namespace Project_Management_System.Models
{
    public class Reports
    {
        public int Id { get; set; }
        public int TotalTasks { get; set; } = 0;
        public int CompletedTasks { get; set; } = 0;
        public int InProgressTasks { get; set; }= 0;
        public int PendingTasks { get; set; } = 0;
        public DateTime GeneratedOn { get; set; } = DateTime.Now;

        //RelationShip [1(TaskItem) : M(Reports)]
        [ForeignKey("TaskItem")]
        public int? TaskItemId { get; set; }
        public virtual TaskItem? TaskItem { get; set; }

        //RelationShip [1(Project) : M(Reports)]
        [ForeignKey("Project")]
        public int? ProjectId { get; set; }
        public virtual Project? Project { get; set; }
    }
}
