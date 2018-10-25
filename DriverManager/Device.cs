using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Device
    {
       /*ДАННЫЕ
       - готовность к работе
       МЕТОДЫ 
       - проверка совмест имости(с драйвером)*/

        private string name;
        private string type;
        private object driver;

        //public bool readyForWork() // и как ней пользоваться?
        //{
        //    if (DriverOnDevice == null)
        //        return false;
        //    else
        //        return true;
        //}
        
        public Device(string DeviceName, string DeviceType, object o)
        {
            type = DeviceName;
            name = DeviceType;
            driver = o;
        }
        
        
        public object DriverOnDevice { get; set; }
        
        public string DeviceName { get; set; }

        public string DeviceType
        {
            get
            {
                return type;
            }
            set
            {
                if (value == "")
                {
                    throw new ArgumentOutOfRangeException("Отрицательных значений не должно быть!");
                }
                else
                    type = value;
            }
        }

        public override string ToString()
        {
            if (DriverOnDevice == null)
                return "Device: " + DeviceName + ", " + DeviceType + ", null";
            else
                return "Device: " + DeviceName + ", " + DeviceType + ", " + DriverOnDevice.ToString();
        }
    }
}
