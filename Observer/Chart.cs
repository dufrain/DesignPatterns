using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class Chart : IObserver
    {
        private DataSource dataSource;

        public Chart(DataSource dataSourc)
        {
            this.dataSource = dataSourc;
        }

        public void update()
        {
            Console.WriteLine("Chart was updated: " + dataSource.GetValue());
        }
    }
}
