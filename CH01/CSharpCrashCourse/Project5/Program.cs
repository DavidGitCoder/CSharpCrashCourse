//string name = null;
//string name2 = "";

//do {
//    Console.WriteLine("Please enter your name");
//    name = Console.ReadLine();
//}
//while (String.IsNullOrEmpty(name));

//Mask a credit card number except last 4 digits
//keep the spaces
string cc = null;
string masked = String.Empty;
int i = 0;

do
{
    Console.WriteLine("Enter credit card number:");
    cc = Console.ReadLine();

} while (String.IsNullOrEmpty(cc));

foreach (char letter in cc)
{
    masked += ((Char.IsDigit(letter)||(Char.IsLetter(letter))) && (i < cc.Length - 4)) ? "X" : letter;

    i++;
}

Console.WriteLine(masked);


