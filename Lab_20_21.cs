using System;

namespace Lab_20_21
{
    internal interface IController
    {
        void TurnOn()
        {
            Console.WriteLine("Turning the device on...");
        }
        void TurnOff()
        {
            Console.WriteLine("Turning the device off...");
        }
        void Pause()
        {
            Console.WriteLine("Pausing the device...");
        }
    }

    internal interface ICount
    {
        double AverageAge();
    }
    internal class TV : IController
    {
        
    }

    internal class Radio : IController
    {
        
    }
    
    internal class Phone : IController
    {
        
    }
    
    internal class PC : IController
    {
        
    }

    internal class BIKS : ICount
    {
        private double[] _studentAge;
        public double AverageAge()
        {
            double value = 0;
            foreach (double i in _studentAge)
                value += i;
            value /= _studentAge.Length;
            return value;
        }
        
        public BIKS(double[] studentAge)
        {
            _studentAge = studentAge;
        }
    }
    
    internal class UIB : ICount
    {
        private double[] _studentAge;
        public double AverageAge()
        {
            double value = 0;
            foreach (double i in _studentAge)
                value += i;
            value /= _studentAge.Length;
            return value;
        }
        
        public UIB(double[] studentAge)
        {
            _studentAge = studentAge;
        }
    }
    
    class Program
    {
        public static void Main()
        {
            IController tvController = new TV();
            tvController.TurnOn();
            tvController.Pause();
            tvController.TurnOff();
            ICount BIKS = new BIKS(new double[] {18, 17, 16, 20});
            Console.WriteLine(BIKS.AverageAge());
        }
    }
}
