using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLib
{
    public class LoadDataFromCsv
    {
        public LoadDataFromCsv(string filePath, DataGridView data)
        {
            // проверка на существование файл
            if (!File.Exists(filePath))
            {
                MessageBox.Show($"Файл не найден: {filePath}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string[] lines = File.ReadAllLines(filePath, Encoding.UTF8);

            // проверяем, пуст ли файл
            if (lines.Length == 0)
            {
                MessageBox.Show("Файл пуст.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // добавляем данные
            for (int i = 0; i < lines.Length; i++)
            {
                string[] values = lines[i].Split(',');
                DataGridViewRow row = new DataGridViewRow();

                for (int j = 0; j < values.Length; j++)
                {
                    row.Cells.Add(new DataGridViewTextBoxCell() { Value = values[j] });
                }
                data.Rows.Add(row);
            }
        }
    }
}
