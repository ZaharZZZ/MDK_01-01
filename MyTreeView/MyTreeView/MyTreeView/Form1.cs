using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLib.Models;
using MyLib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections.ObjectModel;
using System.Xml.Linq;

namespace MyTreeView
{
    public partial class MainForm : Form
    {
        private List<TreeNodeModels> treeData_;
        private CarModel CarModel_;
        
        public MainForm()
        {
            InitializeComponent();

            treeData_ = new List<TreeNodeModels>();

            CarModel_ = new CarModel();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            {
                treeData_.Add(new TreeNodeModels("Седан"));
                var SedanNode = treeData_[0];
                var chevrolet = SedanNode.AddChildNode("Шеврале");
                chevrolet.AddChildNode("Aveo");
                chevrolet.AddChildNode("Lacetti");
                chevrolet.AddChildNode("Cruze");

                var hundai = SedanNode.AddChildNode("Хундай");
                hundai.AddChildNode("Verna");
                hundai.AddChildNode("Aura");
                hundai.AddChildNode("Azera");

                var Audi = SedanNode.AddChildNode("Ауди");
                Audi.AddChildNode("RS7");
                Audi.AddChildNode("A7");
                Audi.AddChildNode("A3");
            }

            {
                treeData_.Add(new TreeNodeModels("Кроссовер"));
                var CrossNode = treeData_[1];
                var ww = CrossNode.AddChildNode("Шеврале");
                ww.AddChildNode("Traverse");
                ww.AddChildNode("Lacetti");
                ww.AddChildNode("Equinox");

                var hundai = CrossNode.AddChildNode("Хундай");
                hundai.AddChildNode("Tucson");
                hundai.AddChildNode("Santa Fe");
                hundai.AddChildNode("Palisade");

                var Audi = CrossNode.AddChildNode("Ауди");
                Audi.AddChildNode("SQ7");
                Audi.AddChildNode("SQ8");
                Audi.AddChildNode("Q3");
            }
            
           FillTreeNodeCollection(treeData_, TreeViewCar.Nodes);

            TreeViewCar.ExpandAll();

            //Table.DataSource = CarModel_.Cars;

        }

        static private void FillTreeNodeCollection(List<TreeNodeModels> sourceData, //данные источника - модели
                                                    TreeNodeCollection targetData) // данные приемника - представления
        {
            foreach (var node in sourceData)
            {
                var treeNode = new TreeNode(node.Name); // объект узла в представлении
                targetData.Add(treeNode); // добавили узел в дерево

                if (node.Children != null && node.Children.Count > 0)
                {
                    FillTreeNodeCollection(node.Children, treeNode.Nodes); //переносим дочерние элементы узла модели в дочерние элементы узла представления
                }
            }
        }


        private void TreeViewCar_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Nodes.Count ==0)
            {
                Car carss = CarModel_.GetExampleByName(e.Node.Text);
                if (carss !=  null)
                {
                    object[] newRow = { carss.Name,  carss.release_date, carss.engine_capacity};
                    Table.Rows.Add(newRow);
                }
            }
        }

        private void Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

