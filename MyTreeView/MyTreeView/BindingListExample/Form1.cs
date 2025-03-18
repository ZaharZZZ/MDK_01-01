using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BindingListExample
{
    public partial class Form1 : Form
    {
        
        public BindingList<Player> Players = new BindingList<Player>();
        public Form1()
        {
            InitializeComponent();
            Players = new BindingList<Player>();
            Players.Add(new Player { name = "Вася", login = "vasy#345", password = "1234" });
            Players.Add(new Player { name = "Петя", login = "Peter%945", password = "4321" });
            Players.Add(new Player { name = "Саша", login = "sasha&9445", password = "9876" });

            playerTable.DataSource = Players;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditPlayer newPlayer = new EditPlayer();
            DialogResult result = newPlayer.ShowDialog();
            if (result == DialogResult.OK)
            {
                
                Player play = newPlayer.AddDataToTable();
                Players.Add(play );
            }

        }
       
        private int GetSelectedIndex()
        {
            if (playerTable.SelectedRows.Count == 0)
            {
                return - 1;
            }
            return playerTable.SelectedRows[0].Index;
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены в удалении данного игрока?", "Подтверждение", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                foreach(DataGridViewRow row in playerTable.SelectedRows)
                {
                    playerTable.Rows.RemoveAt(row.Index);
                }
            }
            else if (dialogResult == DialogResult.No) { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rowIndex = GetSelectedIndex();
            if (rowIndex == -1 || rowIndex >= Players.Count)
            {
                return;
            }
            Player currentPlayer = Players[rowIndex];
            EditPlayer form = new EditPlayer();
            form.SetData(currentPlayer);
            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                Player editPlater = form.EditDataToTable();
                Players[rowIndex].name = editPlater.name;
                Players[rowIndex].login = editPlater.login;
                Players[rowIndex].password = editPlater.password;
            }
            for (int i = 0; i < playerTable.ColumnCount; i++)
            {
                playerTable.UpdateCellValue(i, rowIndex);
            }
        }

        
    }
}
