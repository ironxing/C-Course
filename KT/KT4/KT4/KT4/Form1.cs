using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KT4
{
    public partial class Form1 : Form
    {
        List<string> listOfStrings;
        string filter;

        public Form1()
        {
            InitializeComponent();
            this.listOfStrings = new List<string>();
            this.filter = "";
        }

        private void btnLaggTill_Click(object sender, EventArgs e)
        {
            listOfStrings.Add(tbNyText.Text);
            tbNyText.Clear();
        }

        private void updateList()
        {
            listOfStrings.Sort();
            lbLista.Items.Clear();
            foreach (var element in listOfStrings)
            {
                lbLista.Items.Add(element);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox; //?
            this.filter = textBox.Text;
            updateList();
        }
    }
}
