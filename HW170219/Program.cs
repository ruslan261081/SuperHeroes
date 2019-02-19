using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW170219
{
    class Program
    {
        static void Main(string[] args)
        {
            Flash hero1 = new Flash(300, "Moshe", 31);
            SpiderMan hero2 = new SpiderMan(275, "Menashe", 25);
            SuperMan hero3 = new SuperMan(1000, "Jakob", 27);

            ISuperHero[] superHeroes = new ISuperHero[3];
            superHeroes[0] = hero1;
            superHeroes[1] = hero2;
            superHeroes[2] = hero3;
            Console.WriteLine("Good Look SuperHeroes");

            foreach(object HeroPerson in superHeroes)
            {
                IdentifyHero((ISuperHero)HeroPerson);
                ActivateHero((ISuperHero)HeroPerson);
                GetMoreHeroData((ISuperHero)HeroPerson);

            }
            Console.ReadLine();
        }
        static void IdentifyHero(ISuperHero hero)
        {
            if(hero is Flash)
            {
                Console.WriteLine("Flash is coming");
            }
            else if(hero is SpiderMan)
            {
                Console.WriteLine("SpiderMan is comin to you");
            }
            else if(hero is SuperMan)
            {
                Console.WriteLine("SuperMan in the sky");
            }
            else
            {
                Console.WriteLine("Heroes in holiday today");
            }
        }
        static void ActivateHero(ISuperHero hero)
        {
            hero.ActivateSuperPowers();
        }
        static void GetMoreHeroData(ISuperHero hero)
        {
            if(hero is Flash)
            {
                Console.WriteLine("Flash is coming");
                Console.WriteLine((hero as Flash).Voltage);
            }
            else if(hero is SpiderMan)
            {
                Console.WriteLine("SpiderMan is coming");
                Console.WriteLine((hero as SpiderMan).Speed);
            }
            else if(hero is SuperMan)
            {
                Console.WriteLine("SuperMan in the sky");
                Console.WriteLine((hero as SuperMan).WebLeft);
            }
            else
            {
                Console.WriteLine("Heroes in holiday today");
            }
        }
        static ISuperHero CreateHero(string HeroName)
        {
            Flash option1 = new Flash(375, HeroName, 30);
            SpiderMan option2 = new SpiderMan(450, HeroName, 21);
            SuperMan option3 = new SuperMan(1001, HeroName, 35);

            switch(HeroName)
            {
                case ("Flash"): return option1;
                case ("SpiderMan"): return option2;
                case ("Superman"): return option3;
                default:return null;
            }
        }
    }
}
