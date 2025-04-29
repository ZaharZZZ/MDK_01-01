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

            
            report.AddSale(new Sales(1, new Things("Puma", 1500, 12, Vid_odezhdi.Сумка)));
            report.AddSale(new Sales(1, new Things("Addidas", 1000, 6, Vid_odezhdi.Футболка)));
            report.AddSale(new Sales(1, new Things("Nike", 2000, 8, Vid_odezhdi.Сумка)));
            report.AddSale(new Sales(1, new Things("Puma", 2000, 5, Vid_odezhdi.Футболка)));
            report.AddSale(new Sales(1, new Things("Nike", 3550, 13, Vid_odezhdi.Кепка)));
            report.AddSale(new Sales(1, new Things("Addidas", 3500, 9, Vid_odezhdi.Шорты)));


            report.AddSale(new Sales(2, new Things("Nike", 1000, 5, Vid_odezhdi.Шорты)));
            report.AddSale(new Sales(2, new Things("Puma", 350, 13, Vid_odezhdi.Сумка)));
            report.AddSale(new Sales(2, new Things("Addidas", 1500, 9, Vid_odezhdi.Футболка)));
            report.AddSale(new Sales(2, new Things("Nike", 1500, 12, Vid_odezhdi.Кофта)));
            report.AddSale(new Sales(2, new Things("Nike", 1900, 6, Vid_odezhdi.Шорты)));
            report.AddSale(new Sales(2, new Things("Addidas", 3000, 8, Vid_odezhdi.Кепка)));

            // Запрашиваем у пользователя выбор типа отчета
            bool continueRunning = true;

            while (continueRunning)
            {
                Console.Clear(); // Очищаем консоль перед новым выбором
                Console.WriteLine("Меню отчетов:");
                Console.WriteLine("1 - Полный отчет");
                Console.WriteLine("2 - Отчет по видам одежды");
                Console.WriteLine("3 - Выход");
                Console.Write("Выберите действие: ");

                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
                {
                    Console.Write("Неверный ввод. Пожалуйста, введите число от 1 до 3: ");
                }

                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        report.PrintReportAll();
                        break;
                    case 2:
                        Console.Clear();
                        report.PrintReportPerGenre();
                        break;
                    case 3:
                        continueRunning = false;
                        Console.WriteLine("Программа завершена.");
                        continue;
                }

                if (continueRunning)
                {
                    Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
                    Console.ReadKey();
                }
            }
        }
    }
}
