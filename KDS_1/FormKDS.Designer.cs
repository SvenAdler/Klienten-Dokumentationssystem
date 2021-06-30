
namespace KDS_1
{
    partial class FormKDS
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klientHinzufuegenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klientEntfernenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportierenAlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ansichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ganzerBildschirmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vergrößernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verkleinernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonDatensatzOeffnen = new System.Windows.Forms.Button();
            this.panelUeberschriftKlientenListe = new System.Windows.Forms.Panel();
            this.labelKlientenListe = new System.Windows.Forms.Label();
            this.panelMainWindow = new System.Windows.Forms.Panel();
            this.listBoxKlienten = new System.Windows.Forms.ListBox();
            this.panelEintragKlientDoku = new System.Windows.Forms.Panel();
            this.panelAktuellerKlient = new System.Windows.Forms.Panel();
            this.labelAktuellerKlient = new System.Windows.Forms.Label();
            this.panelBisherigeGespraecheR = new System.Windows.Forms.Panel();
            this.labelListeGespraeche = new System.Windows.Forms.Label();
            this.panelGespraechsEintragR = new System.Windows.Forms.Panel();
            this.labelGespraechsEintrag = new System.Windows.Forms.Label();
            this.panelGespraechTxtBox = new System.Windows.Forms.Panel();
            this.textBoxGespraechEintrag = new System.Windows.Forms.TextBox();
            this.buttonGespraechsDokuAbbrechen = new System.Windows.Forms.Button();
            this.buttonGespraechSpeichern = new System.Windows.Forms.Button();
            this.listBoxListeBisherigerGespraeche = new System.Windows.Forms.ListBox();
            this.panelUeberschrAusgGespr = new System.Windows.Forms.Panel();
            this.labelUberschriftAusgGespr = new System.Windows.Forms.Label();
            this.menuStripMain.SuspendLayout();
            this.panelUeberschriftKlientenListe.SuspendLayout();
            this.panelMainWindow.SuspendLayout();
            this.panelEintragKlientDoku.SuspendLayout();
            this.panelAktuellerKlient.SuspendLayout();
            this.panelBisherigeGespraecheR.SuspendLayout();
            this.panelGespraechsEintragR.SuspendLayout();
            this.panelGespraechTxtBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.ansichtToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(868, 24);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.klientHinzufuegenToolStripMenuItem,
            this.klientEntfernenToolStripMenuItem,
            this.importierenToolStripMenuItem,
            this.exportierenAlsToolStripMenuItem,
            this.sendenToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // klientHinzufuegenToolStripMenuItem
            // 
            this.klientHinzufuegenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.klientHinzufuegenToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.klientHinzufuegenToolStripMenuItem.Name = "klientHinzufuegenToolStripMenuItem";
            this.klientHinzufuegenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.klientHinzufuegenToolStripMenuItem.Text = "Klient hinzufügen";
            this.klientHinzufuegenToolStripMenuItem.Click += new System.EventHandler(this.klientHinzufuegenToolStripMenuItem_Click);
            // 
            // klientEntfernenToolStripMenuItem
            // 
            this.klientEntfernenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.klientEntfernenToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.klientEntfernenToolStripMenuItem.Name = "klientEntfernenToolStripMenuItem";
            this.klientEntfernenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.klientEntfernenToolStripMenuItem.Text = "Klient entfernen";
            this.klientEntfernenToolStripMenuItem.Click += new System.EventHandler(this.klientEntfernenToolStripMenuItem_Click);
            // 
            // importierenToolStripMenuItem
            // 
            this.importierenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.importierenToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.importierenToolStripMenuItem.Name = "importierenToolStripMenuItem";
            this.importierenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importierenToolStripMenuItem.Text = "Importieren";
            // 
            // exportierenAlsToolStripMenuItem
            // 
            this.exportierenAlsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.exportierenAlsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jSONToolStripMenuItem});
            this.exportierenAlsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exportierenAlsToolStripMenuItem.Name = "exportierenAlsToolStripMenuItem";
            this.exportierenAlsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportierenAlsToolStripMenuItem.Text = "Exportieren als...";
            // 
            // jSONToolStripMenuItem
            // 
            this.jSONToolStripMenuItem.Name = "jSONToolStripMenuItem";
            this.jSONToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.jSONToolStripMenuItem.Text = "JSON";
            // 
            // sendenToolStripMenuItem
            // 
            this.sendenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.sendenToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sendenToolStripMenuItem.Name = "sendenToolStripMenuItem";
            this.sendenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sendenToolStripMenuItem.Text = "Senden";
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.beendenToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // ansichtToolStripMenuItem
            // 
            this.ansichtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ganzerBildschirmToolStripMenuItem,
            this.vergrößernToolStripMenuItem,
            this.verkleinernToolStripMenuItem});
            this.ansichtToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ansichtToolStripMenuItem.Name = "ansichtToolStripMenuItem";
            this.ansichtToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.ansichtToolStripMenuItem.Text = "Ansicht";
            // 
            // ganzerBildschirmToolStripMenuItem
            // 
            this.ganzerBildschirmToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.ganzerBildschirmToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ganzerBildschirmToolStripMenuItem.Name = "ganzerBildschirmToolStripMenuItem";
            this.ganzerBildschirmToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ganzerBildschirmToolStripMenuItem.Text = "Ganzer Bildschirm";
            // 
            // vergrößernToolStripMenuItem
            // 
            this.vergrößernToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.vergrößernToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.vergrößernToolStripMenuItem.Name = "vergrößernToolStripMenuItem";
            this.vergrößernToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vergrößernToolStripMenuItem.Text = "Vergrößern ";
            // 
            // verkleinernToolStripMenuItem
            // 
            this.verkleinernToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.verkleinernToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.verkleinernToolStripMenuItem.Name = "verkleinernToolStripMenuItem";
            this.verkleinernToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verkleinernToolStripMenuItem.Text = "Verkleinern";
            // 
            // buttonDatensatzOeffnen
            // 
            this.buttonDatensatzOeffnen.Location = new System.Drawing.Point(12, 427);
            this.buttonDatensatzOeffnen.Name = "buttonDatensatzOeffnen";
            this.buttonDatensatzOeffnen.Size = new System.Drawing.Size(84, 23);
            this.buttonDatensatzOeffnen.TabIndex = 2;
            this.buttonDatensatzOeffnen.Text = "Datei öffnen...";
            this.buttonDatensatzOeffnen.UseVisualStyleBackColor = true;
            // 
            // panelUeberschriftKlientenListe
            // 
            this.panelUeberschriftKlientenListe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(66)))), ((int)(((byte)(88)))));
            this.panelUeberschriftKlientenListe.Controls.Add(this.labelKlientenListe);
            this.panelUeberschriftKlientenListe.Location = new System.Drawing.Point(12, 67);
            this.panelUeberschriftKlientenListe.Name = "panelUeberschriftKlientenListe";
            this.panelUeberschriftKlientenListe.Size = new System.Drawing.Size(832, 33);
            this.panelUeberschriftKlientenListe.TabIndex = 3;
            // 
            // labelKlientenListe
            // 
            this.labelKlientenListe.AutoSize = true;
            this.labelKlientenListe.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.labelKlientenListe.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelKlientenListe.Location = new System.Drawing.Point(3, 2);
            this.labelKlientenListe.Name = "labelKlientenListe";
            this.labelKlientenListe.Size = new System.Drawing.Size(81, 25);
            this.labelKlientenListe.TabIndex = 4;
            this.labelKlientenListe.Text = "Klienten";
            // 
            // panelMainWindow
            // 
            this.panelMainWindow.Controls.Add(this.menuStripMain);
            this.panelMainWindow.Controls.Add(this.panelUeberschriftKlientenListe);
            this.panelMainWindow.Controls.Add(this.buttonDatensatzOeffnen);
            this.panelMainWindow.Controls.Add(this.listBoxKlienten);
            this.panelMainWindow.Location = new System.Drawing.Point(-7, -6);
            this.panelMainWindow.Name = "panelMainWindow";
            this.panelMainWindow.Size = new System.Drawing.Size(868, 567);
            this.panelMainWindow.TabIndex = 4;
            // 
            // listBoxKlienten
            // 
            this.listBoxKlienten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.listBoxKlienten.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.listBoxKlienten.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.listBoxKlienten.FormattingEnabled = true;
            this.listBoxKlienten.ItemHeight = 20;
            this.listBoxKlienten.Location = new System.Drawing.Point(12, 97);
            this.listBoxKlienten.Name = "listBoxKlienten";
            this.listBoxKlienten.Size = new System.Drawing.Size(832, 324);
            this.listBoxKlienten.TabIndex = 0;
            this.listBoxKlienten.DoubleClick += new System.EventHandler(this.listBoxKlienten_DoubleClick);
            // 
            // panelEintragKlientDoku
            // 
            this.panelEintragKlientDoku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.panelEintragKlientDoku.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelEintragKlientDoku.Controls.Add(this.panelAktuellerKlient);
            this.panelEintragKlientDoku.Controls.Add(this.panelBisherigeGespraecheR);
            this.panelEintragKlientDoku.Controls.Add(this.panelGespraechsEintragR);
            this.panelEintragKlientDoku.Controls.Add(this.panelGespraechTxtBox);
            this.panelEintragKlientDoku.Controls.Add(this.buttonGespraechsDokuAbbrechen);
            this.panelEintragKlientDoku.Controls.Add(this.buttonGespraechSpeichern);
            this.panelEintragKlientDoku.Controls.Add(this.listBoxListeBisherigerGespraeche);
            this.panelEintragKlientDoku.Location = new System.Drawing.Point(-4, -6);
            this.panelEintragKlientDoku.Name = "panelEintragKlientDoku";
            this.panelEintragKlientDoku.Size = new System.Drawing.Size(865, 567);
            this.panelEintragKlientDoku.TabIndex = 5;
            // 
            // panelAktuellerKlient
            // 
            this.panelAktuellerKlient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(66)))), ((int)(((byte)(88)))));
            this.panelAktuellerKlient.Controls.Add(this.labelAktuellerKlient);
            this.panelAktuellerKlient.Location = new System.Drawing.Point(17, 20);
            this.panelAktuellerKlient.Name = "panelAktuellerKlient";
            this.panelAktuellerKlient.Size = new System.Drawing.Size(204, 33);
            this.panelAktuellerKlient.TabIndex = 19;
            // 
            // labelAktuellerKlient
            // 
            this.labelAktuellerKlient.AutoSize = true;
            this.labelAktuellerKlient.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.labelAktuellerKlient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelAktuellerKlient.Location = new System.Drawing.Point(3, 2);
            this.labelAktuellerKlient.Name = "labelAktuellerKlient";
            this.labelAktuellerKlient.Size = new System.Drawing.Size(153, 25);
            this.labelAktuellerKlient.TabIndex = 4;
            this.labelAktuellerKlient.Text = "Fräulein Schmidt";
            // 
            // panelBisherigeGespraecheR
            // 
            this.panelBisherigeGespraecheR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(66)))), ((int)(((byte)(88)))));
            this.panelBisherigeGespraecheR.Controls.Add(this.labelListeGespraeche);
            this.panelBisherigeGespraecheR.Location = new System.Drawing.Point(17, 68);
            this.panelBisherigeGespraecheR.Name = "panelBisherigeGespraecheR";
            this.panelBisherigeGespraecheR.Size = new System.Drawing.Size(204, 33);
            this.panelBisherigeGespraecheR.TabIndex = 16;
            // 
            // labelListeGespraeche
            // 
            this.labelListeGespraeche.AutoSize = true;
            this.labelListeGespraeche.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.labelListeGespraeche.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelListeGespraeche.Location = new System.Drawing.Point(3, 2);
            this.labelListeGespraeche.Name = "labelListeGespraeche";
            this.labelListeGespraeche.Size = new System.Drawing.Size(184, 25);
            this.labelListeGespraeche.TabIndex = 4;
            this.labelListeGespraeche.Text = "Bisherige Gespräche";
            // 
            // panelGespraechsEintragR
            // 
            this.panelGespraechsEintragR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(66)))), ((int)(((byte)(88)))));
            this.panelGespraechsEintragR.Controls.Add(this.labelGespraechsEintrag);
            this.panelGespraechsEintragR.Location = new System.Drawing.Point(275, 20);
            this.panelGespraechsEintragR.Name = "panelGespraechsEintragR";
            this.panelGespraechsEintragR.Size = new System.Drawing.Size(571, 33);
            this.panelGespraechsEintragR.TabIndex = 14;
            // 
            // labelGespraechsEintrag
            // 
            this.labelGespraechsEintrag.AutoSize = true;
            this.labelGespraechsEintrag.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.labelGespraechsEintrag.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelGespraechsEintrag.Location = new System.Drawing.Point(3, 2);
            this.labelGespraechsEintrag.Name = "labelGespraechsEintrag";
            this.labelGespraechsEintrag.Size = new System.Drawing.Size(322, 25);
            this.labelGespraechsEintrag.TabIndex = 4;
            this.labelGespraechsEintrag.Text = "Gespräch dokumentieren/bearbeiten";
            // 
            // panelGespraechTxtBox
            // 
            this.panelGespraechTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelGespraechTxtBox.Controls.Add(this.textBoxGespraechEintrag);
            this.panelGespraechTxtBox.Location = new System.Drawing.Point(275, 50);
            this.panelGespraechTxtBox.Name = "panelGespraechTxtBox";
            this.panelGespraechTxtBox.Size = new System.Drawing.Size(571, 446);
            this.panelGespraechTxtBox.TabIndex = 15;
            // 
            // textBoxGespraechEintrag
            // 
            this.textBoxGespraechEintrag.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxGespraechEintrag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxGespraechEintrag.Location = new System.Drawing.Point(6, 7);
            this.textBoxGespraechEintrag.Multiline = true;
            this.textBoxGespraechEintrag.Name = "textBoxGespraechEintrag";
            this.textBoxGespraechEintrag.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxGespraechEintrag.Size = new System.Drawing.Size(555, 428);
            this.textBoxGespraechEintrag.TabIndex = 0;
            // 
            // buttonGespraechsDokuAbbrechen
            // 
            this.buttonGespraechsDokuAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonGespraechsDokuAbbrechen.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.buttonGespraechsDokuAbbrechen.Location = new System.Drawing.Point(676, 519);
            this.buttonGespraechsDokuAbbrechen.Name = "buttonGespraechsDokuAbbrechen";
            this.buttonGespraechsDokuAbbrechen.Size = new System.Drawing.Size(172, 31);
            this.buttonGespraechsDokuAbbrechen.TabIndex = 13;
            this.buttonGespraechsDokuAbbrechen.Text = "Zurück";
            this.buttonGespraechsDokuAbbrechen.UseVisualStyleBackColor = true;
            this.buttonGespraechsDokuAbbrechen.Click += new System.EventHandler(this.buttonGespraechsDokuAbbrechen_Click);
            // 
            // buttonGespraechSpeichern
            // 
            this.buttonGespraechSpeichern.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.buttonGespraechSpeichern.Location = new System.Drawing.Point(474, 519);
            this.buttonGespraechSpeichern.Name = "buttonGespraechSpeichern";
            this.buttonGespraechSpeichern.Size = new System.Drawing.Size(170, 31);
            this.buttonGespraechSpeichern.TabIndex = 12;
            this.buttonGespraechSpeichern.Text = "Speichern";
            this.buttonGespraechSpeichern.UseVisualStyleBackColor = true;
            this.buttonGespraechSpeichern.Click += new System.EventHandler(this.buttonGespraechSpeichern_Click);
            // 
            // listBoxListeBisherigerGespraeche
            // 
            this.listBoxListeBisherigerGespraeche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.listBoxListeBisherigerGespraeche.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.listBoxListeBisherigerGespraeche.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.listBoxListeBisherigerGespraeche.FormattingEnabled = true;
            this.listBoxListeBisherigerGespraeche.ItemHeight = 20;
            this.listBoxListeBisherigerGespraeche.Location = new System.Drawing.Point(17, 97);
            this.listBoxListeBisherigerGespraeche.Name = "listBoxListeBisherigerGespraeche";
            this.listBoxListeBisherigerGespraeche.Size = new System.Drawing.Size(204, 424);
            this.listBoxListeBisherigerGespraeche.TabIndex = 18;
            this.listBoxListeBisherigerGespraeche.SelectedIndexChanged += new System.EventHandler(this.listBoxListeBisherigerGespraeche_SelectedIndexChanged);
            // 
            // panelUeberschrAusgGespr
            // 
            this.panelUeberschrAusgGespr.Location = new System.Drawing.Point(0, 0);
            this.panelUeberschrAusgGespr.Name = "panelUeberschrAusgGespr";
            this.panelUeberschrAusgGespr.Size = new System.Drawing.Size(200, 100);
            this.panelUeberschrAusgGespr.TabIndex = 0;
            // 
            // labelUberschriftAusgGespr
            // 
            this.labelUberschriftAusgGespr.Location = new System.Drawing.Point(0, 0);
            this.labelUberschriftAusgGespr.Name = "labelUberschriftAusgGespr";
            this.labelUberschriftAusgGespr.Size = new System.Drawing.Size(100, 23);
            this.labelUberschriftAusgGespr.TabIndex = 0;
            // 
            // FormKDS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(856, 556);
            this.Controls.Add(this.panelMainWindow);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormKDS";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Shown += new System.EventHandler(this.FormKDS_Shown);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.panelUeberschriftKlientenListe.ResumeLayout(false);
            this.panelUeberschriftKlientenListe.PerformLayout();
            this.panelMainWindow.ResumeLayout(false);
            this.panelMainWindow.PerformLayout();
            this.panelEintragKlientDoku.ResumeLayout(false);
            this.panelAktuellerKlient.ResumeLayout(false);
            this.panelAktuellerKlient.PerformLayout();
            this.panelBisherigeGespraecheR.ResumeLayout(false);
            this.panelBisherigeGespraecheR.PerformLayout();
            this.panelGespraechsEintragR.ResumeLayout(false);
            this.panelGespraechsEintragR.PerformLayout();
            this.panelGespraechTxtBox.ResumeLayout(false);
            this.panelGespraechTxtBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klientHinzufuegenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klientEntfernenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportierenAlsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ansichtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ganzerBildschirmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vergrößernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verkleinernToolStripMenuItem;
        private System.Windows.Forms.Button buttonDatensatzOeffnen;
        private System.Windows.Forms.Panel panelUeberschriftKlientenListe;
        private System.Windows.Forms.Label labelKlientenListe;
        private System.Windows.Forms.Panel panelMainWindow;
        private System.Windows.Forms.Panel panelEintragKlientDoku;
        private System.Windows.Forms.ListBox listBoxKlienten;
        private System.Windows.Forms.Panel panelBisherigeGespraecheR;
        private System.Windows.Forms.Label labelListeGespraeche;
        private System.Windows.Forms.Button buttonGespraechsDokuAbbrechen;
        private System.Windows.Forms.Button buttonGespraechSpeichern;
        private System.Windows.Forms.ListBox listBoxListeBisherigerGespraeche;
        private System.Windows.Forms.Panel panelAktuellerKlient;
        private System.Windows.Forms.Label labelAktuellerKlient;
        private System.Windows.Forms.Panel panelGespraechsEintragR;
        private System.Windows.Forms.Label labelGespraechsEintrag;
        private System.Windows.Forms.Panel panelUeberschrAusgGespr;
        private System.Windows.Forms.Label labelUberschriftAusgGespr;
        private System.Windows.Forms.Panel panelGespraechTxtBox;
        private System.Windows.Forms.TextBox textBoxGespraechEintrag;
    }
}

