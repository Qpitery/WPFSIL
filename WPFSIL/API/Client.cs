using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WPFSIL.API
{
    internal class Client
    {
        HttpClient httpClient = new HttpClient();

        private Client()
        {
            httpClient.BaseAddress = new Uri(@"https://localhost:7226/"); 
        }
        static Client Instance = new();
        public static Client Instsans {  get => Instance; }






    }
}
