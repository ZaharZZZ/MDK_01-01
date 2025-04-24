using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veshi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем новый объект класса SaleList для хранения информации о продажах
            SaleList report = new SaleList();

            // Добавляем несколько продаж в отчет:
            // Каждая продажа содержит:
            // - номер продавца (1 или 2)
            // - объект Things (товар) с параметрами:
            //   * название товара
            //   * цена
            //   * количество
            //   * бренд (из перечисления Vid_odezhdi)

            
            report.AddSale(new Sales(1, new Things("Сумка", 1500, 12, Vid_odezhdi.Zadidas)));
            report.AddSale(new Sales(1, new Things("Футболка", 1000, 6, Vid_odezhdi.Zike)));
            report.AddSale(new Sales(1, new Things("джинсы", 2000, 8, Vid_odezhdi.Zadidas)));
            report.AddSale(new Sales(1, new Things("Штаны", 2000, 5, Vid_odezhdi.Zuma)));
            report.AddSale(new Sales(1, new Things("джемпер", 3550, 13, Vid_odezhdi.Zalenciaga)));
            report.AddSale(new Sales(1, new Things("кепка", 3500, 9, Vid_odezhdi.Zuma)));


            report.AddSale(new Sales(2, new Things("Штаны", 1000, 5, Vid_odezhdi.Zuma)));
            report.AddSale(new Sales(2, new Things("джемпер", 350, 13, Vid_odezhdi.Zalenciaga)));
            report.AddSale(new Sales(2, new Things("кепка", 1500, 9, Vid_odezhdi.Zuma)));
            report.AddSale(new Sales(2, new Things("Сумка", 1500, 12, Vid_odezhdi.Zadidas)));
            report.AddSale(new Sales(2, new Things("Футболка", 1900, 6, Vid_odezhdi.Zike)));
            report.AddSale(new Sales(2, new Things("джинсы", 3000, 8, Vid_odezhdi.Zadidas)));

            // Запрашиваем у пользователя выбор типа отчета
            int reportType;
            Console.WriteLine("Выберите вид отчёта (1 - весь, 2 - по видам): ");
            reportType = Convert.ToInt32(Console.ReadLine());

            // В зависимости от выбора пользователя выводим соответствующий отчет
            if (reportType == 1)
            {
                // Выводим полный отчет (все продажи)
                report.PrintReportAll();
            }
            else if (reportType == 2)
            {
                // Выводим отчет, сгруппированный по видам одежды/брендам
                report.PrintReportPerGenre();
            }
            else
            {
                // Обработка некорректного ввода
                Console.WriteLine("Введено неверное значение");
            }
        }
    }
}
