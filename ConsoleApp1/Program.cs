using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentAssignments = 5;

            int[] sophiaScores ={90, 86, 87, 98, 100, 94,90};

            int[] nicolasScores = {92, 89, 81, 96, 90, 89};
            
            int[] zahirahScores = { 90, 85, 87, 98, 68, 89, 89, 89};

            int[] jeongScores = {90, 95, 87, 88, 96, 96};
            
            int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
           
            int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
            
            int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
            
            int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
            
            int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
            
            int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
            
            int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };


            string[] studentNames = { "Sophia", "Nicolas", "Zahirah", "Jeong", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };
            
            int[] studentScores = new int[10];

            string currentStudentLetterGrade;

            Console.WriteLine($"\n  Name\t\tMarks\t\tAverage\t\tGrade \n\n");

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

                else if (currentStudent == "Andrew")
                    studentScores = andrewScores;
               
                else if (currentStudent == "Emma")
                    studentScores = emmaScores;
                
                else if (currentStudent == "Logan")
                    studentScores = loganScores;

                else if (currentStudent == "Becky")
                    studentScores = beckyScores;
                
                else if (currentStudent == "Chris")
                    studentScores = chrisScores;
               
                else if (currentStudent == "Eric")
                    studentScores = ericScores;
               
                else if (currentStudent == "Gregor")
                    studentScores = gregorScores;
                
                else
                    continue;


                var sumAssignmentScores = 0;
                int gradedAssignments = 0;

                    foreach (var score in studentScores)
                    {
                    gradedAssignments += 1;

                        if (gradedAssignments <= currentAssignments)
                        sumAssignmentScores += score;
                        else
                        sumAssignmentScores += score/10;
                        
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

                Console.WriteLine($" {currentStudent}:  \t{sumAssignmentScores}\t\t{studentAverage}\t\t{currentStudentLetterGrade}");
                
            }
            
        }
    }
}
