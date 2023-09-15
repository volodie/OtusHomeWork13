using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusHomeWork13
{
    internal class TopPersons
    {
        public void TopPeople(int count, int percent, int min, int max)
        {
            try
            {
                Console.WriteLine("Вывод элементов коллекции типа Person");
                if (count <= 0)
                    throw new ArgumentException("количество элементов должно быть больше нуля");
                if (max <= min)
                    throw new ArgumentException("аргумент max должен быть болше аргумента min");
                Person[] people = new Person[count];     
                for (int i = 0; i < people.Length; i++) 
                {
                    people[i] = new Person() { Age = new Random().Next(min, max) };
                }
                var peoples = people.Top(percent, x => x.Age);  

                foreach (var person in peoples)         
                    Console.Write(person.Age + " ");
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
