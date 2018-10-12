namespace books
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitel = new System.Windows.Forms.Label();
            this.tbTitel = new System.Windows.Forms.TextBox();
            this.lblPris = new System.Windows.Forms.Label();
            this.tbPris = new System.Windows.Forms.TextBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.lblSumma = new System.Windows.Forms.Label();
            this.lblPrisFel = new System.Windows.Forms.Label();
            this.lblTitelFel = new System.Windows.Forms.Label();
            this.lvBookList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvKundVagn = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Location = new System.Drawing.Point(22, 356);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(38, 20);
            this.lblTitel.TabIndex = 1;
            this.lblTitel.Text = "Titel";
            // 
            // tbTitel
            // 
            this.tbTitel.Location = new System.Drawing.Point(79, 353);
            this.tbTitel.Name = "tbTitel";
            this.tbTitel.Size = new System.Drawing.Size(240, 26);
            this.tbTitel.TabIndex = 2;
            // 
            // lblPris
            // 
            this.lblPris.AutoSize = true;
            this.lblPris.Location = new System.Drawing.Point(22, 390);
            this.lblPris.Name = "lblPris";
            this.lblPris.Size = new System.Drawing.Size(35, 20);
            this.lblPris.TabIndex = 3;
            this.lblPris.Text = "Pris";
            // 
            // tbPris
            // 
            this.tbPris.Location = new System.Drawing.Point(79, 387);
            this.tbPris.Name = "tbPris";
            this.tbPris.Size = new System.Drawing.Size(240, 26);
            this.tbPris.TabIndex = 4;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(26, 429);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(95, 34);
            this.btnAddBook.TabIndex = 5;
            this.btnAddBook.Text = "Lägg till";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(79, 478);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(240, 26);
            this.tbFilter.TabIndex = 6;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(26, 481);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(44, 20);
            this.lblFilter.TabIndex = 7;
            this.lblFilter.Text = "Filter";
            // 
            // lblSumma
            // 
            this.lblSumma.AutoSize = true;
            this.lblSumma.Location = new System.Drawing.Point(419, 353);
            this.lblSumma.Name = "lblSumma";
            this.lblSumma.Size = new System.Drawing.Size(72, 20);
            this.lblSumma.TabIndex = 8;
            this.lblSumma.Text = "Summa: ";
            // 
            // lblPrisFel
            // 
            this.lblPrisFel.AutoSize = true;
            this.lblPrisFel.Location = new System.Drawing.Point(325, 390);
            this.lblPrisFel.Name = "lblPrisFel";
            this.lblPrisFel.Size = new System.Drawing.Size(51, 20);
            this.lblPrisFel.TabIndex = 9;
            this.lblPrisFel.Text = "label1";
            // 
            // lblTitelFel
            // 
            this.lblTitelFel.AutoSize = true;
            this.lblTitelFel.Location = new System.Drawing.Point(326, 356);
            this.lblTitelFel.Name = "lblTitelFel";
            this.lblTitelFel.Size = new System.Drawing.Size(51, 20);
            this.lblTitelFel.TabIndex = 10;
            this.lblTitelFel.Text = "label2";
            // 
            // lvBookList
            // 
            this.lvBookList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvBookList.GridLines = true;
            this.lvBookList.Location = new System.Drawing.Point(26, 24);
            this.lvBookList.Name = "lvBookList";
            this.lvBookList.Size = new System.Drawing.Size(497, 309);
            this.lvBookList.TabIndex = 11;
            this.lvBookList.UseCompatibleStateImageBehavior = false;
            this.lvBookList.View = System.Windows.Forms.View.Details;
            this.lvBookList.DoubleClick += new System.EventHandler(this.lvKundVagn_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Titel";
            this.columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Pris";
            this.columnHeader2.Width = 100;
            // 
            // lvKundVagn
            // 
            this.lvKundVagn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader5});
            this.lvKundVagn.GridLines = true;
            this.lvKundVagn.Location = new System.Drawing.Point(605, 24);
            this.lvKundVagn.Name = "lvKundVagn";
            this.lvKundVagn.Size = new System.Drawing.Size(483, 309);
            this.lvKundVagn.TabIndex = 12;
            this.lvKundVagn.UseCompatibleStateImageBehavior = false;
            this.lvKundVagn.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Titel";
            this.columnHeader3.Width = 250;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Antal";
            this.columnHeader5.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 517);
            this.Controls.Add(this.lvKundVagn);
            this.Controls.Add(this.lvBookList);
            this.Controls.Add(this.lblTitelFel);
            this.Controls.Add(this.lblPrisFel);
            this.Controls.Add(this.lblSumma);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.tbPris);
            this.Controls.Add(this.lblPris);
            this.Controls.Add(this.tbTitel);
            this.Controls.Add(this.lblTitel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.TextBox tbTitel;
        private System.Windows.Forms.Label lblPris;
        private System.Windows.Forms.TextBox tbPris;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Label lblSumma;
        private System.Windows.Forms.Label lblPrisFel;
        private System.Windows.Forms.Label lblTitelFel;
        private System.Windows.Forms.ListView lvBookList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView lvKundVagn;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

