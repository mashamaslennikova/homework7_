using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AbstractFactory
{
    public class AbstractFactory
    {
        // AbstractProductA
        abstract class Car
        {
            public abstract void Info();
        }
        // ConcreteProductA1
        class Ford : Car
        {
            public override void Info()
            {
                Console.WriteLine("Ford");
            }
        }
        //ConcreteProductA2
        class Toyota : Car
        {
            public override void Info()
            {
                Console.WriteLine("Toyota");
            }
        }
        class Mercedes : Car
        {
            public override void Info()
            {
                Console.WriteLine("Mercedes");
            }
        }
        // AbstractProductB
        abstract class Engine
        {
            public virtual void GetPower()
            {
            }
        }
        // ConcreteProductB1
        class FordEngine : Engine
        {
            public override void GetPower()
            {
                Console.WriteLine("Ford Engine 4.4");
            }
        }

        //ConcreteProductB2
        class ToyotaEngine : Engine
        {
            public override void GetPower()
            {
                Console.WriteLine("Toyota Engine 3.2");
            }
        }
        class MercedesEngine : Engine
        {
            public override void GetPower()
            {
                Console.WriteLine("Mercedes Engine V12");
            }
        }

        abstract class Wheels
        {
            public virtual void Drive()
            {
            }
        }

        class FordWheels : Wheels
        {
            public override void Drive()
            {
                Console.WriteLine("Wheels1");
            }
        }

        //ConcreteProductB2
        class ToyotaWheels : Wheels
        {
            public override void Drive()
            {
                Console.WriteLine("Wheels1");
            }
        }
        class MercedesWheels : Wheels
        {
            public override void Drive()
            {
                Console.WriteLine("Wheels1");
            }
        }


        // AbstractFactory
        interface ICarFactory
        {
            Car CreateCar();
            Engine CreateEngine();
            Wheels CreateWheels();
        }
        // ConcreteFactory1
        class FordFactory : ICarFactory
        {
            // from CarFactory
            Car ICarFactory.CreateCar()
            {
                return new Ford();
            }
            Engine ICarFactory.CreateEngine()
            {
                return new FordEngine();
            }
            Wheels ICarFactory.CreateWheels()
            {
                return new FordWheels();
            }
        }
        // ConcreteFactory2
        class ToyotaFactory : ICarFactory
        {
            // from CarFactory
            Car ICarFactory.CreateCar()
            {
                return new Toyota();
            }
            Engine ICarFactory.CreateEngine()
            {
                return new ToyotaEngine();
            }
            Wheels ICarFactory.CreateWheels()
            {
                return new ToyotaWheels();
            }
        }
        class MercedesFactory : ICarFactory
        {
            Car ICarFactory.CreateCar()
            {
                return new Mercedes();
            }
            Engine ICarFactory.CreateEngine()
            {
                return new MercedesEngine();
            }
            Wheels ICarFactory.CreateWheels()
            {
                return new MercedesWheels();
            }
        }
        static void Main(string[] args)
        {
            ICarFactory carFactory;
            Car myCar;
            // Створення змінної інтерфейсу фабрики

            carFactory = new ToyotaFactory();
            myCar = carFactory.CreateCar();
            myCar.Info();
            Engine myEngine = carFactory.CreateEngine();
            myEngine.GetPower();
            Wheels myWheels = carFactory.CreateWheels();
            myWheels.Drive();
            // Присвоєння змінній заводу "Тойота". Представлення автівки даної марки

            carFactory = new FordFactory();
            myCar = carFactory.CreateCar();
            myCar.Info();
            myEngine = carFactory.CreateEngine();
            myEngine.GetPower();
            myWheels = carFactory.CreateWheels();
            myWheels.Drive();
            // Присвоєння змінній заводу "Форд". Представлення автівки даної марки

            carFactory = new MercedesFactory();
            myCar = carFactory.CreateCar();
            myCar.Info();
            myEngine = carFactory.CreateEngine();
            myEngine.GetPower();
            myWheels = carFactory.CreateWheels();
            myWheels.Drive();
            // Присвоєння змінній заводу "Мерседес". Представлення автівки даної марки

            Console.ReadKey();
        }
    }
}
