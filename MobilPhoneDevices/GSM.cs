using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilPhoneDevices
{
    class GSM
    {
        private Battery battery; // Задача 1
        private Display display;
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int? Price { get; set; }
        public string Owner { get; set; }

        private List<Call> calls = new List<Call>(); // Задача 9
        public List<Call> CallHistory
        {
            get { return this.calls; }
            set { this.calls = value; }
        }

        // Задача 2
        public GSM(string model, string manufacturer, int price, string owner, Battery battery, Display display)
        {
            Model = model;
            Manufacturer = manufacturer;
            Price = price;
            Owner = owner;
            this.battery = battery;
            this.display = display;
        }

        public GSM(string model, string manufacturer, int price)
        {
            Model = model;
            Manufacturer = manufacturer;
            Price = price;
            Owner = null;
            this.battery = null;
            this.display = null;
        }

        public GSM(string model, string manufacturer, string owner)
        {
            Model = model;
            Manufacturer = manufacturer;
            Price = null;
            Owner = owner;
            this.battery = null;
            this.display = null;
        }

        public GSM(string model, string manufacturer, Battery battery, Display display)
        {
            Model = model;
            Manufacturer = manufacturer;
            Price = null;
            Owner = null;
            this.battery = battery;
            this.display = display;
        }

        // Задача 6
        static GSM iphone4S = new GSM("iPhone 4S", "Apple", 800, "Nakov", new Battery(BatteryType.NiMH, "36 hours", "8 hours"),
            new Display("50, 110, 6", "Black"));

        public static GSM IPhone4S
        {
            get { return iphone4S; }
        }

        // Задача 10
        public void AddCall(DateTime dateAndTime, string number, int duration)
        {
            Call newCall = new Call(dateAndTime, number, duration);
            calls.Add(newCall);
        }

        public void DeleteCall(int index)
        {
            calls.Remove(calls[index]);
        }

        public void ClearCalls()
        {
            calls.Clear();
        }
        // Задача 11
        public double CalcTotalPrice(double pricePerMinute)
        {
            double sum = 0;
            foreach (var call in calls)
            {
                sum += call.Duration;
            }

            return pricePerMinute * (sum / 60);
        }
        // Задача 12
        public void PrintCalls()
        {
            Console.Write("Calls: ");
            if (calls.Count == 0)
            {
                Console.WriteLine("Empty!");
            }
            Console.WriteLine();
            foreach (var call in calls)
            {
                Console.WriteLine(call);
            }
        }

        public int GetLongestCall()
        {
            int longestCall = 0;
            int index = 0;
            for (int i = 0; i < calls.Count; i++)
            {
                if (longestCall < calls[i].Duration)
                {
                    longestCall = calls[i].Duration;
                    index = i;
                }
            }
            return index;
        }

        // Задача 4
        public override string ToString()
        {
            return "GSM:\n Model: " + Model + "\n Mannufacturer: " + Manufacturer + "\n Price: " + Price
                + "\n Owner: " + Owner + "\n Battery: " + this.battery + "\n Display: " + this.display;
        }
    }
}
