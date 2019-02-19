using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW170219
{
    interface ISuperHero
    {
        void ActivateSuperPowers();
        
    }
    interface IFlash : ISuperHero
    {
        void FireLightnings();
    }
    interface IClimb : ISuperHero
    {
        void Climb();
    }
    interface IFly : ISuperHero
    {
        void Fly();
    }

    abstract class Human
    {
        public abstract string Name { get; set; }

        private int age;

        public  int AgeGet
        {
            get
            {
                return this.age;
            }
        }

        protected Human(string name, int age)
        {
            Name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return $"The Name is: {Name}, age is: {age}";
        }
    }
    class Flash : Human, IFlash 
    {
        public int Voltage{get; private set;}
        public override string Name { get; set; }

        public Flash(int voltage, string name, int age) : base(name, age)
        {
            Voltage = voltage;

        }
       
        public void ActivateSuperPowers()
        {
            Console.WriteLine("Flash is superhero !!! ");
        }

        public void FireLightnings()
        {
            Console.WriteLine("");
        }

        public override string ToString()
        {
            return $"Voltage is: {Voltage} " + base.ToString();
        }
    }
    class SpiderMan : Human, IClimb
    {
        public int Speed { get; private set; }
        public override string Name { get; set; }

        public SpiderMan(int speed, string name, int age) : base(name,age)
        {
            Speed = speed;

        }


        public void ActivateSuperPowers()
        {
            Console.WriteLine("SpiderMan can walk the wall");
        }

        public void Climb()
        {
            Console.WriteLine("SpiderMan can Climb everyone");
        }

        public override string ToString()
        {
            return $"Speed is: {Speed} " + base.ToString();
        }
    }
    class SuperMan : Human, IFly
    {
        public int WebLeft { get; private set; }
        public override string Name { get; set; }

        public SuperMan(int webleft, string name, int age) : base(name,age)
        {
            WebLeft = webleft;
        }

        public void ActivateSuperPowers()
        {
            Console.WriteLine("SuperMan help people in truble");
        }

        public void Fly()
        {
            Console.WriteLine("I Belive a can fly, I Belive a can touch to sky");
        }

        public override string ToString()
        {
            return $"Webleft Is: {WebLeft} " + base.ToString();
        }
    }



}
