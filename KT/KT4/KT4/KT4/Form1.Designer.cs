namespace KT4
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
            this.lbLista = new System.Windows.Forms.ListBox();
            this.tbNyText = new System.Windows.Forms.TextBox();
            this.btnLaggTill = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbLista
            // 
            this.lbLista.FormattingEnabled = true;
            this.lbLista.ItemHeight = 20;
            this.lbLista.Location = new System.Drawing.Point(29, 32);
            this.lbLista.Name = "lbLista";
            this.lbLista.Size = new System.Drawing.Size(812, 164);
            this.lbLista.TabIndex = 0;
            // 
            // tbNyText
            // 
            this.tbNyText.Location = new System.Drawing.Point(29, 228);
            this.tbNyText.Name = "tbNyText";
            this.tbNyText.Size = new System.Drawing.Size(682, 26);
            this.tbNyText.TabIndex = 1;
            // 
            // btnLaggTill
            // 
            this.btnLaggTill.Location = new System.Drawing.Point(759, 228);
            this.btnLaggTill.Name = "btnLaggTill";
            this.btnLaggTill.Size = new System.Drawing.Size(75, 33);
            this.btnLaggTill.TabIndex = 2;
            this.btnLaggTill.Text = "Lägg till";
            this.btnLaggTill.UseVisualStyleBackColor = true;
            this.btnLaggTill.Click += new System.EventHandler(this.btnLaggTill_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filter";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(29, 315);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(682, 26);
            this.tbFilter.TabIndex = 4;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 521);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLaggTill);
            this.Controls.Add(this.tbNyText);
            this.Controls.Add(this.lbLista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbLista;
        private System.Windows.Forms.TextBox tbNyText;
        private System.Windows.Forms.Button btnLaggTill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFilter;
    }
}

