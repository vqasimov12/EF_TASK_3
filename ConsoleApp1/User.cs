namespace ConsoleApp1;
public class User
{
    public int Id { get; set; }
    public string Login { get; set; }
    public string Pswd {  get; set; }
    public bool IsOpen { get; set; } = true;
    public bool Gender { get; set; } = true;
    public DateTime BirthDay {  get; set; }
    public List<Post> Posts { get; set; } = [];
}
