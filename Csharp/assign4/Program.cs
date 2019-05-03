using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Program
    {
        public static void Add(New data)
        {
            Console.WriteLine("Nhập ID");
            int Id = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhập Title");
            String title = Console.ReadLine();
            Console.WriteLine("PublishDate");
            String PublishDate = Console.ReadLine();
            Console.WriteLine("Author");
            String Author = Console.ReadLine();
            Console.WriteLine("Content");
            String Content = Console.ReadLine();
            Console.WriteLine("AverageRate ");
            float diemTBcong = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào 3 số");
            int so1 = Int32.Parse(Console.ReadLine());
            int so2 = Int32.Parse(Console.ReadLine());
            int so3 = Int32.Parse(Console.ReadLine());
            int[] RateList = { so1, so2, so3 };
            data.add(new New(Id, title, PublishDate, Author, Content, diemTBcong, RateList));

        }
        public static void Menu()
        {
            Console.WriteLine("1:Insert news");
            Console.WriteLine("2:View list news");
            Console.WriteLine("3:Average rate");
            Console.WriteLine("4:Exit");
        }
        static void Main(string[] args)
        {
            New data = new New();
            Boolean flag = true;
            while (flag)
            {
                Console.WriteLine("1:Insert news");
                Console.WriteLine("2:View list news");
                Console.WriteLine("3:Average rate");
                Console.WriteLine("4:Exit");
                int chon = Int32.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        Add(data);
                        Menu();
                        break;
                    case 2:
                        data.Display();
                        break;
                    case 3:
                        data.Calculate();
                        break;
                    case 4:

                        flag = false;
                        break;

                }


            }

        }
    }
}

