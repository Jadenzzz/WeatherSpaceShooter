using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;


namespace spaces
{
    class Weather
    {
        private Weather() { }
        public string weathercond;
        public string temp;
        private static Weather instance;

        public static Weather getInstance()
        {
            if (instance == null)
                instance = new Weather();
            return instance;
        }

        public string Cond
        {
            get
            {
                return weathercond;
            }
            set
            {
                weathercond = value;
            }
        }

        public string Temp
        {
            get
            {
                return temp;
            }
            set
            {
                temp = value;
            }
        }
        string APIkey = "362315e1d9a59b58721e9b0a2128196a";
        public string city = "Melbourne";
        public void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", city, APIkey);
                var json = web.DownloadString(url);//download a JSON docs from web
                var result = JsonConvert.DeserializeObject<WeatherInfo.root>(json);//deserialize JOSN docs
                WeatherInfo.root Info = result;
                this.Cond = Info.weather[0].main;
                this.Temp = Info.main.temp.ToString();
            }
        }
    }
}
