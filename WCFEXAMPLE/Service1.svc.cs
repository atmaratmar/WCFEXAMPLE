using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFEXAMPLE
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private static readonly List<Person> Catches = new List<Person>
        {
            new Person(1, "EbbeVand2222", "Gedde", 3.75, "Aresø", 2),
            new Person(2, "PeterStor", "Ørred", 1.55, "Emsø", 7),
            new Person(3, "Andybor", "Skalle", 0.35, "Vejlesø", 25),
            new Person(4, "JamShen", "Bras", 1.30, "RoSø", 25),
            new Person(5, "ZuSheik", "Snapper", 0.75, "Lundsø", 30),
            new Person(6, "Micha", "Helt", 0.95, "Furesø", 2)
        };
        public Person AddFish(Person catch1)
        {
            Catches.Add(catch1);
            return catch1;
        }

        public void DeleteFish(int id)
        {
            Catches.Remove(Catches.Find(Catches => Catches.ID == id));
        }

        public IList<Person> GetAllFishes()
        {
            return Catches;
        }

        public IEnumerable<string> GetAllFishesName()
        {
            return Catches.Select(Catch => Catch.Navn);
        }

        public Person GetFishById(int id)
        {
            var idInt = id;
            return Catches.FirstOrDefault(Catches => Catches.ID == idInt);
        }

        public IEnumerable<Person> GetFishesByName(string nameFragment)
        {
            nameFragment = nameFragment.ToLower();
            return Catches.FindAll(Catch => Catch.Navn.ToLower().Contains(nameFragment));
        }

        public void UpdateFish(Person c, int id)
        {
            var find = Catches.Find(Catches => Catches.ID == id);
            find.ID = c.ID;
            find.Navn = c.Navn;
            find.Art = c.Art;
            find.Vaegt = c.Vaegt;
            find.Sted = c.Sted;
            find.Uge = c.Uge;
        }
    }
}
