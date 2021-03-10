using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortAlgorithmsVisualizer
{
    public partial class Form1 : MaterialForm
    {
        private int[] ArrayToSort;
        private Graphics graphics;

        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            //  materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue400, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            graphics = panel1.CreateGraphics();

            int EntriesNumber = panel1.Width;

            int MaxValue = panel1.Height;

            ArrayToSort = new int[EntriesNumber];

            graphics.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.Black), 0, 0, EntriesNumber, MaxValue);

            Random rand = new Random();

            for ( int i = 0; i < EntriesNumber; i++ )
            {
                ArrayToSort[i] = rand.Next(0, MaxValue);
            }


            for ( int i = 0; i < EntriesNumber; i++ )
            {
                graphics.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.White), i, MaxValue - ArrayToSort[i], 1, MaxValue);
            }
        }
    }
}