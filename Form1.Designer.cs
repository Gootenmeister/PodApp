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
            UrlLänk = new TextBox();
            LabelUrl = new Label();
            LabelNamn = new Label();
            AngeNamn = new TextBox();
            VäljKategori = new ComboBox();
            LäggTillPodd = new Button();
            ÄndraPodd = new Button();
            TaBortPodd = new Button();
            dataGridView = new DataGridView();
            Avsnitt = new ListBox();
            AvsnittInfo = new Panel();
            KategoriGroupBox = new GroupBox();
            LäggTillKategori = new Button();
            ÄndraKategori = new Button();
            TaBortKategori = new Button();
            LabelKategori = new Label();
            NamnPåKategori = new TextBox();
            FiltreringsComboBox = new ComboBox();
            Återställa = new Button();
            ColumnNamn = new DataGridViewTextBoxColumn();
            ColumnTitel = new DataGridViewTextBoxColumn();
            ColumnPublicering = new DataGridViewTextBoxColumn();
            ColumnKategori1 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // UrlLänk
            // 
            UrlLänk.Location = new Point(130, 107);
            UrlLänk.Name = "UrlLänk";
            UrlLänk.Size = new Size(315, 31);
            UrlLänk.TabIndex = 0;
            UrlLänk.TextChanged += urlLänk;
            // 
            // LabelUrl
            // 
            LabelUrl.AutoSize = true;
            LabelUrl.Location = new Point(50, 107);
            LabelUrl.Name = "LabelUrl";
            LabelUrl.Size = new Size(45, 25);
            LabelUrl.TabIndex = 1;
            LabelUrl.Text = "URL";
            // 
            // LabelNamn
            // 
            LabelNamn.AutoSize = true;
            LabelNamn.Location = new Point(55, 150);
            LabelNamn.Name = "LabelNamn";
            LabelNamn.Size = new Size(69, 25);
            LabelNamn.TabIndex = 2;
            LabelNamn.Text = "NAMN";
            // 
            // AngeNamn
            // 
            AngeNamn.Location = new Point(130, 147);
            AngeNamn.Name = "AngeNamn";
            AngeNamn.Size = new Size(315, 31);
            AngeNamn.TabIndex = 3;
            // 
            // VäljKategori
            // 
            VäljKategori.FormattingEnabled = true;
            VäljKategori.Location = new Point(451, 150);
            VäljKategori.Name = "VäljKategori";
            VäljKategori.Size = new Size(182, 33);
            VäljKategori.TabIndex = 4;
            VäljKategori.Text = "Välj kategori";
            VäljKategori.SelectedIndexChanged += VäljKategori_SelectedIndexChanged;
            // 
            // LäggTillPodd
            // 
            LäggTillPodd.Location = new Point(50, 200);
            LäggTillPodd.Name = "LäggTillPodd";
            LäggTillPodd.Size = new Size(112, 34);
            LäggTillPodd.TabIndex = 5;
            LäggTillPodd.Text = "lägg Till";
            LäggTillPodd.UseVisualStyleBackColor = true;
            LäggTillPodd.Click += LäggTillPodd_Click;
            // 
            // ÄndraPodd
            // 
            ÄndraPodd.Location = new Point(186, 200);
            ÄndraPodd.Name = "ÄndraPodd";
            ÄndraPodd.Size = new Size(112, 34);
            ÄndraPodd.TabIndex = 6;
            ÄndraPodd.Text = "Ändra";
            ÄndraPodd.UseVisualStyleBackColor = true;
            ÄndraPodd.Click += ÄndraPodd_Click;
            // 
            // TaBortPodd
            // 
            TaBortPodd.Location = new Point(320, 200);
            TaBortPodd.Name = "TaBortPodd";
            TaBortPodd.Size = new Size(112, 34);
            TaBortPodd.TabIndex = 7;
            TaBortPodd.Text = "Ta bort";
            TaBortPodd.UseVisualStyleBackColor = true;
            TaBortPodd.Click += TaBortPodd_Click;
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ColumnNamn, ColumnTitel, ColumnPublicering, ColumnKategori1 });
            dataGridView.Location = new Point(32, 267);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.Size = new Size(663, 590);
            dataGridView.TabIndex = 8;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // Avsnitt
            // 
            Avsnitt.FormattingEnabled = true;
            Avsnitt.ItemHeight = 25;
            Avsnitt.Location = new Point(831, 246);
            Avsnitt.Name = "Avsnitt";
            Avsnitt.Size = new Size(322, 304);
            Avsnitt.TabIndex = 9;
            Avsnitt.SelectedIndexChanged += Avsnitt_SelectedIndexChanged;
            // 
            // AvsnittInfo
            // 
            AvsnittInfo.BackColor = Color.White;
            AvsnittInfo.Location = new Point(831, 577);
            AvsnittInfo.Name = "AvsnittInfo";
            AvsnittInfo.Size = new Size(322, 248);
            AvsnittInfo.TabIndex = 10;
            AvsnittInfo.Paint += AvsnittInfo_Paint;
            // 
            // KategoriGroupBox
            // 
            KategoriGroupBox.BackColor = Color.White;
            KategoriGroupBox.Location = new Point(1176, 302);
            KategoriGroupBox.Name = "KategoriGroupBox";
            KategoriGroupBox.Size = new Size(384, 248);
            KategoriGroupBox.TabIndex = 11;
            KategoriGroupBox.TabStop = false;
            KategoriGroupBox.Text = "Kategori";
            KategoriGroupBox.Enter += KategoriGroupBox_Enter;
            // 
            // LäggTillKategori
            // 
            LäggTillKategori.Location = new Point(1176, 246);
            LäggTillKategori.Name = "LäggTillKategori";
            LäggTillKategori.Size = new Size(112, 34);
            LäggTillKategori.TabIndex = 12;
            LäggTillKategori.Text = "Lägg Till";
            LäggTillKategori.UseVisualStyleBackColor = true;
            LäggTillKategori.Click += LäggTillKategori_Click;
            // 
            // ÄndraKategori
            // 
            ÄndraKategori.Location = new Point(1297, 247);
            ÄndraKategori.Name = "ÄndraKategori";
            ÄndraKategori.Size = new Size(112, 34);
            ÄndraKategori.TabIndex = 13;
            ÄndraKategori.Text = "Ändra";
            ÄndraKategori.UseVisualStyleBackColor = true;
            // 
            // TaBortKategori
            // 
            TaBortKategori.Location = new Point(1415, 247);
            TaBortKategori.Name = "TaBortKategori";
            TaBortKategori.Size = new Size(112, 34);
            TaBortKategori.TabIndex = 14;
            TaBortKategori.Text = "Ta bort";
            TaBortKategori.UseVisualStyleBackColor = true;
            // 
            // LabelKategori
            // 
            LabelKategori.AutoSize = true;
            LabelKategori.Location = new Point(1026, 188);
            LabelKategori.Name = "LabelKategori";
            LabelKategori.Size = new Size(83, 25);
            LabelKategori.TabIndex = 15;
            LabelKategori.Text = "Kategori";
            LabelKategori.Click += LabelKategori_Click;
            // 
            // NamnPåKategori
            // 
            NamnPåKategori.Location = new Point(1176, 182);
            NamnPåKategori.Name = "NamnPåKategori";
            NamnPåKategori.Size = new Size(362, 31);
            NamnPåKategori.TabIndex = 16;
            NamnPåKategori.TextChanged += KategoriNamnTextBox;
            // 
            // FiltreringsComboBox
            // 
            FiltreringsComboBox.FormattingEnabled = true;
            FiltreringsComboBox.Location = new Point(130, 46);
            FiltreringsComboBox.Name = "FiltreringsComboBox";
            FiltreringsComboBox.Size = new Size(315, 33);
            FiltreringsComboBox.TabIndex = 17;
            FiltreringsComboBox.Text = "Filtrera";
            FiltreringsComboBox.SelectedIndexChanged += FiltreringsComboBox_SelectedIndexChanged;
            // 
            // Återställa
            // 
            Återställa.Location = new Point(1207, -3);
            Återställa.Name = "Återställa";
            Återställa.Size = new Size(112, 34);
            Återställa.TabIndex = 18;
            Återställa.Text = "Återställa";
            Återställa.UseVisualStyleBackColor = true;
            Återställa.Click += Återställa_Click;
            // 
            // ColumnNamn
            // 
            ColumnNamn.HeaderText = "Namn";
            ColumnNamn.MinimumWidth = 8;
            ColumnNamn.Name = "ColumnNamn";
            ColumnNamn.Width = 150;
            // 
            // ColumnTitel
            // 
            ColumnTitel.HeaderText = "Titel";
            ColumnTitel.MinimumWidth = 8;
            ColumnTitel.Name = "ColumnTitel";
            ColumnTitel.Width = 150;
            // 
            // ColumnPublicering
            // 
            ColumnPublicering.HeaderText = "Publicering";
            ColumnPublicering.MinimumWidth = 8;
            ColumnPublicering.Name = "ColumnPublicering";
            ColumnPublicering.Width = 150;
            // 
            // ColumnKategori1
            // 
            ColumnKategori1.HeaderText = "Kategori";
            ColumnKategori1.MinimumWidth = 8;
            ColumnKategori1.Name = "ColumnKategori1";
            ColumnKategori1.Width = 150;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1636, 882);
            Controls.Add(Återställa);
            Controls.Add(FiltreringsComboBox);
            Controls.Add(NamnPåKategori);
            Controls.Add(LabelKategori);
            Controls.Add(TaBortKategori);
            Controls.Add(ÄndraKategori);
            Controls.Add(LäggTillKategori);
            Controls.Add(KategoriGroupBox);
            Controls.Add(AvsnittInfo);
            Controls.Add(Avsnitt);
            Controls.Add(dataGridView);
            Controls.Add(TaBortPodd);
            Controls.Add(ÄndraPodd);
            Controls.Add(LäggTillPodd);
            Controls.Add(VäljKategori);
            Controls.Add(AngeNamn);
            Controls.Add(LabelNamn);
            Controls.Add(LabelUrl);
            Controls.Add(UrlLänk);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "KebabCast (pre-alpha)";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UrlLänk;
        private Label LabelUrl;
        private Label LabelNamn;
        private TextBox AngeNamn;
        private ComboBox VäljKategori;
        private Button LäggTillPodd;
        private Button ÄndraPodd;
        private Button TaBortPodd;
        private DataGridView dataGridView;
        private ListBox Avsnitt;
        private Panel AvsnittInfo;
        private GroupBox KategoriGroupBox;
        private Button LäggTillKategori;
        private Button ÄndraKategori;
        private Button TaBortKategori;
        private Label LabelKategori;
        private TextBox NamnPåKategori;
        private ComboBox FiltreringsComboBox;
        private Button Återställa;
        private DataGridViewTextBoxColumn ColumnNamn;
        private DataGridViewTextBoxColumn ColumnTitel;
        private DataGridViewTextBoxColumn ColumnPublicering;
        private DataGridViewTextBoxColumn ColumnKategori1;
    }
}
