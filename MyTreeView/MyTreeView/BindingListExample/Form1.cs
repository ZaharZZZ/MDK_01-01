using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BindingListExample
{
    public partial class Form1: Form
    {
        private BindingList<Player> Players;
        public Form1()
        {
            InitializeComponent();
            Players = new BindingList<Player>();
            Players.Add(new Player { name = "Вася", login =  "vasy#345",password ="1234"});
            Players.Add(new Player { name = "Петя", login = "Peter%945", password = "4321" });
            Players.Add(new Player { name = "Саша", login = "sasha&9445", password = "9876" });

            playerTable.DataSource = Players;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
