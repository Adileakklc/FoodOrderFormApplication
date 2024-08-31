namespace formuygulamasi2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton radioButtonSmall;
        private System.Windows.Forms.RadioButton radioButtonMedium;
        private System.Windows.Forms.RadioButton radioButtonLarge; 
        private System.Windows.Forms.CheckBox checkBoxCheese;
        private System.Windows.Forms.CheckBox checkBoxOnion;
        private System.Windows.Forms.CheckBox checkBoxGarlic;
        private System.Windows.Forms.ListBox listBoxPreviousOrders;


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            listBox1 = new ListBox();
            radioButtonSmall = new RadioButton();
            radioButtonMedium = new RadioButton();
            radioButtonLarge = new RadioButton();
            checkBoxCheese = new CheckBox();
            checkBoxOnion = new CheckBox();
            checkBoxGarlic = new CheckBox();
            listBoxPreviousOrders = new ListBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(40, 46);
            comboBox1.Margin = new Padding(4, 5, 4, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(265, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.White;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(40, 108);
            comboBox2.Margin = new Padding(4, 5, 4, 5);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(265, 28);
            comboBox2.TabIndex = 1;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(333, 51);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(145, 23);
            label1.TabIndex = 2;
            label1.Text = "Seçilen Kategori:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.DarkBlue;
            label2.Location = new Point(333, 112);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(129, 23);
            label2.TabIndex = 3;
            label2.Text = "Seçilen Yemek:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(40, 323);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(265, 27);
            textBox1.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(40, 385);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(100, 35);
            button1.TabIndex = 5;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.White;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(40, 169);
            listBox1.Margin = new Padding(4, 5, 4, 5);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(265, 144);
            listBox1.TabIndex = 6;
            // 
            // radioButtonSmall
            // 
            radioButtonSmall.AutoSize = true;
            radioButtonSmall.Location = new Point(517, 169);
            radioButtonSmall.Margin = new Padding(4, 5, 4, 5);
            radioButtonSmall.Name = "radioButtonSmall";
            radioButtonSmall.Size = new Size(69, 24);
            radioButtonSmall.TabIndex = 9;
            radioButtonSmall.TabStop = true;
            radioButtonSmall.Text = "Küçük";
            radioButtonSmall.UseVisualStyleBackColor = true;
            radioButtonSmall.CheckedChanged += radioButtonPorsiyon_CheckedChanged;
            // 
            // radioButtonMedium
            // 
            radioButtonMedium.AutoSize = true;
            radioButtonMedium.Location = new Point(517, 199);
            radioButtonMedium.Margin = new Padding(4, 5, 4, 5);
            radioButtonMedium.Name = "radioButtonMedium";
            radioButtonMedium.Size = new Size(59, 24);
            radioButtonMedium.TabIndex = 10;
            radioButtonMedium.TabStop = true;
            radioButtonMedium.Text = "Orta";
            radioButtonMedium.UseVisualStyleBackColor = true;
            radioButtonMedium.CheckedChanged += radioButtonPorsiyon_CheckedChanged;
            // 
            // radioButtonLarge
            // 
            radioButtonLarge.AutoSize = true;
            radioButtonLarge.Location = new Point(517, 228);
            radioButtonLarge.Margin = new Padding(4, 5, 4, 5);
            radioButtonLarge.Name = "radioButtonLarge";
            radioButtonLarge.Size = new Size(69, 24);
            radioButtonLarge.TabIndex = 11;
            radioButtonLarge.TabStop = true;
            radioButtonLarge.Text = "Büyük";
            radioButtonLarge.UseVisualStyleBackColor = true;
            radioButtonLarge.CheckedChanged += radioButtonPorsiyon_CheckedChanged;
            // 
            // checkBoxCheese
            // 
            checkBoxCheese.AutoSize = true;
            checkBoxCheese.Location = new Point(322, 169);
            checkBoxCheese.Name = "checkBoxCheese";
            checkBoxCheese.Size = new Size(70, 24);
            checkBoxCheese.TabIndex = 12;
            checkBoxCheese.Text = "Peynir";
            checkBoxCheese.UseVisualStyleBackColor = true;
            checkBoxCheese.CheckedChanged += checkBoxExtras_CheckedChanged;
            // 
            // checkBoxOnion
            // 
            checkBoxOnion.AutoSize = true;
            checkBoxOnion.Location = new Point(322, 199);
            checkBoxOnion.Name = "checkBoxOnion";
            checkBoxOnion.Size = new Size(73, 24);
            checkBoxOnion.TabIndex = 13;
            checkBoxOnion.Text = "Soğan";
            checkBoxOnion.UseVisualStyleBackColor = true;
            checkBoxOnion.CheckedChanged += checkBoxExtras_CheckedChanged;
            // 
            // checkBoxGarlic
            // 
            checkBoxGarlic.AutoSize = true;
            checkBoxGarlic.Location = new Point(322, 229);
            checkBoxGarlic.Name = "checkBoxGarlic";
            checkBoxGarlic.Size = new Size(90, 24);
            checkBoxGarlic.TabIndex = 14;
            checkBoxGarlic.Text = "Sarımsak";
            checkBoxGarlic.UseVisualStyleBackColor = true;
            checkBoxGarlic.CheckedChanged += checkBoxExtras_CheckedChanged;
            // 
            // listBoxPreviousOrders
            // 
            listBoxPreviousOrders.BackColor = Color.White;
            listBoxPreviousOrders.FormattingEnabled = true;
            listBoxPreviousOrders.Location = new Point(312, 323);
            listBoxPreviousOrders.Name = "listBoxPreviousOrders";
            listBoxPreviousOrders.Size = new Size(527, 144);
            listBoxPreviousOrders.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(150, 85, 125);
            ClientSize = new Size(862, 538);
            Controls.Add(listBoxPreviousOrders);
            Controls.Add(checkBoxGarlic);
            Controls.Add(checkBoxOnion);
            Controls.Add(checkBoxCheese);
            Controls.Add(radioButtonLarge);
            Controls.Add(radioButtonMedium);
            Controls.Add(radioButtonSmall);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Yemek Seçimi";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
