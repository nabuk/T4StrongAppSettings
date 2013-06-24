using System;
using System.Collections.Generic;
using System.Configuration;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace T4StrongAppSettings
{
    class Program
    {
        static void Main(string[] args)
        {
            var settings = new AppSettings();

            Console.WriteLine(settings.FirstName);
            Console.WriteLine(settings.LastName);
            Console.WriteLine(settings.Birth);

            Console.ReadLine();
        }
    }
}
