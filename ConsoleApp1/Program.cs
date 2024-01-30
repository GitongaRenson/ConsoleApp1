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

            Console.WriteLine($"\n  Name\t\tExam Score\tExtra Credit\t     Overall Score     Grade \n\n");

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
                var examAverage = 0;
                decimal extraCrediScores = 0;
                var numberOfExtraCredits = studentScores.Length - currentAssignments;

                    foreach (var score in studentScores)
                    {
                    gradedAssignments += 1;

                        if (gradedAssignments <= currentAssignments)
                        sumAssignmentScores += score;
                        //examAverage = sumAssignmentScores;
                        else
                        extraCrediScores += score/(numberOfExtraCredits);

                        
                    }

                    var examScore = (decimal)sumAssignmentScores / currentAssignments;
                var extraCreditValue = ((extraCrediScores/ currentAssignments)/10)* numberOfExtraCredits;
                var overallGradeScore = examScore + extraCreditValue;
                
                if (examScore > 97)
                    currentStudentLetterGrade = "A+";
                
                else if (examScore >= 93)
                    currentStudentLetterGrade = "A";

                else if (examScore >= 90)
                    currentStudentLetterGrade = "A-";

                else if (examScore >= 87)
                    currentStudentLetterGrade = "B+";

                else if (examScore >= 83)
                    currentStudentLetterGrade = "B";

                else if (examScore >= 80)
                    currentStudentLetterGrade = "B-";

                else if (examScore >= 77)
                    currentStudentLetterGrade = "C+";

                else if (examScore >= 73)
                    currentStudentLetterGrade = "C";

                else if (examScore >= 70)
                    currentStudentLetterGrade = "C-";

                else if (examScore >= 67)
                    currentStudentLetterGrade = "D+";

                else if (examScore >= 63)
                    currentStudentLetterGrade = "D";

                else if (examScore >= 60)
                    currentStudentLetterGrade = "D-";

                else
                    currentStudentLetterGrade = "F";

                Console.WriteLine($" {currentStudent}:  \t {examScore}\t\t{extraCrediScores}({extraCreditValue}pts)\t\t{overallGradeScore}\t\t{currentStudentLetterGrade}");
                
            }
            
        }
    }
}
