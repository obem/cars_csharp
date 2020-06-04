using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Cars.models
{
    /// <summary>
    /// a classification of a car
    /// sealed: we can define, that no other class
    /// can inherit the sportcar class
    /// </summary>
    sealed class SportCar : Car
    {
        /// <summary>
        /// passes the parameters to the base class
        /// and defines that i am a sportcar
        /// </summary>
        /// <param name="producer"></param>
        /// <param name="name"></param>
        /// <param name="year"></param>
        /// <param name="color"></param>
        public SportCar(string producer, string name, int year, string color)
            : base(CarType.SPORTCAR, producer, name, year, color)
        {
            
        }
    }
}
