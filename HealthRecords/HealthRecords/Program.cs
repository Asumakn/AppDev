using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthRecords
{
    internal class Program
    {
        private String firstName;
        private String lastName;
        private int birthYear;
        private int height;
        private int weight;
        private int currentYear;

        public Program(string firstName, string lastName, int birthYear, int height, int weight, int currentYear)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthYear = birthYear;
            this.Height = height;
            this.Weight = weight;
            this.CurrentYear = currentYear;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int BirthYear { get => birthYear; set => birthYear = value; }
        public int Height { get => height; set => height = value; }
        public int Weight { get => weight; set => weight = value; }
        public int CurrentYear { get => currentYear; set => currentYear = value; }

        static void Main(string[] args)
        {
        }

        public int calculateAge( int currentYear, int birthYear)
        {
return currentYear - birthYear;
        }
        public int maxHeartRate(int age)
        {
            return 220 - age;
        }

        public int targetMaxHeartRate(int age)
        {
            return (220 - age) * (17 / 20);
        }
        public int targetMinHeartRate(int age)
        {
            return (220 - age) * (5 / 10);
        }
public int calculateBMI(int weight)
        {
            return (weight * 703) / height ^ 2;
        }

    }
}
