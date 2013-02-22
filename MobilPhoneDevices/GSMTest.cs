using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilPhoneDevices
{
    class GSMTest
    {
        static void Main(string[] str)
        {
            // Задача 7
            GSM[] gsmList = new GSM[3];
            gsmList[0] = new GSM("iPhone 5", "Apple", 1000, "Vasil Lazarov", new Battery(BatteryType.LiIon, "40 Hours", "9 Hours"),
                new Display("50, 120, 6", "White"));
            gsmList[1] = new GSM("Galaxy Ace", "Samsung", 800);
            gsmList[2] = new GSM("C7", "Nokia", new Battery(BatteryType.NiCd, "48 Hours", "12 Hours"),
                new Display("45, 105, 5", "Black"));
            Console.WriteLine(GSM.IPhone4S);
            
            foreach (var phone in gsmList)
            {
                Console.WriteLine(phone);
                Console.WriteLine();
            }
            // Задача 12
            gsmList[2].AddCall(new DateTime(2013, 02, 11, 12, 31, 42), "+3958848286", 41);
            gsmList[2].AddCall(new DateTime(2013, 02, 13, 22, 1, 2), "+39588325424", 167);
            gsmList[2].AddCall(new DateTime(2013, 02, 14, 8, 43, 18), "+3958848286", 134);

            gsmList[2].PrintCalls();
            Console.WriteLine("\n Total price is {0:F2} lv.\n", gsmList[2].CalcTotalPrice(0.37));
            int indexOfLongestCall = gsmList[2].GetLongestCall();
            gsmList[2].DeleteCall(indexOfLongestCall);
            gsmList[2].PrintCalls();
            Console.WriteLine("\n New total price is {0:F2} lv.\n", gsmList[2].CalcTotalPrice(0.37));
            gsmList[2].ClearCalls();
            gsmList[2].PrintCalls();
        }
    }
}
