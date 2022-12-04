using Microsoft.AspNetCore.Hosting;

public class ToDoService{
    private readonly DapperContext _context;
    private readonly IWebHostEnvironment _hostEnvironment;
    public ToDoService(IWebHostEnvironment hostEnvironment){
        _hostEnvironment = hostEnvironment;
    }
    public async Task<GetTodoDto> AddTodo(AddTodoDto todo){
        var response = new GetTodoDto(){
            Id = todo.Id,
            TaskName = todo.TaskName,
            Status = todo.Status
        };
        var path = Path.Combine(_hostEnvironment.WebRootPath, "images");
        if (Directory.Exists(path) == false)
        {
            Directory.CreateDirectory(path);
        }
        foreach (var file in todo.Files){
            response.Files.Add(file.FileName);
            var filePath = Path.Combine(path,file.FileName);
            using(var stream = File.Create(filePath)){
                await file.CopyToAsync(stream);
            }
        }
        return response;
    }


}