using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace _Csharp1
{
    class Program1
    {
        static void MainX(string[] args)
        {
           var t=GetGoogleSoruceCode().ContinueWith(x=>{
              x.Result.Dump("içi");
           });

           Console.WriteLine("en alt satır");
           
           Console.ReadLine();
        }


        static Task<string> GetGoogleSoruceCode(){
            var httpClient=new HttpClient();

            var  t=Task.Run(()=>{
                return httpClient.GetStringAsync("https://jsonplaceholder.typicode.com/todos/1").Result;
            });

            return t;

        }



    }
}
