namespace Lab5A
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
            this.components = new System.ComponentModel.Container();
            this.colorPick = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.flowRate = new System.Windows.Forms.Timer(this.components);
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // colorPick
            // 
            this.colorPick.Location = new System.Drawing.Point(43, 12);
            this.colorPick.Name = "colorPick";
            this.colorPick.Size = new System.Drawing.Size(75, 23);
            this.colorPick.TabIndex = 0;
            this.colorPick.Text = "Color";
            this.colorPick.UseVisualStyleBackColor = true;
            this.colorPick.Click += new System.EventHandler(this.colorPick_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(136, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 1;
            this.exit.Text = "Close";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(43, 87);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lab5A.Properties.Resources.Faucet;
            this.pictureBox1.Location = new System.Drawing.Point(57, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 61);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(329, 437);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.colorPick);
            this.Name = "Form1";
            this.Text = "A Drop in the Bucket";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button colorPick;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Timer flowRate;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

