using System;

namespace ToDo.Models
{
    public class Tarefa
    {
        public Tarefa(int id, string titulo)
        {
            Id = id;
            Titulo = titulo;
            Concluido = false;
            DataCriacao = DateTime.Today;
        }

        public int Id { get; set; }
        public string Titulo { get; set; }
        public bool Concluido { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}