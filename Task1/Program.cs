var person = new Person();
System.Console.Write("Enter your Firstname: ");
person.FirstName = Console.ReadLine();
System.Console.Write("Enter your LastName: ");
person.LastName = Console.ReadLine();
System.Console.Write("Enter your Age: ");
person.Age = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter your Address: ");
person.Address = Console.ReadLine();
person.GetFullName();
person.GetBirthYear();



// naqsha
public class Person
{
    public string FirstName; 
    public string LastName;
    public int Age;
    public string Address;

    public void GetInfo()
    {
        System.Console.WriteLine($"FirstName: {FirstName}  LastName: {LastName}  Age: {Age} Address: {Address}");
    }
    public void GetFullName()
    {
        System.Console.WriteLine($"My name is {FirstName} {LastName}");
    }
    public void GetBirthYear()
    {
        System.Console.WriteLine($"My birth year is {2024-Age}");
    }
}
