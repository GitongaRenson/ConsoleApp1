using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentAssignments = 5;

            int[] sophiaScores ={100, 98, 98, 98, 100};

            int[] nicolasScores = {80, 83, 82, 88, 85 };
            
            int[] zahirahScores = { 84, 96, 73, 85, 79 };

            int[] jeongScores = {90, 92, 98, 100, 97 };

            string[] studentNames = { "Sophia", "Nicolas", "Zahirah", "Jeong" };
            int[] studentScores = new int[10];
            string currentStudentLetterGrade;

            Console.WriteLine($"\nName\t\tMarks\t\tAverage\t\tGrade \n\n");

            foreach (string name in studentNames)
            {
                string currentStudent = name;
                if (currentStudent == "Sophia")
                    studentScores = sophiaScores;

                else if(currentStudent == "Nicolas")
                    studentScores = nicolasScores;

                else if(currentStudent == "Zahirah")
                    studentScores = zahirahScores;

                else if(currentStudent == "Jeong")
                    studentScores = jeongScores;
                    
               
                
                
                
                var sumAssignmentScores = 0;
                   

                    foreach (var score in studentScores)
                    {

                        sumAssignmentScores += score;
                    }

                    var studentAverage = (decimal)sumAssignmentScores / currentAssignments;
                if (studentAverage > 97)
                    currentStudentLetterGrade = "A+";
                else if (studentAverage >= 93)
                    currentStudentLetterGrade = "A";

                else if (studentAverage >= 90)
                    currentStudentLetterGrade = "A-";

                else if (studentAverage >= 87)
                    currentStudentLetterGrade = "B+";

                else if (studentAverage >= 83)
                    currentStudentLetterGrade = "B";

                else if (studentAverage >= 80)
                    currentStudentLetterGrade = "B-";

                else if (studentAverage >= 77)
                    currentStudentLetterGrade = "C+";

                else if (studentAverage >= 73)
                    currentStudentLetterGrade = "C";

                else if (studentAverage >= 70)
                    currentStudentLetterGrade = "C-";

                else if (studentAverage >= 67)
                    currentStudentLetterGrade = "D+";

                else if (studentAverage >= 63)
                    currentStudentLetterGrade = "D";

                else if (studentAverage >= 60)
                    currentStudentLetterGrade = "D-";

                else
                    currentStudentLetterGrade = "F";

                Console.WriteLine($" {currentStudent}: \t{sumAssignmentScores}\t\t{studentAverage}\t\t{currentStudentLetterGrade}");
                
            }
            
        }
    }
}
