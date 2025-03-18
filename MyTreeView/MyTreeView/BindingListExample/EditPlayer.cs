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
    public partial class EditPlayer: Form
    {
        
        public EditPlayer()
        {
            InitializeComponent();
        }

        public Player AddDataToTable()
        {
            Player item = new Player { name = textBox1.Text, login = textBox2.Text, password = textBox3.Text };
         
            return item;
        }
        public Player EditDataToTable()
        {
            Player c = new Player ();
            c.name = textBox1.Text;
            c.login = textBox2.Text;
            c.password = textBox3.Text;


            return c;
        }

        public void SetData(Player play)
        {
            textBox1.Text = play.name;
            textBox2.Text = play.login;
            textBox3.Text = play.password;
        }


        private void OKButton_Click(object sender, EventArgs e)
        {

            
        }
    }
}
