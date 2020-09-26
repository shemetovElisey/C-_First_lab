using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace Pract1
{
   class Program
   {
      static void Main(string[] args)
      {
         List<Person> people = new List<Person>();

         using StreamReader inF = new StreamReader("in.txt", Encoding.UTF8);
         try
         {
            while (inF.Peek() != -1)
            {
               string[] things = inF.ReadLine().Split(' ');
               people.Add(new Person(things[0], things[1], things[2],
                   (float)Convert.ToDouble(things[3]),
               (float)Convert.ToDouble(things[4]),
               DateTime.ParseExact(things[5], "dd/MM/yyyy",
               System.Globalization.CultureInfo.InvariantCulture)));
            }
         }
         catch (FormatException)
         {
            Console.WriteLine("Данные введенны неверно");
            throw;
         }

         Console.WriteLine("Выберите направление сортировки\nПо возрастанию: 1\n" +
             "По убыванию: 2");
         string flag = Console.ReadLine();

         if (Convert.ToInt32(flag) == 1)
            people.Sort((x, y) => x.SName.CompareTo(y.SName));
         else
            people.Sort((x, y) => y.SName.CompareTo(x.SName));

         FileStream output = File.OpenWrite("out.txt");
         using StreamWriter f = new StreamWriter(output, Encoding.UTF8);
         {
            CultureInfo ruRU = new CultureInfo("ru-RU");
            foreach (Person person in people)
               f.WriteLine($"{person.SName,-18}{person.FName,-18}" +
                   $"{person.MName,-18}{person.GetAge(),-9}" +
                   $"{person.Weight,-13:e3}" +
                   $"{person.BirthDate.ToString("dd MMMM yyyy", ruRU).ToLower()}");
         }
      }
   }
}


