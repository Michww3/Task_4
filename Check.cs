using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Task_4
{
    internal class Check
    {
        private Dictionary<string, double> itemCost = new();
        private Dictionary<string, int> itemQuantity = new();

        public Check(Dictionary<string, double> cost, Dictionary<string, int> quantity)
        {
            this.itemCost = cost;
            this.itemQuantity = quantity;
        }

        private DateTime dateTime = DateTime.Now;
        private StringBuilder sb = new StringBuilder();

        internal string GetText(string culture = "ru-BY")
        {
            CultureInfo.CurrentCulture = new CultureInfo(culture);
            sb.Clear();
            sb.Append($"Дата покупки: {dateTime:F}\n");
            foreach (string item in itemCost.Keys)
            {
                sb.Append($"{item} - {itemCost[item]:C2} * {itemQuantity[item]} = {itemCost[item] * itemQuantity[item]:C2}\n");
            }
            return sb.ToString();
        }

        internal void CheckToFile(string fileName, string culture = "ru-BY")
        {
            File.WriteAllText(fileName, GetText(culture));
        }
    }
}
