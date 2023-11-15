namespace PKQuiz
{
    partial class Form2
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Pokemon Classic", 28F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(159, 31);
            label1.Name = "label1";
            label1.Size = new Size(1019, 91);
            label1.TabIndex = 0;
            label1.Text = "Que Pokémon é esse?";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(439, 136);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(435, 268);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Red;
            pictureBox2.BackgroundImage = Properties.Resources.lifeCount;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(894, 243);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(116, 104);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.lifeCount;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(1016, 243);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(116, 104);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.lifeCount;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(1139, 243);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(116, 104);
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Fuchsia;
            button1.Location = new Point(138, 437);
            button1.Name = "button1";
            button1.Size = new Size(497, 86);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Fuchsia;
            button2.Location = new Point(765, 437);
            button2.Name = "button2";
            button2.Size = new Size(478, 86);
            button2.TabIndex = 6;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Fuchsia;
            button3.Location = new Point(138, 603);
            button3.Name = "button3";
            button3.Size = new Size(497, 86);
            button3.TabIndex = 7;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Fuchsia;
            button4.Location = new Point(765, 603);
            button4.Name = "button4";
            button4.Size = new Size(478, 86);
            button4.TabIndex = 8;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(41F, 65F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(1284, 701);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Font = new Font("Pokemon Classic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(12, 8, 12, 8);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}