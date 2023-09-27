using System;
using System.Windows.Forms;
using Tekla.Structures.Model;
using Tekla.Structures.Geometry3d;


namespace Practice_Sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model myModel = new Model(); //  X Cordinate
            Beam myBeam = new Beam();
            for(int i = 0; i < 5; i++)
            {
                myBeam.StartPoint = new Point(i * 3000, 0, 0);
                myBeam.EndPoint = new Point(i * 3000.0, 0.0, 5000);
                myBeam.Profile.ProfileString = "ISMB250";
                myBeam.Material.MaterialString = "IS2062";
                myBeam.Class = "11";
                myBeam.Position.Depth = Position.DepthEnum.MIDDLE;
                myBeam.Insert();
            }

            for (int i = 0; i < 4; i++)  //   +12000 Y Distance
            {
                myBeam.StartPoint = new Point(12000, (i*3000)+3000, 0);
                myBeam.EndPoint = new Point(12000.0, (i*3000.0)+3000, 5000);
                myBeam.Profile.ProfileString = "ISMB250";
                myBeam.Material.MaterialString = "IS2062";
                myBeam.Class = "11";
                myBeam.Position.Depth = Position.DepthEnum.MIDDLE;
                myBeam.Insert();
            }
            for (int i = 0; i < 4; i++) //   Y Cordinate
            {
                myBeam.StartPoint = new Point(0,12000 - i * 3000, 0);
                myBeam.EndPoint = new Point(0,12000.0 - i * 3000.0, 5000);
                myBeam.Profile.ProfileString = "ISMB250";
                myBeam.Material.MaterialString = "IS2062";
                myBeam.Class = "11";
                myBeam.Position.Depth = Position.DepthEnum.MIDDLE;
                myBeam.Insert();
            }
            for (int i = 0; i < 3; i++)  //  +12000 X Distance
            {
                myBeam.StartPoint = new Point((12000 - i * 3000) - 3000, 12000, 0);
                myBeam.EndPoint = new Point((12000.0 - i * 3000.0) - 3000, 12000, 5000);
                myBeam.Profile.ProfileString = "ISMB250";
                myBeam.Material.MaterialString = "IS2062";
                myBeam.Class = "11";
                myBeam.Position.Depth = Position.DepthEnum.MIDDLE;
                myBeam.Insert();
            }
            myModel.CommitChanges();
        }
    }
}
