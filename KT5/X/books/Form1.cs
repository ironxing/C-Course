using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace books
{
    public partial class Form1 : Form
    {
        Dictionary<string, int> dictBookData;
        Dictionary<string, int> dictKundVagnData;

        public Form1()
        {
            InitializeComponent();
            this.dictBookData = new Dictionary<string, int>();
            this.dictKundVagnData = new Dictionary<string, int>();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            bool validPris = false;
            bool validTitel = false;

            string titel = tbTitel.Text;
            string prisString = tbPris.Text;

            if (titel.Length >= 5)
            {
                validTitel = true;
            }
            else
            {
                lblTitelFel.Text = "Need to be longer than 5 characters";
            }

            int pris = 0;
            if (int.TryParse(prisString, out pris))
            {
                validPris = true;
            }
            else
            {
                lblPrisFel.Text = "Wrong input format";
            }

            if (validTitel & validPris)
            {
                addData(titel, pris);
                updateBookList();
                tbTitel.Clear();
                tbPris.Clear();
                lblTitelFel.Text = "";
                lblPrisFel.Text = "";
            }
        }

        private void addData(string titel, int pris)
        {
            dictBookData.Add(titel, pris);
        }

        private void updateBookList()
        {
            lvBookList.Items.Clear();
            int summa = 0;
            foreach (var item in dictBookData)
            {
                string titel = item.Key;
                int pris = item.Value;
                string prisString = pris.ToString();
                bool legit = filterTitel(titel);

                if (legit)
                {
                    ListViewItem lvi = new ListViewItem(titel);
                    lvi.SubItems.Add(prisString);
                    lvBookList.Items.Add(lvi);
                    summa += pris;
                }
            }
            lblSumma.Text = "Summa: " + summa.ToString();
        }

        private bool filterTitel(string titel)
        {
            bool legit = false;
            string filter = tbFilter.Text;
            if (titel.Contains(filter))
            {
                legit = true;
            }
            return legit;
        }

        private void lvKundVagn_DoubleClick (object sender, EventArgs e)
        {
            string titel = lvBookList.SelectedItems[0].Text;
            addKundVagnData(titel);
            uppdateKundVagnList();    
        }

        private void addKundVagnData(string titel)
        {
            if (dictKundVagnData.ContainsKey(titel))
            {
                int antal = dictKundVagnData[titel] + 1;
                dictKundVagnData[titel] = antal;
            }   
            else
            {
                dictKundVagnData.Add(titel, 1);
            }
        }

        private void uppdateKundVagnList()
        {
            lvKundVagn.Items.Clear();

            foreach (var element in dictKundVagnData)
            {
                string titel = element.Key;
                int antal = element.Value;
                string antalString = antal.ToString();

                ListViewItem lvi = new ListViewItem(titel);
                lvi.SubItems.Add(antalString);
                lvKundVagn.Items.Add(lvi);
            }
        }
    }
}
