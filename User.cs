namespace tema;

public class User
{
    private string username, password, email;

    public User(string username, string pw, string email)
    {
        this.username = username;
        password = pw;
        this.email = email;
    }

    public string GetMail()
    {
        return email;
    }

    public void ChangePassword(string newPassword)
    {
        password = newPassword;
    }

    public override string ToString()
    {
        return username + " " + email;
    }
}