using System.Globalization;

namespace tema;

public abstract class Application
{
    private string nume;
    private User[] util = new User[20];
    private int numberOfUsers = 0;
    private int max;

    public Application(string name, int max)
    {
        nume = name;
        this.max = max;
    }

    public void AddUser(User a)
    {
        if (max <= 20)
        {
            util[numberOfUsers] = a;
            numberOfUsers++;
            Console.WriteLine("user added");
        }
        else
        {
            Console.WriteLine("not enough space");   
        }
    }

    public bool ExistUser(User user)
    {
        for(int i = 0; i < numberOfUsers; i++)
            if (user.Equals(util[i]))
            {
                return true;
            }

        return false;
    }
    public int RemoveUser(User a)
    {
        for (int i = 0; i < numberOfUsers; i++)
            if (a.Equals(util[i]))
            {
                for (int j = i; j < numberOfUsers; j++)
                    util[j] = util[j + 1];
                numberOfUsers--;
                Console.WriteLine("user removed.");
                return 0;
            }

      
        Console.WriteLine("user not found!");
        return 0;
    }

    public string GetName()
    {
        return nume;
    }

    public int GetNumberOfUsers()
    {
        return numberOfUsers;
    }

    public override string ToString()
    {
        return nume + " " + numberOfUsers;
    }
}