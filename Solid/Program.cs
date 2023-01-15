using Solid.Class;
using Solid.Implementation;
using Solid.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("1. Aplikacija mora prikazivati sav prihod ostvaren od karata.");
            Console.ResetColor();
            List<SmallTrain> lightVehicleTrains= new List<SmallTrain>
            {
                new SmallTrain(Enum.TrainType.Small, LightVehiclePrice.Car),
                new SmallTrain(Enum.TrainType.Small, LightVehiclePrice.Combi),
                new SmallTrain(Enum.TrainType.Small, LightVehiclePrice.Combi),
                new SmallTrain(Enum.TrainType.Small, LightVehiclePrice.Car)
            };

            List<LargeTrain> heavyVehicleTrains = new List<LargeTrain>
            {
                new LargeTrain(Enum.TrainType.Large, HeavyVehiclePrice.Truck),
                new LargeTrain(Enum.TrainType.Large, HeavyVehiclePrice.Bus),
                new LargeTrain(Enum.TrainType.Large, HeavyVehiclePrice.Truck)
            };

            var income = new CalculateIncome().CalculateTotalIncome(lightVehicleTrains, heavyVehicleTrains);
            Console.WriteLine($"Total ticket income is: {income}kn");
            Console.WriteLine();



            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("2. Osnovni zaposlenik terminala. Njegova plaća je 10%.");
            Console.ResetColor();
            Employee employee = new Employee("Marko", "Markic", Enum.Salary.Percent10);
            var employeeSalary = new CalculateSalary().CalculateEmployeeSalary(income, (int)employee.Salary);
            Console.WriteLine(employee + $" salary = {employeeSalary}kn");
            Console.WriteLine();



            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("3. Aplikacija mora prikazivati količinu plina za trenutno vozilo.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Prije punjenja...");
            Console.ResetColor();
            List<GasVehicle> gasVehicles = new List<GasVehicle> {
                new GasVehicle("Audi", 88),
                new GasVehicle("BMW", 18),
                new GasVehicle("Nissan", 45),
                new GasVehicle("Renault", 3),
            };
            List<GasVehicle> validVehicles = new List<GasVehicle>();
            foreach (var v in gasVehicles)
            {
                if (v.IsValid(v))
                {
                    validVehicles.Add(v);
                    Console.WriteLine(v);
                }
            }
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Nakon punjenja...");
            Console.ResetColor();
            var loadedVehicles = new FuelFilling().Fill(validVehicles);
            foreach (var v in loadedVehicles)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine();


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("4. Dodajte još jednog zaposlenika terminala koji radi potpuno isti posao. Njegova je plaća 11%");
            Console.ResetColor();
            Employee emp = new Employee("Pero", "Peric", Enum.Salary.Percent11);
            var empSalary = new CalculateSalary().CalculateEmployeeSalary(income, (int)emp.Salary);
            Console.WriteLine(emp + $" salary = {empSalary}kn");
            Console.WriteLine();


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("5. Aplikacija mora prikazivati napunjenost baterije za trenutno vozilo.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Prije punjenja...");
            Console.ResetColor();
            List<ElectricVehicle> eletricVehicles = new List<ElectricVehicle> {
                new ElectricVehicle("Tesla", 25),
                new ElectricVehicle("Mercedes-Benz EQS", 4),
                new ElectricVehicle("Volkswagen ID.4", 89),
                new ElectricVehicle("Renault Megane E-Tech", 3),
            };
            List<ElectricVehicle> validElecticVehicles = new List<ElectricVehicle>();
            foreach (var e in eletricVehicles)
            {
                if (e.IsValid(e))
                {
                    validElecticVehicles.Add(e);
                    Console.WriteLine(e);
                }
            }
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Nakon punjenja...");
            Console.ResetColor();
            var loadedElectricVehicles = new BatteryFilling().Fill(validElecticVehicles);
            foreach (var v in loadedElectricVehicles)
            {
                Console.WriteLine(v);
            }



        }

    }
}
