namespace LineComp
{
    class UC0
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO LINE COMPARISON PROBLEM");
            int X1, X2, Y1, Y2;
                Console.WriteLine("ENTER THE COORDINATES:");
                X1 = Convert.ToInt16(Console.ReadLine());
                X2 = Convert.ToInt16(Console.ReadLine());
                Y1 = Convert.ToInt16(Console.ReadLine());
                Y2 = Convert.ToInt16(Console.ReadLine());
                var result = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));
               Double length=Math.Round((Double)result,2);
                Console.WriteLine("LENGTH OF THE LINE: " + length);

            }
        }
    }

