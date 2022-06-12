using TorusCalc.Helpers.Classes;
using TorusCalc.Helpers.Utils;

Utils.PrintHelp();

int type = Utils.DecideType();

// Get user input
double r = Utils.Get_r();
double R = Utils.Get_R();

switch (type)
{
    // Ring
    case 1:
        RingTorus ringT = new RingTorus(r, R);
        ringT.Print();
        break;

    // Horn
    case 2:
        HornTorus hornT = new HornTorus(r, R);
        hornT.Print();
        break;

    // Spindle
    case 3:
        SpindleTorus spindleT = new SpindleTorus(r, R);
        spindleT.Print();
        break;

    default:
        Console.WriteLine("Somehow you got here with invalid torus type even though I checked your choice earlier. Congrats.");
        break;
}