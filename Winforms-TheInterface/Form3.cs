using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms_TheInterface
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private IShape[] shape = new IShape[100];
        private static int index = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (index < shape.Length)
            {
                if (rectanglecheckBox.Checked)
                {
                    shape[index] = new Rectangle();
                    index++;
                    rectanglecheckBox.Checked = false;
                }
                if (circlecheckBox.Checked)
                {
                    shape[index] = new Circle();
                    index++;
                    circlecheckBox.Checked = false;
                }
                if (ellipsecheckBox.Checked)
                {
                    shape[index] = new Ellipse();
                    index++;
                    ellipsecheckBox.Checked = false;
                }
                if (trianglecheckBox.Checked)
                {
                    shape[index] = new Triangle();
                    index++;
                    trianglecheckBox.Checked = false;
                }
                if (mooncheckBox.Checked)
                {
                    shape[index] = new Moon();
                    index++;
                    mooncheckBox.Checked = false;
                }
            }
        }
        private void showResultsBtn_Click(object sender, EventArgs e)
        {
            int sumVertices = 0;

            for (int i = 0; i < shape.Length && shape[i] != null; i++)
            {
                sumVertices += shape[i].VerticesNum();
            }

            resultLable.Text = sumVertices.ToString();
        }
    }
}
