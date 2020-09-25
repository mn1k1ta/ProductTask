using ConsoleApp11.Model;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string numb;
            do
            {
                Console.WriteLine("--------");
                Console.WriteLine("1--Send");
                Console.WriteLine("2--Exit");
                Console.WriteLine("--------");
                numb = Console.ReadLine();
                if (numb == "1")
                {
                    PrintResult.Print(await HttpService.HttpGetAsync<Result>("http://tester.consimple.pro"));
                }
                if (numb == "2")
                {
                    break;
                }
            } while (true);
        }                               
    }
}
