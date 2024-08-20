namespace TodoApi.Models;

public class TodoItem
{
    public long Id { get; set; }
    public string? Todo { get; set; }
    public bool IsDone { get; set; }
    public string? Author { get; set; }
    public DateTime Timestamp { get; set; }
}
