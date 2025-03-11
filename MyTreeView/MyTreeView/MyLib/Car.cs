using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTreeView
{
    public class Car
    {
        public string Name { get; set; }
        public string release_date { get; set; }

        public string engine_capacity { get; set; }

        public static Dictionary<string, string> properties = new Dictionary<string, string>
        {
            {nameof(Name), "Название" },
            {nameof(release_date), "Дата выпуска" },
            {nameof(engine_capacity), "Обьём двигателя" }

        };
    }
}
