﻿using _04._Vehicle_Catalogue;
using System.Collections.Generic;
using System.ComponentModel;

namespace _04._Vehicle_Catalogue
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }

    public class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }

    public class Catalog
    {
        public Catalog()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }

        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Catalog catalog = new Catalog();

            while (command != "end")
            {
                string[] data = command.Split("/");

                string type = data[0];
                string brand = data[1];
                string model = data[2];

                if (type == "Car")
                {
                    Car currentCar = new Car
                    {
                        Brand = brand,
                        Model = model,
                        HorsePower = int.Parse(data[3]),
                    };

                    catalog.Cars.Add(currentCar);
                }
                else if (type == "Truck")
                {
                    Truck currentTruck = new Truck
                    {
                        Brand = brand,
                        Model = model,
                        Weight = int.Parse(data[3]),
                    };
                    catalog.Trucks.Add(currentTruck);
                }

                command = Console.ReadLine();
            }
            if (catalog.Cars.Count > 0)
            {
                List<Car> orderedCars = catalog.Cars.OrderBy(x => x.Brand).ToList();
                Console.WriteLine("Cars:");
                foreach (Car car in orderedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (catalog.Trucks.Count > 0)
            {
                List<Truck> orderedTrucks = catalog.Trucks.OrderBy(x => x.Brand).ToList();
                Console.WriteLine("Trucks:");
                foreach (Truck truck in orderedTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
}