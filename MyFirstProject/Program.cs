using System;



namespace MyFirstProject
{

    class Program
    {

    public static bool Sanitize(double value)
        {
            if (value <= 0 | value >= 200)
            {
                return true;
            }
            return false;
        }

    public static bool Sanitize(int value)
        {
            if (value <= 0 | value >= 200)
            {
                return true;
            }
            return false;
        }


        static void Main(string[] args)
        {

            double Calcbmi(double heightincm, double weightinkg)
            {

                return Math.Round(weightinkg / ((heightincm / 100) * (heightincm / 100)));
                //return Math.Round(weightinkg / Math.Pow(heightincm / 100, 2), 2);

            }

            int getage()
            {
                int cycle = 0;
                while (cycle == 0)
                {
                    Console.WriteLine("What is your age?");
                    Console.Write("Age: ");
                    if (Int32.TryParse(Console.ReadLine(), out int properage)) { if (!Program.Sanitize(properage)) { return properage; } };
                    Console.WriteLine("Invalid age entered, please try again.");
                }
                return 0;
                

            }

            int getweight()
            {
                int cycle = 0;
                while (cycle == 0)
                {
                    Console.WriteLine("What is your weight?");
                    Console.Write("Weight: ");
                    if (Int32.TryParse(Console.ReadLine(), out int properweight)) { if (!Program.Sanitize(properweight)) { return properweight; } };
                    Console.WriteLine("Invalid weight entered, please try again.");
                }
                return 0;


            }

            int getheight()
            {
                int cycle = 0;
                while (cycle == 0)
                {
                    Console.WriteLine("What is your height?");
                    Console.Write("Height: ");
                    if (Int32.TryParse(Console.ReadLine(), out int properheight)) { if (!Program.Sanitize(properheight)) { return properheight; } };
                    Console.WriteLine("Invalid height entered, please try again.");
                }
                return 0;


            }
            Console.WriteLine("What is your name?");
            Console.Write("Name: ");
            var name = Console.ReadLine();

            //bool parseage = Int32.TryParse(Console.ReadLine(), out int age);

            // int i = 0;
            // do
            //{
            //     Console.WriteLine("What is your age?");
            //     Console.Write("Age: ");
            //     Int32.TryParse(Console.ReadLine(), out int age);
            //     if (Program.Sanitize(age)) { Console.WriteLine("Invalid age, please try again."); } else { i++; }
            //    age = currage;
            // } while (i == 0);


            //Console.WriteLine("What is your age?");
            //Console.Write("Age: ");
            //Int32.TryParse(Console.ReadLine(), out int age);

           


            /*
            Console.WriteLine("What is your Weight? (in kg)");
            Console.Write("Weight: ");
            Double.TryParse(Console.ReadLine(), out double weight);


            Console.WriteLine("What is your Height? (in cm)");
            Console.Write("Height: ");
            Double.TryParse(Console.ReadLine(), out double height);
            */

            
            // double bmi = Math.Round(weight / Math.Pow(height / 100, 2),2);

            // Console.WriteLine("Weight: " + weight + " Height: " + height + " Supposed height^2: " + Math.Pow(height / 100, 2) + "");


            Console.WriteLine();
            Console.WriteLine();

            //Console.WriteLine(Math.Round(bmi,2));


            int age = getage();
            int weight = getweight();
            int height = getheight();


            // Sanitation testing

            // if (Program.Sanitize(age)) { Console.WriteLine("Wrong age"); }

            // if (Program.Sanitize(weight)) { Console.WriteLine("Wrong weight"); }

            // if (Program.Sanitize(height)) { Console.WriteLine("Wrong height"); }


            Console.WriteLine("Hello " + name + " you are " + age + " years old");
            Console.WriteLine("Your height is " + height + "cm and your weight is " + weight + "kg");
            Console.WriteLine("Your BMI is: " + Calcbmi(height, weight));



            Console.ReadKey();

        }
    }
}
