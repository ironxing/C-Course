namespace KT4try
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
            this.lbList = new System.Windows.Forms.ListBox();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.btnLaggtill = new System.Windows.Forms.Button();
            this.rbtnStart = new System.Windows.Forms.RadioButton();
            this.rbtnEnd = new System.Windows.Forms.RadioButton();
            this.rbtnAny = new System.Windows.Forms.RadioButton();
            this.lblFilter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbList
            // 
            this.lbList.FormattingEnabled = true;
            this.lbList.ItemHeight = 20;
            this.lbList.Location = new System.Drawing.Point(30, 23);
            this.lbList.Name = "lbList";
            this.lbList.Size = new System.Drawing.Size(884, 244);
            this.lbList.TabIndex = 0;
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(30, 300);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(699, 26);
            this.tbInput.TabIndex = 1;
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(30, 378);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(699, 26);
            this.tbFilter.TabIndex = 2;
            // 
            // btnLaggtill
            // 
            this.btnLaggtill.Location = new System.Drawing.Point(775, 296);
            this.btnLaggtill.Name = "btnLaggtill";
            this.btnLaggtill.Size = new System.Drawing.Size(139, 34);
            this.btnLaggtill.TabIndex = 3;
            this.btnLaggtill.Text = "Lägg till";
            this.btnLaggtill.UseVisualStyleBackColor = true;
            this.btnLaggtill.Click += new System.EventHandler(this.btnLaggtill_Click);
            // 
            // rbtnStart
            // 
            this.rbtnStart.AutoSize = true;
            this.rbtnStart.Location = new System.Drawing.Point(30, 445);
            this.rbtnStart.Name = "rbtnStart";
            this.rbtnStart.Size = new System.Drawing.Size(101, 24);
            this.rbtnStart.TabIndex = 4;
            this.rbtnStart.TabStop = true;
            this.rbtnStart.Text = "Start with";
            this.rbtnStart.UseVisualStyleBackColor = true;
            // 
            // rbtnEnd
            // 
            this.rbtnEnd.AutoSize = true;
            this.rbtnEnd.Location = new System.Drawing.Point(209, 444);
            this.rbtnEnd.Name = "rbtnEnd";
            this.rbtnEnd.Size = new System.Drawing.Size(95, 24);
            this.rbtnEnd.TabIndex = 5;
            this.rbtnEnd.TabStop = true;
            this.rbtnEnd.Text = "End with";
            this.rbtnEnd.UseVisualStyleBackColor = true;
            // 
            // rbtnAny
            // 
            this.rbtnAny.AutoSize = true;
            this.rbtnAny.Location = new System.Drawing.Point(385, 443);
            this.rbtnAny.Name = "rbtnAny";
            this.rbtnAny.Size = new System.Drawing.Size(104, 24);
            this.rbtnAny.TabIndex = 6;
            this.rbtnAny.TabStop = true;
            this.rbtnAny.Text = "Anywhere";
            this.rbtnAny.UseVisualStyleBackColor = true;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(38, 342);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(44, 20);
            this.lblFilter.TabIndex = 7;
            this.lblFilter.Text = "Filter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 525);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.rbtnAny);
            this.Controls.Add(this.rbtnEnd);
            this.Controls.Add(this.rbtnStart);
            this.Controls.Add(this.btnLaggtill);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.lbList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbList;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.Button btnLaggtill;
        private System.Windows.Forms.RadioButton rbtnStart;
        private System.Windows.Forms.RadioButton rbtnEnd;
        private System.Windows.Forms.RadioButton rbtnAny;
        private System.Windows.Forms.Label lblFilter;
    }
}

