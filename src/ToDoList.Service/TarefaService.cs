using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using ToDoList.Data.Repository.Interfaces;
using ToDoList.Domain.Entidades;
using ToDoList.Service.Interfaces;
using ToDoList.Service.ViewModels;

namespace ToDoList.Service
{
    public class TarefaService : ITarefaService
    {
        private readonly ITarefaRepository _tarefaRepository;
        private readonly IMapper _mapper;
        public TarefaService(ITarefaRepository tarefaRepository, IMapper mapper)
        {
            _tarefaRepository = tarefaRepository;
            _mapper = mapper;
        }

        public async Task AdicionarTarefa(TarefaViewModel tarefaViewModel)
        {
            await _tarefaRepository.AdicionarTarefa(_mapper.Map<Tarefa>(tarefaViewModel));
        }

        public async Task<List<TarefaViewModel>> GetAll()
        {
            return _mapper.Map<List<TarefaViewModel>>(await _tarefaRepository.GetAll());
        }
    }
}
