namespace tickets
{
    partial class LogUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogUp));
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            namefield = new TextBox();
            pictureBox1 = new PictureBox();
            passfield = new TextBox();
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            pictureBox3 = new PictureBox();
            button2 = new Button();
            closebutton = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(passfield);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(namefield);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(633, 886);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(closebutton);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(633, 223);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Swis721 Blk BT", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(127, 50);
            label1.Name = "label1";
            label1.Size = new Size(381, 115);
            label1.TabIndex = 1;
            label1.Text = "LogUp\r\n";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // namefield
            // 
            namefield.Font = new Font("Swis721 BlkCn BT", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            namefield.Location = new Point(196, 263);
            namefield.Multiline = true;
            namefield.Name = "namefield";
            namefield.Size = new Size(386, 93);
            namefield.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.avatar_profile;
            pictureBox1.Location = new Point(25, 239);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // passfield
            // 
            passfield.Font = new Font("Swis721 BlkCn BT", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            passfield.Location = new Point(196, 413);
            passfield.Multiline = true;
            passfield.Name = "passfield";
            passfield.Size = new Size(386, 93);
            passfield.TabIndex = 6;
            passfield.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(25, 391);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(132, 132);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Swis721 BlkCn BT", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(196, 555);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(386, 93);
            textBox1.TabIndex = 8;
            textBox1.UseSystemPasswordChar = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(25, 531);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(132, 132);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Swis721 Blk BT", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Highlight;
            button2.Location = new Point(160, 720);
            button2.Name = "button2";
            button2.Size = new Size(303, 113);
            button2.TabIndex = 9;
            button2.Text = "LOGUP";
            button2.UseVisualStyleBackColor = true;
            // 
            // closebutton
            // 
            closebutton.Cursor = Cursors.Hand;
            closebutton.Font = new Font("Swis721 BlkEx BT", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            closebutton.Location = new Point(594, 0);
            closebutton.Name = "closebutton";
            closebutton.Size = new Size(39, 34);
            closebutton.TabIndex = 2;
            closebutton.Text = "X";
            closebutton.UseVisualStyleBackColor = true;
            closebutton.Click += closebutton_Click;
            // 
            // LogUp
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(633, 886);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LogUp";
            Text = "LogUp";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private TextBox namefield;
        private PictureBox pictureBox1;
        private TextBox passfield;
        private PictureBox pictureBox2;
        private TextBox textBox1;
        private PictureBox pictureBox3;
        private Button button2;
        private Button closebutton;
    }
}