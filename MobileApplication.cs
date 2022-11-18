namespace tema;

public class MobileApplication : Application
{
    public MobileApplication(string nume, int max) : base(nume, max) {}

    private double rating = 0;

    public double RateApp()
    {
        for (int i = 0; i < GetNumberOfUsers(); i++)
        {
            Console.Write("da o nota aplicatiei: ");
            int nota = Convert.ToInt32(Console.ReadLine());
            rating += nota;
        }

        return rating / GetNumberOfUsers();
    }
}