using System;

namespace modificatores.dz
{
    class Texnica
    {
        private string Brand;
        protected string Power;
        public string Sostoyanie;

        public string GetBrand
        {
            get { return Brand; }
            set { Brand = value; }
        }

        public string GetPower
        {
            get { return Power; }
            set { Power = value; }
        }

        public void TurnOn(string status)
        {
            status = "on";
            Console.WriteLine("Устройство включено");
        }

        public void TurnOff(string status)
        {
            status = "off";
            Console.WriteLine("Устройство выключено");
        }
    }
    
    

    class Refrigerator : Texnica
    {
        public Refrigerator()
        {
            GetBrand = "Toshiba";
            GetPower = "60v";
            
        }

        Refrigerator(string brand, string power )
        {
            GetBrand = brand;
            GetPower = power;
        }
    }

    class Stiralka : Texnica
    {
        public Stiralka()
        {
            GetBrand = "LG";
            GetPower = "80v";
            
        }

        Stiralka(string brand, string power)
        {
            GetBrand = brand;
            GetPower = power;
            
        }
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            Refrigerator refrigerator = new Refrigerator();
            Stiralka stiralka = new Stiralka();
            Console.WriteLine("Холодильник:"+refrigerator.GetBrand);
            Console.WriteLine("Мошность:"+refrigerator.GetPower);
            refrigerator.TurnOn("on");
            Console.WriteLine("Стиральная машина:"+stiralka.GetBrand);
            Console.WriteLine("Мошность:"+stiralka.GetPower);
            stiralka.TurnOff("off");
        }
    }
}