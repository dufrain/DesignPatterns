using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class Spreadsheet : IObserver
    {
        private DataSource dataSource;

        public Spreadsheet(DataSource dataSource)
        {
            this.dataSource = dataSource;
        }

        public void update()
        {
            Console.WriteLine("Spreadsheet was notified: " + dataSource.GetValue());
        }
    }
}
