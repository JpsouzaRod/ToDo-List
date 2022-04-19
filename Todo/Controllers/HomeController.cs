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
        [Route ("Lista")]
        public IActionResult ListarTarefas ([FromServices] AppDbContext context)
        {
            return Ok(context.Tarefas.ToList());
        }

        [HttpGet]
        [Route ("Buscar/{id:int}")]
        public IActionResult BuscarTarefa ([FromRoute] int id, [FromServices] AppDbContext context)
        {
            var tarefa = context.Tarefas.FirstOrDefault(x => x.Id == id);
                if(tarefa == null)
                    NotFound();
                return Ok(tarefa);
        }

        [HttpPost]
        [Route ("Cadastrar")]
        public IActionResult CadastrarTarefa ([FromServices] AppDbContext context, [FromBody] Tarefa tarefa)
        {   
            context.Tarefas.Add(tarefa);
            context.SaveChanges();

            return Ok(tarefa);            
        }

        [HttpPut]
        [Route ("Alterar/{id:int}")]
        public IActionResult AlterarTarefa ([FromRoute] int id, [FromServices] AppDbContext context, [FromBody] string titulo)
        {   
            var model = context.Tarefas.FirstOrDefault(x => x.Id == id);
            
            if(model == null)
                return NotFound();

            model.Titulo = titulo;

            context.Tarefas.Update(model);
            context.SaveChanges();

            return Ok(model);            
        }

        [HttpPut]
        [Route ("Concluir/{id:int}")]
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
        [Route ("Deletar/{id:int}")]
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