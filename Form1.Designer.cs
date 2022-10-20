namespace filigraneur
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_choose_image = new System.Windows.Forms.Button();
            this.button_filigraner = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_choose_filigrane = new System.Windows.Forms.Button();
            this.pictureBox_filigrane1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_filigrane2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_filigrane1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_filigrane2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_choose_image
            // 
            this.button_choose_image.Location = new System.Drawing.Point(12, 12);
            this.button_choose_image.Name = "button_choose_image";
            this.button_choose_image.Size = new System.Drawing.Size(100, 23);
            this.button_choose_image.TabIndex = 0;
            this.button_choose_image.Text = "Choose image";
            this.button_choose_image.UseVisualStyleBackColor = true;
            this.button_choose_image.Click += new System.EventHandler(this.button_choose_image_Click);
            // 
            // button_filigraner
            // 
            this.button_filigraner.Enabled = false;
            this.button_filigraner.Location = new System.Drawing.Point(486, 12);
            this.button_filigraner.Name = "button_filigraner";
            this.button_filigraner.Size = new System.Drawing.Size(75, 23);
            this.button_filigraner.TabIndex = 1;
            this.button_filigraner.Text = "Filigraner";
            this.button_filigraner.UseVisualStyleBackColor = true;
            this.button_filigraner.Click += new System.EventHandler(this.button_filigraner_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.Location = new System.Drawing.Point(13, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(768, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button_choose_filigrane
            // 
            this.button_choose_filigrane.Location = new System.Drawing.Point(238, 12);
            this.button_choose_filigrane.Name = "button_choose_filigrane";
            this.button_choose_filigrane.Size = new System.Drawing.Size(114, 23);
            this.button_choose_filigrane.TabIndex = 3;
            this.button_choose_filigrane.Text = "Choose filigrane ->";
            this.button_choose_filigrane.UseVisualStyleBackColor = true;
            this.button_choose_filigrane.Click += new System.EventHandler(this.button_choose_filigrane_Click);
            // 
            // pictureBox_filigrane1
            // 
            this.pictureBox_filigrane1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox_filigrane1.Location = new System.Drawing.Point(796, 108);
            this.pictureBox_filigrane1.Name = "pictureBox_filigrane1";
            this.pictureBox_filigrane1.Size = new System.Drawing.Size(260, 176);
            this.pictureBox_filigrane1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_filigrane1.TabIndex = 4;
            this.pictureBox_filigrane1.TabStop = false;
            // 
            // pictureBox_filigrane2
            // 
            this.pictureBox_filigrane2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox_filigrane2.Location = new System.Drawing.Point(796, 303);
            this.pictureBox_filigrane2.Name = "pictureBox_filigrane2";
            this.pictureBox_filigrane2.Size = new System.Drawing.Size(260, 176);
            this.pictureBox_filigrane2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_filigrane2.TabIndex = 5;
            this.pictureBox_filigrane2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "<- Choose filigrane";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(876, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "<- Choose filigrane";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(876, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Choose filigrane ->";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(358, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Filigraner (Preview)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(582, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "filigraned_";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(594, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Préfixe filename";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Chocolate;
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(700, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Filigraner dossier";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(860, 482);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "Choose image obligatoire\r\nPermet de recup le dossier\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(830, 517);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "Filigraner dossier filigrane toutes les photos\r\n PNG ET JPG du dossier de la phot" +
    "o";
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 10;
            this.trackBar1.Location = new System.Drawing.Point(796, 42);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(260, 45);
            this.trackBar1.TabIndex = 15;
            this.trackBar1.Value = 99;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(888, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "JPG Quality : 99";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1070, 554);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox_filigrane2);
            this.Controls.Add(this.pictureBox_filigrane1);
            this.Controls.Add(this.button_choose_filigrane);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_filigraner);
            this.Controls.Add(this.button_choose_image);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_filigrane1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_filigrane2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_choose_image;
        private System.Windows.Forms.Button button_filigraner;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_choose_filigrane;
        private System.Windows.Forms.PictureBox pictureBox_filigrane1;
        private System.Windows.Forms.PictureBox pictureBox_filigrane2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label6;
    }
}

