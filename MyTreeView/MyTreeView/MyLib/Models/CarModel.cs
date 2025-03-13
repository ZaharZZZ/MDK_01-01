
using System.Collections.Generic;
using MyTreeView;

namespace MyLib.Models
{
    public class CarModel
    {
        public List<Car> cars_ { get; }
        
        public CarModel()
        {
            cars_ = new List<Car>();
            cars_.Add (new Car{ name = "Aveo", releaseDate = "2008", engineCapacity = "1598 см³"});
            cars_.Add(new Car { name = "Lacetti", releaseDate = "28", engineCapacity = "1598 см³" });
            cars_.Add(new Car { name = "Cruze", releaseDate = "28", engineCapacity = "1598 см³" });
            cars_.Add(new Car { name = "Verna", releaseDate = "28", engineCapacity = "1598 см³" });
            cars_.Add(new Car { name = "Aura", releaseDate = "28", engineCapacity = "1598 см³" });
            cars_.Add(new Car { name = "Azera", releaseDate = "28", engineCapacity = "1598 см³" });
            cars_.Add(new Car { name = "RS7", releaseDate = "28", engineCapacity = "1598 см³" });
            cars_.Add(new Car { name = "A7", releaseDate = "28", engineCapacity = "1598 см³" });
            cars_.Add(new Car { name = "A3", releaseDate = "28", engineCapacity = "1598 см³" });
            cars_.Add(new Car { name = "Traverse", releaseDate = "28", engineCapacity = "1598 см³" }); 
            cars_.Add(new Car { name = "Lacetti", releaseDate = "28", engineCapacity = "1598 см³" });
            cars_.Add(new Car { name = "Equinox", releaseDate = "28", engineCapacity = "1598 см³" });

        }
        public Car GetExampleByName(string name)
        {
            return cars_.Find(e => e.name == name);
        }
    }
}
