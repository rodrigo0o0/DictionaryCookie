using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryCookie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> cookies = new Dictionary<string,string>();
            cookies["user"] = "Maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "996636643";
            cookies["phone"] = "877854125";
            cookies.Remove("email");
            Console.WriteLine(cookies["phone"]);
            if (cookies.ContainsKey("email"))
                Console.WriteLine(cookies["email"]);
            else
                Console.WriteLine("There is no 'email' key");

            Console.WriteLine("Cookies size : " + cookies.Count);
            Console.WriteLine("ALL COOKIES : ");
            foreach (var item in cookies)
            {
                Console.WriteLine(item.Value);
            }

            Console.ReadKey();

        }
    }
}
