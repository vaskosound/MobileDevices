using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilPhoneDevices
{
    class Display
    {
        // Задача 1
        private string size;
        private string color;

        public Display(string size, string color)
        {
            this.size = size;
            this.color = color;
        }
        // Задача 5
        string Size
        {
            get { return this.size; }
            set { this.size = value; }
        }

        string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        // Задача 4
        public override string ToString()
        {
            return string.Format("\n   Size: {0}\n   Color: {1}", this.size, this.color);
        }
    }
}
