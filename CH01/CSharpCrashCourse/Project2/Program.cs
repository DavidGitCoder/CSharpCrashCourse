//Loops - Make your program POWERFUL - Write a little bit of code that does something repetitively 
// and makes your program DO a lot of work

//PreTest Loop
using System.Runtime.Serialization;

for (decimal i = 100; i >= 1; i/=2)
{
    Console.WriteLine($"the current value of i is {i}");

}
foreach (var item in args)
{

}
Console.WriteLine("\nPre-test loop");
int j = 0;
while (j <=20)
{
    Console.WriteLine($"the current value of j is {j}");
    j+=2;
}
Console.WriteLine($"j is {j}");

//Post-test loop
Console.WriteLine("\nPost-test loop");
j = 20;
do
{
    Console.WriteLine($"the current value of j is {j}");
    j++;
} while (j < 10);
Console.WriteLine($"j is {j}");

//Conditionals - Make your programs START
int age = 40;
if (age < 50) 
{
    Console.WriteLine("You're not over the hill!");
}

//Write a program that prints the numbers from 1 to N (where N is a given upper limit)
//for numbers divisible by 3, print "Fizz" instead of the number
//for numbers divisible by 5, print "Buzz" instead of the number
//for numbers divisible by both 3 and 5 print "FizzBuzz" instead of the number
string fizzbuzz = "";
//fizz buzz
int upperlimit = 0;

Console.WriteLine("Upper limit please: ");

int.TryParse(Console.ReadLine(), out upperlimit);

for(int i = 1; i < upperlimit; i++)
{
 
    if (!((i % 3 == 0) || (i % 5 == 0)))
    {
        fizzbuzz = i.ToString("C"); //convert to currency US locale
    }
    
    if (i % 3 == 0)
    {
        fizzbuzz = "Fizz";
    }
    if (i % 5 == 0)
    {
        fizzbuzz += "Buzz";
    }
    Console.WriteLine($"{fizzbuzz}");
    fizzbuzz = "";
}

float n = .12F; //floating point literal
Console.WriteLine($"{n:P0}");
Console.WriteLine("the value is " + n.ToString("P0")); //another way
// Unary operator
// i++

// Binary operator
// i+3

// Ternary conditional operator
int x = 100;

string result = x < 200 ? "i less than 200" : "i greater or equal to 200";
Console.WriteLine(result);



