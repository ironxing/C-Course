using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KT4try
{
    public enum FilterCases {Start, End, Anywhere}

    public partial class Form1 : Form
    {
        List<string> dataList;
        FilterCases filtercase;

        public Form1()
        {
            InitializeComponent();
            this.dataList = new List<string>();
        }

        private void btnLaggtill_Click(object sender, EventArgs e)
        {
            string inputString = tbInput.Text;
            updateDataArray(inputString);
            udpateLb();
        }

        private void updateDataArray(string inputString)
        {
            dataList.Add(inputString);
            tbInput.Clear();
        }

        private void udpateLb()
        {
            dataList.Sort();
            lbList.Items.Clear();
            string filter = tbFilter.Text;
            bool match = false;

            if (rbtnAny.Checked)
            {
                filtercase = FilterCases.Anywhere;
            } else if (rbtnEnd.Checked){
                filtercase = FilterCases.End;
            } else if (rbtnStart.Checked)
            {
                filtercase = FilterCases.Start;
            }


            foreach (var item in dataList)
            {
                switch (filtercase)
                {
                    case FilterCases.Anywhere:
                        match = item.Contains(filter);
                        break;
                    case FilterCases.End:
                        match = item.EndsWith(filter);
                        break;
                    case FilterCases.Start:
                        match = item.StartsWith(filter);
                        break;
                }

                if (match) { 
                    lbList.Items.Add(item);
                }
            }
        }
    }
}
