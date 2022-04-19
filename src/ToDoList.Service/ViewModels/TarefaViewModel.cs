using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Service.ViewModels
{
    public class TarefaViewModel
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }
        [JsonProperty("nome")]
        public string Nome { get; set; }
        [JsonProperty("completa")]
        public bool Completa { get; set; }
        [JsonProperty("criada")]
        public DateTime Criada { get; set; }
    }
}
