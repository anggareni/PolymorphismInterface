using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismInterface
{
    class Program
    {
        public static void Main(string[] args)
        {
            IPrinterWindows printer;

            Console.WriteLine("Pilih Printer : ");
            Console.WriteLine("1.Epson");
            Console.WriteLine("2.Canon");
            Console.WriteLine("3.LaserJet");

            Console.Write("Pilih Printer [1...3] : ");
            int pilihPrinter = Convert.ToInt32(Console.ReadLine());

            if (pilihPrinter == 1)
                printer = new Epson();
            else if (pilihPrinter == 2)
                printer = new Canon();
            else
                printer = new LaserJet();

            printer.Show();
            printer.Print();

            Console.ReadKey();
        }
    }
}