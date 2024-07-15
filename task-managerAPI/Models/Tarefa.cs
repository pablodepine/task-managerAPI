using task_managerAPI.Enums;

namespace task_managerAPI.Models
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public PrioridadeEnum Priority { get; set; }
        public string Description { get; set; }
        public StatusEnum Status { get; set; }
    }
}
