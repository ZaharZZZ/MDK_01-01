using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veshi
{
    //Класс служит для представления информации об одной продаже.
    //Он связывает день продажи с конкретным товаром
    public class Sales
    {
        private int day_;
        private Things Vid_;
        //Конструктор класса . Он вызывается при создании нового объекта класса
        public Sales (int day, Things vid)
        {
            day_ = day;
            Vid_ = vid;
        }
        public int GetDay()
        {
            return day_;
        }
        public Things GetThings()
        {
            return Vid_;
        }
    }
}
