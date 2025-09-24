//console app program that prints out a multiplication table
using System.Data;

bool isValid;
int rows, cols;

do {
    Console.WriteLine("Number of rows:");
    isValid=int.TryParse(Console.ReadLine(), out rows);
}while(!isValid);

//
do
{
    Console.WriteLine("Number of cols:");
    isValid = int.TryParse(Console.ReadLine(), out cols);
} while (!isValid);


//
string colHeader = "";
string rowMult = "";
//
for (int i = 0; i <= rows; i++)
{
    for (int j = 0; j <= cols; j++)
    {
        if (i == 0)
        {
            colHeader += (j==0)? "\t" : j.ToString() + "\t";
        }
        else
        {
            if(j == 0) {
                rowMult += $"{i}\t";
               
            }
            else
            {
                rowMult += $"{i*j}\t";
            }
        }
    }
    rowMult += "\n";
}

Console.WriteLine(colHeader+rowMult);