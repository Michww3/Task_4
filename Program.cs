using System.Globalization;
using System.Text;

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
            {"Хлеб", 1 },
            {"Молоко", 2 },
            {"Яйца", 1 },
            {"Сахар", 5 },
            {"Соль", 4 },
            {"Мука", 1 },
        };

        CultureInfo culture = CultureInfo.CurrentCulture;
        DateTime dateTime = DateTime.Now;
        string byCheck = GetText(itemCost, itemQuantity);
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-Us");
        string enCheck = GetText(itemCost, itemQuantity);
        //Console.WriteLine(enCheck+byCheck);
        checkToFile(enCheck,"ENCheck.txt");
        checkToFile(byCheck,"BYCheck.txt");

        string GetText(Dictionary<string, double> itemCost, Dictionary<string, int> itemQuantity)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Дата покупки: {dateTime:F}\n");
            foreach (string item in itemCost.Keys)
            {
                sb.Append($"{item} - {itemCost[item]:C2} * {itemQuantity[item]} = {itemCost[item] * itemQuantity[item]:C2}\n");
            }
            return sb.ToString();
        }

        void checkToFile(string text,string fileName)
        {
            //File.Create("Check.txt");
            File.WriteAllText(fileName, text);
        }
    }
}
