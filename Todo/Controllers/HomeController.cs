using Microsoft.AspNetCore.Mvc;
using ToDo.Data;
using ToDo.Models;

namespace ToDo.Controllers
{   
    [ApiController]
    [Route ("home")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        [Route ("listar")]
        public IActionResult ListarTarefas ([FromServices] AppDbContext context)
        {
            return Ok(context.Tarefas.ToList());
        }

        [HttpGet]
        [Route ("buscar/{id:int}")]
        public IActionResult BuscarTarefa ([FromRoute] int id, [FromServices] AppDbContext context)
        {
            var tarefa = context.Tarefas.FirstOrDefault(x => x.Id == id);
                if(tarefa == null)
                    NotFound();
                return Ok(tarefa);
        }

        [HttpPost]
        [Route ("cadastrar")]
        public IActionResult CadastrarTarefa ([FromServices] AppDbContext context, [FromBody] Tarefa tarefa)
        {   
            context.Tarefas.Add(tarefa);
            context.SaveChanges();

            return Ok(tarefa);            
        }

        [HttpPut]
        [Route ("alterar")]
        public IActionResult AlterarTarefa ([FromServices] AppDbContext context, [FromBody] Tarefa tarefa)
        {   
            var model = context.Tarefas.FirstOrDefault(x => x.Id == tarefa.Id);
            
            if(model == null)
                return NotFound();

            model.Titulo = tarefa.Titulo;

            context.Tarefas.Update(model);
            context.SaveChanges();

            return Ok(model);            
        }

        [HttpPut]
        [Route ("concluir/{id:int}")]
        public IActionResult ConcluirTarefa ([FromRoute] int id, [FromServices] AppDbContext context)
        {   
            var model = context.Tarefas.FirstOrDefault(x => x.Id == id);
            
            if(model == null)
                return NotFound();

            model.Concluido = true;

            context.Tarefas.Update(model);
            context.SaveChanges();

            return Ok(model);            
        }

        [HttpDelete]
        [Route ("deletar/{id:int}")]
        public IActionResult DeletarTarefa ([FromRoute] int id, [FromServices] AppDbContext context)
        {   
            var model = context.Tarefas.FirstOrDefault(x => x.Id == id);

            if (model == null)
                return NotFound();
            
            context.Tarefas.Remove(model);
            context.SaveChanges();

            return Ok(model);            
        }
        
    }
}