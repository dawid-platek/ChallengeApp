﻿namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        private List<float> grades = new List<float>();

        public Supervisor(string name, string surname, char sex)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;

        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public char Sex { get; private set; }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Invalid grade value.");
            }
        }

        public void AddGrade(int grade)
        {

            float value = grade;
            this.AddGrade(value);
        }

        public void AddGrade(double grade)
        {

            float value = (float)grade;
            this.AddGrade(value);
        }

        public void AddGrade(long grade)
        {

            float value = (float)grade;
            this.AddGrade(value);
        }

        public void AddGrade(char grade)
        {

            switch (grade)
            {
                case 'A':
                case 'a':
                    AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    AddGrade(20);
                    break;
                default:
                    throw new Exception("Wrong Letter");
            }
        }

        public void AddGrade(string grade)
        {
            switch (grade)
            {
                case "6":
                    this.AddGrade(100);
                    break;
                case "5":
                    this.AddGrade(80);
                    break;
                case "4":
                    this.AddGrade(60);
                    break;
                case "3":
                    this.AddGrade(40);
                    break;
                case "3-":
                    this.AddGrade(35);
                    break;
                case "-3":
                    this.AddGrade(35);
                    break;
                case "2+":
                    this.AddGrade(25);
                    break;
                case "+2":
                    this.AddGrade(25);
                    break;
                case "2":
                    this.AddGrade(20);
                    break;
                case "1":
                    this.AddGrade(0);
                    break;
                default:
                    throw new Exception("Invalid grade!!!");
            }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {

                if (grade >= 0)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average += grade;
                }

            }

            statistics.Average /= this.grades.Count;
            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }
            return statistics;
        }
    }
}
