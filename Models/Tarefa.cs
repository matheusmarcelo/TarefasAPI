using System.ComponentModel.DataAnnotations;

namespace Tarefas.Models
{
    public class Tarefa
    {
        [Key]
        public int Id {get; set;}
        public string Titulo {get; set;} = null!;
        public string Descricao {get; set;} = null!;
    }
}