using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using ToDoList.Data.Mapping;
using ToDoList.Domain.Entidades;

namespace ToDoList.Data.Context
{
    public class ToDoContext : DbContext
    {
        public ToDoContext()
            : base("ToDoConnection")
        {

        }

        public DbSet<Tarefa> Tarefas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new TarefaConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}
