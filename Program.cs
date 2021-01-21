using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> _tables = new MyDictionary<string>();
            _tables.Add("Customer");
            _tables.Add("Assets");
            _tables.Add("Payment");
            _tables.Add("Relation");


            foreach (var item in _tables.table)
            {
                Console.WriteLine(item);
            }
        }
    }
}
