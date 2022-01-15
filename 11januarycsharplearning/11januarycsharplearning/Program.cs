using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array1 = new double[100];
            double[] array2 = new double[100];
            double sumatmp = 0;
            double suma = 0, sumaWagi = 0; 
            double srednia = 0;
             int howmanygrades;
            Console.Write("Enter a number of grades you have got:");
            howmanygrades = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" You will have to write {howmanygrades} grades you've got: ");
           for(int i = 0; i < howmanygrades; i++)
            {
                Console.Write("Enter grade you have got:");
                array1[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter weight of this grade:");
                array2[i] = Convert.ToInt32(Console.ReadLine());
                sumaWagi = sumaWagi + array2[i];
                sumatmp = array1[i] * array2[i];
                suma = suma + sumatmp;
            }
            srednia = suma / sumaWagi;
            Console.WriteLine($"Your average grade is  : {srednia}");
        }
    }
}