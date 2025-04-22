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
        Dictionary<string, List<string>> menu; // Словарь для хранения групп медикаментов и их списка 

        Dictionary<string, Dictionary<string, int>> order = new Dictionary<string, Dictionary<string, int>>();
        // Словарь для хранения выбранных медикоментов и их количества

        public MainForm()
        {
            InitializeComponent();
            InitializeMedication();
            InitializeData();

        }
        private void InitializeMedication()
        {
            menu = new Dictionary<string, List<string>>
            {
                { "Закуски", new List<string>{"Салат Цезарь", "Сырные палочки", "Гренки чесночные"}},
                { "Основные блюда", new List<string>{"Стейк", "Паста Карбонара", "Пицца Маргарита"}},
                 {"Напитки", new List<string>() {"Кола", "Сок апельсиновый", "Вода"}},
                { "Десерты", new List<string>{"Тирамису", "Чизкейк", "Мороженое"}}
            };

            foreach (var group in menu.Keys)
            {
                order[group] = new Dictionary<string, int>();
            }
        }
        private void InitializeData()
        {
            foreach (var group in menu.Keys)
            {
                listBox_groups.Items.Add(group);
            }

            listBox_groups.SelectedIndexChanged += listBox_groups_SelectedIndexChanged;
            button_AddToZakaz.Click += button_AddToZakaz_Click;
        }
        //отвечает за заполнение списка блюд
        private void listBox_groups_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectionPanel_flowLayoutPanel.Controls.Clear();
            // Получаем выбранную группу меню
            string SelectedGroup = listBox_groups.SelectedItem.ToString();
            // Заполняем блюдами из выбранной группы
            foreach (var blu in menu[SelectedGroup])
            {
                CheckBox checkBox = new CheckBox { Text = blu };
                NumericUpDown numericUpDown = new NumericUpDown { Minimum = 0, Maximum = 100, Width = 50 };

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
                        order[SelectedGroup][blu] = (int)numericUpDown.Value;
                    }
                    else
                    {
                        order[SelectedGroup].Remove(blu);
                    }
                };

                // Обработчик изменения значения NumericUpDown
                numericUpDown.ValueChanged += (s, ev) =>
                {
                    if (checkBox.Checked)
                    {
                        order[SelectedGroup][blu] = (int)numericUpDown.Value;
                    }
                };

                SelectionPanel_flowLayoutPanel.Controls.Add(checkBox);
                SelectionPanel_flowLayoutPanel.Controls.Add(numericUpDown);
            }
        }

        private void button_AddToZakaz_Click(object sender, EventArgs e)
        {
            string orders = "";
            foreach (string group in menu.Keys)
            {
                orders += $"{group}:\n";
                if (order[group].Count > 0)
                {
                    foreach (var blu in order[group])
                    {
                        orders += $"{blu.Key} x {blu.Value}\n";
                    }
                }
                else { orders += "-------------- \n"; }
            }

            richTextBox1.Text = orders;
        }
    }
}
