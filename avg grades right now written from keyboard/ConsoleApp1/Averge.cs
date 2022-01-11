using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Averge
    {
        public int[] grade= new int [100], weight =new int[100];
        public double sum = 0, sumtmp = 0, avg = 0;
        public int sumWeight = 0, howmanygrades=0, 
        highestGRade=0, highestGradetmp = 0;

        public void inputGradeNumber()
        {
            Console.Write("Enter a number of grades you have got:");
            howmanygrades = Convert.ToInt32(Console.ReadLine());
            if(howmanygrades < 1)
            {
                Console.WriteLine("Bad data, input must be bigger than 1");
                return;
            }
            Console.WriteLine($" You will have to write {howmanygrades} grades you've got: ");
        }
        public void AvgOverall()
        {
            for (int i = 0; i < howmanygrades; i++)
            {
                Console.Write("Enter grade you have got:");
                grade[i] = Convert.ToInt32(Console.ReadLine());
                if (grade[i] < 1 || grade[i] > 6)
                {
                    Console.WriteLine("Bad data, input must be bigger than 1 and lower than 6");
                    return;
                }
                else
                {
                    Console.Write("Enter weight of this grade:");
                    weight[i] = Convert.ToInt32(Console.ReadLine());
                    if (weight[i] < 1 || grade[i] > 12)
                    {
                        Console.WriteLine("Bad data, input must be bigger than 1 and lower than 12");
                        return;
                    }
                    else
                    {
                        sumWeight = sumWeight + weight[i];
                        sumtmp = grade[i] * weight[i];
                        sum = sum + sumtmp;
                    }
                }
            }
            avg = sum / sumWeight;
        }

        public void showResults()
        {
            Console.WriteLine($"Your average grade is  : {avg}");
            Console.WriteLine($"Your highest grade is: {highestGRade}");
        }
        public void highestGrade()
        {
            for (int i = 0; i < howmanygrades; i++)
            {
                if (grade[i]>highestGradetmp) 
                {
                    highestGRade = grade[i];
                    highestGradetmp = grade[i];
                }
                else
                {

                }
            }
        }
    }
}
