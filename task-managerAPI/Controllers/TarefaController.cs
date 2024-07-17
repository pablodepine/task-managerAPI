using Microsoft.AspNetCore.Mvc;
using task_managerAPI.Models;
using task_managerAPI.Service.TarefaService;

namespace task_managerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefaController : Controller
    {        
        public readonly ITarefaInferace _tarefainterface;
        public TarefaController(ITarefaInferace tarefaInferace)
        {
            _tarefainterface = tarefaInferace;
        }

        [HttpGet]
        public async Task <ActionResult<IEnumerable<Tarefa>>> GetAllTarefas()
        {
            IEnumerable<Tarefa> tarefas = await _tarefainterface.GetAllTarefas();

            if(!tarefas.Any())
            {
                return NotFound("Nenhuma tarefa encontrada");
            }

            return Ok(tarefas);
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<Tarefa>>> CreateTarefa([FromForm]Tarefa tarefa)
        {
            IEnumerable<Tarefa> tarefas = await _tarefainterface.CreateTarefa(tarefa);

            return Ok(tarefas);
        }

        [HttpPut]
        public async Task <ActionResult<IEnumerable<Tarefa>>> UpdateTarefa(Tarefa tarefa)
        {
            Tarefa tarefaEspecifica = await _tarefainterface.GetTarefaById(tarefa.TaskId);

            if(tarefaEspecifica == null)
            {
                return NotFound("Tarefa não encontrada.");                
            }

            IEnumerable<Tarefa> tarefas = await _tarefainterface.UpdateTarefa(tarefa);

            return Ok(tarefas);
        }
    }
}
