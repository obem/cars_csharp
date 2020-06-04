using Cars.Extensions;
using Cars.models;
using System;
using System.Collections.Generic;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            List<Car> cars = new List<Car>();
            CarType? selectedCarType = null;

            while (run)
            {
                //print user selection
                Console.WriteLine("Was für ein Auto möchten Sie konfigurieren?\n1. Auto \n2. Sportauto");
                /*
                 * read the user selection, i created an generic extension method to convert string do any
                 * datatype ==> ConvertType<T>
                 */
                var choice = Console.ReadLine().ConvertType<int>();

                /*
                 * same like if(choice != null)
                 */
                if (choice.HasValue && (choice.Value == 1 || choice.Value == 2))
                {
                    /*
                     * on 1 its a car on 2 its a sportcar
                     */
                    selectedCarType = choice.Value == 1 ? CarType.CAR : CarType.SPORTCAR;

                    if (selectedCarType.HasValue)
                    {
                        /*
                         * user inputs for the properties of car
                         */
                        Console.WriteLine("Modell:");
                        var modelName = Console.ReadLine();
                        Console.WriteLine("Hersteller:");
                        var producer = Console.ReadLine();
                        Console.WriteLine("Herstellungsjahr:");
                        var year = Console.ReadLine().ConvertType<int>();
                        Console.WriteLine("Farbe:");
                        var color = Console.ReadLine();

                        Car newCar = null;
                        /*
                         * sportcar or car to create?
                         */
                        switch (selectedCarType.Value)
                        {
                            case CarType.CAR:
                                newCar = new Car(producer, modelName, year.Value, color);
                                break;

                            case CarType.SPORTCAR:
                                newCar = new SportCar(producer, modelName, year.Value, color);
                                break;
                        }

                        /*
                         * add the new car
                         */
                        cars.Add(newCar);

                        Console.WriteLine("\nWie wollen Sie fortfahren? \n 1. weitere Autos anlegen \n 2. Autos anzeigen \n 3. Abbrechen");
                        
                        var continueChoice = Console.ReadLine().ConvertType<int>();

                        if(continueChoice.HasValue && continueChoice.Value >= 1 && continueChoice.Value <= 3)
                        {
                            /*
                             * shows the cars
                             * ToConsole is an Extension written in the extensions folder
                             */
                            if(continueChoice.Value == 2)
                            {
                                Console.WriteLine(cars.ToConsole<Car>());
                                /*
                                 * continue after shown?
                                 */
                                Console.WriteLine("\nFortfahren? (Y/N)");
                                var continueAfterShown = Console.ReadLine();

                                if(continueAfterShown == "N")
                                {
                                    run = false;
                                }
                            } 
                            else if(continueChoice.Value == 3)
                            {
                                run = false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Bitte gültige Auswahl treffen!");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Bitte gültige Auswahl treffen");
                }
            }
        }
    }
}
