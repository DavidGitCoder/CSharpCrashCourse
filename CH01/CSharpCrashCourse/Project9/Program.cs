//POLYMOPRPHISM
using Project9; 

Patient p1=new Patient();
Upholsterer p2 = new Upholsterer();
FootballPlayer p3 = new FootballPlayer();

//Polymorphism states that a method's behavior 
//will change based on the object that it references
Recovery(p1);
Recovery(p2);
Recovery(p3);

void Recovery(IRecoverable r) //Any class that implement IRecoverable can be passed in
{
    Console.WriteLine(r.Recover());
}

