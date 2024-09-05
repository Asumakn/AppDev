using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartRates
{
    internal class Program
    {

        private String firstName;
        private String lastName;
        private int birthYear;
        private int currentYear;

        public String getFirstName() {  return firstName; }
        public String getLastName() { return lastName; }
        public int getbirthYear() { return birthYear;}
        public int getCurrentYear() { return currentYear; }

        public void setFirstName(String newString) {  firstName = newString; }
        public void setLastName(String newString) { lastName = newString; }
        public void setbirthYear(int newInt) { birthYear = newInt; }
        public void setCurrentYear(int newInt) { currentYear = newInt; }

        public Program(string firstName, string lastName, int birthYear, int currentYear)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthYear = birthYear;
            this.currentYear = currentYear;
        }

        static void Main(string[] args)
        {
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
        public int calculateAge(int birthYear, int currentYear)
        {
            return currentYear - birthYear;
        }
        public int maxHeartRate(int age)
        {
            return 220 - age;
        }

        public int targetMaxHeartRate(int age)
        {
            return (220 - age) *(17/20);
        }
        public int targetMinHeartRate(int age)
        {
            return (220 - age) * (5 / 10);
        }


    }


}

