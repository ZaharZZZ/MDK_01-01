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
            SaleList report = new SaleList();
            report.AddSale(new Sales(1, new Things("Сумка", 1500, 12, Vid_odezhdi.Zadidas)));
            report.AddSale(new Sales(1, new Things("Футболка", 1700, 6, Vid_odezhdi.Zike)));

            report.AddSale(new Sales(2, new Things("джинсы", 2000, 8, Vid_odezhdi.Zoika_gobana)));
            report.AddSale(new Sales(2, new Things("Штаны", 1000, 5, Vid_odezhdi.Zuma)));

            report.AddSale(new Sales(3, new Things("джемпер", 350, 13, Vid_odezhdi.Zalenciaga)));
            report.AddSale(new Sales(3, new Things("кепка", 500, 9, Vid_odezhdi.Ztone_Zisland)));



            int reportType;
            Console.WriteLine("Выберите вид отчёта (1 - весь, 2 - по видам): ");
            reportType = Convert.ToInt32(Console.ReadLine());
            if (reportType == 1)
            {
                report.PrintReportAll();
            }
            else if (reportType == 2)
            {
                report.PrintReportPerGenre();
            }
            else
            {
                Console.WriteLine("Введено неверное значение");
            }
        }
    }
}
