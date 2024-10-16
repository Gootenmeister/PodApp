namespace PodApp
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Avsnitt = new ListBox();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label3 = new Label();
            textBox3 = new TextBox();
            comboBox2 = new ComboBox();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(92, 122);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(315, 31);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 122);
            label1.Name = "label1";
            label1.Size = new Size(45, 25);
            label1.TabIndex = 1;
            label1.Text = "URL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 165);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 2;
            label2.Text = "NAMN";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(92, 162);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(315, 31);
            textBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(413, 165);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 4;
            comboBox1.Text = "Välj kategori";
            // 
            // button1
            // 
            button1.Location = new Point(12, 215);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "lägg Till";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(148, 215);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 6;
            button2.Text = "Ändra";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(282, 215);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 7;
            button3.Text = "Ta bort";
            button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(-6, 281);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(515, 591);
            dataGridView1.TabIndex = 8;
            // 
            // Column1
            // 
            Column1.HeaderText = "Namn";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Titel";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Kategori";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Avsnitt
            // 
            Avsnitt.FormattingEnabled = true;
            Avsnitt.ItemHeight = 25;
            Avsnitt.Location = new Point(515, 281);
            Avsnitt.Name = "Avsnitt";
            Avsnitt.Size = new Size(322, 304);
            Avsnitt.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(515, 612);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 248);
            panel1.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Location = new Point(860, 337);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(384, 248);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kategori";
            // 
            // button4
            // 
            button4.Location = new Point(860, 281);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 12;
            button4.Text = "Lägg Till";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(981, 282);
            button5.Name = "button5";
            button5.Size = new Size(112, 34);
            button5.TabIndex = 13;
            button5.Text = "Ändra";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(1099, 282);
            button6.Name = "button6";
            button6.Size = new Size(112, 34);
            button6.TabIndex = 14;
            button6.Text = "Ta bort";
            button6.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(857, 186);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 15;
            label3.Text = "Kategori";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(860, 217);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(362, 31);
            textBox3.TabIndex = 16;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(92, 61);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(315, 33);
            comboBox2.TabIndex = 17;
            comboBox2.Text = "Filtrera";
            // 
            // button7
            // 
            button7.Location = new Point(1169, 12);
            button7.Name = "button7";
            button7.Size = new Size(112, 34);
            button7.TabIndex = 18;
            button7.Text = "Återställa";
            button7.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1636, 882);
            Controls.Add(button7);
            Controls.Add(comboBox2);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(Avsnitt);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "KebabCast (pre-alpha)";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private ListBox Avsnitt;
        private Panel panel1;
        private GroupBox groupBox1;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label3;
        private TextBox textBox3;
        private ComboBox comboBox2;
        private Button button7;
    }
}
