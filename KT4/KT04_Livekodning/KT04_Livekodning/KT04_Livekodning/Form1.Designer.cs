namespace KT04_Livekodning {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lbLista = new System.Windows.Forms.ListBox();
            this.tbNyText = new System.Windows.Forms.TextBox();
            this.btnLaggTill = new System.Windows.Forms.Button();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbWholeWord = new System.Windows.Forms.RadioButton();
            this.rbEnd = new System.Windows.Forms.RadioButton();
            this.rbStart = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbLista
            // 
            this.lbLista.BackColor = System.Drawing.SystemColors.Window;
            this.lbLista.FormattingEnabled = true;
            this.lbLista.Location = new System.Drawing.Point(12, 12);
            this.lbLista.Name = "lbLista";
            this.lbLista.Size = new System.Drawing.Size(577, 95);
            this.lbLista.TabIndex = 0;
            // 
            // tbNyText
            // 
            this.tbNyText.Location = new System.Drawing.Point(12, 113);
            this.tbNyText.Name = "tbNyText";
            this.tbNyText.Size = new System.Drawing.Size(367, 20);
            this.tbNyText.TabIndex = 1;
            // 
            // btnLaggTill
            // 
            this.btnLaggTill.Location = new System.Drawing.Point(513, 109);
            this.btnLaggTill.Name = "btnLaggTill";
            this.btnLaggTill.Size = new System.Drawing.Size(75, 23);
            this.btnLaggTill.TabIndex = 2;
            this.btnLaggTill.Text = "Lägg till...";
            this.btnLaggTill.UseVisualStyleBackColor = true;
            this.btnLaggTill.Click += new System.EventHandler(this.btnLaggTill_Click);
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(13, 183);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(576, 20);
            this.tbFilter.TabIndex = 3;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filtrera:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbWholeWord);
            this.panel1.Controls.Add(this.rbEnd);
            this.panel1.Controls.Add(this.rbStart);
            this.panel1.Location = new System.Drawing.Point(16, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 55);
            this.panel1.TabIndex = 5;
            // 
            // rbWholeWord
            // 
            this.rbWholeWord.AutoSize = true;
            this.rbWholeWord.Location = new System.Drawing.Point(123, 15);
            this.rbWholeWord.Name = "rbWholeWord";
            this.rbWholeWord.Size = new System.Drawing.Size(65, 17);
            this.rbWholeWord.TabIndex = 2;
            this.rbWholeWord.Text = "Hela ord";
            this.rbWholeWord.UseVisualStyleBackColor = true;
            this.rbWholeWord.CheckedChanged += new System.EventHandler(this.rbWholeWord_CheckedChanged);
            // 
            // rbEnd
            // 
            this.rbEnd.AutoSize = true;
            this.rbEnd.Location = new System.Drawing.Point(65, 15);
            this.rbEnd.Name = "rbEnd";
            this.rbEnd.Size = new System.Drawing.Size(52, 17);
            this.rbEnd.TabIndex = 1;
            this.rbEnd.Text = "Slutet";
            this.rbEnd.UseVisualStyleBackColor = true;
            this.rbEnd.CheckedChanged += new System.EventHandler(this.rbEnd_CheckedChanged);
            // 
            // rbStart
            // 
            this.rbStart.AutoSize = true;
            this.rbStart.Checked = true;
            this.rbStart.Location = new System.Drawing.Point(4, 15);
            this.rbStart.Name = "rbStart";
            this.rbStart.Size = new System.Drawing.Size(55, 17);
            this.rbStart.TabIndex = 0;
            this.rbStart.TabStop = true;
            this.rbStart.Text = "Början";
            this.rbStart.UseVisualStyleBackColor = true;
            this.rbStart.CheckedChanged += new System.EventHandler(this.rbStart_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 277);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.btnLaggTill);
            this.Controls.Add(this.tbNyText);
            this.Controls.Add(this.lbLista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbLista;
        private System.Windows.Forms.TextBox tbNyText;
        private System.Windows.Forms.Button btnLaggTill;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbWholeWord;
        private System.Windows.Forms.RadioButton rbEnd;
        private System.Windows.Forms.RadioButton rbStart;
    }
}

