using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T>
    {
        T[] tables;

        public MyDictionary()
        {
            tables = new T[0];
        }

        public void Add(T table)
        {
            T[] tempTables = tables;
            tables = new T[tables.Length + 1];

            for (int i = 0; i < tempTables.Length; i++)
            {
                tables[i] = tempTables[i];
            }

            tables[tables.Length - 1] = table;
        
      
        }   
         public T[] table
        {
            get { return tables; }
        }   

    }
}
