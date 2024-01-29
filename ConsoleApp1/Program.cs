using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // initialize variables - graded assignments 
            /*
            Student     Grade
            Sophia      94.6  A
            Nicolas     83.6  B
            Zahirah     83.4  B

            Jeong       95.4  A
            */
            var currentAssignments = 5;

            var sophia1 = 93;
            var sophia2 = 87;
            var sophia3 = 98;
            var sophia4 = 95;
            var sophia5 = 100;

            var nicolas1 = 80;
            var nicolas2 = 83;
            var nicolas3 = 82;
            var nicolas4 = 88;
            var nicolas5 = 85;

            var zahirah1 = 84;
            var zahirah2 = 96;
            var zahirah3 = 73;
            var zahirah4 = 85;
            var zahirah5 = 79;

            var jeong1 = 90;
            var jeong2 = 92;
            var jeong3 = 98;
            var jeong4 = 100;
            var jeong5 = 97;

            //Calculating the sum marks for each student.
            var sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
            var nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
            var zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
            var jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

            //Calculating the Average marks for each student
            var sophiaAverage = (decimal)sophiaSum / currentAssignments;
            var nicolasAverage = (decimal)nicolasSum / currentAssignments;
            var zahirahAverage = (decimal)zahirahSum / currentAssignments;
            var jeongAverage = (decimal)jeongSum / currentAssignments;

            // Using an If statement to determine the grade of each student.

            Console.WriteLine($" Name\t\tMarks  Average\t  Grade \n\nSophia:\t\t {sophiaSum}\t{sophiaAverage} \t\tA \nNicolas:\t {nicolasSum}\t{nicolasAverage} \t\tB \nZahirah:\t {zahirahSum}\t{zahirahAverage} \t\tB \nJeong:\t\t {jeongSum}\t{jeongAverage} \t\tA");
        }
    }
}
