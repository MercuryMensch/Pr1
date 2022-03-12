using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class lib
    {
        public string name { get; set; }
        public string address { get; set; }
        public int year { get; set; }
        public void Print()
        {
            Console.WriteLine($"имя: {name}  адрес: {address} год основания: {year}");
        }
        static void Main(string[] args)
        { 
            lib Nan = new lib();
            Nan.name = "Billy";
            Nan.address = "Hruzkogo street 24";
            Nan.year = 1;
            Nan.Print();
            Console.ReadKey();

        }
    }
}
