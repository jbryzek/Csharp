namespace AutomatyKomorkowe1D
{
    partial class FormCellular
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.lblRule = new System.Windows.Forms.Label();
            this.lblIterations = new System.Windows.Forms.Label();
            this.tbIterations = new System.Windows.Forms.TextBox();
            this.cbRules = new System.Windows.Forms.ComboBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.lblCondition = new System.Windows.Forms.Label();
            this.cbCondition = new System.Windows.Forms.ComboBox();
            this.pb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(3, 1);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(111, 66);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblRule
            // 
            this.lblRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRule.Location = new System.Drawing.Point(417, 18);
            this.lblRule.Name = "lblRule";
            this.lblRule.Size = new System.Drawing.Size(117, 37);
            this.lblRule.TabIndex = 2;
            this.lblRule.Text = "zasada:";
            this.lblRule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIterations
            // 
            this.lblIterations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIterations.Location = new System.Drawing.Point(573, 17);
            this.lblIterations.Name = "lblIterations";
            this.lblIterations.Size = new System.Drawing.Size(113, 40);
            this.lblIterations.TabIndex = 4;
            this.lblIterations.Text = "iteracje:";
            this.lblIterations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbIterations
            // 
            this.tbIterations.Location = new System.Drawing.Point(670, 27);
            this.tbIterations.Name = "tbIterations";
            this.tbIterations.Size = new System.Drawing.Size(57, 26);
            this.tbIterations.TabIndex = 5;
            this.tbIterations.Text = "300";
            // 
            // cbRules
            // 
            this.cbRules.FormattingEnabled = true;
            this.cbRules.Items.AddRange(new object[] {
            "30",
            "60",
            "90",
            "120",
            "225"});
            this.cbRules.Location = new System.Drawing.Point(516, 24);
            this.cbRules.Name = "cbRules";
            this.cbRules.Size = new System.Drawing.Size(69, 28);
            this.cbRules.TabIndex = 6;
            this.cbRules.Text = "30";
            // 
            // lblSize
            // 
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSize.Location = new System.Drawing.Point(733, 16);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(95, 40);
            this.lblSize.TabIndex = 7;
            this.lblSize.Text = "rozmiar:";
            this.lblSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbSize
            // 
            this.tbSize.Location = new System.Drawing.Point(822, 26);
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(60, 26);
            this.tbSize.TabIndex = 8;
            this.tbSize.Text = "300";
            // 
            // lblCondition
            // 
            this.lblCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCondition.Location = new System.Drawing.Point(120, 16);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(215, 37);
            this.lblCondition.TabIndex = 9;
            this.lblCondition.Text = "warunek brzegowy:";
            this.lblCondition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbCondition
            // 
            this.cbCondition.FormattingEnabled = true;
            this.cbCondition.Items.AddRange(new object[] {
            "stały ",
            "zawijany",
            "odbijający"});
            this.cbCondition.Location = new System.Drawing.Point(319, 23);
            this.cbCondition.Name = "cbCondition";
            this.cbCondition.Size = new System.Drawing.Size(106, 28);
            this.cbCondition.TabIndex = 10;
            this.cbCondition.Text = "stały ";
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(3, 73);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(889, 476);
            this.pb.TabIndex = 11;
            this.pb.TabStop = false;
            // 
            // FormCellular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 561);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.cbCondition);
            this.Controls.Add(this.lblCondition);
            this.Controls.Add(this.tbSize);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.cbRules);
            this.Controls.Add(this.tbIterations);
            this.Controls.Add(this.lblIterations);
            this.Controls.Add(this.lblRule);
            this.Controls.Add(this.btnStart);
            this.Name = "FormCellular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CellularAutomata";
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblRule;
        private System.Windows.Forms.Label lblIterations;
        private System.Windows.Forms.TextBox tbIterations;
        private System.Windows.Forms.ComboBox cbRules;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.ComboBox cbCondition;
        private System.Windows.Forms.PictureBox pb;
    }
}

