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
    public partial class Form1 : Form
    {
        private Dictionary<string, List<string>> menu = new Dictionary<string, List<string>>()
        {
            {"Закуски", new List<string>() {"Салат Цезарь", "Сырные палочки", "Гренки чесночные"}},
            {"Основные блюда", new List<string>() {"Стейк", "Паста Карбонара", "Пицца Маргарита"}},
            {"Напитки", new List<string>() {"Кола", "Сок апельсиновый", "Вода"}},
            {"Десерты", new List<string>() {"Тирамису", "Чизкейк", "Мороженое"}}
        };

        // Словарь для хранения количества заказанных блюд (блюдо - количество)
        private Dictionary<string, int> order = new Dictionary<string, int>();

        public Form1()
        {
            InitializeComponent();
            comboBoxMenuGroups.Items.AddRange(menu.Keys.ToArray());
        }

        private void comboBoxMenuGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBoxMenuItems.Items.Clear();

            // Получаем выбранную группу меню
            string selectedGroup = comboBoxMenuGroups.SelectedItem.ToString();

            // Заполняем CheckBoxList блюдами из выбранной группы
            foreach (string item in menu[selectedGroup])
            {
                checkedListBoxMenuItems.Items.Add(item);
            }
        }

        private void checkedListBoxMenuItems_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string itemName = checkedListBoxMenuItems.Items[e.Index].ToString();
            string numericUpDownName = "numericUpDown_" + itemName.Replace(" ", "_");

            if (e.NewValue == CheckState.Checked)
            {
                // Create NumericUpDown dynamically
                NumericUpDown nud = new NumericUpDown();
                nud.Name = numericUpDownName;
                nud.Minimum = 0;
                nud.Maximum = 100; // Set a reasonable maximum
                nud.Value = 1; // Default quantity
                nud.Width = 50;

                // Calculate position (adjust as needed)
                int x = checkedListBoxMenuItems.Location.X + checkedListBoxMenuItems.Width + 10;
                int y = checkedListBoxMenuItems.Location.Y + (e.Index * checkedListBoxMenuItems.ItemHeight);
                nud.Location = new Point(x, y);

                // Add to form's controls
                this.Controls.Add(nud);
                nud.BringToFront();  // Ensures it's visible

            }
            else
            {
                //Remove dynamically
                NumericUpDown nudToRemove = this.Controls.Find(numericUpDownName, true).FirstOrDefault() as NumericUpDown;
                if (nudToRemove != null)
                {
                    this.Controls.Remove(nudToRemove);
                    nudToRemove.Dispose(); //Important to release resources
                }
            }
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            // Очищаем предыдущий заказ
            

            // Собираем выбранные блюда из CheckBoxList
            foreach (int index in checkedListBoxMenuItems.CheckedIndices)
            {
                string selectedItem = checkedListBoxMenuItems.Items[index].ToString();

                // Получаем количество из соответствующего NumericUpDown (создадим динамически)
                // Имя NumericUpDown формируется на основе имени элемента меню в CheckListBox
                string numericUpDownName = "numericUpDown_" + selectedItem.Replace(" ", "_"); // Replace spaces with underscores

                NumericUpDown nud = this.Controls.Find(numericUpDownName, true).FirstOrDefault() as NumericUpDown;
                if (nud != null)
                {
                    int quantity = (int)nud.Value;

                    if (quantity > 0)
                    {
                        order[selectedItem] = quantity;
                    }
                }
                else
                {
                    // Если NumericUpDown не найден, выводим ошибку (очень маловероятно, но все же)
                    MessageBox.Show($"Не найдено поле для ввода количества для блюда: {selectedItem}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; //Прерываем обработку заказа
                }
            }


            // Формируем текст заказа для вывода в TextBox
            StringBuilder orderText = new StringBuilder();

            if (order.Count == 0)
            {
                orderText.AppendLine("Заказ пуст.");
            }
            else
            {
                orderText.AppendLine("Ваш заказ:");

                // Группируем заказанные блюда по группам меню
                var groupedOrder = order.GroupBy(item => menu.FirstOrDefault(group => group.Value.Contains(item.Key)).Key);

                foreach (var group in groupedOrder)
                {
                    orderText.AppendLine($"\r\n{group.Key}:");
                    foreach (var item in group)
                    {
                        orderText.AppendLine($"  - {item.Key}: {item.Value} шт.");
                    }
                }
            }

            // Выводим текст заказа в TextBox
            textBoxOrder.Text = orderText.ToString();
        }
    }
}
