using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_array
{
    class Program
    {
        String[] city = new String[] { "Delhi", "Pune", "Banglore", "Mysore", "Hyderabad" };
        static void Main(string[] args)
            {
                Program p = new Program();
            
                Console.WriteLine("Enter name you want to search...");
                String name = Console.ReadLine();
            
            if (p.city.Contains(name))
                {
                    Console.WriteLine("city found...");
                }
                else
                {
                    Console.WriteLine("city not found...");
                }

                p.SearchWithletter();

                p.oddlength();


        }

        int Searchname(String name)
            {
                int result = -1;
                for (int i = 0; i < city.Length; i++)
                {
                    if (city[i] == name)
                    {
                        result = i;
                        break;
                    }
                    else
                    {
                        result = -1;
                    }
                }
                return result;
            }


            void SearchWithletter()
            {
                int count = 0;
                //String start with 'a' letter...
                for (int i = 0; i < city.Length; i++)
                {
                    if (city[i].Contains('a') || city[i].Contains('A'))
                    {
                        count++;
                    }
                }
                Console.WriteLine("count of string containing 'a' letter is: " + count);
            }


            void oddlength()
            {
                int count = 0;
                for (int i = 0; i < city.Length; i++)
                {
                    if (city[i].Length % 2 == 1)
                    {
                        count++;
                    }
                }
                Console.WriteLine("odd length string count is..." + count);
                Console.ReadKey();


            }
    }
}
