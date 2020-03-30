namespace MastarsUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.powitanieLbl = new System.Windows.Forms.Label();
            this.btnDalej1 = new System.Windows.Forms.Button();
            this.btnExit1 = new System.Windows.Forms.Button();
            this.uamLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uamLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.powitanieLbl);
            this.panel1.Controls.Add(this.btnDalej1);
            this.panel1.Controls.Add(this.btnExit1);
            this.panel1.Controls.Add(this.uamLogo);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 387);
            this.panel1.TabIndex = 0;
            // 
            // powitanieLbl
            // 
            this.powitanieLbl.Location = new System.Drawing.Point(1, 186);
            this.powitanieLbl.Name = "powitanieLbl";
            this.powitanieLbl.Size = new System.Drawing.Size(560, 123);
            this.powitanieLbl.TabIndex = 3;
            this.powitanieLbl.Text = resources.GetString("powitanieLbl.Text");
            this.powitanieLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnDalej1
            // 
            this.btnDalej1.Location = new System.Drawing.Point(482, 360);
            this.btnDalej1.Name = "btnDalej1";
            this.btnDalej1.Size = new System.Drawing.Size(75, 23);
            this.btnDalej1.TabIndex = 2;
            this.btnDalej1.Text = "Dalej";
            this.btnDalej1.UseVisualStyleBackColor = true;
            // 
            // btnExit1
            // 
            this.btnExit1.Location = new System.Drawing.Point(4, 361);
            this.btnExit1.Name = "btnExit1";
            this.btnExit1.Size = new System.Drawing.Size(75, 23);
            this.btnExit1.TabIndex = 1;
            this.btnExit1.Text = "Zamknij";
            this.btnExit1.UseVisualStyleBackColor = true;
            // 
            // uamLogo
            // 
            this.uamLogo.Image = global::MastarsUI.Properties.Resources.logo;
            this.uamLogo.Location = new System.Drawing.Point(0, 19);
            this.uamLogo.Name = "uamLogo";
            this.uamLogo.Size = new System.Drawing.Size(561, 129);
            this.uamLogo.TabIndex = 0;
            this.uamLogo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uamLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label powitanieLbl;
        private System.Windows.Forms.Button btnDalej1;
        private System.Windows.Forms.Button btnExit1;
        private System.Windows.Forms.PictureBox uamLogo;
    }
}

