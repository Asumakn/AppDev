using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthRecords
{
    internal class HealthRecords
    {
        private String firstName;
        private String lastName;
        private int birthYear;
        private int height;
        private int weight;
        private int currentYear;

        public HealthRecords(string firstName, string lastName, int birthYear, int height, int weight, int currentYear)
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
            HealthRecords lp = new HealthRecords("luke","fdsfsdfsdfsdfs",2005,100,200,2026);
            displayPatientRecords(lp);
            lp.weight =15 ;
          Console.WriteLine(lp.weight);
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
            return ((220 - calculateAge()* 17) / 20);
        }
        public int targetMinHeartRate()
        {
            return ((220 - calculateAge() * 5) / 10);
        }
public double calculateBMI()
        {
            return (weight * 703) /( height *height);
        }
        public String BMITextValue()
        {
            if (calculateBMI()<18.5)
            {
                return "underweight";
            
            } else if (calculateBMI()>18.5&&calculateBMI()<24.9)
            {
                return "normal";

            }
                else if (calculateBMI()>24.9&&calculateBMI() <29.9) {
                return "overweight";

            }
            else { return "obese"; }
                

            }


            public static void drawLine()
        {

            Console.Write("|");
            for (int i = 0; i < 80; i++)
            {

                Console.Write("-");

            }
            Console.WriteLine("|");



        }
        public static void displayPatientRecords(HealthRecords hr)
        {
            drawLine();
            Console.WriteLine($"|{"PATIENTE HEART BEAT RECORDS",50}{"|",31}");
            drawLine();
            Console.WriteLine($"{"|Patient Name",-40}|{hr.firstName + " " + hr.lastName,-40}{"|"}");
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
            Console.WriteLine($"{"|Target Heart Rate Range"}  {"|",15}{" ",36}{"{0}"+ "|",-10}",
                hr.targetMinHeartRate() + "" + hr.targetMaxHeartRate());
            drawLine();
            Console.WriteLine($"{"|BMI Numeric Value"}       {"|",16}{"{0}|",42}",
                hr.calculateBMI());
            drawLine();
            Console.WriteLine($"{"|BMI Text Value"}    {"|",22}  {" ",-18} {hr.BMITextValue()+"|",20}");
            drawLine();


        }

    }
}
