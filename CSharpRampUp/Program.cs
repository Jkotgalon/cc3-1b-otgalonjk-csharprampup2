namespace CSharpRampUp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter weight in pounds: ");
            int lbs = Convert.ToInt32(Console.ReadLine());
            double kg_conv = 0.45359237;
            double kg = lbs * kg_conv;
            Console.WriteLine("Weight in Kilograms: " + kg + " kg.");
            Console.WriteLine("======================================");

            Console.Write("Enter distance in miles: ");
            int mi = Convert.ToInt32(Console.ReadLine());
            double km_conv = 1.60934;
            double km = mi * km_conv;
            Console.WriteLine("Distance in kilometers: " + km + " km.");
            Console.WriteLine("======================================");

            Console.Write("Enter temperature in Fahrenheit: ");
            double temp_far = Convert.ToDouble(Console.ReadLine());
            double temp_cel = (temp_far - 32) / 1.8;
            Console.WriteLine("Temperature in Celsius: " + temp_cel);
            Console.WriteLine("=================================");

            int age1, age2, age3, age4, age5, age6, age7, age8, age9, age10;
            Console.Write("Enter a number for student 1: ");
            age1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number for student 2: ");
            age2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number for student 3: ");
            age3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number for student 4: ");
            age4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number for student 5: ");
            age5 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number for student 6: ");
            age6 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number for student 7: ");
            age7 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number for student 8: ");
            age8 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number for student 9: ");
            age9 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number for student 10: ");
            age10 = Convert.ToInt32(Console.ReadLine());
            
            int age_avg = age1 + age2 + age3 + age4 + age5 + age6 + age7 + age8 + age9 + age10;
            
            Console.WriteLine();
            Console.WriteLine("Student Age 1: " + age1);
            Console.WriteLine("Student Age 2: " + age2);
            Console.WriteLine("Student Age 3: " + age3);
            Console.WriteLine("Student Age 4: " + age4);
            Console.WriteLine("Student Age 5: " + age5);
            Console.WriteLine("Student Age 6: " + age6);
            Console.WriteLine("Student Age 7: " + age7);
            Console.WriteLine("Student Age 8: " + age8);
            Console.WriteLine("Student Age 9: " + age9);
            Console.WriteLine("Student Age 10: " + age10);
            Console.WriteLine("The average age of the 10 students is " + (age_avg / 10));
            Console.WriteLine("=================================");
            
            string char1 = "Johnson";
            string char2 = "Captain Jayden";
            string char3 = "Doctor Rooney";
            string char4 = "Jax";
            string char5 = "Eruditio Inventors";
            
            Console.WriteLine("A star quarterback named " + char1 + ", adored by millions, faced death after a horror crash. He was " +
                "miraculously saved by " + char3 + " and the " + char5 + ". " + char1 + " was reborn as a cyborg, able to transform " +
                "into a super-powered sports car. Grateful, " + char1 + " pledged to protect Eruditio, alongside the valiant City " +
                "Guards led by " + char2 + ". Now a brick wall on wheels, " + char1 + ", with his allies " + char3 + "," + char2 + "," +
                " and his mechanic, " + char4 + ", became an unstoppable force, crushing any who threatened their beloved city. The " +
                "roar of his engine, a battle cry echoing through the streets, struck fear into the hearts of enemies, a testament to the " +
                "city's unwavering defense.");
            Console.WriteLine("=================================");
            
            int number1, number2, number3;
            
            Console.Write("Enter a number for experiment 1: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            if (number1 <= 0)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                for (int i = 1; i <= number1; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine("=================================");
            
            Console.Write("Enter a number for experiment 2: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            if (number2 <= 0)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                int result = 0;
                for (int i = 1; i <= number2; i++)
                {
                    result += i;
                }
                Console.WriteLine("The sum of numbers from 1 to " + number2 + " is " + result + " .");
            }
            Console.WriteLine("=================================");
            
            Console.Write("Enter a number for experiment 3: ");
            number3 = Convert.ToInt32(Console.ReadLine());
            if (number3 <= 0)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                for (int i = number3; i > 0; i--)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine("=================================");
        }
    }
}
