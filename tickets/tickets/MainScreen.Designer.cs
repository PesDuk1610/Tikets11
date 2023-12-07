namespace tickets
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            panel1 = new Panel();
            panel2 = new Panel();
            closebutton = new Button();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1302, 663);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(closebutton);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button2);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1302, 266);
            panel2.TabIndex = 1;
            // 
            // closebutton
            // 
            closebutton.Cursor = Cursors.Hand;
            closebutton.Font = new Font("Swis721 BlkEx BT", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            closebutton.Location = new Point(1263, 0);
            closebutton.Name = "closebutton";
            closebutton.Size = new Size(39, 34);
            closebutton.TabIndex = 13;
            closebutton.Text = "X";
            closebutton.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Swis721 Blk BT", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.Highlight;
            button3.Location = new Point(63, 77);
            button3.Name = "button3";
            button3.Size = new Size(303, 113);
            button3.TabIndex = 12;
            button3.Text = "Profile";
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Swis721 Blk BT", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Highlight;
            button1.Location = new Point(938, 77);
            button1.Name = "button1";
            button1.Size = new Size(300, 113);
            button1.TabIndex = 11;
            button1.Text = "Booking";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Swis721 Blk BT", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Highlight;
            button2.Location = new Point(393, 77);
            button2.Name = "button2";
            button2.Size = new Size(519, 113);
            button2.TabIndex = 10;
            button2.Text = "Search Flights";
            button2.UseVisualStyleBackColor = true;
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1302, 663);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainScreen";
            Text = "MainScreen";
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button3;
        private Button button1;
        private Button button2;
        private Button closebutton;
    }
}