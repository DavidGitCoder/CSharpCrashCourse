// LISTS
using System.ComponentModel.Design;

List<int> myInts = new List<int>(4);

myInts.Add(9);
myInts.Add(1);
myInts.Add(3);
myInts.Add(8);
myInts.Add(2);
myInts.Add(4);
myInts.Add(5);
myInts.Add(6);
myInts.Add(7);
Console.WriteLine(myInts.Count);

//DICTIONARY
Dictionary<int, string> students = new Dictionary<int, string>();
students.Add(1001, "Bob");
students.Add(1002, "Evan");
students.Add(1003, "Sophie");
students.Add(1004, "Mario");

Console.WriteLine(students[1003]);
if (students.ContainsValue("Mario"))
{
    Console.WriteLine("Mario is a student");
}

//Contact list<string, string> contact name, phone number
//1. Add contact
//2. View contact
//3 Update Contact
//4 Delete contact
//5 List all contact
//6 Exit

bool isvalid;
int menu;
Dictionary<string, string> phoneBook = new();
phoneBook.Add("Evan", "123-456-7890");
phoneBook.Add("John", "098-411-3630");
phoneBook.Add("Jane", "560-987-1234");


do
{
    Console.WriteLine("1. Add contact");
    Console.WriteLine("2. View contact");
    Console.WriteLine("3. Update Contact");
    Console.WriteLine("4. Delete contact");
    Console.WriteLine("5. List all contact");
    Console.WriteLine("6. Exit");
    isvalid = Int32.TryParse(Console.ReadLine(), out menu);

}while (!isvalid);

switch (menu)
{

    case 1:
        string name= String.Empty;
        
        Console.WriteLine("*** ADD NEW STUDENT ***");
        do
        {
            isvalid = true;
            Console.WriteLine("Enter name of student:");
            name = Console.ReadLine();

            foreach(char c in name)
            {
                if(Char.IsDigit(c))
                { 
                    Console.WriteLine($"{name} contains illicit character: {c} at position {name.IndexOf(c)+1}. Please fix.");
                    isvalid = false;
                }
            }
        } while (String.IsNullOrEmpty(name)||!isvalid);
        Console.WriteLine("Enter Phone Number:");
        string phoneNumber = Console.ReadLine();

        phoneBook.Add(name, phoneNumber);

        Console.WriteLine(phoneBook.Last());

        break;

    case 2:
        break;

    case 3:
        break;

    case 4:
        break;

    case 5:
        break;

    case 6:
        break;
}
