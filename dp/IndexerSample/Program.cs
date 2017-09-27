using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerSample
{
    class Program
    {
        private string[] nameList = new string[size];
        static public int size = 10;
        public Program()
        {
            for(int i=0;i<size;i++)
            {
                nameList[i] = "N. A. ";
            }
        }

        public string this[int index]
        {
            get
            {
                string tmp;
                if (index >= 0 && index <= size-1)
                {
                    tmp = nameList[index];
                }
                else
                {
                    tmp = "";
                }
                return (tmp);
            }
            set
            {
                if(index >= 0 && index <= size-1)
                {
                    nameList[index] = value;
                }
            }
        }

        public int this[string name]
        {
            get
            {
                int index = 0;
                while(index < size)
                {
                    if(nameList[index] == name)
                    {
                        return index;
                    }
                    index++;
                }
                return index;
            }
        }

        static void Main(string[] args)
        {
            Program names = new Program();
            names[0] = "Zara";
            names[1] = "Rix";
            names[2] = "Nuha";

            for(int i = 0;i<Program.size;i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine(names["Nuha"]);
            Console.ReadKey();
        }
    }
}
