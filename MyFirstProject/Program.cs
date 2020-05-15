using System;




namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Main code goes in here
            /* This is a 
             * Big Bock
             * of comments.
             * 
             */



            // 32 bit
            //int smallnumber = 35;
            // 63 bit
            //long abignumber = 99999999999;

            // fractions
            // floats are fast, 32 bit

            //float somefrac = 80.5f;

            // double precision compared:
            // doubles are slower, 64 bit, default number type with fraction
            //double twoandahalf = 2.5;



            // decimal for money and scientific numbers, 128 bit
            //decimal money = (decimal)10000000000000000000.1324233453462357527;


            // string is used for text, need (")
            //string myname = "Paul";

            // char for a single letter use (')
            //char aletter = 'k';

            // boolean, true/false
            //bool somethingtrue = true;
            //bool somethingfalse = false;


            // var can be used to define a variable with a type
            //var vardone = "Variables done!";
            //var somemoremoney = 313423.2435245;



            Console.WriteLine("What is your name?");
            Console.Write("Name: ");
            var name = Console.ReadLine();

            Console.WriteLine("What is your age?");
            Console.Write("Age: ");
            Int32.TryParse(Console.ReadLine(),out int age);

            Console.WriteLine("What is your Weight? (in kg)");
            Console.Write("Weight: ");
            Int32.TryParse(Console.ReadLine(), out int weight);


            Console.WriteLine("What is your Height? (in cm)");
            Console.Write("Height: ");
            Double.TryParse(Console.ReadLine(), out double height);

            double bmi = Math.Round(weight / Math.Pow(height / 100, 2),2);

            // Console.WriteLine("Weight: " + weight + " Height: " + height + " Supposed height^2: " + Math.Pow(height / 100, 2) + "");


            Console.WriteLine();
            Console.WriteLine();

            //Console.WriteLine(Math.Round(bmi,2));


            Console.WriteLine("Hello " + name + " you are " + age + " years old");
            Console.WriteLine("Youre height is " + height + " and your weight is " + weight + "");
            Console.WriteLine("Youre BMI is: " + bmi);



            Console.ReadKey();

        }
    }
}
