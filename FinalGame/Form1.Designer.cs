namespace FinalGame
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
            this.pic_01 = new System.Windows.Forms.PictureBox();
            this.butt_01 = new System.Windows.Forms.Button();
            this.txt_o1 = new System.Windows.Forms.RichTextBox();
            this.txt_02 = new System.Windows.Forms.RichTextBox();
            this.lab_01 = new System.Windows.Forms.Label();
            this.butt_02 = new System.Windows.Forms.Button();
            this.butt_03 = new System.Windows.Forms.Button();
            this.butt_04 = new System.Windows.Forms.Button();
            this.butt_05 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_01)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_01
            // 
            this.pic_01.Location = new System.Drawing.Point(29, 39);
            this.pic_01.Name = "pic_01";
            this.pic_01.Size = new System.Drawing.Size(153, 292);
            this.pic_01.TabIndex = 0;
            this.pic_01.TabStop = false;
            // 
            // butt_01
            // 
            this.butt_01.Location = new System.Drawing.Point(29, 363);
            this.butt_01.Name = "butt_01";
            this.butt_01.Size = new System.Drawing.Size(153, 31);
            this.butt_01.TabIndex = 1;
            this.butt_01.Text = "Switch";
            this.butt_01.UseVisualStyleBackColor = true;
            this.butt_01.Click += new System.EventHandler(this.butt_01_Click);
            // 
            // txt_o1
            // 
            this.txt_o1.Location = new System.Drawing.Point(203, 271);
            this.txt_o1.Name = "txt_o1";
            this.txt_o1.Size = new System.Drawing.Size(211, 60);
            this.txt_o1.TabIndex = 2;
            this.txt_o1.Text = "";
            // 
            // txt_02
            // 
            this.txt_02.Location = new System.Drawing.Point(203, 39);
            this.txt_02.Name = "txt_02";
            this.txt_02.Size = new System.Drawing.Size(453, 194);
            this.txt_02.TabIndex = 3;
            this.txt_02.Text = "";
            // 
            // lab_01
            // 
            this.lab_01.AutoSize = true;
            this.lab_01.Location = new System.Drawing.Point(420, 271);
            this.lab_01.Name = "lab_01";
            this.lab_01.Size = new System.Drawing.Size(95, 13);
            this.lab_01.TabIndex = 4;
            this.lab_01.Text = "Character Spects  ";
            // 
            // butt_02
            // 
            this.butt_02.Location = new System.Drawing.Point(29, 363);
            this.butt_02.Name = "butt_02";
            this.butt_02.Size = new System.Drawing.Size(153, 31);
            this.butt_02.TabIndex = 5;
            this.butt_02.Text = "Switch";
            this.butt_02.UseVisualStyleBackColor = true;
            this.butt_02.Visible = false;
            this.butt_02.Click += new System.EventHandler(this.butt_02_Click);
            // 
            // butt_03
            // 
            this.butt_03.Location = new System.Drawing.Point(29, 363);
            this.butt_03.Name = "butt_03";
            this.butt_03.Size = new System.Drawing.Size(153, 31);
            this.butt_03.TabIndex = 6;
            this.butt_03.Text = "Switch";
            this.butt_03.UseVisualStyleBackColor = true;
            this.butt_03.Visible = false;
            this.butt_03.Click += new System.EventHandler(this.butt_03_Click);
            // 
            // butt_04
            // 
            this.butt_04.Location = new System.Drawing.Point(261, 363);
            this.butt_04.Name = "butt_04";
            this.butt_04.Size = new System.Drawing.Size(153, 31);
            this.butt_04.TabIndex = 7;
            this.butt_04.Text = "Load";
            this.butt_04.UseVisualStyleBackColor = true;
            // 
            // butt_05
            // 
            this.butt_05.Location = new System.Drawing.Point(503, 363);
            this.butt_05.Name = "butt_05";
            this.butt_05.Size = new System.Drawing.Size(153, 31);
            this.butt_05.TabIndex = 8;
            this.butt_05.Text = "Continue ";
            this.butt_05.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 452);
            this.Controls.Add(this.butt_05);
            this.Controls.Add(this.butt_04);
            this.Controls.Add(this.butt_03);
            this.Controls.Add(this.butt_02);
            this.Controls.Add(this.lab_01);
            this.Controls.Add(this.txt_02);
            this.Controls.Add(this.txt_o1);
            this.Controls.Add(this.butt_01);
            this.Controls.Add(this.pic_01);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_01)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_01;
        private System.Windows.Forms.Button butt_01;
        private System.Windows.Forms.RichTextBox txt_o1;
        private System.Windows.Forms.RichTextBox txt_02;
        private System.Windows.Forms.Label lab_01;
        private System.Windows.Forms.Button butt_02;
        private System.Windows.Forms.Button butt_03;
        private System.Windows.Forms.Button butt_04;
        private System.Windows.Forms.Button butt_05;
    }
}

