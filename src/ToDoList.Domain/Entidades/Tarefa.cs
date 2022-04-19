using System;

namespace ToDoList.Domain.Entidades
{
    public class Tarefa
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public bool Completa { get; set; }
        public DateTime Criada { get; set; }
    }
}
