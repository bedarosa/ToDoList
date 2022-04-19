using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using ToDoList.Data.Context;
using ToDoList.Data.Repository.Interfaces;
using ToDoList.Domain.Entidades;

namespace ToDoList.Data.Repository
{
    public class TarefaRepository : ITarefaRepository
    {
        private readonly ToDoContext _context;
        private DbSet<Tarefa> _dbSet;

        public TarefaRepository(ToDoContext context)
        {
            _context = context;
            _dbSet = context.Set<Tarefa>();
        }

        public async Task AdicionarTarefa(Tarefa tarefa)
        {
            _dbSet.Add(tarefa);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Tarefa>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }
    }
}
