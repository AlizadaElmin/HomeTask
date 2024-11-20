using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApp.Data;
using TodoApp.Models;

namespace TodoApp.Controllers;

public class TodoController:Controller
{
    public async Task<IActionResult> Index()
    {
        using (Ab108todosContext context = new())
        {
            return View(await context.Todos.ToListAsync());
        }
    }
    [HttpGet]
    public async Task<IActionResult> Create()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Create(Todo todo)
    {
        using (Ab108todosContext context = new())
        {
            await context.Todos.AddAsync(todo);
            await context.SaveChangesAsync();
        }
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Delete(int? id)
    {
        if(!id.HasValue) return BadRequest();
        using (Ab108todosContext context = new())
        {
            if (await context.Todos.AnyAsync(t => t.Id == id))
            {
                context.Todos.Remove(new Todo { Id = id.Value });
                await context.SaveChangesAsync();
            }
        }

        return RedirectToAction(nameof(Index));
    }
    
    [HttpGet]
    public async Task<IActionResult> Update(int? id)
    {
        if(!id.HasValue) return BadRequest();
        using (Ab108todosContext context = new())
        {
            Todo data = await context.Todos.FindAsync(id.Value);
            if (data is null) return NotFound();
            return View(data);
        }
    }
    [HttpPost]
    public async Task<IActionResult> Update(int? id, Todo todo)
    {
        if(!id.HasValue) return BadRequest();
        using (Ab108todosContext context = new())
        {
            Todo entity = await context.Todos.FindAsync(id.Value);
            if (entity is null) return NotFound();
            entity.Title=todo.Title;
            entity.Description=todo.Description;
            entity.Deadline = todo.Deadline;
            entity.IsDone=todo.IsDone;
            await context.SaveChangesAsync();
        }

        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Details(int? id)
    {
        if (!id.HasValue) return BadRequest();
        using (Ab108todosContext context = new())
        {
            var todo = await context.Todos.FindAsync(id.Value);
            if (todo is null) return NotFound();
            return View(todo);
        }
      
    }
}