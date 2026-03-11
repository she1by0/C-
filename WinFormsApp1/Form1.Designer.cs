namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button = new Button();
            label1 = new Label();
            Food = new TextBox();
            SuspendLayout();
            // 
            // button
            // 
            button.Location = new Point(324, 255);
            button.Name = "button";
            button.Size = new Size(111, 83);
            button.TabIndex = 0;
            button.Text = "點餐";
            button.UseVisualStyleBackColor = true;
            button.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(324, 149);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 1;
            label1.Text = "請問你今天想吃什麼";
            label1.Click += label1_Click;
            // 
            // Food
            // 
            Food.Location = new Point(287, 203);
            Food.Name = "Food";
            Food.Size = new Size(178, 23);
            Food.TabIndex = 2;
            Food.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Food);
            Controls.Add(label1);
            Controls.Add(button);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button;
        private Label label1;
        private TextBox Food;
    }
}
