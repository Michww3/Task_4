using System.Globalization;
using System.Text;
using Task_4;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, double> itemCost = new Dictionary<string, double>
        {
            {"Хлеб", 0.80 },
            {"Молоко", 1.20 },
            {"Яйца", 3.60 },
            {"Сахар", 1.5 },
            {"Соль", 0.50 },
            {"Мука", 2 },
        };
        Dictionary<string, int> itemQuantity = new Dictionary<string, int>
        {
            { "Хлеб", 1 },
            { "Молоко", 2 },
            { "Яйца", 1 },
            { "Сахар", 5 },
            { "Соль", 4 },
            { "Мука", 1 },
        };

        Check check = new Check(itemCost, itemQuantity);
        check.CheckToFile("BYCheck.txt");
        check.CheckToFile("ENCheck.txt", "en-US");

        Console.WriteLine(check.GetText());
        Console.WriteLine(check.GetText("en-US"));
    }
}
