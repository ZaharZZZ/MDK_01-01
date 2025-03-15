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
using System.IO;

namespace MyTreeView
{
    public partial class MainForm : Form
    {
        
        private List<TreeNodeModel> treeData_;
        private CarModel carModel_;
        private CarsDataModel carsDataModel_;
        private BindingList<Car> InfoCars_;
        
        
        public MainForm()
        {
            InitializeComponent();

            InfoCars_ = new BindingList < Car > ();
            treeData_ = new List<TreeNodeModel>();
            carModel_ = new CarModel();
            carsDataModel_ = new CarsDataModel();
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {            
            //carsDataGridView.Columns.Add("NameColumn", "Название");
            //carsDataGridView.Columns.Add("ReleaseDateColumn", "Дата выпуска");
            //carsDataGridView.Columns.Add("EngineCapacityColumn", "Объём двигателя");
            //carsDataGridView.Columns["EngineCapacityColumn"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            treeData_ = carsDataModel_.treeData;
            FillTreeNodeCollection(treeData_, carsTreeView.Nodes);
            carsTreeView.ExpandAll();
        }

        static private void FillTreeNodeCollection(List<TreeNodeModel> sourceData, TreeNodeCollection targetData)
        {
            foreach (var node in sourceData)
            {
                var treeNode = new TreeNode(node.Name);
                targetData.Add(treeNode);

                if (node.Children != null && node.Children.Count > 0)
                {
                    FillTreeNodeCollection(node.Children, treeNode.Nodes);
                }
            }
        }


        private void TreeViewCar_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {


            if (e.Node.Nodes.Count ==0)
            {
                Car cars = carModel_.GetExampleByName(e.Node.Text);
                if (cars !=  null)
                {

                    InfoCars_.Add(cars);
                    //object[] newRow = { cars.name, cars.releaseDate, cars.engineCapacity};
                    //carsDataGridView.Rows.Add(newRow);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // проверка на наличие данныхв в таблице
            if (carsDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("В таблице нет данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "./";
            openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialog.Title = "Выберите файл";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string selectedFileName = openFileDialog.FileName;
                    SaveDataToCsv savedData = new SaveDataToCsv(selectedFileName, carsDataGridView);
                    MessageBox.Show("Данные успешно сохранены. Путь к файлу: " + selectedFileName, "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось сохранить файл.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // очищаем таблицу
            carsDataGridView.Rows.Clear();

            string filePath = "data.csv";
            LoadDataFromCsv loadedData = new LoadDataFromCsv(filePath, carsDataGridView);

            MessageBox.Show($"Данные из файла успешно загружены.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

