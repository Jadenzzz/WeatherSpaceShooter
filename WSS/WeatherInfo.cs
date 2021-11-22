using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace spaces
{
    public class WeatherInfo
    {
        public class weather
        {
            public string main { get; set; }

        }

        public class main
        {
            public double temp { get; set; }

        }

        public class root
        {
            public List<weather> weather { get; set; }
            public main main { get; set; }

        }
    }
}
