namespace ConsoleApp1;
public class Post
{
    public int Id { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;
    public string? Text { get; set; }
    public string ImagePath { get; set; }
}
