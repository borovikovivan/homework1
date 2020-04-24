using System;
using System.Globalization;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args) // Ctrl+K,D
        {
            //Player player1 = new Player();
            //player1.Name = "Иванов";
            //player1.Birthday = new DateTime(1974, 12, 21, 0, 0, 0);

            //Player player1 = new Player("Empty", new DateTime(1987, 12, 12));

            //Console.Write("Введите фамилию >");
            //player1.Name = Console.ReadLine();

            //Console.WriteLine(player1.Name);

            Vector2D v1 = new Vector2D(5, 7);
            Vector2D v2 = new Vector2D(-7, 2);

            Vector2D v3 = v1 + v2;

            Vector2D v4 = v3 + 3.14159265358979;

            //CultureInfo ru = new CultureInfo("ru-ru");
            //CultureInfo en_us = new CultureInfo("en-us");
            //CultureInfo invariant = CultureInfo.InvariantCulture;
            //CultureInfo current = CultureInfo.CurrentCulture;
            //CultureInfo current_ui = CultureInfo.CurrentUICulture;

            //double pi = double.Parse("3.1415", invariant); //Convert.ToDouble("3,1415");
            ////int j = Convert.ToInt32(3.14);
            //int i = (int)pi;

            //Console.WriteLine(pi);

            //double length = v4;

            //Printer printer = new Printer();
            //PrefixPrinter prefix_printer = new PrefixPrinter();
            //prefix_printer.Prefix = "!!!!!!!-------!!!!!!!";

            //prefix_printer.Print("QWE");

            //printer.Print("Hello World!");
            //prefix_printer.PrintData(3.14);

            //printer.Print("123");

            //printer = prefix_printer;

            //Printer printer1 = new PrefixPrinter();

            //printer.Print("345");
            //printer1.Print("678");

            Console.ReadLine();
        }
    }
}
