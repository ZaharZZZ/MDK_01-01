
using MyTreeView;
using System.Collections.Generic;


namespace MyLib.Models
{
    public class CarModel
    {
        public List<Car> Cars { get; }
        
        public CarModel()
        {
            Cars = new List<Car>();

            Cars.Add (new Car{ Name = "Aveo", release_date = "2008",engine_capacity = "1598 см³"});
            Cars.Add(new Car { Name = "eo", release_date = "28", engine_capacity = "1598 см³" });

        }
        public Car GetExampleByName(string name)
        {
            return Cars.Find(e => e.Name == name);
        }
    }
}
