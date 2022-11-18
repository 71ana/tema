namespace tema;

public class WebApplication : Application
{
    public WebApplication(string nume, int max) : base(nume, max) {}
    
    public void HttpRequest(User user)
    {
        if(ExistUser(user))
            Console.WriteLine("ok request");
        else
        {
            Console.WriteLine("bad request");
        }
    }
}