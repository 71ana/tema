namespace tema;

public class Admin
{
    private string name;
    private List<Application> list = new List<Application>();
    
    public Admin(string name)
    {
        this.name = name;
    }

    public string AddUser(User user, Application app)
    {
        app.AddUser(user);
        list.Add(app);
        return "";
    }

    public void RemoveUser(User user, Application app)
    {
        app.RemoveUser(user);
    }
}