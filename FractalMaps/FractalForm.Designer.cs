namespace FractalMaps
{
    partial class FractalForm
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
            this.ImageBox = new System.Windows.Forms.PictureBox();
            this.Generate = new System.Windows.Forms.Button();
            this.seedBox = new System.Windows.Forms.TextBox();
            this.shaveBox = new System.Windows.Forms.CheckBox();
            this.smallScaleBox = new System.Windows.Forms.TextBox();
            this.largeScaleBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.oceanBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.minScaleBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oceanBar)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageBox
            // 
            this.ImageBox.ImageLocation = "";
            this.ImageBox.Location = new System.Drawing.Point(12, 12);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(722, 405);
            this.ImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageBox.TabIndex = 0;
            this.ImageBox.TabStop = false;
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(12, 459);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(240, 52);
            this.Generate.TabIndex = 1;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.button1_Click);
            // 
            // seedBox
            // 
            this.seedBox.Location = new System.Drawing.Point(88, 425);
            this.seedBox.Name = "seedBox";
            this.seedBox.Size = new System.Drawing.Size(164, 20);
            this.seedBox.TabIndex = 2;
            this.seedBox.Text = "987321584";
            this.seedBox.TextChanged += new System.EventHandler(this.seedBox_TextChanged);
            // 
            // shaveBox
            // 
            this.shaveBox.AutoSize = true;
            this.shaveBox.Checked = true;
            this.shaveBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.shaveBox.Location = new System.Drawing.Point(429, 428);
            this.shaveBox.Name = "shaveBox";
            this.shaveBox.Size = new System.Drawing.Size(86, 17);
            this.shaveBox.TabIndex = 3;
            this.shaveBox.Text = "Shave Poles";
            this.shaveBox.UseVisualStyleBackColor = true;
            // 
            // smallScaleBox
            // 
            this.smallScaleBox.Location = new System.Drawing.Point(323, 459);
            this.smallScaleBox.Name = "smallScaleBox";
            this.smallScaleBox.Size = new System.Drawing.Size(100, 20);
            this.smallScaleBox.TabIndex = 4;
            this.smallScaleBox.Text = "11";
            this.smallScaleBox.TextChanged += new System.EventHandler(this.smallScaleBox_TextChanged);
            // 
            // largeScaleBox
            // 
            this.largeScaleBox.Location = new System.Drawing.Point(322, 488);
            this.largeScaleBox.Name = "largeScaleBox";
            this.largeScaleBox.Size = new System.Drawing.Size(100, 20);
            this.largeScaleBox.TabIndex = 5;
            this.largeScaleBox.Text = "20";
            this.largeScaleBox.TextChanged += new System.EventHandler(this.largeScaleBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "New Seed";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 462);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Small Scale";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 491);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Large Scale";
            // 
            // oceanBar
            // 
            this.oceanBar.Location = new System.Drawing.Point(429, 466);
            this.oceanBar.Maximum = 100;
            this.oceanBar.Name = "oceanBar";
            this.oceanBar.Size = new System.Drawing.Size(224, 45);
            this.oceanBar.SmallChange = 5;
            this.oceanBar.TabIndex = 9;
            this.oceanBar.TickFrequency = 5;
            this.oceanBar.Value = 80;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(429, 450);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ocean %";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 436);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Min Scale";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // minScaleBox
            // 
            this.minScaleBox.Location = new System.Drawing.Point(323, 433);
            this.minScaleBox.Name = "minScaleBox";
            this.minScaleBox.Size = new System.Drawing.Size(100, 20);
            this.minScaleBox.TabIndex = 11;
            this.minScaleBox.Text = "3";
            this.minScaleBox.TextChanged += new System.EventHandler(this.minScaleBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 523);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.minScaleBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.oceanBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.largeScaleBox);
            this.Controls.Add(this.smallScaleBox);
            this.Controls.Add(this.shaveBox);
            this.Controls.Add(this.seedBox);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.ImageBox);
            this.Name = "Form1";
            this.Text = "FractalMaps";
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oceanBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImageBox;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.TextBox seedBox;
        private System.Windows.Forms.CheckBox shaveBox;
        private System.Windows.Forms.TextBox smallScaleBox;
        private System.Windows.Forms.TextBox largeScaleBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar oceanBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox minScaleBox;
    }
}

