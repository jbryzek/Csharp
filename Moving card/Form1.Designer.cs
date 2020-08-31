namespace Justyna_BryzekUNIC
{
    partial class Moving_Cards
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Moving_Cards));
            this.cardRed = new System.Windows.Forms.PictureBox();
            this.cardBlack = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cardRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBlack)).BeginInit();
            this.SuspendLayout();
            // 
            // cardRed
            // 
            this.cardRed.Image = ((System.Drawing.Image)(resources.GetObject("cardRed.Image")));
            this.cardRed.Location = new System.Drawing.Point(153, 62);
            this.cardRed.Name = "cardRed";
            this.cardRed.Size = new System.Drawing.Size(116, 146);
            this.cardRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardRed.TabIndex = 0;
            this.cardRed.TabStop = false;
            this.cardRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cardRed_MouseDown);
            this.cardRed.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cardRed_MouseMove);
            this.cardRed.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cardRed_MouseUp);
            // 
            // cardBlack
            // 
            this.cardBlack.Image = ((System.Drawing.Image)(resources.GetObject("cardBlack.Image")));
            this.cardBlack.Location = new System.Drawing.Point(305, 62);
            this.cardBlack.Name = "cardBlack";
            this.cardBlack.Size = new System.Drawing.Size(116, 146);
            this.cardBlack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardBlack.TabIndex = 1;
            this.cardBlack.TabStop = false;
            this.cardBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cardBlack_MouseDown);
            this.cardBlack.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cardBlack_MouseMove);
            this.cardBlack.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cardBlack_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Moving_Cards
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cardBlack);
            this.Controls.Add(this.cardRed);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Moving_Cards";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Moving Cards";
            this.Click += new System.EventHandler(this.Moving_Cards_Click);
            ((System.ComponentModel.ISupportInitialize)(this.cardRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBlack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cardRed;
        private System.Windows.Forms.PictureBox cardBlack;
        private System.Windows.Forms.Timer timer1;
    }
}

