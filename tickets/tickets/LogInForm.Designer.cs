namespace tickets
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            passfield = new TextBox();
            pictureBox2 = new PictureBox();
            namefield = new TextBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            closebutton = new Button();
            LogIn = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(passfield);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(namefield);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(657, 892);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Swis721 Blk BT", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Highlight;
            button1.Location = new Point(170, 807);
            button1.Name = "button1";
            button1.Size = new Size(303, 45);
            button1.TabIndex = 6;
            button1.Text = "Create an accout";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Swis721 Blk BT", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Highlight;
            button2.Location = new Point(170, 661);
            button2.Name = "button2";
            button2.Size = new Size(303, 113);
            button2.TabIndex = 5;
            button2.Text = "LOGIN";
            button2.UseVisualStyleBackColor = true;
            // 
            // passfield
            // 
            passfield.Font = new Font("Swis721 BlkCn BT", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            passfield.Location = new Point(219, 456);
            passfield.Multiline = true;
            passfield.Name = "passfield";
            passfield.Size = new Size(386, 93);
            passfield.TabIndex = 4;
            passfield.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(48, 432);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(132, 132);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // namefield
            // 
            namefield.Font = new Font("Swis721 BlkCn BT", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            namefield.Location = new Point(219, 249);
            namefield.Multiline = true;
            namefield.Name = "namefield";
            namefield.Size = new Size(386, 93);
            namefield.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.avatar_profile;
            pictureBox1.Location = new Point(48, 228);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(closebutton);
            panel2.Controls.Add(LogIn);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(657, 218);
            panel2.TabIndex = 0;
            // 
            // closebutton
            // 
            closebutton.Cursor = Cursors.Hand;
            closebutton.Font = new Font("Swis721 BlkEx BT", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            closebutton.Location = new Point(618, 0);
            closebutton.Name = "closebutton";
            closebutton.Size = new Size(39, 34);
            closebutton.TabIndex = 1;
            closebutton.Text = "X";
            closebutton.UseVisualStyleBackColor = true;
            closebutton.Click += closebutton_Click;
            // 
            // LogIn
            // 
            LogIn.Font = new Font("Swis721 Blk BT", 36F, FontStyle.Regular, GraphicsUnit.Point);
            LogIn.ForeColor = SystemColors.Highlight;
            LogIn.Location = new Point(159, 45);
            LogIn.Name = "LogIn";
            LogIn.Size = new Size(347, 124);
            LogIn.TabIndex = 0;
            LogIn.Text = "LogIn";
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 892);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LogInForm";
            Text = "LogInForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label LogIn;
        private Button closebutton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox namefield;
        private Button button2;
        private TextBox passfield;
        private Button button1;
    }
}