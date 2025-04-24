using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR3
{
    public partial class MainForm : Form
    {
        // Словарь для хранения меню: ключ - группа блюд (например, "Закуски"), значение - список блюд в этой группе
        Dictionary<string, List<string>> menu;

        // Словарь для хранения заказа: 
        // ключ 1-го уровня - группа блюд, 
        // ключ 2-го уровня - название блюда, 
        // значение - количество этого блюда в заказе
        Dictionary<string, Dictionary<string, int>> order = new Dictionary<string, Dictionary<string, int>>();

        public MainForm()
        {
            InitializeComponent(); // Стандартная инициализация компонентов формы
            InitializeMedication(); // Инициализация данных меню
            InitializeData(); // Настройка элементов управления
        }

        // Метод для инициализации данных меню
        private void InitializeMedication()
        {
            // Создание структуры меню с группами блюд и их списками
            menu = new Dictionary<string, List<string>>
        {
            { "Закуски", new List<string>{"Салат Цезарь", "Сырные палочки", "Гренки чесночные"}},
            { "Основные блюда", new List<string>{"Стейк", "Паста Карбонара", "Пицца Маргарита"}},
            {"Напитки", new List<string>() {"Кола", "Сок апельсиновый", "Вода"}},
            { "Десерты", new List<string>{"Тирамису", "Чизкейк", "Мороженое"}}
        };

            // Инициализация структуры заказа для каждой группы меню
            foreach (var group in menu.Keys)
            {
                order[group] = new Dictionary<string, int>();
            }
        }

        // Метод для настройки элементов управления на форме
        private void InitializeData()
        {
            // Заполнение listBox_groups названиями групп меню
            foreach (var group in menu.Keys)
            {
                listBox_groups.Items.Add(group);
            }

            // Подписка на события
            listBox_groups.SelectedIndexChanged += listBox_groups_SelectedIndexChanged; // При изменении выбранной группы
            button_AddToZakaz.Click += button_AddToZakaz_Click; // При нажатии кнопки "Добавить в заказ"
        }

        // Обработчик события изменения выбранной группы в listBox_groups
        private void listBox_groups_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Очистка панели перед добавлением новых элементов
            SelectionPanel_flowLayoutPanel.Controls.Clear();

            // Получение выбранной группы из listBox
            string SelectedGroup = listBox_groups.SelectedItem.ToString();

            // Для каждого блюда в выбранной группе
            foreach (var blu in menu[SelectedGroup])
            {
                // Создание CheckBox для выбора блюда
                CheckBox checkBox = new CheckBox { Text = blu };
                // Создание NumericUpDown для выбора количества
                NumericUpDown numericUpDown = new NumericUpDown { Minimum = 0, Maximum = 100, Width = 50 };

                // Если блюдо уже есть в заказе, устанавливаем соответствующие значения
                if (order[SelectedGroup].ContainsKey(blu))
                {
                    numericUpDown.Value = order[SelectedGroup][blu];
                    checkBox.Checked = true;
                }

                // Обработчик изменения состояния CheckBox
                checkBox.CheckedChanged += (s, ev) =>
                {
                    if (checkBox.Checked)
                    {
                        // Если блюдо выбрано, добавляем его в заказ с текущим количеством
                        order[SelectedGroup][blu] = (int)numericUpDown.Value;
                    }
                    else
                    {
                        // Если сняли выбор, удаляем блюдо из заказа
                        order[SelectedGroup].Remove(blu);
                    }
                };

                // Обработчик изменения значения NumericUpDown
                numericUpDown.ValueChanged += (s, ev) =>
                {
                    // Если блюдо выбрано, обновляем его количество в заказе
                    if (checkBox.Checked)
                    {
                        order[SelectedGroup][blu] = (int)numericUpDown.Value;
                    }
                };

                // Добавление элементов на панель
                SelectionPanel_flowLayoutPanel.Controls.Add(checkBox);
                SelectionPanel_flowLayoutPanel.Controls.Add(numericUpDown);
            }
        }

        // Обработчик нажатия кнопки "Добавить в заказ"
        private void button_AddToZakaz_Click(object sender, EventArgs e)
        {
            string orders = ""; // Строка для формирования текста заказа

            // Перебор всех групп меню
            foreach (string group in menu.Keys)
            {
                orders += $"{group}:\n"; // Добавляем название группы

                if (order[group].Count > 0)
                {
                    // Добавляем все блюда из этой группы, которые есть в заказе
                    foreach (var blu in order[group])
                    {
                        orders += $"{blu.Key} x {blu.Value}\n"; // Название блюда и количество
                    }
                }
                else
                {
                    orders += "-------------- \n"; // Если в группе ничего не заказано
                }
            }

            // Выводим сформированный заказ в richTextBox1
            richTextBox1.Text = orders;
        }
    }
}
