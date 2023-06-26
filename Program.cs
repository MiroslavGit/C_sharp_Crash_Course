namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            * 3. - 4. Data types
            */            
            int age = 21;
            double height = 300.5; 
            bool alive = true;
            char symbol = '&';
            String name = "Bro";
            string userName = symbol + name;
            const double pi = 3.14159;

            Console.WriteLine("Hello" + name);
            Console.WriteLine("Your age is " + age);
            Console.WriteLine("Your high is " + height + "cm");
            Console.WriteLine("Are you alive? " + alive);
            Console.WriteLine("Your symbol is " + symbol);
            Console.WriteLine("Your username is " + userName);
            Console.WriteLine("Pi is " + pi);

            /* 
            * 5. Type casting
            */
            double a = 3.14;
            int b = Convert.ToInt32(a);

            int c = 123;
            double d = Convert.ToDouble(c) + 0.1;

            int e = 321;
            string f = Convert.ToString(e);

            string g = "$";
            char h = Convert.ToChar(g);

            string i = "true";
            bool j = Convert.ToBoolean(i);

            Console.WriteLine("\n");
            Console.WriteLine(b.GetType());
            Console.WriteLine(d.GetType());
            Console.WriteLine(f.GetType());
            Console.WriteLine(h.GetType());
            Console.WriteLine(j.GetType());


            /* 
            * 6. User inputs
            */
            Console.WriteLine("\nWhat is your name? ");
            string inputName = Console.ReadLine();

            Console.WriteLine("What is your age? ");
            string inputAge = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Hello " + inputName);
            Console.WriteLine("You are " + inputAge + " year old");


            /* 
            * 7. Arithmetic operators 
            */
            int friends = 5;

            friends = friends + 2;
            friends += 2;
            friends++;

            friends = friends - 2;
            friends -= 2;
            friends--;

            friends = friends * 2;
            friends *= 2;

            friends = friends / 2;
            friends /= 2;

            int remainders = friends % 2;

            Console.WriteLine("\n");
            Console.WriteLine(remainders);


            /* 
            * 8. Math class 
            */
            double xx = 3.99;
            double yy = 5;

            double aa = Math.Pow(xx,3);
            double bb = Math.Sqrt(xx);
            double cc = Math.Abs(xx);
            double dd = Math.Round(xx);
            double ee = Math.Ceiling(xx);
            double ff = Math.Floor(xx);
            double gg = Math.Max(xx, yy);
            double hh = Math.Min(xx, yy);

            Console.WriteLine("\n");
            Console.WriteLine(hh);

            /* 
            * 9. Random numbers 
            */
            Random random = new Random();

            int num = random.Next(1,7);
            double num2 = random.NextDouble();

            Console.WriteLine("\n");
            Console.WriteLine(num2);

            /* 
            * 10.Hypotenuse calculator program (výpočet prepony)
            */
            int odvesna1 = 3;
            int odvesna2 = 4;
            double prepona = Math.Sqrt( Math.Pow(odvesna1,2) + Math.Pow(odvesna2,2) );

            Console.WriteLine("\n");
            Console.WriteLine("Prepona je " + prepona);

            /* 
            * 11.String methods
            */


            Console.ReadLine();
        }
    }
}