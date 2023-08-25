using System.Diagnostics;

namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();
        public string Name { get; private set; }
        public string Surname { get; private set; }

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Value is out of range 0-100.");
            }
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("Invalid string value.");
            }
        }
        public void AddGrade(char grade)
        {
            var gradeParsed = grade.ToString();
            if (float.TryParse(gradeParsed, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("Invalid char value.");
            }
        }

        public void AddGrade(int grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }

        public void AddGrade(double grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }

        public Statistics GetStatisticsWithForEach()
        {
            var stats = new Statistics();
            stats.Average = 0;
            stats.Max = float.MinValue;
            stats.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                stats.Max = Math.Max(stats.Max, grade);
                stats.Min = Math.Min(stats.Min, grade);
                stats.Average += grade;
            }
            stats.Average /= this.grades.Count;
            return stats;

        }

        public Statistics GetStatisticsWithFor()
        {
            var stats = new Statistics();
            stats.Average = 0;
            stats.Max = float.MinValue;
            stats.Min = float.MaxValue;
            
            for (int i = 0; i < this.grades.Count; i++)
            {
                stats.Max = Math.Max(stats.Max, grades[i]);
                stats.Min = Math.Min(stats.Min, grades[i]);
                stats.Average += grades[i];
            }

            stats.Average /= this.grades.Count;
            return stats;
        }

        public Statistics GetStatisticsWithDoWhile()
        {
            var stats = new Statistics();
            stats.Average = 0;
            stats.Max = float.MinValue;
            stats.Min = float.MaxValue;

            int i = 0;
            do
            {
                stats.Max = Math.Max(stats.Max, grades[i]);
                stats.Min = Math.Min(stats.Min, grades[i]);
                stats.Average += grades[i];
                i++;

            } while (i < this.grades.Count);

            stats.Average /= this.grades.Count;
            return stats;
        }

        public Statistics GetStatisticsWithWhile()
        {
            var stats = new Statistics();
            stats.Average = 0;
            stats.Max = float.MinValue;
            stats.Min = float.MaxValue;

            int i = 0;
            while (i < this.grades.Count)
            {
                stats.Max = Math.Max(stats.Max, grades[i]);
                stats.Min = Math.Min(stats.Min, grades[i]);
                stats.Average += grades[i];
                i++;
            }

            stats.Average /= this.grades.Count;
            return stats;
        }

    }

}