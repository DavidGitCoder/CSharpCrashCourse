using Project8;

Person firstPerson = new Person("David","King",33);
Console.WriteLine(firstPerson);
firstPerson.SetFirstName("John");
firstPerson.SetLastName("Doe");
Console.WriteLine(firstPerson);

Cart myCart = new Cart("A0001");
myCart.AddItem("Book", 35.99);
myCart.AddItem("Vacuum Cleaner", 450.76);
myCart.AddItem("iPhone 16", 1200);
Console.WriteLine(myCart);

Student stu = new Student("Franklin", "Roosevelt", 95, 3.8);
Console.WriteLine(stu);


Book b1 = new Book();
//b1.NumPages = 500;
Console.WriteLine(b1);