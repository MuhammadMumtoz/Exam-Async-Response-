using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]

public class ToDoController 
{
    private readonly ToDoService _toDoService;
    public ToDoController(ToDoService toDoService){
        _toDoService = toDoService;
    }

[HttpPost("AddToDo")]
public async Task<GetTodoDto> AddToDo([FromForm]AddTodoDto todoDto)
{
    return await _toDoService.AddTodo(todoDto);
}


}