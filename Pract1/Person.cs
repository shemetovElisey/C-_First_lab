using System;
namespace Pract1
{
    public class Person
    {
        public string SName { get; }
        public string FName { get; }
        public string Patr { get; }
        public double Hight { get; }
        public double Weight { get; }
        public DateTime Birth { get; }

        public Person(string sName, string fName, string patr, double hight,
            double weight, DateTime birth)
        {
            this.SName = sName;
            this.FName = fName;
            this.Patr = patr;
            this.Hight = hight;
            this.Weight = weight;
            this.Birth = birth;
        }

        public byte GetAge()
        {
            try
            {
                if (DateTime.Now.Month > Birth.Month)
                    return Convert.ToByte(DateTime.Now.Year - Birth.Year);
                else if (DateTime.Now.Year == Birth.Year)
                    return Convert.ToByte(DateTime.Now.Date < Birth.Date ?
                        DateTime.Now.Year - Birth.Year - 1 :
                        DateTime.Now.Year - Birth.Year);
                else return Convert.ToByte(DateTime.Now.Year - Birth.Year - 1);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Возраст больше 255");
                throw;
            }
        }



    }
}
