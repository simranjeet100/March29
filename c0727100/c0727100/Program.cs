using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace c0727100
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Downloading a file");
            Download();
            Console.ReadLine();
        }

        static async void Download()
        {
            await Network.Download();
            Console.WriteLine("Download Complete");
        }

    }

    class Network
    {
        public async void Download()
        {
            HttpClient client = new HttpClient();
            var data = await client.GetStringAsync("https://torontopubliclibrary.ca");
            Console.WriteLine(data);
        }
    }
}
