namespace PokeCalk
{
    partial class FormMain
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
            this.btnTest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvTypes = new System.Windows.Forms.DataGridView();
            this.clmType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPkmn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPkmn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPkmn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPkmn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPkmn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPkmn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Team = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabView = new System.Windows.Forms.TabControl();
            this.tabType = new System.Windows.Forms.TabPage();
            this.tabStats = new System.Windows.Forms.TabPage();
            this.dgvStats = new System.Windows.Forms.DataGridView();
            this.Stats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pkmn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pkmn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pkmn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pkmn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pkmn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pkmn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatsTeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.importPokeListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sendFeedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTeam = new System.Windows.Forms.SaveFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbP5 = new System.Windows.Forms.ComboBox();
            this.cmbP4 = new System.Windows.Forms.ComboBox();
            this.cmbP2 = new System.Windows.Forms.ComboBox();
            this.cmbP3 = new System.Windows.Forms.ComboBox();
            this.cmbP1 = new System.Windows.Forms.ComboBox();
            this.cmbP0 = new System.Windows.Forms.ComboBox();
            this.picBoxPkmn1 = new System.Windows.Forms.PictureBox();
            this.picBoxPkmn2 = new System.Windows.Forms.PictureBox();
            this.picBoxPkmn3 = new System.Windows.Forms.PictureBox();
            this.picBoxPkmn4 = new System.Windows.Forms.PictureBox();
            this.picBoxPkmn5 = new System.Windows.Forms.PictureBox();
            this.picBoxPkmn6 = new System.Windows.Forms.PictureBox();
            this.openTeam = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypes)).BeginInit();
            this.tabView.SuspendLayout();
            this.tabType.SuspendLayout();
            this.tabStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStats)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPkmn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPkmn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPkmn3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPkmn4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPkmn5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPkmn6)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Location = new System.Drawing.Point(12, 188);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(414, 52);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "Calculate";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnCalk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pokemon 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pokemon 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(222, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Pokemon 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(222, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Pokemon 4";
            // 
            // dgvTypes
            // 
            this.dgvTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTypes.ColumnHeadersHeight = 25;
            this.dgvTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmType,
            this.clmPkmn1,
            this.clmPkmn2,
            this.clmPkmn3,
            this.clmPkmn4,
            this.clmPkmn5,
            this.clmPkmn6,
            this.Team});
            this.dgvTypes.Location = new System.Drawing.Point(6, 6);
            this.dgvTypes.Name = "dgvTypes";
            this.dgvTypes.Size = new System.Drawing.Size(515, 268);
            this.dgvTypes.TabIndex = 21;
            // 
            // clmType
            // 
            this.clmType.HeaderText = "Type";
            this.clmType.Name = "clmType";
            // 
            // clmPkmn1
            // 
            this.clmPkmn1.HeaderText = "Pkmn 1";
            this.clmPkmn1.Name = "clmPkmn1";
            this.clmPkmn1.Width = 50;
            // 
            // clmPkmn2
            // 
            this.clmPkmn2.HeaderText = "Pkmn 2";
            this.clmPkmn2.Name = "clmPkmn2";
            this.clmPkmn2.Width = 50;
            // 
            // clmPkmn3
            // 
            this.clmPkmn3.HeaderText = "Pkmn 3";
            this.clmPkmn3.Name = "clmPkmn3";
            this.clmPkmn3.Width = 50;
            // 
            // clmPkmn4
            // 
            this.clmPkmn4.HeaderText = "Pkmn 4";
            this.clmPkmn4.Name = "clmPkmn4";
            this.clmPkmn4.Width = 50;
            // 
            // clmPkmn5
            // 
            this.clmPkmn5.HeaderText = "Pkmn 5";
            this.clmPkmn5.Name = "clmPkmn5";
            this.clmPkmn5.Width = 50;
            // 
            // clmPkmn6
            // 
            this.clmPkmn6.HeaderText = "Pkmn 6";
            this.clmPkmn6.Name = "clmPkmn6";
            this.clmPkmn6.Width = 50;
            // 
            // Team
            // 
            this.Team.HeaderText = "Team";
            this.Team.Name = "Team";
            this.Team.Width = 50;
            // 
            // tabView
            // 
            this.tabView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabView.Controls.Add(this.tabType);
            this.tabView.Controls.Add(this.tabStats);
            this.tabView.Location = new System.Drawing.Point(442, 40);
            this.tabView.Name = "tabView";
            this.tabView.SelectedIndex = 0;
            this.tabView.Size = new System.Drawing.Size(535, 306);
            this.tabView.TabIndex = 22;
            // 
            // tabType
            // 
            this.tabType.Controls.Add(this.dgvTypes);
            this.tabType.Location = new System.Drawing.Point(4, 22);
            this.tabType.Name = "tabType";
            this.tabType.Padding = new System.Windows.Forms.Padding(3);
            this.tabType.Size = new System.Drawing.Size(527, 280);
            this.tabType.TabIndex = 0;
            this.tabType.Text = "Types";
            this.tabType.UseVisualStyleBackColor = true;
            // 
            // tabStats
            // 
            this.tabStats.Controls.Add(this.dgvStats);
            this.tabStats.Location = new System.Drawing.Point(4, 22);
            this.tabStats.Name = "tabStats";
            this.tabStats.Padding = new System.Windows.Forms.Padding(3);
            this.tabStats.Size = new System.Drawing.Size(527, 280);
            this.tabStats.TabIndex = 2;
            this.tabStats.Text = "Stats";
            this.tabStats.UseVisualStyleBackColor = true;
            // 
            // dgvStats
            // 
            this.dgvStats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStats.ColumnHeadersHeight = 25;
            this.dgvStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Stats,
            this.Pkmn1,
            this.Pkmn2,
            this.Pkmn3,
            this.Pkmn4,
            this.Pkmn5,
            this.Pkmn6,
            this.StatsTeam});
            this.dgvStats.Location = new System.Drawing.Point(6, 6);
            this.dgvStats.Name = "dgvStats";
            this.dgvStats.Size = new System.Drawing.Size(515, 268);
            this.dgvStats.TabIndex = 0;
            // 
            // Stats
            // 
            this.Stats.HeaderText = "Stats";
            this.Stats.Name = "Stats";
            // 
            // Pkmn1
            // 
            this.Pkmn1.FillWeight = 50F;
            this.Pkmn1.HeaderText = "Pkmn 1";
            this.Pkmn1.Name = "Pkmn1";
            this.Pkmn1.Width = 50;
            // 
            // Pkmn2
            // 
            this.Pkmn2.FillWeight = 50F;
            this.Pkmn2.HeaderText = "Pkmn 2";
            this.Pkmn2.Name = "Pkmn2";
            this.Pkmn2.Width = 50;
            // 
            // Pkmn3
            // 
            this.Pkmn3.FillWeight = 50F;
            this.Pkmn3.HeaderText = "Pkmn 3";
            this.Pkmn3.Name = "Pkmn3";
            this.Pkmn3.Width = 50;
            // 
            // Pkmn4
            // 
            this.Pkmn4.FillWeight = 50F;
            this.Pkmn4.HeaderText = "Pkmn 4";
            this.Pkmn4.Name = "Pkmn4";
            this.Pkmn4.Width = 50;
            // 
            // Pkmn5
            // 
            this.Pkmn5.FillWeight = 50F;
            this.Pkmn5.HeaderText = "Pkmn 5";
            this.Pkmn5.Name = "Pkmn5";
            this.Pkmn5.Width = 50;
            // 
            // Pkmn6
            // 
            this.Pkmn6.FillWeight = 50F;
            this.Pkmn6.HeaderText = "Pkmn 6";
            this.Pkmn6.Name = "Pkmn6";
            this.Pkmn6.Width = 50;
            // 
            // StatsTeam
            // 
            this.StatsTeam.HeaderText = "Team";
            this.StatsTeam.Name = "StatsTeam";
            this.StatsTeam.Width = 50;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(165, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.toolStripSeparator2,
            this.importPokeListToolStripMenuItem,
            this.toolStripSeparator1,
            this.sendFeedbackToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetToolStripMenuItem.Text = "New";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // importPokeListToolStripMenuItem
            // 
            this.importPokeListToolStripMenuItem.Name = "importPokeListToolStripMenuItem";
            this.importPokeListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importPokeListToolStripMenuItem.Text = "Import PokeList";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // sendFeedbackToolStripMenuItem
            // 
            this.sendFeedbackToolStripMenuItem.Name = "sendFeedbackToolStripMenuItem";
            this.sendFeedbackToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sendFeedbackToolStripMenuItem.Text = "Send Feedback";
            this.sendFeedbackToolStripMenuItem.Click += new System.EventHandler(this.sendFeedbackToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Pokemon 5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(222, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Pokemon 6";
            // 
            // cmbP5
            // 
            this.cmbP5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbP5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbP5.FormattingEnabled = true;
            this.cmbP5.Location = new System.Drawing.Point(226, 161);
            this.cmbP5.Name = "cmbP5";
            this.cmbP5.Size = new System.Drawing.Size(200, 21);
            this.cmbP5.TabIndex = 17;
            this.cmbP5.SelectedIndexChanged += new System.EventHandler(this.cmbP5_SelectedIndexChanged);
            // 
            // cmbP4
            // 
            this.cmbP4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbP4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbP4.FormattingEnabled = true;
            this.cmbP4.Location = new System.Drawing.Point(12, 161);
            this.cmbP4.Name = "cmbP4";
            this.cmbP4.Size = new System.Drawing.Size(200, 21);
            this.cmbP4.TabIndex = 14;
            this.cmbP4.SelectedIndexChanged += new System.EventHandler(this.cmbP4_SelectedIndexChanged);
            // 
            // cmbP2
            // 
            this.cmbP2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbP2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbP2.FormattingEnabled = true;
            this.cmbP2.Location = new System.Drawing.Point(12, 114);
            this.cmbP2.Name = "cmbP2";
            this.cmbP2.Size = new System.Drawing.Size(200, 21);
            this.cmbP2.TabIndex = 8;
            this.cmbP2.SelectedIndexChanged += new System.EventHandler(this.cmbP2_SelectedIndexChanged);
            // 
            // cmbP3
            // 
            this.cmbP3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbP3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbP3.FormattingEnabled = true;
            this.cmbP3.Location = new System.Drawing.Point(226, 114);
            this.cmbP3.Name = "cmbP3";
            this.cmbP3.Size = new System.Drawing.Size(200, 21);
            this.cmbP3.TabIndex = 11;
            this.cmbP3.SelectedIndexChanged += new System.EventHandler(this.cmbP3_SelectedIndexChanged);
            // 
            // cmbP1
            // 
            this.cmbP1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbP1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbP1.FormattingEnabled = true;
            this.cmbP1.Location = new System.Drawing.Point(226, 67);
            this.cmbP1.Name = "cmbP1";
            this.cmbP1.Size = new System.Drawing.Size(200, 21);
            this.cmbP1.TabIndex = 5;
            this.cmbP1.SelectedIndexChanged += new System.EventHandler(this.cmbP1_SelectedIndexChanged);
            // 
            // cmbP0
            // 
            this.cmbP0.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbP0.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbP0.FormattingEnabled = true;
            this.cmbP0.Location = new System.Drawing.Point(12, 67);
            this.cmbP0.Name = "cmbP0";
            this.cmbP0.Size = new System.Drawing.Size(200, 21);
            this.cmbP0.TabIndex = 2;
            this.cmbP0.SelectedIndexChanged += new System.EventHandler(this.cmbP0_SelectedIndexChanged);
            // 
            // picBoxPkmn1
            // 
            this.picBoxPkmn1.Location = new System.Drawing.Point(12, 246);
            this.picBoxPkmn1.Name = "picBoxPkmn1";
            this.picBoxPkmn1.Size = new System.Drawing.Size(64, 64);
            this.picBoxPkmn1.TabIndex = 25;
            this.picBoxPkmn1.TabStop = false;
            // 
            // picBoxPkmn2
            // 
            this.picBoxPkmn2.Location = new System.Drawing.Point(82, 246);
            this.picBoxPkmn2.Name = "picBoxPkmn2";
            this.picBoxPkmn2.Size = new System.Drawing.Size(64, 64);
            this.picBoxPkmn2.TabIndex = 25;
            this.picBoxPkmn2.TabStop = false;
            // 
            // picBoxPkmn3
            // 
            this.picBoxPkmn3.Location = new System.Drawing.Point(152, 246);
            this.picBoxPkmn3.Name = "picBoxPkmn3";
            this.picBoxPkmn3.Size = new System.Drawing.Size(64, 64);
            this.picBoxPkmn3.TabIndex = 25;
            this.picBoxPkmn3.TabStop = false;
            // 
            // picBoxPkmn4
            // 
            this.picBoxPkmn4.Location = new System.Drawing.Point(222, 246);
            this.picBoxPkmn4.Name = "picBoxPkmn4";
            this.picBoxPkmn4.Size = new System.Drawing.Size(64, 64);
            this.picBoxPkmn4.TabIndex = 25;
            this.picBoxPkmn4.TabStop = false;
            // 
            // picBoxPkmn5
            // 
            this.picBoxPkmn5.Location = new System.Drawing.Point(292, 246);
            this.picBoxPkmn5.Name = "picBoxPkmn5";
            this.picBoxPkmn5.Size = new System.Drawing.Size(64, 64);
            this.picBoxPkmn5.TabIndex = 25;
            this.picBoxPkmn5.TabStop = false;
            // 
            // picBoxPkmn6
            // 
            this.picBoxPkmn6.Location = new System.Drawing.Point(362, 246);
            this.picBoxPkmn6.Name = "picBoxPkmn6";
            this.picBoxPkmn6.Size = new System.Drawing.Size(64, 64);
            this.picBoxPkmn6.TabIndex = 25;
            this.picBoxPkmn6.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(989, 361);
            this.Controls.Add(this.picBoxPkmn6);
            this.Controls.Add(this.picBoxPkmn5);
            this.Controls.Add(this.picBoxPkmn4);
            this.Controls.Add(this.picBoxPkmn3);
            this.Controls.Add(this.picBoxPkmn2);
            this.Controls.Add(this.picBoxPkmn1);
            this.Controls.Add(this.tabView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbP5);
            this.Controls.Add(this.cmbP4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbP3);
            this.Controls.Add(this.cmbP0);
            this.Controls.Add(this.cmbP2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbP1);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(750, 400);
            this.Name = "FormMain";
            this.Text = "PokeCalk (v1.0)";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypes)).EndInit();
            this.tabView.ResumeLayout(false);
            this.tabType.ResumeLayout(false);
            this.tabStats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStats)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPkmn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPkmn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPkmn3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPkmn4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPkmn5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPkmn6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvTypes;
        private System.Windows.Forms.TabControl tabView;
        private System.Windows.Forms.TabPage tabType;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendFeedbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveTeam;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem importPokeListToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbP5;
        private System.Windows.Forms.ComboBox cmbP4;
        private System.Windows.Forms.ComboBox cmbP2;
        private System.Windows.Forms.ComboBox cmbP3;
        private System.Windows.Forms.ComboBox cmbP1;
        private System.Windows.Forms.ComboBox cmbP0;
        private System.Windows.Forms.TabPage tabStats;
        private System.Windows.Forms.PictureBox picBoxPkmn1;
        private System.Windows.Forms.PictureBox picBoxPkmn2;
        private System.Windows.Forms.PictureBox picBoxPkmn3;
        private System.Windows.Forms.PictureBox picBoxPkmn4;
        private System.Windows.Forms.PictureBox picBoxPkmn5;
        private System.Windows.Forms.PictureBox picBoxPkmn6;
        private System.Windows.Forms.DataGridView dgvStats;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPkmn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPkmn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPkmn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPkmn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPkmn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPkmn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Team;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stats;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pkmn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pkmn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pkmn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pkmn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pkmn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pkmn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatsTeam;
        private System.Windows.Forms.OpenFileDialog openTeam;
    }
}

