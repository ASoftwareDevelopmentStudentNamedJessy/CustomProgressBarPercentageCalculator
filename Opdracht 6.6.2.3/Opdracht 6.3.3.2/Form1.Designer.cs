namespace Opdracht_6._3._3._2
{
    partial class OpdrachtZesDrieDrieDrie
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
            this.txtAantalKamersBezet = new System.Windows.Forms.TextBox();
            this.btnBereken = new System.Windows.Forms.Button();
            this.txtTotaalKamers = new System.Windows.Forms.TextBox();
            this.lblProgress = new System.Windows.Forms.Label();
            this.lblProgressMax = new System.Windows.Forms.Label();
            this.lblBezettingsgraad = new System.Windows.Forms.Label();
            this.pbProgress = new Opdracht_6._3._3._2.CustomProgressBar();
            this.SuspendLayout();
            // 
            // txtAantalKamersBezet
            // 
            this.txtAantalKamersBezet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtAantalKamersBezet.Location = new System.Drawing.Point(431, 199);
            this.txtAantalKamersBezet.Name = "txtAantalKamersBezet";
            this.txtAantalKamersBezet.Size = new System.Drawing.Size(134, 34);
            this.txtAantalKamersBezet.TabIndex = 1;
            // 
            // btnBereken
            // 
            this.btnBereken.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnBereken.Location = new System.Drawing.Point(571, 199);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(193, 74);
            this.btnBereken.TabIndex = 2;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // txtTotaalKamers
            // 
            this.txtTotaalKamers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtTotaalKamers.Location = new System.Drawing.Point(431, 239);
            this.txtTotaalKamers.Name = "txtTotaalKamers";
            this.txtTotaalKamers.Size = new System.Drawing.Size(134, 34);
            this.txtTotaalKamers.TabIndex = 4;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblProgress.Location = new System.Drawing.Point(190, 199);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(235, 29);
            this.lblProgress.TabIndex = 5;
            this.lblProgress.Text = "Aantal kamers bezet:";
            // 
            // lblProgressMax
            // 
            this.lblProgressMax.AutoSize = true;
            this.lblProgressMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblProgressMax.Location = new System.Drawing.Point(183, 239);
            this.lblProgressMax.Name = "lblProgressMax";
            this.lblProgressMax.Size = new System.Drawing.Size(242, 29);
            this.lblProgressMax.TabIndex = 6;
            this.lblProgressMax.Text = "Totaal aantal kamers:";
            // 
            // lblBezettingsgraad
            // 
            this.lblBezettingsgraad.AutoSize = true;
            this.lblBezettingsgraad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblBezettingsgraad.Location = new System.Drawing.Point(190, 100);
            this.lblBezettingsgraad.Name = "lblBezettingsgraad";
            this.lblBezettingsgraad.Size = new System.Drawing.Size(187, 29);
            this.lblBezettingsgraad.TabIndex = 7;
            this.lblBezettingsgraad.Text = "Bezettingsgraad";
            // 
            // pbProgress
            // 
            this.pbProgress.Location = new System.Drawing.Point(188, 132);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(576, 61);
            this.pbProgress.TabIndex = 0;
            // 
            // OpdrachtZesDrieDrieDrie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBezettingsgraad);
            this.Controls.Add(this.lblProgressMax);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.txtTotaalKamers);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.txtAantalKamersBezet);
            this.Controls.Add(this.pbProgress);
            this.Name = "OpdrachtZesDrieDrieDrie";
            this.Text = "Opdracht 6.3.3.3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAantalKamersBezet;
        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.TextBox txtTotaalKamers;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Label lblProgressMax;
        private System.Windows.Forms.Label lblBezettingsgraad;
        private CustomProgressBar pbProgress;
    }
}

