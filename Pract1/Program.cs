using System;

namespace Pract1
{
    class Person
    {
        private string sName;
        private string fName;
        private string patr;
        private float hight;
        private float weight;
        private DateTime bDate;

        public Person(string sName, string fName, string patr, float hight,
            float weight, DateTime bDate)
        {
            this.sName = sName;
            this.fName = fName;
            this.patr = patr;
            this.hight = hight;
            this.weight = weight;
            this.bDate = bDate;
        }

        public Byte getAge()
        {
            return 0;
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}


