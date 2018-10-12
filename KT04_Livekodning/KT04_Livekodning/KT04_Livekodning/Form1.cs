using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KT04_Livekodning {
    enum FilterMode {
        Start,
        End,
        WholeWord
    }

    public partial class Form1 : Form {
        List<string> listOfStrings;
        string activeFilter;
        FilterMode filterMode;

        public Form1() {
            InitializeComponent();
            this.listOfStrings = new List<string>();
            this.activeFilter = "";
            this.filterMode = FilterMode.Start;

            var x = this.filterMode == FilterMode.Start ? 10 : 5;
            //var x = 0;
            if (this.filterMode == FilterMode.Start) {
                x = 10;
            } else {
                x = 5;
            }
        }

        private void UpdateList() {
            lbLista.Items.Clear();
            listOfStrings.Sort();

            foreach (var item in listOfStrings) {
                var matchesFilter = false;
                if (filterMode == FilterMode.Start) {
                    matchesFilter = item.StartsWith(this.activeFilter);
                } else if (filterMode == FilterMode.End) {
                    matchesFilter = item.EndsWith(this.activeFilter);
                } else if (filterMode == FilterMode.WholeWord) {
                    matchesFilter = item == activeFilter;
                }
                if (matchesFilter) {
                    lbLista.Items.Add(item);
                }
            }
        }

        private void btnLaggTill_Click(object sender, EventArgs e) {
            listOfStrings.Add(tbNyText.Text);
            tbNyText.Clear();
            UpdateList();
        }

        private void tbFilter_TextChanged(object sender, EventArgs e) {
            var textBox = sender as TextBox;
            this.activeFilter = textBox.Text;
            UpdateList();
        }

        private void rbStart_CheckedChanged(object sender, EventArgs e) {
            var btn = sender as RadioButton;
            if (btn.Checked) {
                this.filterMode = FilterMode.Start;
            }
        }

        private void rbEnd_CheckedChanged(object sender, EventArgs e) {
            if ((sender as RadioButton).Checked) {
                this.filterMode = FilterMode.End;
            }
        }

        private void rbWholeWord_CheckedChanged(object sender, EventArgs e) {
            if ((sender as RadioButton).Checked) {
                this.filterMode = FilterMode.WholeWord;
            }
        }
    }
}
