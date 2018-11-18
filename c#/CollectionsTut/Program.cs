using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsTut
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Toyota", "Camry", "A1", 2001, 30000);
            Car car2 = new Car("Hyundai", "Sonata", "B2", 2017, 22000);
            Car car3 = new Car("Toyota", "Prius", "C3", 1988, 35000);
            Car car4 = new Car("Honda", "Civic", "D4", 2003, 27000);
            Car car5 = new Car("Toyota", "Corolla", "E5", 2009, 23000);

            //// List<T>
            //// Work the same as ArrayLists, but is limited
            //// by specifying the type of List
            //List<Car> myList = new List<Car>();
            //myList.Add(car1);
            //myList.Add(car2);
            //// myList.Add("hello"); // ERROR

            //foreach(Car car in myList)
            //{
            //    Console.WriteLine(car.Make);
            //}


            //// Dictionary<TKey, TValue>
            //Dictionary<string, Car> myDict = new Dictionary<string, Car>();
            //myDict.Add(car1.VIN, car1);
            //myDict.Add(car2.VIN, car1);
            //Console.WriteLine(myDict["B2"].Make);

            //// LINQ query
            //List<Car> carList = new List<Car>() { car1, car2, car3, car4, car5 };
            //var toyotas = from car in carList
            //              where car.Make == "Toyota"
            //                       && car.Year > 2000
            //              select car;

            //var orderedCars = from car in carList
            //orderby car.Year descending
            //select car;
            //foreach (var car in toyotas)
            //{
            //    Console.WriteLine("{0} - {1}", car.Model, car.VIN);
            //}


            // LINQ Method
            List<Car> carList = new List<Car>() { car1, car2, car3, car4, car5 };
            var toyotas = carList.Where(car => car.Make == "Toyota"
                                       && car.Year > 2000);
            var orderedCars = carList.OrderByDescending(car => car.Year);
            bool allTrue = carList.TrueForAll(x => x.Year > 1980);
            bool priusExists = carList.Exists(x => x.Model == "Prius");
            int totalPrice = carList.Sum(x => x.StickerPrice);
            carList.ForEach(x => x.StickerPrice += 250);
            carList.ForEach(x => Console.WriteLine("{0} - {1:C}", x.VIN, x.StickerPrice));


        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string VIN { get; set; }
        public int Year { get; set; }
        public int StickerPrice { get; set; }

        public Car(string make, string model, string vin, int year, int price)
        {
            this.Make = make;
            this.Model = model;
            this.VIN = vin;
            this.Year = year;
            this.StickerPrice = price;
        }
    }

}
