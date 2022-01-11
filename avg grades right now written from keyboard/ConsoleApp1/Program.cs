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
            Averge a1 = new Averge();
            a1.inputGradeNumber();
            a1.AvgOverall();
            a1.highestGrade();
            a1.showResults();
        }
    }

}
/*
            int[] grade = new int[100];
            int[] weight = new int[100];
            double sumtmp = 0;
            double sum = 0;
            int sumWeight = 0;
            double avg = 0;
            int howmanygrades;
            Console.Write("Enter a number of grades you have got:");
            howmanygrades = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" You will have to write {howmanygrades} grades you've got: ");
            for (int i = 0; i < howmanygrades; i++)
            {
                Console.Write("Enter grade you have got:");
                grade[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter weight of this grade:");
                weight[i] = Convert.ToInt32(Console.ReadLine());
                sumWeight = sumWeight + weight[i];
                sumtmp = grade[i] * weight[i];
                sum = sum + sumtmp;
            }
            avg = sum / sumWeight;
            Console.WriteLine($"Your average grade is  : {avg}");
            */