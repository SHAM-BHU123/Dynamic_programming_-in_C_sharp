using System;

namespace Dynamic_programming__in_C_sharp
{
    abstract class shape
    {

        public abstract int area();

    }

    class rectangle : shape {
        private int length;
        private int breath;

        public rectangle(int l = 0, int b = 0){

             length = l;
             breath = b;
    }

        public override int area()
        {
            return length * breath;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            rectangle r = new rectangle(2,3);
            double s = r.area();
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
