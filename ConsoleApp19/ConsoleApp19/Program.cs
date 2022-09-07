using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    public class Program
    {
        public class Shop
        {
            public int inputshopname;
            public int inputnumber;
            public int inputshopkeeper;
            public int inputtax;


        }
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            Console.Write("Please input Name:");
            shop.inputshopname = int.Parse(Console.ReadLine());
            Console.Write("Please input number:");
            shop.inputnumber = int.Parse(Console.ReadLine());
            Console.Write("Please input Owner Name:");
            shop.inputshopkeeper = int.Parse(Console.ReadLine());
            Console.Write("Please input Registered Value:");
            shop.inputtax = int.Parse(Console.ReadLine());
            
            
            PrintShopInformation(shop);

            Changmoney money = new Changmoney();
            Console.WriteLine("Please Input Money:");
            money.money = double.Parse(Console.ReadLine());

            Console.WriteLine("1000: {0}", money.Coinc(1000.0));
            Console.WriteLine("500: {0}", money.Coinc(500.0));
            Console.WriteLine("100: {0}", money.Coinc(100.0));
            Console.WriteLine("50: {0}", money.Coinc(50.0));
            Console.WriteLine("20: {0}", money.Coinc(20.0));
            Console.WriteLine("10: {0}", money.Coinc(10.0));
            Console.WriteLine("5: {0}", money.Coinc(5.0));
            Console.WriteLine("2: {0}", money.Coinc(2.0));
            Console.WriteLine("1: {0}", money.Coinc(1.0));
            Console.WriteLine(".50: {0}", money.Coinc(0.50));
            Console.WriteLine(".25: {0}", money.Coinc(0.25));

            Console.ReadLine();

        }

        static void PrintShopInformation(Shop shop)
        {
            Console.WriteLine("----------Shop Information----------");
            Console.WriteLine("Name: {0}", shop.inputshopname);
            Console.WriteLine("Number: {0}",shop.inputnumber);
            Console.WriteLine("Owner name: {0}",shop.inputshopkeeper);
            Console.WriteLine("Registered Value: {0}", shop.inputtax);
            Console.WriteLine("---------------------------------------");
            
            Console.ReadLine();
        }


    }
    public class Changmoney
    {
        public double money;

        public double Coinc(double value)
        {
            double remain = money - (money % value);
            money = money - remain;
            return remain / value;

        }


    }






}




