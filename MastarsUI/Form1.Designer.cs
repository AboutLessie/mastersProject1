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
            this.uamLogo = new System.Windows.Forms.PictureBox();
            this.powitanieLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numberOfTestsTBX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nextBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.moreInfoBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.resultTBX = new System.Windows.Forms.ListBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uamLogo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.uamLogo);
            this.panel1.Controls.Add(this.powitanieLbl);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 358);
            this.panel1.TabIndex = 0;
            // 
            // uamLogo
            // 
            this.uamLogo.Image = global::MastarsUI.Properties.Resources.logo;
            this.uamLogo.Location = new System.Drawing.Point(0, 19);
            this.uamLogo.Name = "uamLogo";
            this.uamLogo.Size = new System.Drawing.Size(561, 129);
            this.uamLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uamLogo.TabIndex = 0;
            this.uamLogo.TabStop = false;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.numberOfTestsTBX);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(561, 355);
            this.panel2.TabIndex = 4;
            // 
            // numberOfTestsTBX
            // 
            this.numberOfTestsTBX.Location = new System.Drawing.Point(40, 226);
            this.numberOfTestsTBX.Name = "numberOfTestsTBX";
            this.numberOfTestsTBX.Size = new System.Drawing.Size(100, 20);
            this.numberOfTestsTBX.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wprowadź ile testów należy wykonać:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MastarsUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(4, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(554, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(500, 376);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 23);
            this.nextBtn.TabIndex = 1;
            this.nextBtn.Text = "Dalej";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(16, 375);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Zamknij";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.moreInfoBTN);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.resultTBX);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(560, 357);
            this.panel3.TabIndex = 1;
            // 
            // moreInfoBTN
            // 
            this.moreInfoBTN.Location = new System.Drawing.Point(376, 285);
            this.moreInfoBTN.Name = "moreInfoBTN";
            this.moreInfoBTN.Size = new System.Drawing.Size(75, 23);
            this.moreInfoBTN.TabIndex = 5;
            this.moreInfoBTN.Text = "Szczegóły";
            this.moreInfoBTN.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Najlepszy wynik uzyskały następujące konfiguracje testów:";
            // 
            // resultTBX
            // 
            this.resultTBX.FormattingEnabled = true;
            this.resultTBX.Location = new System.Drawing.Point(29, 226);
            this.resultTBX.Name = "resultTBX";
            this.resultTBX.Size = new System.Drawing.Size(303, 95);
            this.resultTBX.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MastarsUI.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(0, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(554, 123);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 413);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uamLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label powitanieLbl;
        private System.Windows.Forms.PictureBox uamLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox numberOfTestsTBX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button moreInfoBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox resultTBX;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

