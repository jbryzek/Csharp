namespace Hangman
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
            this.lblsample = new System.Windows.Forms.Label();
            this.btnSolution = new System.Windows.Forms.Button();
            this.lblsample2 = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblsample
            // 
            this.lblsample.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblsample.ForeColor = System.Drawing.Color.Blue;
            this.lblsample.Location = new System.Drawing.Point(12, 77);
            this.lblsample.Name = "lblsample";
            this.lblsample.Size = new System.Drawing.Size(40, 40);
            this.lblsample.TabIndex = 0;
            this.lblsample.Visible = false;
            // 
            // btnSolution
            // 
            this.btnSolution.Location = new System.Drawing.Point(274, 377);
            this.btnSolution.Name = "btnSolution";
            this.btnSolution.Size = new System.Drawing.Size(126, 52);
            this.btnSolution.TabIndex = 1;
            this.btnSolution.Text = "Solution";
            this.btnSolution.UseVisualStyleBackColor = true;
            this.btnSolution.Click += new System.EventHandler(this.btnSolution_Click);
            // 
            // lblsample2
            // 
            this.lblsample2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblsample2.ForeColor = System.Drawing.Color.Blue;
            this.lblsample2.Location = new System.Drawing.Point(68, 283);
            this.lblsample2.Name = "lblsample2";
            this.lblsample2.Size = new System.Drawing.Size(81, 81);
            this.lblsample2.TabIndex = 2;
            this.lblsample2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblsample2.Visible = false;
            // 
            // lblLine
            // 
            this.lblLine.BackColor = System.Drawing.Color.Black;
            this.lblLine.ForeColor = System.Drawing.Color.Blue;
            this.lblLine.Location = new System.Drawing.Point(217, 283);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(60, 8);
            this.lblLine.TabIndex = 3;
            this.lblLine.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 450);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.lblsample2);
            this.Controls.Add(this.btnSolution);
            this.Controls.Add(this.lblsample);
            this.Name = "Form1";
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblsample;
        private System.Windows.Forms.Button btnSolution;
        private System.Windows.Forms.Label lblsample2;
        private System.Windows.Forms.Label lblLine;
    }
}

