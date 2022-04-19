using System.Collections.Generic;
using System.Threading.Tasks;
using ToDoList.Domain.Entidades;

namespace ToDoList.Data.Repository.Interfaces
{
    public interface ITarefaRepository
    {
        Task<List<Tarefa>> GetAll();
        Task AdicionarTarefa(Tarefa tarefa);
    }
}
