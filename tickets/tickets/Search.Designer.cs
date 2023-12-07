namespace tickets
{
    partial class Search
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 106);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(684, 523);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveBorder;
            label1.Font = new Font("Swis721 Blk BT", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(80, 21);
            label1.Name = "label1";
            label1.Size = new Size(514, 64);
            label1.TabIndex = 1;
            label1.Text = "Search for fllight";
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Swis721 Blk BT", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Highlight;
            button2.Location = new Point(906, 47);
            button2.Name = "button2";
            button2.Size = new Size(283, 65);
            button2.TabIndex = 17;
            button2.Text = "From";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Swis721 Blk BT", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Highlight;
            button1.Location = new Point(906, 211);
            button1.Name = "button1";
            button1.Size = new Size(283, 65);
            button1.TabIndex = 18;
            button1.Text = "To";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(906, 118);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(283, 62);
            textBox1.TabIndex = 19;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(906, 282);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(283, 62);
            textBox2.TabIndex = 20;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Swis721 Blk BT", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.Highlight;
            button3.Location = new Point(883, 382);
            button3.Name = "button3";
            button3.Size = new Size(344, 90);
            button3.TabIndex = 21;
            button3.Text = "Search";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Swis721 Blk BT", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.Highlight;
            button4.Location = new Point(768, 563);
            button4.Name = "button4";
            button4.Size = new Size(522, 66);
            button4.TabIndex = 22;
            button4.Text = "Back to main screen";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Cursor = Cursors.Hand;
            button5.Font = new Font("Swis721 Blk BT", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.Highlight;
            button5.Location = new Point(768, 491);
            button5.Name = "button5";
            button5.Size = new Size(522, 66);
            button5.TabIndex = 23;
            button5.Text = "Go to Booking";
            button5.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.search2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1302, 663);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Search";
            Text = "Search";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}