namespace rozrostCA_MC
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.cbRule = new System.Windows.Forms.ComboBox();
            this.lblInitial = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.tbX = new System.Windows.Forms.TextBox();
            this.lblx = new System.Windows.Forms.Label();
            this.lbly = new System.Windows.Forms.Label();
            this.tbY = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnSize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBoundary = new System.Windows.Forms.ComboBox();
            this.cbInitial = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRow = new System.Windows.Forms.Label();
            this.lblCol = new System.Windows.Forms.Label();
            this.tbRow = new System.Windows.Forms.TextBox();
            this.tbCol = new System.Windows.Forms.TextBox();
            this.tbRadius = new System.Windows.Forms.TextBox();
            this.lblRadius = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.lblInitial2 = new System.Windows.Forms.Label();
            this.cbRule2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbBoundary2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbKt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIterations = new System.Windows.Forms.TextBox();
            this.btnStartMC = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbRule
            // 
            this.cbRule.FormattingEnabled = true;
            this.cbRule.Items.AddRange(new object[] {
            "Von Neumann",
            "Pentagonalne losowe",
            "Heksagonalne",
            "Moore",
            "z promieniem"});
            this.cbRule.Location = new System.Drawing.Point(311, 12);
            this.cbRule.Name = "cbRule";
            this.cbRule.Size = new System.Drawing.Size(149, 28);
            this.cbRule.TabIndex = 1;
            this.cbRule.Text = "Von Neumann";
            this.cbRule.SelectedIndexChanged += new System.EventHandler(this.cbRule_SelectedIndexChanged);
            // 
            // lblInitial
            // 
            this.lblInitial.AutoSize = true;
            this.lblInitial.Location = new System.Drawing.Point(184, 15);
            this.lblInitial.Name = "lblInitial";
            this.lblInitial.Size = new System.Drawing.Size(121, 20);
            this.lblInitial.TabIndex = 2;
            this.lblInitial.Text = "Typ sasiedztwa:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(762, 15);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(112, 20);
            this.lblSize.TabIndex = 3;
            this.lblSize.Text = "Rozmiar siatki:";
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(900, 14);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(54, 26);
            this.tbX.TabIndex = 4;
            this.tbX.Text = "20";
            // 
            // lblx
            // 
            this.lblx.AutoSize = true;
            this.lblx.Location = new System.Drawing.Point(870, 15);
            this.lblx.Name = "lblx";
            this.lblx.Size = new System.Drawing.Size(24, 20);
            this.lblx.TabIndex = 5;
            this.lblx.Text = "X:";
            // 
            // lbly
            // 
            this.lbly.AutoSize = true;
            this.lbly.Location = new System.Drawing.Point(960, 15);
            this.lbly.Name = "lbly";
            this.lbly.Size = new System.Drawing.Size(24, 20);
            this.lbly.TabIndex = 6;
            this.lbly.Text = "Y:";
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(990, 15);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(54, 26);
            this.tbY.TabIndex = 7;
            this.tbY.Text = "20";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(4, 1);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(81, 54);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(91, 1);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 54);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Czysc";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersHeight = 8;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv.ColumnHeadersVisible = false;
            this.dgv.Location = new System.Drawing.Point(32, 61);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 8;
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv.RowTemplate.Height = 8;
            this.dgv.Size = new System.Drawing.Size(820, 820);
            this.dgv.TabIndex = 11;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // btnSize
            // 
            this.btnSize.Location = new System.Drawing.Point(900, 70);
            this.btnSize.Name = "btnSize";
            this.btnSize.Size = new System.Drawing.Size(126, 63);
            this.btnSize.TabIndex = 12;
            this.btnSize.Text = "Ustaw nowy rozmiar";
            this.btnSize.UseVisualStyleBackColor = true;
            this.btnSize.Click += new System.EventHandler(this.btnSize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(466, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Warunki brzegowe:";
            // 
            // cbBoundary
            // 
            this.cbBoundary.FormattingEnabled = true;
            this.cbBoundary.Items.AddRange(new object[] {
            "absorbujące",
            "periodyczne"});
            this.cbBoundary.Location = new System.Drawing.Point(607, 15);
            this.cbBoundary.Name = "cbBoundary";
            this.cbBoundary.Size = new System.Drawing.Size(149, 28);
            this.cbBoundary.TabIndex = 14;
            this.cbBoundary.Text = "absorbujące";
            // 
            // cbInitial
            // 
            this.cbInitial.FormattingEnabled = true;
            this.cbInitial.Items.AddRange(new object[] {
            "Jednorodne",
            "Z promieniem",
            "Losowe",
            "Wyklikanie"});
            this.cbInitial.Location = new System.Drawing.Point(874, 215);
            this.cbInitial.Name = "cbInitial";
            this.cbInitial.Size = new System.Drawing.Size(149, 28);
            this.cbInitial.TabIndex = 15;
            this.cbInitial.Text = "Jednorodne";
            this.cbInitial.SelectedIndexChanged += new System.EventHandler(this.cbInitial_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(871, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Zarodkowanie:";
            // 
            // lblRow
            // 
            this.lblRow.AutoSize = true;
            this.lblRow.Location = new System.Drawing.Point(870, 269);
            this.lblRow.Name = "lblRow";
            this.lblRow.Size = new System.Drawing.Size(81, 20);
            this.lblRow.TabIndex = 17;
            this.lblRow.Text = "w wierszu:";
            // 
            // lblCol
            // 
            this.lblCol.AutoSize = true;
            this.lblCol.Location = new System.Drawing.Point(870, 338);
            this.lblCol.Name = "lblCol";
            this.lblCol.Size = new System.Drawing.Size(91, 20);
            this.lblCol.TabIndex = 18;
            this.lblCol.Text = "w kolumnie:";
            // 
            // tbRow
            // 
            this.tbRow.Location = new System.Drawing.Point(878, 292);
            this.tbRow.Name = "tbRow";
            this.tbRow.Size = new System.Drawing.Size(54, 26);
            this.tbRow.TabIndex = 19;
            this.tbRow.Text = "10";
            // 
            // tbCol
            // 
            this.tbCol.Location = new System.Drawing.Point(874, 361);
            this.tbCol.Name = "tbCol";
            this.tbCol.Size = new System.Drawing.Size(54, 26);
            this.tbCol.TabIndex = 20;
            this.tbCol.Text = "10";
            // 
            // tbRadius
            // 
            this.tbRadius.Location = new System.Drawing.Point(875, 420);
            this.tbRadius.Name = "tbRadius";
            this.tbRadius.Size = new System.Drawing.Size(54, 26);
            this.tbRadius.TabIndex = 21;
            this.tbRadius.Text = "3";
            this.tbRadius.Visible = false;
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(874, 397);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(70, 20);
            this.lblRadius.TabIndex = 22;
            this.lblRadius.Text = "promien:";
            this.lblRadius.Visible = false;
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.AllowUserToResizeColumns = false;
            this.dgv1.AllowUserToResizeRows = false;
            this.dgv1.BackgroundColor = System.Drawing.Color.White;
            this.dgv1.ColumnHeadersHeight = 8;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv1.ColumnHeadersVisible = false;
            this.dgv1.Location = new System.Drawing.Point(1071, 61);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.RowHeadersWidth = 8;
            this.dgv1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv1.RowTemplate.Height = 8;
            this.dgv1.Size = new System.Drawing.Size(820, 820);
            this.dgv1.TabIndex = 23;
            // 
            // lblInitial2
            // 
            this.lblInitial2.AutoSize = true;
            this.lblInitial2.Location = new System.Drawing.Point(1173, 18);
            this.lblInitial2.Name = "lblInitial2";
            this.lblInitial2.Size = new System.Drawing.Size(121, 20);
            this.lblInitial2.TabIndex = 24;
            this.lblInitial2.Text = "Typ sasiedztwa:";
            // 
            // cbRule2
            // 
            this.cbRule2.FormattingEnabled = true;
            this.cbRule2.Items.AddRange(new object[] {
            "Von Neumann",
            "Pentagonalne losowe",
            "Heksagonalne",
            "Moore",
            "z promieniem"});
            this.cbRule2.Location = new System.Drawing.Point(1300, 15);
            this.cbRule2.Name = "cbRule2";
            this.cbRule2.Size = new System.Drawing.Size(149, 28);
            this.cbRule2.TabIndex = 25;
            this.cbRule2.Text = "Von Neumann";
            this.cbRule2.SelectedIndexChanged += new System.EventHandler(this.cbRule2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1455, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Warunki brzegowe:";
            // 
            // cbBoundary2
            // 
            this.cbBoundary2.FormattingEnabled = true;
            this.cbBoundary2.Items.AddRange(new object[] {
            "absorbujące",
            "periodyczne"});
            this.cbBoundary2.Location = new System.Drawing.Point(1605, 14);
            this.cbBoundary2.Name = "cbBoundary2";
            this.cbBoundary2.Size = new System.Drawing.Size(149, 28);
            this.cbBoundary2.TabIndex = 27;
            this.cbBoundary2.Text = "absorbujące";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1760, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Parakemtr kt:";
            // 
            // tbKt
            // 
            this.tbKt.Location = new System.Drawing.Point(1869, 15);
            this.tbKt.Name = "tbKt";
            this.tbKt.Size = new System.Drawing.Size(54, 26);
            this.tbKt.TabIndex = 29;
            this.tbKt.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1904, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Liczba iteracji:";
            // 
            // tbIterations
            // 
            this.tbIterations.Location = new System.Drawing.Point(1931, 93);
            this.tbIterations.Name = "tbIterations";
            this.tbIterations.Size = new System.Drawing.Size(54, 26);
            this.tbIterations.TabIndex = 31;
            this.tbIterations.Text = "1";
            // 
            // btnStartMC
            // 
            this.btnStartMC.Location = new System.Drawing.Point(1071, 0);
            this.btnStartMC.Name = "btnStartMC";
            this.btnStartMC.Size = new System.Drawing.Size(81, 54);
            this.btnStartMC.TabIndex = 32;
            this.btnStartMC.Text = "Start";
            this.btnStartMC.UseVisualStyleBackColor = true;
            this.btnStartMC.Click += new System.EventHandler(this.btnStartMC_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2016, 885);
            this.Controls.Add(this.btnStartMC);
            this.Controls.Add(this.tbIterations);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbKt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbBoundary2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbRule2);
            this.Controls.Add(this.lblInitial2);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.lblRadius);
            this.Controls.Add(this.tbRadius);
            this.Controls.Add(this.tbCol);
            this.Controls.Add(this.tbRow);
            this.Controls.Add(this.lblCol);
            this.Controls.Add(this.lblRow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbInitial);
            this.Controls.Add(this.cbBoundary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSize);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.lbly);
            this.Controls.Add(this.lblx);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblInitial);
            this.Controls.Add(this.cbRule);
            this.Name = "Form1";
            this.Text = "CA+MC";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbRule;
        private System.Windows.Forms.Label lblInitial;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.Label lblx;
        private System.Windows.Forms.Label lbly;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBoundary;
        private System.Windows.Forms.ComboBox cbInitial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRow;
        private System.Windows.Forms.Label lblCol;
        private System.Windows.Forms.TextBox tbRow;
        private System.Windows.Forms.TextBox tbCol;
        private System.Windows.Forms.TextBox tbRadius;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Label lblInitial2;
        private System.Windows.Forms.ComboBox cbRule2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbBoundary2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbKt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIterations;
        private System.Windows.Forms.Button btnStartMC;
        private System.Windows.Forms.Timer timer1;
    }
}

