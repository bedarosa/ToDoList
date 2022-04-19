using System.Data.Entity.ModelConfiguration;
using ToDoList.Domain.Entidades;

namespace ToDoList.Data.Mapping
{
    public class TarefaConfig : EntityTypeConfiguration<Tarefa>
    {
        public TarefaConfig()
        {
            HasKey(x => x.Id);

            Property(x => x.Nome)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("varchar");

            Property(x => x.Criada)
                .HasColumnType("date");
        }
    }
}
