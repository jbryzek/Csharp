namespace gra
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
            this.cbInitial = new System.Windows.Forms.ComboBox();
            this.lblInitial = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.tbX = new System.Windows.Forms.TextBox();
            this.lblx = new System.Windows.Forms.Label();
            this.lbly = new System.Windows.Forms.Label();
            this.tbY = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSize = new System.Windows.Forms.Button();
            this.btnInterval = new System.Windows.Forms.Button();
            this.tbInterval = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // cbInitial
            // 
            this.cbInitial.FormattingEnabled = true;
            this.cbInitial.Items.AddRange(new object[] {
            "niezmienny",
            "glider",
            "reczna definicja",
            "oscylator",
            "losowy"});
            this.cbInitial.Location = new System.Drawing.Point(402, 12);
            this.cbInitial.Name = "cbInitial";
            this.cbInitial.Size = new System.Drawing.Size(149, 28);
            this.cbInitial.TabIndex = 1;
            this.cbInitial.Text = "niezmienny";
            // 
            // lblInitial
            // 
            this.lblInitial.AutoSize = true;
            this.lblInitial.Location = new System.Drawing.Point(262, 15);
            this.lblInitial.Name = "lblInitial";
            this.lblInitial.Size = new System.Drawing.Size(134, 20);
            this.lblInitial.TabIndex = 2;
            this.lblInitial.Text = "Stan poczatkowy:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(557, 15);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(112, 20);
            this.lblSize.TabIndex = 3;
            this.lblSize.Text = "Rozmiar siatki:";
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(705, 12);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(54, 26);
            this.tbX.TabIndex = 4;
            this.tbX.Text = "10";
            // 
            // lblx
            // 
            this.lblx.AutoSize = true;
            this.lblx.Location = new System.Drawing.Point(675, 15);
            this.lblx.Name = "lblx";
            this.lblx.Size = new System.Drawing.Size(24, 20);
            this.lblx.TabIndex = 5;
            this.lblx.Text = "X:";
            // 
            // lbly
            // 
            this.lbly.AutoSize = true;
            this.lbly.Location = new System.Drawing.Point(765, 15);
            this.lbly.Name = "lbly";
            this.lbly.Size = new System.Drawing.Size(24, 20);
            this.lbly.TabIndex = 6;
            this.lbly.Text = "Y:";
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(795, 12);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(54, 26);
            this.tbY.TabIndex = 7;
            this.tbY.Text = "10";
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
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(91, 1);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(79, 54);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(176, 1);
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
            this.dgv.ColumnHeadersHeight = 8;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv.ColumnHeadersVisible = false;
            this.dgv.Location = new System.Drawing.Point(4, 70);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 8;
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv.RowTemplate.Height = 8;
            this.dgv.Size = new System.Drawing.Size(724, 551);
            this.dgv.TabIndex = 11;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnSize
            // 
            this.btnSize.Location = new System.Drawing.Point(755, 56);
            this.btnSize.Name = "btnSize";
            this.btnSize.Size = new System.Drawing.Size(126, 63);
            this.btnSize.TabIndex = 12;
            this.btnSize.Text = "Ustaw nowy rozmiar";
            this.btnSize.UseVisualStyleBackColor = true;
            this.btnSize.Click += new System.EventHandler(this.btnSize_Click);
            // 
            // btnInterval
            // 
            this.btnInterval.Location = new System.Drawing.Point(755, 183);
            this.btnInterval.Name = "btnInterval";
            this.btnInterval.Size = new System.Drawing.Size(126, 63);
            this.btnInterval.TabIndex = 13;
            this.btnInterval.Text = "Ustaw nowy interwal";
            this.btnInterval.UseVisualStyleBackColor = true;
            this.btnInterval.Click += new System.EventHandler(this.btnInterval_Click);
            // 
            // tbInterval
            // 
            this.tbInterval.Location = new System.Drawing.Point(795, 139);
            this.tbInterval.Name = "tbInterval";
            this.tbInterval.Size = new System.Drawing.Size(54, 26);
            this.tbInterval.TabIndex = 14;
            this.tbInterval.Text = "10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 626);
            this.Controls.Add(this.tbInterval);
            this.Controls.Add(this.btnInterval);
            this.Controls.Add(this.btnSize);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.lbly);
            this.Controls.Add(this.lblx);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblInitial);
            this.Controls.Add(this.cbInitial);
            this.Name = "Form1";
            this.Text = "The game of life";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbInitial;
        private System.Windows.Forms.Label lblInitial;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.Label lblx;
        private System.Windows.Forms.Label lbly;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSize;
        private System.Windows.Forms.Button btnInterval;
        private System.Windows.Forms.TextBox tbInterval;
    }
}

