using System;

namespace Todo.Models
{
    public class TodoModel
    {
        // public TodoModel(int id, string title)
        // {
        //     Id = id;
        //     Title = title;
        //     Done = false;
        //     CreatedAt = DateTime.Now;
        // }

        public int Id { get; set; }
        public string Title { get; set; }
        public bool Done { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}