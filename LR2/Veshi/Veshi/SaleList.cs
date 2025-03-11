using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Veshi
{
    public class SaleList
    {
        private List<Sales> Sale;

        public SaleList()
        {
            Sale = new List<Sales>();
        }

        public void AddSale(Sales sale_)
        {
            Sale.Add(sale_);
        }

        public void PrintReportAll()
        {
            double totalRevenue = 0;
            foreach (var sale_ in Sale)
            {
                var thing = sale_.GetThings();

                Console.WriteLine($"День: {sale_.GetDay()}, Название одежды: {thing.GetName()}, Вид: {thing.GetVid()}, Цена: {thing.GetPrice()}, Количество: {thing.GetQuantity()}, Выручка с одежды: {thing.GetPrice() * thing.GetQuantity()}");
                totalRevenue += thing.GetQuantity() * thing.GetPrice();
            }
            Console.WriteLine($"Общая выручка: {totalRevenue}");
        }

        public void PrintReportPerGenre()
        {
            string vid;
            Console.WriteLine("Введите вид: ");
            vid = Console.ReadLine();

            double totalRevenue = 0;
            foreach (var sale_ in Sale)
            {
                var thing = sale_.GetThings();
                if (vid == Convert.ToString(thing.GetVid()))
                {
                    Console.WriteLine($"День: {sale_.GetDay()}, Название одежды: {thing.GetName()}, Жанр: {thing.GetVid()}, Цена: {thing.GetPrice()}, Количество: {thing.GetQuantity()}, Выручка с одежды: {thing.GetPrice() * thing.GetQuantity()}");
                    totalRevenue += thing.GetQuantity() * thing.GetPrice();
                }
            }
            if (totalRevenue != 0)
            {
                Console.WriteLine($"Общая выручка: {totalRevenue}");
            }
            if (totalRevenue == 0)
            {
                Console.WriteLine("Выручка по виду нулевая/Данного вида не существует");
            }
        }
    }
}

