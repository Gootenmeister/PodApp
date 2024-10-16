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
            ColumnNamn = new DataGridViewTextBoxColumn();
            ColumnTitel = new DataGridViewTextBoxColumn();
            ColumnPublicering = new DataGridViewTextBoxColumn();
            ColumnKategori1 = new DataGridViewTextBoxColumn();
            Avsnitt = new ListBox();
            AvsnittInfo = new Panel();
            KategoriGroupBox = new GroupBox();
            LäggTillKategori = new Button();
            ÄndraKategori = new Button();
            TaBortKategori = new Button();
            AktuellKategori = new Label();
            NamnPåKategori = new TextBox();
            FiltreringsComboBox = new ComboBox();
            Återställa = new Button();
            LabelKategoriCBox = new Label();
            LabelTitle = new Label();
            LabelGetFeed = new Label();
            LabelListPodcasts = new Label();
            LabelAvsnitt = new Label();
            LabelPodcastDesc = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // UrlLänk
            // 
            UrlLänk.Location = new Point(32, 110);
            UrlLänk.Name = "UrlLänk";
            UrlLänk.Size = new Size(315, 23);
            UrlLänk.TabIndex = 0;
            UrlLänk.TextChanged += urlLänk;
            // 
            // LabelUrl
            // 
            LabelUrl.AutoSize = true;
            LabelUrl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            LabelUrl.Location = new Point(32, 86);
            LabelUrl.Name = "LabelUrl";
            LabelUrl.Size = new Size(43, 21);
            LabelUrl.TabIndex = 1;
            LabelUrl.Text = "URL:";
            LabelUrl.Click += LabelUrl_Click;
            // 
            // LabelNamn
            // 
            LabelNamn.AutoSize = true;
            LabelNamn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            LabelNamn.Location = new Point(32, 136);
            LabelNamn.Name = "LabelNamn";
            LabelNamn.Size = new Size(57, 21);
            LabelNamn.TabIndex = 2;
            LabelNamn.Text = "Namn:";
            LabelNamn.Click += LabelNamn_Click;
            // 
            // AngeNamn
            // 
            AngeNamn.Location = new Point(32, 160);
            AngeNamn.Name = "AngeNamn";
            AngeNamn.Size = new Size(315, 23);
            AngeNamn.TabIndex = 3;
            // 
            // VäljKategori
            // 
            VäljKategori.FormattingEnabled = true;
            VäljKategori.Location = new Point(471, 201);
            VäljKategori.Name = "VäljKategori";
            VäljKategori.Size = new Size(224, 23);
            VäljKategori.TabIndex = 4;
            VäljKategori.Text = "Välj kategori";
            VäljKategori.SelectedIndexChanged += VäljKategori_SelectedIndexChanged;
            // 
            // LäggTillPodd
            // 
            LäggTillPodd.Location = new Point(32, 201);
            LäggTillPodd.Name = "LäggTillPodd";
            LäggTillPodd.Size = new Size(112, 34);
            LäggTillPodd.TabIndex = 5;
            LäggTillPodd.Text = "lägg Till";
            LäggTillPodd.UseVisualStyleBackColor = true;
            LäggTillPodd.Click += LäggTillPodd_Click;
            // 
            // ÄndraPodd
            // 
            ÄndraPodd.Location = new Point(173, 201);
            ÄndraPodd.Name = "ÄndraPodd";
            ÄndraPodd.Size = new Size(112, 34);
            ÄndraPodd.TabIndex = 6;
            ÄndraPodd.Text = "Ändra";
            ÄndraPodd.UseVisualStyleBackColor = true;
            ÄndraPodd.Click += ÄndraPodd_Click;
            // 
            // TaBortPodd
            // 
            TaBortPodd.Location = new Point(322, 201);
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
            dataGridView.Location = new Point(32, 276);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.Size = new Size(663, 590);
            dataGridView.TabIndex = 8;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
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
            // Avsnitt
            // 
            Avsnitt.FormattingEnabled = true;
            Avsnitt.ItemHeight = 15;
            Avsnitt.Location = new Point(831, 276);
            Avsnitt.Name = "Avsnitt";
            Avsnitt.Size = new Size(322, 364);
            Avsnitt.TabIndex = 9;
            Avsnitt.SelectedIndexChanged += Avsnitt_SelectedIndexChanged;
            // 
            // AvsnittInfo
            // 
            AvsnittInfo.BackColor = Color.White;
            AvsnittInfo.Location = new Point(831, 666);
            AvsnittInfo.Name = "AvsnittInfo";
            AvsnittInfo.Size = new Size(322, 200);
            AvsnittInfo.TabIndex = 10;
            AvsnittInfo.Paint += AvsnittInfo_Paint;
            // 
            // KategoriGroupBox
            // 
            KategoriGroupBox.BackColor = Color.White;
            KategoriGroupBox.Location = new Point(1176, 276);
            KategoriGroupBox.Name = "KategoriGroupBox";
            KategoriGroupBox.Size = new Size(384, 248);
            KategoriGroupBox.TabIndex = 11;
            KategoriGroupBox.TabStop = false;
            KategoriGroupBox.Text = "Kategori";
            KategoriGroupBox.Enter += KategoriGroupBox_Enter;
            // 
            // LäggTillKategori
            // 
            LäggTillKategori.Location = new Point(1176, 239);
            LäggTillKategori.Name = "LäggTillKategori";
            LäggTillKategori.Size = new Size(112, 34);
            LäggTillKategori.TabIndex = 12;
            LäggTillKategori.Text = "Lägg Till";
            LäggTillKategori.UseVisualStyleBackColor = true;
            LäggTillKategori.Click += LäggTillKategori_Click;
            // 
            // ÄndraKategori
            // 
            ÄndraKategori.Location = new Point(1312, 239);
            ÄndraKategori.Name = "ÄndraKategori";
            ÄndraKategori.Size = new Size(112, 34);
            ÄndraKategori.TabIndex = 13;
            ÄndraKategori.Text = "Ändra";
            ÄndraKategori.UseVisualStyleBackColor = true;
            // 
            // TaBortKategori
            // 
            TaBortKategori.Location = new Point(1448, 239);
            TaBortKategori.Name = "TaBortKategori";
            TaBortKategori.Size = new Size(112, 34);
            TaBortKategori.TabIndex = 14;
            TaBortKategori.Text = "Ta bort";
            TaBortKategori.UseVisualStyleBackColor = true;
            // 
            // AktuellKategori
            // 
            AktuellKategori.AutoSize = true;
            AktuellKategori.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Underline);
            AktuellKategori.Location = new Point(1176, 177);
            AktuellKategori.Name = "AktuellKategori";
            AktuellKategori.Size = new Size(132, 21);
            AktuellKategori.TabIndex = 15;
            AktuellKategori.Text = "Aktuell Kategori:";
            AktuellKategori.Click += AktuellKategori_Click;
            // 
            // NamnPåKategori
            // 
            NamnPåKategori.Location = new Point(1176, 201);
            NamnPåKategori.Name = "NamnPåKategori";
            NamnPåKategori.Size = new Size(362, 23);
            NamnPåKategori.TabIndex = 16;
            NamnPåKategori.TextChanged += KategoriNamnTextBox;
            // 
            // FiltreringsComboBox
            // 
            FiltreringsComboBox.FormattingEnabled = true;
            FiltreringsComboBox.Location = new Point(32, 60);
            FiltreringsComboBox.Name = "FiltreringsComboBox";
            FiltreringsComboBox.Size = new Size(315, 23);
            FiltreringsComboBox.TabIndex = 17;
            FiltreringsComboBox.Text = "Filtrera";
            FiltreringsComboBox.SelectedIndexChanged += FiltreringsComboBox_SelectedIndexChanged;
            // 
            // Återställa
            // 
            Återställa.Location = new Point(1448, 530);
            Återställa.Name = "Återställa";
            Återställa.Size = new Size(112, 34);
            Återställa.TabIndex = 18;
            Återställa.Text = "Återställ";
            Återställa.UseVisualStyleBackColor = true;
            Återställa.Click += Återställa_Click;
            // 
            // LabelKategoriCBox
            // 
            LabelKategoriCBox.AutoSize = true;
            LabelKategoriCBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Underline);
            LabelKategoriCBox.Location = new Point(471, 177);
            LabelKategoriCBox.Name = "LabelKategoriCBox";
            LabelKategoriCBox.Size = new Size(73, 21);
            LabelKategoriCBox.TabIndex = 19;
            LabelKategoriCBox.Text = "Kategori";
            LabelKategoriCBox.Click += LabelCategory_Click;
            // 
            // LabelTitle
            // 
            LabelTitle.Dock = DockStyle.Top;
            LabelTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelTitle.Location = new Point(0, 0);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(1636, 34);
            LabelTitle.TabIndex = 20;
            LabelTitle.Text = "KebabCast™";
            LabelTitle.TextAlign = ContentAlignment.TopCenter;
            LabelTitle.Click += LabelTitle_Click;
            // 
            // LabelGetFeed
            // 
            LabelGetFeed.AutoSize = true;
            LabelGetFeed.BackColor = Color.Transparent;
            LabelGetFeed.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelGetFeed.Location = new Point(32, 25);
            LabelGetFeed.Name = "LabelGetFeed";
            LabelGetFeed.Size = new Size(213, 30);
            LabelGetFeed.TabIndex = 22;
            LabelGetFeed.Text = "Hantera dina poddar\r\n";
            LabelGetFeed.Click += LabelGetFeed_Click;
            // 
            // LabelListPodcasts
            // 
            LabelListPodcasts.AutoSize = true;
            LabelListPodcasts.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            LabelListPodcasts.Location = new Point(32, 248);
            LabelListPodcasts.Name = "LabelListPodcasts";
            LabelListPodcasts.Size = new Size(91, 25);
            LabelListPodcasts.TabIndex = 23;
            LabelListPodcasts.Text = "Podcasts:";
            // 
            // LabelAvsnitt
            // 
            LabelAvsnitt.AutoSize = true;
            LabelAvsnitt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Underline);
            LabelAvsnitt.Location = new Point(831, 252);
            LabelAvsnitt.Name = "LabelAvsnitt";
            LabelAvsnitt.Size = new Size(65, 21);
            LabelAvsnitt.TabIndex = 24;
            LabelAvsnitt.Text = "Avsnitt:";
            // 
            // LabelPodcastDesc
            // 
            LabelPodcastDesc.AutoSize = true;
            LabelPodcastDesc.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Underline);
            LabelPodcastDesc.Location = new Point(831, 642);
            LabelPodcastDesc.Name = "LabelPodcastDesc";
            LabelPodcastDesc.Size = new Size(156, 21);
            LabelPodcastDesc.TabIndex = 25;
            LabelPodcastDesc.Text = "Avsnittsbeskrivning:";
            LabelPodcastDesc.Click += LabelPodcastDesc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1636, 882);
            Controls.Add(LabelPodcastDesc);
            Controls.Add(LabelAvsnitt);
            Controls.Add(LabelListPodcasts);
            Controls.Add(LabelGetFeed);
            Controls.Add(LabelTitle);
            Controls.Add(LabelKategoriCBox);
            Controls.Add(Återställa);
            Controls.Add(FiltreringsComboBox);
            Controls.Add(NamnPåKategori);
            Controls.Add(AktuellKategori);
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
        private Label AktuellKategori;
        private TextBox NamnPåKategori;
        private ComboBox FiltreringsComboBox;
        private Button Återställa;
        private DataGridViewTextBoxColumn ColumnNamn;
        private DataGridViewTextBoxColumn ColumnTitel;
        private DataGridViewTextBoxColumn ColumnPublicering;
        private DataGridViewTextBoxColumn ColumnKategori1;
        private Label LabelKategoriCBox;
        private Label LabelTitle;
        private Label LabelGetFeed;
        private Label LabelListPodcasts;
        private Label LabelAvsnitt;
        private Label LabelPodcastDesc;
    }
}
