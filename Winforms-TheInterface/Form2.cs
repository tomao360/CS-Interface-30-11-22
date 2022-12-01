
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private IItem[] items = new IItem[5]; 
        private static int index = 0;
        private void getItemBtn_Click(object sender, EventArgs e)
        {
            IItem item = new Cola();
        }

        private void colaBtn_Click(object sender, EventArgs e)
        {
            if (index < items.Length)
            {
                Cola cola = new Cola();
                items[index] = cola;
                index++;
            }
        }
        private void kinleyBtn_Click(object sender, EventArgs e)
        {
            if (index < items.Length)
            {
                Kinley kinley = new Kinley();
                items[index] = kinley;
                index++;
            }
        }

        private void printListBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < items.Length && items[i] != null; i++)
            {
                MessageBox.Show("The Price of:" + items[i].GetName() + " is:" + items[i].GetPrice());
            }
        }

    }
}
