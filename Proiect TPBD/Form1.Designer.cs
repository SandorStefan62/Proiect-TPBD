namespace WindowsFormsApplication2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nRCRTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRENUMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fUNCTIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sALARBAZADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pREMIIBRUTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOTALBRUTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bRUTIMPOZITABILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMPOZITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cASSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rETINERIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vIRATCARDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aNGAJATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new WindowsFormsApplication2.DataSet1();
            this.aNGAJATTableAdapter = new WindowsFormsApplication2.DataSet1TableAdapters.ANGAJATTableAdapter();
            this.buttonAfisare = new System.Windows.Forms.Button();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.textBoxPrenume = new System.Windows.Forms.TextBox();
            this.textBoxFunctie = new System.Windows.Forms.TextBox();
            this.textBoxSalarBaza = new System.Windows.Forms.TextBox();
            this.textBoxSpor = new System.Windows.Forms.TextBox();
            this.textBoxPremiiBrute = new System.Windows.Forms.TextBox();
            this.textBoxRetineri = new System.Windows.Forms.TextBox();
            this.labelNume = new System.Windows.Forms.Label();
            this.labelPrenume = new System.Windows.Forms.Label();
            this.labelFunctie = new System.Windows.Forms.Label();
            this.labelSalarBaza = new System.Windows.Forms.Label();
            this.labelSpor = new System.Windows.Forms.Label();
            this.labelPremiiBrute = new System.Windows.Forms.Label();
            this.labelRetineri = new System.Windows.Forms.Label();
            this.buttonInserare = new System.Windows.Forms.Button();
            this.buttonCautare = new System.Windows.Forms.Button();
            this.buttonCautareFunctie = new System.Windows.Forms.Button();
            this.buttonSterge = new System.Windows.Forms.Button();
            this.vARIABILEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new WindowsFormsApplication2.DataSet2();
            this.vARIABILETableAdapter = new WindowsFormsApplication2.DataSet2TableAdapters.VARIABILETableAdapter();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.buttonGenerareStatPlata = new System.Windows.Forms.Button();
            this.buttonFluturasi = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAngajati = new System.Windows.Forms.TabPage();
            this.tabPageRaport = new System.Windows.Forms.TabPage();
            this.tabPageVariabile = new System.Windows.Forms.TabPage();
            this.tabPageAjutor = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cASDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cASSDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMPOZITDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNGAJATBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vARIABILEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageAngajati.SuspendLayout();
            this.tabPageRaport.SuspendLayout();
            this.tabPageVariabile.SuspendLayout();
            this.tabPageAjutor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nRCRTDataGridViewTextBoxColumn,
            this.nUMEDataGridViewTextBoxColumn,
            this.pRENUMEDataGridViewTextBoxColumn,
            this.fUNCTIEDataGridViewTextBoxColumn,
            this.sALARBAZADataGridViewTextBoxColumn,
            this.sPORDataGridViewTextBoxColumn,
            this.pREMIIBRUTEDataGridViewTextBoxColumn,
            this.tOTALBRUTDataGridViewTextBoxColumn,
            this.bRUTIMPOZITABILDataGridViewTextBoxColumn,
            this.iMPOZITDataGridViewTextBoxColumn,
            this.cASDataGridViewTextBoxColumn,
            this.cASSDataGridViewTextBoxColumn,
            this.rETINERIDataGridViewTextBoxColumn,
            this.vIRATCARDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aNGAJATBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1139, 301);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            // 
            // nRCRTDataGridViewTextBoxColumn
            // 
            this.nRCRTDataGridViewTextBoxColumn.DataPropertyName = "NR_CRT";
            this.nRCRTDataGridViewTextBoxColumn.HeaderText = "NR_CRT";
            this.nRCRTDataGridViewTextBoxColumn.Name = "nRCRTDataGridViewTextBoxColumn";
            // 
            // nUMEDataGridViewTextBoxColumn
            // 
            this.nUMEDataGridViewTextBoxColumn.DataPropertyName = "NUME";
            this.nUMEDataGridViewTextBoxColumn.HeaderText = "NUME";
            this.nUMEDataGridViewTextBoxColumn.Name = "nUMEDataGridViewTextBoxColumn";
            // 
            // pRENUMEDataGridViewTextBoxColumn
            // 
            this.pRENUMEDataGridViewTextBoxColumn.DataPropertyName = "PRENUME";
            this.pRENUMEDataGridViewTextBoxColumn.HeaderText = "PRENUME";
            this.pRENUMEDataGridViewTextBoxColumn.Name = "pRENUMEDataGridViewTextBoxColumn";
            // 
            // fUNCTIEDataGridViewTextBoxColumn
            // 
            this.fUNCTIEDataGridViewTextBoxColumn.DataPropertyName = "FUNCTIE";
            this.fUNCTIEDataGridViewTextBoxColumn.HeaderText = "FUNCTIE";
            this.fUNCTIEDataGridViewTextBoxColumn.Name = "fUNCTIEDataGridViewTextBoxColumn";
            // 
            // sALARBAZADataGridViewTextBoxColumn
            // 
            this.sALARBAZADataGridViewTextBoxColumn.DataPropertyName = "SALAR_BAZA";
            this.sALARBAZADataGridViewTextBoxColumn.HeaderText = "SALAR_BAZA";
            this.sALARBAZADataGridViewTextBoxColumn.Name = "sALARBAZADataGridViewTextBoxColumn";
            // 
            // sPORDataGridViewTextBoxColumn
            // 
            this.sPORDataGridViewTextBoxColumn.DataPropertyName = "SPOR";
            this.sPORDataGridViewTextBoxColumn.HeaderText = "SPOR";
            this.sPORDataGridViewTextBoxColumn.Name = "sPORDataGridViewTextBoxColumn";
            // 
            // pREMIIBRUTEDataGridViewTextBoxColumn
            // 
            this.pREMIIBRUTEDataGridViewTextBoxColumn.DataPropertyName = "PREMII_BRUTE";
            this.pREMIIBRUTEDataGridViewTextBoxColumn.HeaderText = "PREMII_BRUTE";
            this.pREMIIBRUTEDataGridViewTextBoxColumn.Name = "pREMIIBRUTEDataGridViewTextBoxColumn";
            // 
            // tOTALBRUTDataGridViewTextBoxColumn
            // 
            this.tOTALBRUTDataGridViewTextBoxColumn.DataPropertyName = "TOTAL_BRUT";
            this.tOTALBRUTDataGridViewTextBoxColumn.HeaderText = "TOTAL_BRUT";
            this.tOTALBRUTDataGridViewTextBoxColumn.Name = "tOTALBRUTDataGridViewTextBoxColumn";
            // 
            // bRUTIMPOZITABILDataGridViewTextBoxColumn
            // 
            this.bRUTIMPOZITABILDataGridViewTextBoxColumn.DataPropertyName = "BRUT_IMPOZITABIL";
            this.bRUTIMPOZITABILDataGridViewTextBoxColumn.HeaderText = "BRUT_IMPOZITABIL";
            this.bRUTIMPOZITABILDataGridViewTextBoxColumn.Name = "bRUTIMPOZITABILDataGridViewTextBoxColumn";
            // 
            // iMPOZITDataGridViewTextBoxColumn
            // 
            this.iMPOZITDataGridViewTextBoxColumn.DataPropertyName = "IMPOZIT";
            this.iMPOZITDataGridViewTextBoxColumn.HeaderText = "IMPOZIT";
            this.iMPOZITDataGridViewTextBoxColumn.Name = "iMPOZITDataGridViewTextBoxColumn";
            // 
            // cASDataGridViewTextBoxColumn
            // 
            this.cASDataGridViewTextBoxColumn.DataPropertyName = "CAS";
            this.cASDataGridViewTextBoxColumn.HeaderText = "CAS";
            this.cASDataGridViewTextBoxColumn.Name = "cASDataGridViewTextBoxColumn";
            // 
            // cASSDataGridViewTextBoxColumn
            // 
            this.cASSDataGridViewTextBoxColumn.DataPropertyName = "CASS";
            this.cASSDataGridViewTextBoxColumn.HeaderText = "CASS";
            this.cASSDataGridViewTextBoxColumn.Name = "cASSDataGridViewTextBoxColumn";
            // 
            // rETINERIDataGridViewTextBoxColumn
            // 
            this.rETINERIDataGridViewTextBoxColumn.DataPropertyName = "RETINERI";
            this.rETINERIDataGridViewTextBoxColumn.HeaderText = "RETINERI";
            this.rETINERIDataGridViewTextBoxColumn.Name = "rETINERIDataGridViewTextBoxColumn";
            // 
            // vIRATCARDDataGridViewTextBoxColumn
            // 
            this.vIRATCARDDataGridViewTextBoxColumn.DataPropertyName = "VIRAT_CARD";
            this.vIRATCARDDataGridViewTextBoxColumn.HeaderText = "VIRAT_CARD";
            this.vIRATCARDDataGridViewTextBoxColumn.Name = "vIRATCARDDataGridViewTextBoxColumn";
            // 
            // aNGAJATBindingSource
            // 
            this.aNGAJATBindingSource.DataMember = "ANGAJAT";
            this.aNGAJATBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aNGAJATTableAdapter
            // 
            this.aNGAJATTableAdapter.ClearBeforeFill = true;
            // 
            // buttonAfisare
            // 
            this.buttonAfisare.Location = new System.Drawing.Point(178, 418);
            this.buttonAfisare.Name = "buttonAfisare";
            this.buttonAfisare.Size = new System.Drawing.Size(147, 23);
            this.buttonAfisare.TabIndex = 1;
            this.buttonAfisare.Text = "Afisare Toti Angajatii";
            this.buttonAfisare.UseVisualStyleBackColor = true;
            this.buttonAfisare.Click += new System.EventHandler(this.buttonAfisare_Click);
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(72, 316);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(100, 20);
            this.textBoxNume.TabIndex = 2;
            // 
            // textBoxPrenume
            // 
            this.textBoxPrenume.Location = new System.Drawing.Point(71, 342);
            this.textBoxPrenume.Name = "textBoxPrenume";
            this.textBoxPrenume.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrenume.TabIndex = 3;
            // 
            // textBoxFunctie
            // 
            this.textBoxFunctie.Location = new System.Drawing.Point(71, 368);
            this.textBoxFunctie.Name = "textBoxFunctie";
            this.textBoxFunctie.Size = new System.Drawing.Size(100, 20);
            this.textBoxFunctie.TabIndex = 4;
            // 
            // textBoxSalarBaza
            // 
            this.textBoxSalarBaza.Location = new System.Drawing.Point(71, 394);
            this.textBoxSalarBaza.Name = "textBoxSalarBaza";
            this.textBoxSalarBaza.Size = new System.Drawing.Size(100, 20);
            this.textBoxSalarBaza.TabIndex = 5;
            // 
            // textBoxSpor
            // 
            this.textBoxSpor.Location = new System.Drawing.Point(71, 420);
            this.textBoxSpor.Name = "textBoxSpor";
            this.textBoxSpor.Size = new System.Drawing.Size(100, 20);
            this.textBoxSpor.TabIndex = 6;
            this.textBoxSpor.Text = "0";
            // 
            // textBoxPremiiBrute
            // 
            this.textBoxPremiiBrute.Location = new System.Drawing.Point(71, 446);
            this.textBoxPremiiBrute.Name = "textBoxPremiiBrute";
            this.textBoxPremiiBrute.Size = new System.Drawing.Size(100, 20);
            this.textBoxPremiiBrute.TabIndex = 7;
            this.textBoxPremiiBrute.Text = "0";
            // 
            // textBoxRetineri
            // 
            this.textBoxRetineri.Location = new System.Drawing.Point(71, 472);
            this.textBoxRetineri.Name = "textBoxRetineri";
            this.textBoxRetineri.Size = new System.Drawing.Size(100, 20);
            this.textBoxRetineri.TabIndex = 8;
            this.textBoxRetineri.Text = "0";
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Location = new System.Drawing.Point(6, 319);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(35, 13);
            this.labelNume.TabIndex = 9;
            this.labelNume.Text = "Nume";
            // 
            // labelPrenume
            // 
            this.labelPrenume.AutoSize = true;
            this.labelPrenume.Location = new System.Drawing.Point(6, 345);
            this.labelPrenume.Name = "labelPrenume";
            this.labelPrenume.Size = new System.Drawing.Size(49, 13);
            this.labelPrenume.TabIndex = 10;
            this.labelPrenume.Text = "Prenume";
            // 
            // labelFunctie
            // 
            this.labelFunctie.AutoSize = true;
            this.labelFunctie.Location = new System.Drawing.Point(6, 371);
            this.labelFunctie.Name = "labelFunctie";
            this.labelFunctie.Size = new System.Drawing.Size(42, 13);
            this.labelFunctie.TabIndex = 11;
            this.labelFunctie.Text = "Functie";
            // 
            // labelSalarBaza
            // 
            this.labelSalarBaza.AutoSize = true;
            this.labelSalarBaza.Location = new System.Drawing.Point(6, 397);
            this.labelSalarBaza.Name = "labelSalarBaza";
            this.labelSalarBaza.Size = new System.Drawing.Size(58, 13);
            this.labelSalarBaza.TabIndex = 12;
            this.labelSalarBaza.Text = "Salar Baza";
            // 
            // labelSpor
            // 
            this.labelSpor.AutoSize = true;
            this.labelSpor.Location = new System.Drawing.Point(6, 423);
            this.labelSpor.Name = "labelSpor";
            this.labelSpor.Size = new System.Drawing.Size(29, 13);
            this.labelSpor.TabIndex = 13;
            this.labelSpor.Text = "Spor";
            // 
            // labelPremiiBrute
            // 
            this.labelPremiiBrute.AutoSize = true;
            this.labelPremiiBrute.Location = new System.Drawing.Point(6, 449);
            this.labelPremiiBrute.Name = "labelPremiiBrute";
            this.labelPremiiBrute.Size = new System.Drawing.Size(63, 13);
            this.labelPremiiBrute.TabIndex = 14;
            this.labelPremiiBrute.Text = "Premii Brute";
            // 
            // labelRetineri
            // 
            this.labelRetineri.AutoSize = true;
            this.labelRetineri.Location = new System.Drawing.Point(6, 475);
            this.labelRetineri.Name = "labelRetineri";
            this.labelRetineri.Size = new System.Drawing.Size(43, 13);
            this.labelRetineri.TabIndex = 15;
            this.labelRetineri.Text = "Retineri";
            // 
            // buttonInserare
            // 
            this.buttonInserare.Location = new System.Drawing.Point(178, 314);
            this.buttonInserare.Name = "buttonInserare";
            this.buttonInserare.Size = new System.Drawing.Size(147, 23);
            this.buttonInserare.TabIndex = 9;
            this.buttonInserare.Text = "Inserare Angajat";
            this.buttonInserare.UseVisualStyleBackColor = true;
            this.buttonInserare.Click += new System.EventHandler(this.buttonInserare_Click);
            // 
            // buttonCautare
            // 
            this.buttonCautare.Location = new System.Drawing.Point(178, 340);
            this.buttonCautare.Name = "buttonCautare";
            this.buttonCautare.Size = new System.Drawing.Size(147, 23);
            this.buttonCautare.TabIndex = 10;
            this.buttonCautare.Text = "Cautare Dupa Nume";
            this.buttonCautare.UseVisualStyleBackColor = true;
            this.buttonCautare.Click += new System.EventHandler(this.buttonCautare_Click);
            // 
            // buttonCautareFunctie
            // 
            this.buttonCautareFunctie.Location = new System.Drawing.Point(178, 366);
            this.buttonCautareFunctie.Name = "buttonCautareFunctie";
            this.buttonCautareFunctie.Size = new System.Drawing.Size(147, 23);
            this.buttonCautareFunctie.TabIndex = 11;
            this.buttonCautareFunctie.Text = "Cautare Dupa Functie";
            this.buttonCautareFunctie.UseVisualStyleBackColor = true;
            this.buttonCautareFunctie.Click += new System.EventHandler(this.buttonCautareFunctie_Click);
            // 
            // buttonSterge
            // 
            this.buttonSterge.Location = new System.Drawing.Point(178, 392);
            this.buttonSterge.Name = "buttonSterge";
            this.buttonSterge.Size = new System.Drawing.Size(147, 23);
            this.buttonSterge.TabIndex = 12;
            this.buttonSterge.Text = "Sterge Angajati Selectati";
            this.buttonSterge.UseVisualStyleBackColor = true;
            this.buttonSterge.Click += new System.EventHandler(this.buttonSterge_Click);
            // 
            // vARIABILEBindingSource
            // 
            this.vARIABILEBindingSource.DataMember = "VARIABILE";
            this.vARIABILEBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vARIABILETableAdapter
            // 
            this.vARIABILETableAdapter.ClearBeforeFill = true;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(6, 6);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1139, 486);
            this.crystalReportViewer1.TabIndex = 17;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // buttonGenerareStatPlata
            // 
            this.buttonGenerareStatPlata.Location = new System.Drawing.Point(177, 444);
            this.buttonGenerareStatPlata.Name = "buttonGenerareStatPlata";
            this.buttonGenerareStatPlata.Size = new System.Drawing.Size(148, 23);
            this.buttonGenerareStatPlata.TabIndex = 18;
            this.buttonGenerareStatPlata.Text = "Generare Stat Plata";
            this.buttonGenerareStatPlata.UseVisualStyleBackColor = true;
            this.buttonGenerareStatPlata.Click += new System.EventHandler(this.buttonGenerareStatPlata_Click);
            // 
            // buttonFluturasi
            // 
            this.buttonFluturasi.Location = new System.Drawing.Point(177, 470);
            this.buttonFluturasi.Name = "buttonFluturasi";
            this.buttonFluturasi.Size = new System.Drawing.Size(147, 23);
            this.buttonFluturasi.TabIndex = 19;
            this.buttonFluturasi.Text = "Generare Fluturasi";
            this.buttonFluturasi.UseVisualStyleBackColor = true;
            this.buttonFluturasi.Click += new System.EventHandler(this.buttonFluturasi_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAngajati);
            this.tabControl1.Controls.Add(this.tabPageRaport);
            this.tabControl1.Controls.Add(this.tabPageVariabile);
            this.tabControl1.Controls.Add(this.tabPageAjutor);
            this.tabControl1.Location = new System.Drawing.Point(13, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1159, 524);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPageAngajati
            // 
            this.tabPageAngajati.Controls.Add(this.dataGridView1);
            this.tabPageAngajati.Controls.Add(this.buttonFluturasi);
            this.tabPageAngajati.Controls.Add(this.labelNume);
            this.tabPageAngajati.Controls.Add(this.buttonGenerareStatPlata);
            this.tabPageAngajati.Controls.Add(this.buttonAfisare);
            this.tabPageAngajati.Controls.Add(this.textBoxNume);
            this.tabPageAngajati.Controls.Add(this.textBoxPrenume);
            this.tabPageAngajati.Controls.Add(this.buttonSterge);
            this.tabPageAngajati.Controls.Add(this.textBoxSalarBaza);
            this.tabPageAngajati.Controls.Add(this.buttonCautareFunctie);
            this.tabPageAngajati.Controls.Add(this.textBoxFunctie);
            this.tabPageAngajati.Controls.Add(this.buttonCautare);
            this.tabPageAngajati.Controls.Add(this.textBoxRetineri);
            this.tabPageAngajati.Controls.Add(this.buttonInserare);
            this.tabPageAngajati.Controls.Add(this.textBoxPremiiBrute);
            this.tabPageAngajati.Controls.Add(this.labelRetineri);
            this.tabPageAngajati.Controls.Add(this.textBoxSpor);
            this.tabPageAngajati.Controls.Add(this.labelPremiiBrute);
            this.tabPageAngajati.Controls.Add(this.labelPrenume);
            this.tabPageAngajati.Controls.Add(this.labelSpor);
            this.tabPageAngajati.Controls.Add(this.labelFunctie);
            this.tabPageAngajati.Controls.Add(this.labelSalarBaza);
            this.tabPageAngajati.Location = new System.Drawing.Point(4, 22);
            this.tabPageAngajati.Name = "tabPageAngajati";
            this.tabPageAngajati.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAngajati.Size = new System.Drawing.Size(1151, 498);
            this.tabPageAngajati.TabIndex = 0;
            this.tabPageAngajati.Text = "Angajati";
            this.tabPageAngajati.UseVisualStyleBackColor = true;
            // 
            // tabPageRaport
            // 
            this.tabPageRaport.Controls.Add(this.crystalReportViewer1);
            this.tabPageRaport.Location = new System.Drawing.Point(4, 22);
            this.tabPageRaport.Name = "tabPageRaport";
            this.tabPageRaport.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRaport.Size = new System.Drawing.Size(1151, 498);
            this.tabPageRaport.TabIndex = 1;
            this.tabPageRaport.Text = "Raport";
            this.tabPageRaport.UseVisualStyleBackColor = true;
            // 
            // tabPageVariabile
            // 
            this.tabPageVariabile.Controls.Add(this.dataGridView2);
            this.tabPageVariabile.Location = new System.Drawing.Point(4, 22);
            this.tabPageVariabile.Name = "tabPageVariabile";
            this.tabPageVariabile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVariabile.Size = new System.Drawing.Size(1151, 498);
            this.tabPageVariabile.TabIndex = 2;
            this.tabPageVariabile.Text = "Variabile";
            this.tabPageVariabile.UseVisualStyleBackColor = true;
            // 
            // tabPageAjutor
            // 
            this.tabPageAjutor.Controls.Add(this.richTextBox1);
            this.tabPageAjutor.Location = new System.Drawing.Point(4, 22);
            this.tabPageAjutor.Name = "tabPageAjutor";
            this.tabPageAjutor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAjutor.Size = new System.Drawing.Size(1151, 498);
            this.tabPageAjutor.TabIndex = 3;
            this.tabPageAjutor.Text = "Ajutor";
            this.tabPageAjutor.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 7);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1138, 485);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.cASDataGridViewTextBoxColumn1,
            this.cASSDataGridViewTextBoxColumn1,
            this.iMPOZITDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.vARIABILEBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(382, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(377, 179);
            this.dataGridView2.TabIndex = 21;
            this.dataGridView2.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView2_CellBeginEdit);
            this.dataGridView2.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEndEdit);
            this.dataGridView2.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView2_CellValidating);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 34;
            // 
            // cASDataGridViewTextBoxColumn1
            // 
            this.cASDataGridViewTextBoxColumn1.DataPropertyName = "CAS";
            this.cASDataGridViewTextBoxColumn1.HeaderText = "CAS";
            this.cASDataGridViewTextBoxColumn1.Name = "cASDataGridViewTextBoxColumn1";
            // 
            // cASSDataGridViewTextBoxColumn1
            // 
            this.cASSDataGridViewTextBoxColumn1.DataPropertyName = "CASS";
            this.cASSDataGridViewTextBoxColumn1.HeaderText = "CASS";
            this.cASSDataGridViewTextBoxColumn1.Name = "cASSDataGridViewTextBoxColumn1";
            // 
            // iMPOZITDataGridViewTextBoxColumn1
            // 
            this.iMPOZITDataGridViewTextBoxColumn1.DataPropertyName = "IMPOZIT";
            this.iMPOZITDataGridViewTextBoxColumn1.HeaderText = "IMPOZIT";
            this.iMPOZITDataGridViewTextBoxColumn1.Name = "iMPOZITDataGridViewTextBoxColumn1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 551);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNGAJATBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vARIABILEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageAngajati.ResumeLayout(false);
            this.tabPageAngajati.PerformLayout();
            this.tabPageRaport.ResumeLayout(false);
            this.tabPageVariabile.ResumeLayout(false);
            this.tabPageAjutor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource aNGAJATBindingSource;
        private DataSet1TableAdapters.ANGAJATTableAdapter aNGAJATTableAdapter;
        private System.Windows.Forms.Button buttonAfisare;
        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.TextBox textBoxPrenume;
        private System.Windows.Forms.TextBox textBoxFunctie;
        private System.Windows.Forms.TextBox textBoxSalarBaza;
        private System.Windows.Forms.TextBox textBoxSpor;
        private System.Windows.Forms.TextBox textBoxPremiiBrute;
        private System.Windows.Forms.TextBox textBoxRetineri;
        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.Label labelPrenume;
        private System.Windows.Forms.Label labelFunctie;
        private System.Windows.Forms.Label labelSalarBaza;
        private System.Windows.Forms.Label labelSpor;
        private System.Windows.Forms.Label labelPremiiBrute;
        private System.Windows.Forms.Label labelRetineri;
        private System.Windows.Forms.Button buttonInserare;
        private System.Windows.Forms.Button buttonCautare;
        private System.Windows.Forms.Button buttonCautareFunctie;
        private System.Windows.Forms.Button buttonSterge;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource vARIABILEBindingSource;
        private DataSet2TableAdapters.VARIABILETableAdapter vARIABILETableAdapter;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button buttonGenerareStatPlata;
        private System.Windows.Forms.Button buttonFluturasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn nRCRTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRENUMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fUNCTIEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sALARBAZADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pREMIIBRUTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOTALBRUTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bRUTIMPOZITABILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMPOZITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cASSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rETINERIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vIRATCARDDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAngajati;
        private System.Windows.Forms.TabPage tabPageRaport;
        private System.Windows.Forms.TabPage tabPageVariabile;
        private System.Windows.Forms.TabPage tabPageAjutor;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cASDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cASSDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMPOZITDataGridViewTextBoxColumn1;
    }
}

