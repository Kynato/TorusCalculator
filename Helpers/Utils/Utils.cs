namespace TorusCalc.Helpers.Utils
{
    class Utils
    {
        public static void PrintHelp()
        {
            Console.WriteLine("This program calculates a volume for three types of toruses.\n");
            Console.WriteLine("VARIABLES:");
            Console.WriteLine("r: radius of cross-section");
            Console.WriteLine("R: distance between the center of the torus to the center of the cross-section\n");
        }

        public static int DecideType()
        {
            Console.WriteLine("\nChoose torus type:");

            Console.WriteLine("     1. Ring type    (R > r)");
            Console.WriteLine("     2. Horn type    (R = r)");
            Console.WriteLine("     3. Spindle type (R < r)");

            try
            {
                while (true)
                {
                    Console.Write("Insert type: ");
                    if (int.TryParse(Console.ReadLine(), out int num))
                    {
                        if (num > 0 && num < 4) return num;
                        Console.WriteLine("Choice must be between [1 - 3].\n");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex}. Exception Caught.");
                Console.WriteLine("Defaulting to most common torus: Ring");
                return 1;
            }
        }

        public static double Get_r()
        {
            Console.Write("\rEnter r: ");

            if (!double.TryParse(Console.ReadLine(), out double r))
                Console.WriteLine($"{r} is outside the range of a double.");

            return r;
        }

        public static double Get_R()
        {
            Console.Write("Enter R: ");

            if (!double.TryParse(Console.ReadLine(), out double R))
                Console.WriteLine($"{R} is outside the range of a double.");

            return R;
        }
    }
}

