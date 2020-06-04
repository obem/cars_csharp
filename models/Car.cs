using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Cars.models
{
    /// <summary>
    /// a class that represent cars with some basic properties
    /// </summary>
    class Car
    {
        /// <summary>
        /// is it an car, or an sportcar? or something else
        /// </summary>
        public CarType CarType { get; set; }
        /// <summary>
        /// who produce this car
        /// </summary>
        public string Producer { get; set; }
        /// <summary>
        /// name of the car (brand)
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// when was the car built in
        /// </summary>
        public int Year { get; set; }
        /// <summary>
        /// which color has the car
        /// </summary>
        public string Color { get; set; }

        public Car(CarType carType, string producer, string name, int year, string color)
        {
            CarType = carType;
            Producer = producer;
            Name = name;
            Year = year;
            Color = color;
        }

        public Car(string producer, string name, int year, string color)
        {
            CarType = CarType.CAR;
            Producer = producer;
            Name = name;
            Year = year;
            Color = color;
        }

        public override string ToString()
        {
            return $"{CarType} - {Name} - {Year} // {Producer}";
        }
    }
}
