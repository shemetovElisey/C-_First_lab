using System;
namespace Pract1
{
   public class Person
   {
      public string SName { get; }
      public string FName { get; }
      public string MName { get; }
      public double Hight { get; }
      public double Weight { get; }
      public DateTime BirthDate { get; }

      public Person(string sName, string fName, string mName, double hight,
          double weight, DateTime birth)
      {
         this.SName = sName;
         this.FName = fName;
         this.MName = mName;
         this.Hight = hight;
         this.Weight = weight;
         this.BirthDate = birth;
      }

      public byte GetAge()
      {
         try
         {
            int age = DateTime.Now.Year - BirthDate.Year;

            if (DateTime.Now.Month > BirthDate.Month)
               return Convert.ToByte(age);
            else
               return Convert.ToByte(DateTime.Now.Date < BirthDate.Date ?
                  age - 1 : age);
         }

         catch (OverflowException)
         {
            Console.WriteLine("Возраст больше 255 или меньше 0");
            throw;
         }
      }
   }
}
