using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace _Csharp1
{
    class Program
    {
        static void Main(string[] args)
        {
           var t=GetGoogleSoruceCode();
           Console.WriteLine("main en alt satır");
           
           Console.ReadLine();
        }


        static async Task GetGoogleSoruceCode(){
            var httpClient=new HttpClient();
            var result= await httpClient.GetStringAsync("https://jsonplaceholder.typicode.com/todos/1");

            Console.WriteLine(result);
           
          }



    }
}
