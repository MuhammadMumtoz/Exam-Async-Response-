using Microsoft.AspNetCore.Http;
public enum Status
{
    notDone,
    inProgress,
    completed
}
public class AddTodoDto
{
    public int Id { get; set; }
    public string TaskName { get; set; }
    public List<IFormFile> Files { get; set; }
    public Status Status { get; set; }
}
public class GetTodoDto
{
    public int Id { get; set; }
    public string TaskName { get; set; }
    public List<string> Files { get; set; }
    public Status Status { get; set; }
    public GetTodoDto()
    {
        Files = new List<string>();
    }
}
