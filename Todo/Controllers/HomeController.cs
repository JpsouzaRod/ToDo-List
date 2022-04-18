using Microsoft.AspNetCore.Mvc;
using Todo.Data;
using Todo.Models;

namespace Todo.Controllers
{   
    [ApiController]
    [Route ("home")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        [Route ("")]
        public IActionResult ListarTarefas ([FromServices] AppDbContext context)
        {
            return Ok(context.Todos.ToList());
        }

        [HttpGet]
        [Route ("{id:int}")]
        public IActionResult BuscarTarefa ([FromRoute] int id, [FromServices] AppDbContext context)
        {
            var todos = context.Todos.FirstOrDefault(x => x.Id == id);
                if(todos == null)
                    NotFound();

                return Ok(todos);
        }

        [HttpPost]
        [Route ("")]
        public IActionResult CriarTarefa ([FromServices] AppDbContext context, [FromBody] TodoModel TodoItem)
        {   
            context.Todos.Add(TodoItem);
            context.SaveChanges();

            return Ok(TodoItem);            
        }

        [HttpPut]
        [Route ("{id:int}")]
        public IActionResult AlterarTarefa ([FromRoute] int id, [FromServices] AppDbContext context, [FromBody] TodoModel TodoItem)
        {   
            var model = context.Todos.FirstOrDefault(x => x.Id == id);
            
            if(model == null)
                return NotFound();

            model.Title = TodoItem.Title;
            model.Done = TodoItem.Done;

            context.Todos.Update(model);
            context.SaveChanges();

            return Ok(model);            
        }

        [HttpDelete]
        [Route ("{id:int}")]
        public IActionResult DeletarTarefa ([FromRoute] int id, [FromServices] AppDbContext context)
        {   
            var model = context.Todos.FirstOrDefault(x => x.Id == id);

            if (model == null)
                return NotFound();
            
            context.Todos.Remove(model);
            context.SaveChanges();

            return Ok(model);            
        }
        
    }
}