using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartRates
{
    internal class HeartRates
    {

        private String firstName;
        private String lastName;
        private int birthYear;
        private int currentYear;

        public String getFirstName() { return firstName; }
        public String getLastName() { return lastName; }
        public int getbirthYear() { return birthYear; }
        public int getCurrentYear() { return currentYear; }

        public void setFirstName(String newString) { firstName = newString; }
        public void setLastName(String newString) { lastName = newString; }
        public void setbirthYear(int newInt) { birthYear = newInt; }
        public void setCurrentYear(int newInt) { currentYear = newInt; }

        public HeartRates(string firstName, string lastName, int birthYear, int currentYear)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthYear = birthYear;
            this.currentYear = currentYear;
        }

        static void Main(string[] args)
        {
            HeartRates lp = new HeartRates("luke","nodasasdaf",2005,2026);
            displayPatientRecords(lp);
            

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
        public int calculateAge()
        {
            return currentYear - birthYear;
        }
        public int maxHeartRate()
        {
            return 220 - calculateAge();
            
        }

        public int targetMaxHeartRate()
        {
            return (((220 - calculateAge()) * 17 )/20);
        }
        public int targetMinHeartRate()
        {
            return (((220 - calculateAge()) * 5) / 10);
        }


        public static void drawLine()
        {

            Console.Write("|");
            for (int i = 0; i < 80; i++) {

                Console.Write("-");

            }
            Console.WriteLine("|");



        }
        public static void displayPatientRecords(HeartRates hr)
        {
            drawLine();
            Console.WriteLine($"|{"PATIENTE HEART BEAT RECORDS",50}{"|",31}");
            drawLine();
            Console.WriteLine($"|Patient Name{"",14}             |{hr.firstName + " " + hr.lastName,-40}{"|"}");
            drawLine();
            Console.WriteLine($"{"|Patient Birth Year"}       {"|",15}{"{0}|",40}",
                hr.birthYear);
            drawLine();
            Console.WriteLine($"{"|Patient  Age"}             {"|",15}{"{0}|",42}",
                hr.calculateAge());
            drawLine();
            Console.WriteLine($"{"|Maximum Heart Rate"}       {"|",15}{"{0}|",41}",
                hr.maxHeartRate());
            drawLine();
            Console.WriteLine($"{"|Target Heart Rate Range"}  {"|",15}{" ",34}{hr.targetMinHeartRate() + "-" + hr.targetMaxHeartRate()+ "|",-10}");
            drawLine();

        }


    }

}

