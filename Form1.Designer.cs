namespace U3_Practica_9
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            listBox1 = new ListBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(205, 24);
            label1.TabIndex = 0;
            label1.Text = "Factorial de un número";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightGray;
            textBox1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(223, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 32);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.LightGray;
            textBox2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(262, 325);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 32);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.LightGray;
            textBox3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(89, 373);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(298, 32);
            textBox3.TabIndex = 3;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.LightGray;
            listBox1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 24;
            listBox1.Location = new Point(138, 87);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(199, 196);
            listBox1.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.WhiteSmoke;
            button1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(364, 23);
            button1.Name = "button1";
            button1.Size = new Size(103, 39);
            button1.TabIndex = 5;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(55, 328);
            label2.Name = "label2";
            label2.Size = new Size(201, 24);
            label2.TabIndex = 6;
            label2.Text = "El factorial del número";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(55, 376);
            label3.Name = "label3";
            label3.Size = new Size(28, 24);
            label3.TabIndex = 7;
            label3.Text = "es";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(491, 436);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Factoriales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ListBox listBox1;
        private Button button1;
        private Label label2;
        private Label label3;
    }
}