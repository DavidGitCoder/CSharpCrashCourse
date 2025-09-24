using Project9_App;

List<ITurnable> turnables = new List<ITurnable>();
turnables.Add(new Page());
turnables.Add(new Pancake());
turnables.Add(new Leaf());
turnables.Add(new Corner());
turnables.Add(new Page());
Console.WriteLine(turnables[2]);

Turning(turnables);
void Turning(List<ITurnable> turnable)
{
    foreach(ITurnable l in turnable)
    {
        Console.WriteLine(l.Turn());
        Console.WriteLine($"Instances of {l.GetType().Name}: {l.GetCount()}");    }
}



//Page t1= new Page();
//Corner t2= new Corner();
//Leaf t3 = new Leaf();
//Pancake t4 = new Pancake();


