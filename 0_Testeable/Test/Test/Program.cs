using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime
            DateTime date1 = DateTime.Now;
            DateTime date2 = DateTime.UtcNow;
            DateTime date3 = DateTime.Today;

            Console.WriteLine(date1);
            Console.WriteLine(date2);
            Console.WriteLine(date3);


            //Con formato
            DateTime date4 = new DateTime(2008, 3, 1, 7, 0, 0);
            Console.WriteLine(date4.ToString("yyyy-MM-dd"));

            //Sin formato
            DateTime date5 = new DateTime(2015, 12, 25);
            Console.WriteLine(date5.ToString());

            Console.ReadLine();
        }
    }
}
