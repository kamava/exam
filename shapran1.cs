using System;

namespace Shapran_exemple
{
    class index
    {
         public string str = "X,Y";
        public void y()
        {
            string[] can = str.Split(',');
            Console.WriteLine(can[1]);
        }
        public void x()
        {
            string[] can = str.Split(',');
            Console.WriteLine(can[0]);
        }

    }
    




    
   
   
               
    
    class Program
    {
        static void Main(string[] args)
        {
            index indexator = new index();
            start:
            Console.WriteLine("Paste index 0 for x or 1 for y");
            int res =Convert.ToInt32( Console.ReadLine());
            switch (res)
            {
                case 0:
                    indexator.x();
                    break;
                case 1:
                    indexator.y();
                    break;
                default:
                    Console.WriteLine("Paste correct value");
                   goto start ;

            }
            Console.WriteLine("thx for using");
        }
    }
}


        
