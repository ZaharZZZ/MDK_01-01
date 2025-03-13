using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLib
{
    public class SaveDataToCsv
    {
        public SaveDataToCsv(string filePath, DataGridView data) 
        {
            StringBuilder csvContent = new StringBuilder();
            foreach (DataGridViewRow row in data.Rows)
            {
                for (int i = 0; i < data.Columns.Count; i++)
                {
                    string cellValue = row.Cells[i].Value.ToString();
                    csvContent.Append(cellValue);

                    if (i < data.Columns.Count - 1)
                    {
                        csvContent.Append(",");
                    }
                }
                csvContent.AppendLine();
            }
            File.WriteAllText(filePath, csvContent.ToString(), Encoding.UTF8);
        }
    }
}
