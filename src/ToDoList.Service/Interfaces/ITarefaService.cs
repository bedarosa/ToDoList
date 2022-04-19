using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Service.ViewModels;

namespace ToDoList.Service.Interfaces
{
    public interface ITarefaService
    {
        Task<List<TarefaViewModel>> GetAll();
        Task AdicionarTarefa(TarefaViewModel tarefaViewModel);
    }
}
