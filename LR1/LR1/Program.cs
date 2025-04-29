using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1
{
    public class Client
    {
        public string Name { get; set; }
        public List<string> Services { get; set; } = new List<string>();

        public Client(string name)
        {
            Name = name;
        }
    }

    public class SalonManagement
    {
        private List<Client> clients;

        public SalonManagement()
        {
            clients = new List<Client>();
        }

        public void AddClient(Client client)
        {
            clients.Add(client);
        }
        //Добавляет услугу к списку услуг клиента (по имени)
        public void AddServiceToClient(string clientName, string serviceName)
        {
            Client client = clients.FirstOrDefault(c => c.Name == clientName);
            if (client != null)
            {
                client.Services.Add(serviceName);
            }
            else
            {
                Console.WriteLine($"Клиент с именем '{clientName}' не найден.");
            }
        }
        //Выводит список клиентов, использующих указанную услугу, отсортированный по частоте использования, и вычисляет среднее количество обращений по этой услуге.
        public void ProcessServiceRequest(string serviceName)
        {
            // 1. Считаем, сколько раз каждый клиент использовал услугу.
            var clientServiceCounts = new Dictionary<string, int>();
            foreach (var client in clients)
            {
                int count = client.Services.Count(s => s == serviceName);
                if (count > 0)
                {
                    clientServiceCounts.Add(client.Name, count);
                }
            }

            // 2. Сортируем клиентов по убыванию количества использований услуги.
            var sortedClients = clientServiceCounts.OrderByDescending(kvp => kvp.Value);

            // 3. Выводим список клиентов.
            Console.WriteLine($"Клиенты, использующие услугу '{serviceName}':");
            if (sortedClients.Any())
            {
                foreach (var kvp in sortedClients)
                {
                    Console.WriteLine($"- {kvp.Key}: {kvp.Value} раз(а)");
                }
            }
            else
            {
                Console.WriteLine("Нет клиентов, использующих эту услугу.");
            }

            // 4. Подсчитываем среднее количество обращений по данной услуге.
            if (clientServiceCounts.Values.Count > 0)
            {
                double averageCount = (double)clientServiceCounts.Values.Sum() / clients.Count;
                Console.WriteLine($"\nСреднее количество обращений по услуге '{serviceName}': {averageCount:F2}");
            }
            else
            {
                Console.WriteLine($"\nСреднее количество обращений по услуге '{serviceName}': 0.00");
            }


        }

        public List<string> GetAllServices() // Возвращает список услуг для выбора
        {
            HashSet<string> allServices = new HashSet<string>(); // Используем HashSet для уникальности услуг

            foreach (var client in clients)
            {
                foreach (var service in client.Services)
                {
                    allServices.Add(service);
                }
            }

            return allServices.ToList();
        }

        public string SelectService()
        {
            List<string> services = GetAllServices();

            if (!services.Any())
            {
                Console.WriteLine("В системе нет зарегистрированных услуг.");
                return null;
            }

            Console.WriteLine("Выберите услугу из списка (введите номер):");
            for (int i = 0; i < services.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {services[i]}");
            }

            int choice;
            while (true)
            {
                Console.Write("Ваш выбор: ");
                if (int.TryParse(Console.ReadLine(), out choice) && choice > 0 && choice <= services.Count)
                {
                    return services[choice - 1];
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите номер услуги из списка.");
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SalonManagement salon = new SalonManagement();

            // Добавляем клиентов и услуги
            Client client1 = new Client("Иванова Мария");
            client1.Services.Add("Стрижка");
            client1.Services.Add("Окрашивание");
            client1.Services.Add("Маникюр");
            client1.Services.Add("Стрижка");
            client1.Services.Add("Стрижка");

            Client client2 = new Client("Петрова Анна");
            client2.Services.Add("Маникюр");
            client2.Services.Add("Педикюр");
            client2.Services.Add("Массаж");
            client2.Services.Add("Маникюр");
            client2.Services.Add("Стрижка");
            client2.Services.Add("Стрижка");
            client2.Services.Add("Стрижка");
            client2.Services.Add("Стрижка");

            Client client3 = new Client("Сидорова Елена");
            client3.Services.Add("Стрижка");
            client3.Services.Add("Массаж");

            salon.AddClient(client1);
            salon.AddClient(client2);
            salon.AddClient(client3);

            // Выбор услуги
            bool continueRunning = true;
            while (continueRunning)
            {
                // Выбор услуги
                string selectedService = salon.SelectService();

                if (selectedService != null)
                {
                    salon.ProcessServiceRequest(selectedService);
                }

                // Предложение продолжить
                Console.Write("Хотите выбрать другую услугу? (да/нет): ");
                string answer = Console.ReadLine().ToLower();
                if (answer != "да")
                {
                    continueRunning = false;
                }
                Console.WriteLine(); // Добавляем пустую строку для лучшего отображения
            }

            Console.WriteLine("Программа завершена.");
            Console.ReadKey();
        }
    }
}
