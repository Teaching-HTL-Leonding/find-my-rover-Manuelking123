int westcounter = 0;
int eastcounter = 0;
int southcounter = 0;
int northcounter = 0;
int end = 0;
WelcomeMessage();
void WelcomeMessage()
{
    Console.WriteLine("Welcome to FindMyRover");
    Console.WriteLine("######################");
    Console.WriteLine("");
}
Console.WriteLine("Enter the movement log of your rover!");
string movementlog = Console.ReadLine()!;

eastcounter = movementlog.Count(c => c == '>');
westcounter = movementlog.Count(c => c == '<');
northcounter = movementlog.Count(c => c == '^');
southcounter = movementlog.Count(c => c == 'V');

double all = eastcounter + westcounter + northcounter + southcounter;
double length = movementlog.Length;
if (all != length)
{
    Console.WriteLine("ERROR!!!!!!");
    end = 1;
}
if (end == 0)
{
    double y = northcounter - southcounter;
    double x = eastcounter - westcounter;
    double directwaylength = Math.Sqrt((y * y) + (x * x));
    Console.WriteLine("X =" + x);
    Console.WriteLine("Y =" + y);
    Console.WriteLine("Direct way =" + directwaylength);

}