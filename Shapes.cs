namespace ShapesMaker
{
    internal static class Shapes
    {
        public static int windowWidth = Console.WindowWidth;
        public static void MakeTriangle(int hight)
        {
            for (int row = 1; row <= hight; row++)
            {
                int numberOfStars = row * 2 - 1;
                string result = "";
                for (int star = 0; star < numberOfStars; star++)
                {
                    result += "*";
                }
                int padding = (windowWidth - numberOfStars) / 2;
                result = result.PadLeft(padding + numberOfStars);
                Console.Write($"{result}\n");
            }
        }
        public static void MakeInvertedTriangle(int hight)
        {
            for (int row = hight; row > 0; row--)
            {
                int numberOfStars = row * 2 - 1;
                string result = "";
                for (int star = 0; star < numberOfStars; star++)
                {
                    result += "*";
                }
                int padding = (windowWidth - numberOfStars) / 2;
                result = result.PadLeft(padding + numberOfStars);
                Console.WriteLine(result);
            }
        }
        public static void MakeSquare(int sideLength)
        {
            string result = "";
            for (int j = 0; j < sideLength; j++)
            {
                result += "* ";
            }
            int padding = (windowWidth - result.Length) / 2;
            result = result.PadLeft(padding + result.Length);
            for (int i = 0; i < sideLength; i++)
            {
                Console.WriteLine(result);
            }
        }
        public static void MakeRectangle(int length, int width)
        {
            string result = "";
            for (int j = 0; j < length; j++)
            {
                result += "* ";
            }
            int padding = (windowWidth - result.Length) / 2;
            result = result.PadLeft(padding + result.Length);
            for (int i = 0; i < width; i++)
            {
                Console.WriteLine(result);
            }
        }
        public static void MakeRhombus(int diameter)
        {
            MakeTriangle(diameter);
            ProgramMethodes.ClearLines(1);
            MakeInvertedTriangle(diameter);
        }
        public static void MakeSandClock(int width)
        {
            MakeInvertedTriangle(width);
            ProgramMethodes.ClearLines(1);
            MakeTriangle(width);
        }
        public static void MakeCircle(int diameter)
        {
            double radius = diameter / 2 - 0.5;
            double r = Math.Pow(radius + 0.25, 2) + 1;

            for (int i = 0; i < diameter; i++)
            {
                string result = "";
                double y = Math.Pow(i - radius, 2);
                for (int j = 0; j < diameter; j++)
                {
                    double x = Math.Pow(j - radius, 2);
                    if (x + y <= r)
                    {
                        result += "* ";
                    }
                    else
                    {
                        result += " ";
                    }
                }
                int padding = (windowWidth - result.Length) / 2;
                result = result.PadLeft(padding + result.Length);
                Console.WriteLine(result);
            }
        }
    }
}
