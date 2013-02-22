using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilPhoneDevices
{
    class Call //Задача 8
    {
        private DateTime dateAndTime;
        private string dialedNumbers;
        private int duration;

        public Call(DateTime dateAndTime, string dialedNumbers, int duration)
        {
            this.dateAndTime = dateAndTime;
            this.dialedNumbers = dialedNumbers;
            this.duration = duration;
        }

        public DateTime DateAndTime
        {
            get { return this.dateAndTime; }
            set { this.dateAndTime = value; }
        }

        public string DialedNumbers
        {
            get { return this.dialedNumbers; }
            set { this.dialedNumbers = value; }
        }

        public int Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }

        public override string ToString()
        {
            return string.Format(" {0}\n {1} - {2:D2}:{3:D2}", this.dialedNumbers, this.dateAndTime, this.duration / 60,
                this.duration % 60);
        }
    }
}
