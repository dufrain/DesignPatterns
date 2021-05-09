using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataSource = new DataSource();
            var sheet1 = new Spreadsheet();
            var sheet2 = new Spreadsheet();
            var chart = new Chart();

            dataSource.AddObserver(sheet1);
            dataSource.AddObserver(sheet2);
            dataSource.AddObserver(chart);
            dataSource.SetValue(3);

            Console.ReadKey();
        }
    }
}
