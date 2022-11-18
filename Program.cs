// See https://aka.ms/new-console-template for more information

using tema;

Console.WriteLine("admin: ");
string nume = Console.ReadLine();
Admin a = new Admin(nume);

User u1 = new User("idk", "12345", "idk@gmail.com");
User u2 = new User("ale", "do not", "hi@yahoo.com");

WebApplication a1 = new WebApplication("axa", 20);
MobileApplication a2 = new MobileApplication("ham", 19);

a.AddUser(u1,a1);
a.AddUser(u2,a1);
a.AddUser(u1,a2);
a.AddUser(u2,a2);

a1.HttpRequest(u2);
Console.WriteLine(a1.GetNumberOfUsers());

a2.RemoveUser(u2);

Console.WriteLine(a1.ToString());