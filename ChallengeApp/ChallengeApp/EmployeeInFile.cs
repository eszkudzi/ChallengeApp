﻿namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        public override event GradeAddedDelegate GradeAdded;
        private const string fileName = "grades.txt";
        public EmployeeInFile(string name, string surname) : base(name, surname) { }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Value is out of range 0-100.");
            }
        }
        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                throw new Exception("Invalid string value.");
            }
        }
        public override void AddGrade(int grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }
        public override void AddGrade(double grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }
        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    this.AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    this.AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    this.AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    this.AddGrade(20);
                    break;
                default:
                    throw new Exception("Incorrect grade.");
            }
        }
        public override Statistics GetStatistics()
        {
            var gradesFromFile = this.ReadGradesFromFile();
            var stats = new Statistics();
            foreach (var grade in gradesFromFile)
            {
                stats.AddGrade(grade);
            }
            return stats;
        }
        private List<float> ReadGradesFromFile()
        {
            var grades = new List<float>();
            if (File.Exists($"{fileName}"))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        grades.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return grades;
        }
    }
}
