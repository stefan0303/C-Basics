using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Car
{
    public string Model;
    public double fuel;
    public double fuelConsumption;
    public double distanceTraveled;

    public Car(string Model,double fuel, double fuelConsumption)
    {
        this.Model = Model;
        this.fuel = fuel;
        this.fuelConsumption = fuelConsumption;
        this.distanceTraveled = 0;
    }
    public void Drive(double amountOfKilometers) //Ako e static vmesto public nemoje da se izpolzva this.
    {
        if (amountOfKilometers <= this.fuel / this.fuelConsumption) //??
        {
            this.distanceTraveled += amountOfKilometers;
            this.fuel -= this.fuelConsumption*amountOfKilometers;
        }
        else
        {
            Console.WriteLine("Insufficient fuel for the drive");   
        }
    }
}   
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Car> cars = new List<Car>();
        for (int i = 0; i < n; i++)
        {
            string[] carModelsInfo = Console.ReadLine().Split().ToArray();
            // var car = new Car(carModelsInfo[0], double.Parse(carModelsInfo[1]), double.Parse(carModelsInfo[2]));
            string model = carModelsInfo[0];
            double fuel = double.Parse(carModelsInfo[1]);
            double fuelConsumption = double.Parse(carModelsInfo[2]);
            Car car = new Car(model, fuel, fuelConsumption);
            cars.Add(car);
        }
        string[] command = Console.ReadLine().Split().ToArray();
        while (command[0] != "End")
        {
            string carModel = command[1];
            double amountOfKilometers = double.Parse(command[2]);
            Car carToDrive = cars.First(c => c.Model == carModel); //???
            carToDrive.Drive(amountOfKilometers);

            command = Console.ReadLine().Split().ToArray();
        }
        foreach (var car in cars)
        {
            Console.WriteLine("{0} {1:f2} {2}",car.Model,car.fuel,car.distanceTraveled);
        }
    }
}

