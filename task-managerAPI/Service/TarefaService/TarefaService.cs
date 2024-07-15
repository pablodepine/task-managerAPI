using System.Data.SqlClient;
using Dapper;
using task_managerAPI.Models;

namespace task_managerAPI.Service.TarefaService
{
    public class TarefaService : ITarefaInferace
    {
        private readonly IConfiguration _config;
        private readonly string getConnection;
        public TarefaService(IConfiguration configuration)
        {
            _config = configuration;
            getConnection = _config.GetConnectionString("DefaultConnection");
        }

        public Task<IEnumerable<Tarefa>> CreateTarefa(Tarefa tarefa)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Tarefa>> GetAllTarefas()
        {
            using(var con = new SqlConnection(getConnection))
            {
                var sql = "select * from Tarefas";
                return await con.QueryAsync<Tarefa>(sql);
            }
        }

        public Task<IEnumerable<Tarefa>> UpdateTarefa(Tarefa tarefa)
        {
            throw new NotImplementedException();
        }
    }
}
