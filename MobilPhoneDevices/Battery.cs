using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilPhoneDevices
{
    public enum BatteryType // Задача 3
    { LiIon, NiMH, NiCd }

    class Battery
    {
        // Задача 1
        private BatteryType batteryModel;
        private string hoursIdle;
        private string hoursTalk;

        // Задача 5
        BatteryType Model
        {
            get { return this.batteryModel; }
            set { this.batteryModel = value; }
        }

        string HoursIdel
        {
            get { return this.hoursIdle; }
            set { this.hoursIdle = value; }
        }

        string HoursTalk
        {
            get { return this.hoursTalk; }
            set { this.hoursTalk = value; }
        }

        public Battery(BatteryType batteryModel, string hoursIdle, string hoursTalk)
        {            
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
            this.batteryModel = batteryModel;
        }

        // Задача 4
        public override string ToString()
        {
            return string.Format("\n   Batery model: {0}\n   Hours idle: {1}\n   Hours talk: {2}", this.batteryModel,
                this.hoursIdle, this.hoursTalk);
        }
    }
}
