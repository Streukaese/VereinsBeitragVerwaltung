namespace VereinsBeitragVerwaltung
{
    partial class Hauptfenster
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewMitglieder = new System.Windows.Forms.DataGridView();
            this.labelMitglieder = new System.Windows.Forms.Label();
            this.buttonHinzufuegen = new System.Windows.Forms.Button();
            this.buttonAendern = new System.Windows.Forms.Button();
            this.buttonEntfernen = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelBeitrag = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.numericUpDownAge = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBeitrag = new System.Windows.Forms.NumericUpDown();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBeitrag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMitglieder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBeitrag)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMitglieder
            // 
            this.dataGridViewMitglieder.AllowUserToAddRows = false;
            this.dataGridViewMitglieder.AllowUserToDeleteRows = false;
            this.dataGridViewMitglieder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMitglieder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnName,
            this.ColumnAge,
            this.ColumnBeitrag});
            this.dataGridViewMitglieder.Location = new System.Drawing.Point(12, 42);
            this.dataGridViewMitglieder.Name = "dataGridViewMitglieder";
            this.dataGridViewMitglieder.ReadOnly = true;
            this.dataGridViewMitglieder.RowHeadersWidth = 51;
            this.dataGridViewMitglieder.RowTemplate.Height = 24;
            this.dataGridViewMitglieder.Size = new System.Drawing.Size(391, 396);
            this.dataGridViewMitglieder.TabIndex = 0;
            this.dataGridViewMitglieder.DoubleClick += new System.EventHandler(this.dataGridViewMitglieder_DoubleClick);
            // 
            // labelMitglieder
            // 
            this.labelMitglieder.AutoSize = true;
            this.labelMitglieder.Location = new System.Drawing.Point(13, 20);
            this.labelMitglieder.Name = "labelMitglieder";
            this.labelMitglieder.Size = new System.Drawing.Size(66, 16);
            this.labelMitglieder.TabIndex = 1;
            this.labelMitglieder.Text = "Mitglieder";
            // 
            // buttonHinzufuegen
            // 
            this.buttonHinzufuegen.Location = new System.Drawing.Point(517, 244);
            this.buttonHinzufuegen.Name = "buttonHinzufuegen";
            this.buttonHinzufuegen.Size = new System.Drawing.Size(166, 33);
            this.buttonHinzufuegen.TabIndex = 2;
            this.buttonHinzufuegen.Text = "Hinzufügen";
            this.buttonHinzufuegen.UseVisualStyleBackColor = true;
            this.buttonHinzufuegen.Click += new System.EventHandler(this.buttonHinzufuegen_Click);
            // 
            // buttonAendern
            // 
            this.buttonAendern.Location = new System.Drawing.Point(517, 308);
            this.buttonAendern.Name = "buttonAendern";
            this.buttonAendern.Size = new System.Drawing.Size(166, 33);
            this.buttonAendern.TabIndex = 3;
            this.buttonAendern.Text = "Ändern";
            this.buttonAendern.UseVisualStyleBackColor = true;
            this.buttonAendern.Click += new System.EventHandler(this.buttonAendern_Click);
            // 
            // buttonEntfernen
            // 
            this.buttonEntfernen.Location = new System.Drawing.Point(517, 405);
            this.buttonEntfernen.Name = "buttonEntfernen";
            this.buttonEntfernen.Size = new System.Drawing.Size(166, 33);
            this.buttonEntfernen.TabIndex = 4;
            this.buttonEntfernen.Text = "Entfernen";
            this.buttonEntfernen.UseVisualStyleBackColor = true;
            this.buttonEntfernen.Click += new System.EventHandler(this.buttonEntfernen_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(422, 42);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(44, 16);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Name";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(422, 75);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(32, 16);
            this.labelAge.TabIndex = 6;
            this.labelAge.Text = "Age";
            // 
            // labelBeitrag
            // 
            this.labelBeitrag.AutoSize = true;
            this.labelBeitrag.Location = new System.Drawing.Point(422, 110);
            this.labelBeitrag.Name = "labelBeitrag";
            this.labelBeitrag.Size = new System.Drawing.Size(50, 16);
            this.labelBeitrag.TabIndex = 7;
            this.labelBeitrag.Text = "Beitrag";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(517, 42);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(187, 22);
            this.textBoxName.TabIndex = 8;
            // 
            // numericUpDownAge
            // 
            this.numericUpDownAge.Location = new System.Drawing.Point(517, 75);
            this.numericUpDownAge.Name = "numericUpDownAge";
            this.numericUpDownAge.Size = new System.Drawing.Size(187, 22);
            this.numericUpDownAge.TabIndex = 9;
            // 
            // numericUpDownBeitrag
            // 
            this.numericUpDownBeitrag.Location = new System.Drawing.Point(517, 110);
            this.numericUpDownBeitrag.Name = "numericUpDownBeitrag";
            this.numericUpDownBeitrag.Size = new System.Drawing.Size(187, 22);
            this.numericUpDownBeitrag.TabIndex = 10;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "ID";
            this.ColumnId.MinimumWidth = 6;
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Visible = false;
            this.ColumnId.Width = 125;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.MinimumWidth = 6;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.Width = 125;
            // 
            // ColumnAge
            // 
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.ColumnAge.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnAge.HeaderText = "Age";
            this.ColumnAge.MinimumWidth = 6;
            this.ColumnAge.Name = "ColumnAge";
            this.ColumnAge.ReadOnly = true;
            this.ColumnAge.Width = 125;
            // 
            // ColumnBeitrag
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.ColumnBeitrag.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnBeitrag.HeaderText = "Beitrag";
            this.ColumnBeitrag.MinimumWidth = 6;
            this.ColumnBeitrag.Name = "ColumnBeitrag";
            this.ColumnBeitrag.ReadOnly = true;
            this.ColumnBeitrag.Width = 125;
            // 
            // Hauptfenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDownBeitrag);
            this.Controls.Add(this.numericUpDownAge);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelBeitrag);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonEntfernen);
            this.Controls.Add(this.buttonAendern);
            this.Controls.Add(this.buttonHinzufuegen);
            this.Controls.Add(this.labelMitglieder);
            this.Controls.Add(this.dataGridViewMitglieder);
            this.Name = "Hauptfenster";
            this.Text = "Verein";
            this.Load += new System.EventHandler(this.Hauptfenster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMitglieder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBeitrag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMitglieder;
        private System.Windows.Forms.Label labelMitglieder;
        private System.Windows.Forms.Button buttonHinzufuegen;
        private System.Windows.Forms.Button buttonAendern;
        private System.Windows.Forms.Button buttonEntfernen;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelBeitrag;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.NumericUpDown numericUpDownAge;
        private System.Windows.Forms.NumericUpDown numericUpDownBeitrag;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBeitrag;
    }
}

