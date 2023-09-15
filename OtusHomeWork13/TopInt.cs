using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusHomeWork13
{
    public class TopForInt
    {
        public void TopInt(int count, int percent, int min, int max)
        {
            try
            {
                Console.WriteLine("Вывод элементов коллекции типа int");
                if (count <= 0)
                    throw new ArgumentException("количество элементов должно быть больше нуля");
                if (max <= min)
                    throw new ArgumentException("аргумент max должен быть больше аргумента min");
                int[] ints = new int[count];   
                for (int i = 0; i < ints.Length; i++) 
                {
                    ints[i] = new Random().Next(min, max);
                }
                var result = ints.Top(percent);     
                Console.WriteLine(String.Join<int>(' ', result));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
