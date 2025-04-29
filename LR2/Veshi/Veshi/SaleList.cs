using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Veshi
{
    // класс , который будет доступен из других частей программы
    public class SaleList
    {
        //Объявление приватного поля , которое представляет собой список объектов типа массив объектов .
        private List<Sales> Sale;
        //Конструктор класса
        public SaleList()
        {
            //Инициализация списка
            Sale = new List<Sales>();
        }
        //Метод для добавления новой продажи в список
        public void AddSale(Sales sale_)
        {
            //Добавляет объект
            Sale.Add(sale_);
        }
        //Метод для вывода отчета по всем продажам
        public void PrintReportAll()
        {
            //Инициализация переменной для хранения общей выручки
            double totalRevenue = 0;
            //Цикл, который перебирает все объекты в списке 
            foreach (var sale_ in Sale)
            {
                //Предполагается, что у объекта есть метод , который возвращает объект,
                //содержащий информацию об одежде (название, вид, цену, количество).
                var thing = sale_.GetThings();
                //Вывод информации о текущей продаже в консоль
                Console.WriteLine($"День: {sale_.GetDay()}, Название одежды: {thing.GetName()}, Вид: {thing.GetVid()}, Цена: {thing.GetPrice()}, Количество: {thing.GetQuantity()}, Выручка с одежды: {thing.GetPrice() * thing.GetQuantity()}");
                totalRevenue += thing.GetQuantity() * thing.GetPrice();
            }
            Console.WriteLine($"Общая выручка: {totalRevenue}");
        }
        //Метод для вывода отчета по продажам, отфильтрованным по “виду” одежды
        public void PrintReportPerGenre()
        {
            //Вывод списка доступных видов одежды
            Console.WriteLine("\nДоступные виды одежды:");
            int index = 1;
            foreach (var name in Enum.GetNames(typeof(Vid_odezhdi)))
            {
                Console.WriteLine($"{index++}. {name}");
            }

            //Запрос выбора вида одежды
            Console.WriteLine("\nВведите номер вида одежды для отчета:");
            int selectedIndex;
            while (!int.TryParse(Console.ReadLine(), out selectedIndex) || selectedIndex < 1 || selectedIndex > Enum.GetNames(typeof(Vid_odezhdi)).Length)
            {
                Console.WriteLine("Неверный ввод. Пожалуйста, введите номер из списка:");
            }

            //Получение выбранного вида одежды
            Vid_odezhdi selectedVid = (Vid_odezhdi)selectedIndex;
            string vid = selectedVid.ToString();

            //Инициализация переменной для хранения общей выручки для выбранного “вида”
            double totalRevenue = 0;
            bool found = false;

            Console.WriteLine($"\nОтчет по виду: {vid}");
            foreach (var sale_ in Sale)
            {
                //Получение информации об одежде из текущей продажи.
                var thing = sale_.GetThings();
                //Сравнение введенного пользователем “вида” () с “видом” текущей одежды
                if (vid == Convert.ToString(thing.GetVid()))
                {
                    found = true;
                    //Вывод информации о текущей продаже в консоль, если “вид” соответствует введенному.
                    Console.WriteLine($"День: {sale_.GetDay()}, Название одежды: {thing.GetName()}, Вид: {thing.GetVid()}, Цена: {thing.GetPrice()}, Количество: {thing.GetQuantity()}, Выручка с одежды: {thing.GetPrice() * thing.GetQuantity()}");
                    totalRevenue += thing.GetQuantity() * thing.GetPrice();
                }
            }

            if (found)
            {
                Console.WriteLine($"\nОбщая выручка по виду {vid}: {totalRevenue}");
            }
            else
            {
                Console.WriteLine("Выручка по выбранному виду нулевая");
            }
        }
    }
}

