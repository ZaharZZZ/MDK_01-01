using System.Collections.Generic;

namespace MyLib.Models
{
    public class CarsDataModel
    {
        public List<TreeNodeModel> treeData { get; }

        public CarsDataModel()
        {
            treeData = new List<TreeNodeModel>();

            // Седан
            {
                treeData.Add(new TreeNodeModel("Седан"));
                var SedanNode = treeData[0];
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

            // Кроссовер
            {
                treeData.Add(new TreeNodeModel("Кроссовер"));
                var CrossNode = treeData[1];
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
        }
    }
}
