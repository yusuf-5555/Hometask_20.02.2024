Car myCar = new Car("Toyota","Camry",2022,10);

Console.WriteLine($"Make: {myCar.Make}");
Console.WriteLine($"Model: {myCar.Model}");
Console.WriteLine($"Year: {myCar.Year}");
Console.WriteLine($"Fuel level: {myCar.Fuel} gallons");
Console.WriteLine($"Mileage: {myCar.Mileage} miles");
Console.WriteLine();

myCar.Drive(100);
myCar.AddFuel(10);
Console.WriteLine();

Console.WriteLine($"\nAfter the trip and refueling:");
Console.WriteLine($"Mileage: {myCar.Mileage} miles");
Console.WriteLine($"Fuel level: {myCar.Fuel} gallons");
class Car
{
    public string Make;
    public string Model;
    public int Year; 
    public double Mileage;
    public double Fuel; 
    public Car(string make,string model, int year,double fuel)  
    {
        Make=make;
        Model=model;
        Year=year;
        Fuel=fuel;
        
    } 
    public void Drive(double miles)
    { 
        if(Fuel<=0)
        {
            Console.Write("No Fuel");
        }
        Mileage += miles;
        Console.WriteLine($"You have driven {miles} miles. Current mileage: {Mileage} miles. " + $"Remaining fuel: {Fuel-(Mileage*0.05)} gallons.");
        Fuel = Fuel - (Mileage * 0.1);
    } 
    public void AddFuel(double gallons) 
    {
        Fuel += gallons;
        Console.WriteLine($"Added {gallons} gallons of fuel. Current fuel level: {gallons+5} gallons.");
    }
}
