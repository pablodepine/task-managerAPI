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

        public async Task<IEnumerable<Tarefa>> CreateTarefa(Tarefa tarefa)
        {
            using (var conn = new SqlConnection(getConnection))
            {
                var sql = $"insert into Tasks (title, priority, description, status) values (@title, @priority, @description, @status)";
                await conn.ExecuteAsync(sql, tarefa);

                return await conn.QueryAsync<Tarefa>("select * from Tasks");
            }
        }

        public async Task<IEnumerable<Tarefa>> GetAllTarefas()
        {
            using(var conn = new SqlConnection(getConnection))
            {
                var sql = "select * from Tasks";
                return await conn.QueryAsync<Tarefa>(sql);
            }
        }

        public async Task<Tarefa> GetTarefaById(int taskId)
        {
            using(var conn = new SqlConnection(getConnection))
            {
                var sql = "select * from Tasks where TaskId = @Id";

                return await conn.QueryFirstOrDefaultAsync<Tarefa>(sql, new { Id = taskId } );
            }
        }

        public async Task<IEnumerable<Tarefa>> UpdateTarefa(Tarefa tarefa)
        {
            using(var conn = new SqlConnection(getConnection))
            {
                var sql = "update Tasks set title = @title, priority = @priority, description = @description, status = @status where TaskId = @TaskId";
                await conn.ExecuteAsync(sql, tarefa);

                return await conn.QueryAsync<Tarefa>("select * from Tasks");
            }
        }
    }
}
