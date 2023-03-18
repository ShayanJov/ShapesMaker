using System.Runtime.InteropServices;

namespace ShapesMaker
{
    internal static class ProgramMethodes
    {
        private static bool isFirstCall = true;
        private static int linesToBeCleard = 0;
        public static string AskForShape()
        {
            linesToBeCleard = isFirstCall ? 5 : 6;
            string[] possibleInputs = { "3", "4", "0" };

            Console.WriteLine("What kind of shape do you want to make?");
            Console.WriteLine("Enter \"3\" for three sides shapes. (Triangles)");
            Console.WriteLine("Enter \"4\" for four sides shapes. (Squares, Rectangles, Rhombuses)");
            Console.WriteLine("Enter \"0\" for special shapes. (Sand clocks)");

            string input = Console.ReadLine();

            if (possibleInputs.Contains(input))
            {
                ClearLines(linesToBeCleard);
                isFirstCall = true;
                switch (input)
                {
                    case "3":
                        return ThreeSidedShapes();
                    case "4":
                        return FourSidedShapes();
                    case "0":
                        return SpecialShapes();
                }
            }
            ClearLines(linesToBeCleard);
            isFirstCall = false;
            InputFailMessage();
            return AskForShape();
        }
        public static int AskAndGetInt(string question)
        {
            if (isFirstCall)
                Console.WriteLine("Keep in mind: input must be between 0 and 61!",
                    Console.ForegroundColor = ConsoleColor.Red);
            Console.ResetColor();
            linesToBeCleard = 3;
            try
            {
                Console.WriteLine(question);
                int hight = int.Parse(Console.ReadLine());
                if (hight > 0 && hight < 61)
                {
                    ClearLines(linesToBeCleard);
                    isFirstCall = true;
                    return hight;
                }
                else
                {
                    ClearLines(linesToBeCleard);
                    Console.WriteLine("Input must be a number between 0 and 61!",
                        Console.ForegroundColor = ConsoleColor.Red);
                    Console.ResetColor();
                    isFirstCall = false;
                    return AskAndGetInt(question);
                }
            }
            catch
            {
                ClearLines(linesToBeCleard);
                Console.WriteLine("Input most be a number!",
                    Console.ForegroundColor = ConsoleColor.Red);
                Console.ResetColor();
                isFirstCall = false;
                return AskAndGetInt(question);
            }
        }
        private static string ThreeSidedShapes()
        {
            linesToBeCleard = isFirstCall ? 5 : 6;
            string[] possibleInputs = { "T", "IT", "B" };

            Console.WriteLine("What kind of three sided shape do you want to make?");
            Console.WriteLine("Enter \"T\" for a triangle.");
            Console.WriteLine("Enter \"IT\" for a inverted triangle.");
            Console.WriteLine("Enter \"B\" to go back to category page.");
            string input = Console.ReadLine().ToUpper();

            if (possibleInputs.Contains(input))
            {
                ClearLines(linesToBeCleard);
                isFirstCall = true;
                if (input == "B") return AskForShape();
                return input;
            }
            ClearLines(linesToBeCleard);
            isFirstCall = false;
            InputFailMessage();
            return ThreeSidedShapes();

        }
        private static string FourSidedShapes()
        {
            string[] possibleInputs = { "S", "R", "RH", "B" };
            linesToBeCleard = isFirstCall ? 6 : 7;

            Console.WriteLine("What kind of three sided shape do you want to make?");
            Console.WriteLine("Enter \"S\" for a square.");
            Console.WriteLine("Enter \"R\" for a rectangle.");
            Console.WriteLine("Enter \"RH\" for a rhombus.");
            Console.WriteLine("Enter \"B\" to go back to category page.");
            string input = Console.ReadLine().ToUpper();

            if (possibleInputs.Contains(input))
            {
                ClearLines(linesToBeCleard);
                isFirstCall = true;
                if (input == "B") return AskForShape();
                return input;
            }
            ClearLines(linesToBeCleard);
            isFirstCall = false;
            InputFailMessage();
            return FourSidedShapes();
        }
        private static string SpecialShapes()
        {
            string[] possibleInputs = { "SC", "B", "C" };
            linesToBeCleard = isFirstCall ? 5 : 6;

            Console.WriteLine("What kind of special shape do you want to make?");
            Console.WriteLine("Enter \"C\" for a Circle.");
            Console.WriteLine("Enter \"SC\" for a sand clock.");
            Console.WriteLine("Enter \"B\" to go back to category page.");
            string input = Console.ReadLine().ToUpper();

            if (possibleInputs.Contains(input))
            {
                ClearLines(linesToBeCleard);
                isFirstCall = true;
                if (input == "B") return AskForShape();
                return input;
            }
            ClearLines(linesToBeCleard);
            isFirstCall = false;
            InputFailMessage();
            return FourSidedShapes();
        }
        public static void ClearLines(int lines)
        {
            for (int i = 0; i < lines; i++)
            {
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                int currentLineCursor = Console.CursorTop;
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, currentLineCursor);
            }
        }
        private static void InputFailMessage()
        {
            Console.WriteLine("Input was unrecognized!",
                Console.ForegroundColor = ConsoleColor.Red);
            Console.ResetColor();
        }
    }
}
