using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using ToDoList.Service.Interfaces;
using ToDoList.Service.ViewModels;

namespace ToDo.Api.Controllers
{
    public class TarefaController : ApiController
    {
        private readonly ITarefaService _tarefaService;
        public TarefaController(ITarefaService tarefaService)
        {
            _tarefaService = tarefaService;
        }

        [HttpGet]
        public async Task<List<TarefaViewModel>> TodasTarefas()
        {
            return await _tarefaService.GetAll();
        }

        [HttpPost]
        public async Task<HttpStatusCode> AdicionarTarefa(TarefaViewModel tarefaViewModel)
        {
            tarefaViewModel.Id = Guid.NewGuid();
            tarefaViewModel.Criada = DateTime.Now;
            await _tarefaService.AdicionarTarefa(tarefaViewModel);
            return HttpStatusCode.Created;
        }
    }
}
