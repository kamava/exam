using System;

namespace Shapran_exemple3
{
    
    class first
    {
        
        protected object[] ar;
        protected int Leng;

        public first(int Size)
        {
            ar = new object[Size];
            Leng = Size;

        }
       public void res()
        {
            first a1 = new first(Size: 5);
            a1[0] = 5;
            a1[1] = 10;
            a1[2] = 15;
            a1[3] = 20;
            a1[4] = 25;
            for (int i = 0; i < 5; i++)
                Console.Write("{0}\t", a1[i]);
            Console.WriteLine("\nSize - {0}", a1.Leng);
        }
        private object this[int index]
        {
            set
            {
                ar[index] = value;
            }
            get
            {
                return ar[index];
            }

    }  }
    class second : first
    {
        public second(int Size) : base(Size)
        {
        }
        string v = "Some message";
      
        public char this[char index]
        {
            get
            {
                return v[Convert.ToChar(index.ToString()) ];
            }
            set
            {
                string p = v.Insert(5, "text");
                 
            }
        }
        public void size()
        {
            first a = new first(Size: 4);
            a[0] = "S";
            a[1] = "O";
            a[2] = "M";
            a[3] = "E";
            for (int i = 0; i < 5; i++)
                Console.Write("{0}\t", a[i]);
            Console.WriteLine("\nSize - {0}", a.Leng);
        }






    }
    class Program
    {
        static void Main(string[] args)
        {

            first a1 = new first(Size: 5);
            a1.res();
            second a = new second(Size: 4);
            a.size();
           
        }
    }
}
