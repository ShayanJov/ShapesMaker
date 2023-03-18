using ShapesMaker;

int i = 0;
while (true)
{
    i++;
    Console.WriteLine($"{i}. ");
    Console.WriteLine(new string(' ', Console.WindowWidth));

    string shape = ProgramMethodes.AskForShape();
    switch (shape)
    {
        case "T":
            Shapes.MakeTriangle
                (ProgramMethodes.AskAndGetInt("What is the hight of your triangle?"));
            break;
        case "IT":
            Shapes.MakeInvertedTriangle
                (ProgramMethodes.AskAndGetInt("What is the hight of your inverted triangle?"));
            break;
        case "S":
            Shapes.MakeSquare
                (ProgramMethodes.AskAndGetInt("What is the side length of your square?"));
            break;
        case "R":
            Shapes.MakeRectangle
                (ProgramMethodes.AskAndGetInt("What is the length of your rectangle?"),
                ProgramMethodes.AskAndGetInt("What is the width of your rectangle?"));
            break;
        case "RH":
            Shapes.MakeRhombus
                (ProgramMethodes.AskAndGetInt("What is the diameter of your rhombus?"));
            break;
        case "C":
            Shapes.MakeCircle
                (ProgramMethodes.AskAndGetInt("What is the diameter of your circle?"));
            break;
        case "SC":
            Shapes.MakeSandClock
                (ProgramMethodes.AskAndGetInt("What is the width of your sand clock?"));
            break;
    }

    Console.WriteLine(new string(' ', Console.WindowWidth));
    Console.WriteLine(new string('-', Console.WindowWidth));
}