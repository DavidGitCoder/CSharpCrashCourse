string name = "How are you?";
String name2 = new string("bob");

if(name.ToLower().Equals(name2.ToLower()))
{
    Console.WriteLine("names are equal");
}
else
{
    Console.WriteLine("names not equal");
}
string reversed = "";
foreach (char letter in name)
{
    reversed = letter + reversed;

}
Console.WriteLine(reversed);

//for(int i=name.Length;i>=0;i--)
//    { 
//    reversed += name.Substring(i);
//}
//Console.WriteLine();