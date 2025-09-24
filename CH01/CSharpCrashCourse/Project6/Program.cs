// ARRAYS
//Sort the data
//Search

int[] myInts = new int[10]; // Dimensioned: holds 10 integers


double[] myDoubles = [1.2, 5.6, 10.0]; //shorthand form


for(int i = 0;i<myDoubles.Length;i++)
{
    Console.WriteLine(myDoubles[i]);
}

String[] myStrings = ["Evan", "Bob", "Jane"];

Array.Sort(myStrings); //alphabetical order
for(int i = myStrings.Length-1 ; i>=0;i--)
{
    Console.WriteLine(myStrings[i]);
}

Console.WriteLine(Array.IndexOf(myStrings, "Jane"));


Console.WriteLine("who are you looking for?");

//reading data out of an array
foreach(String name in myStrings)
{
    Console.WriteLine(name);

}

int[] testScores = [100, 90, 30, 88, 75, 93];

int best = 0;
int worst = 100;
int sum = 0;

foreach(int score in testScores)
{
    best = int.Max(best, score);
    worst = int.Min(worst, score);
    sum += score;
}
Console.WriteLine($"Best: {best}\nWorst: {worst}\nSum: {sum}\nAverage: {sum/6}");