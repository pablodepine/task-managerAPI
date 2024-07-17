using task_managerAPI.Models;

namespace task_managerAPI.Service.TarefaService
{
    public interface ITarefaInferace
    {
        Task<IEnumerable<Tarefa>> GetAllTarefas();
        Task<Tarefa> GetTarefaById(int id);
        Task<IEnumerable<Tarefa>> CreateTarefa(Tarefa tarefa);
        Task<IEnumerable<Tarefa>> UpdateTarefa(Tarefa tarefa);
    }
}
