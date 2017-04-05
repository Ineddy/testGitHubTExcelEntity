namespace Texcel_TabControl
{
    partial class frmModifierPlateforme
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
            this.dgvOS = new System.Windows.Forms.DataGridView();
            this.dgvNoSE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNomOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEditionOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvVersionSE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNomPlateforme = new System.Windows.Forms.TextBox();
            this.cbTypePlateforme = new System.Windows.Forms.ComboBox();
            this.rtbConfigPlateforme = new System.Windows.Forms.RichTextBox();
            this.btnModifierPLateforme = new System.Windows.Forms.Button();
            this.lblSE = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblConfigPlateforme = new System.Windows.Forms.Label();
            this.lblPlateforme = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOS)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOS
            // 
            this.dgvOS.AllowUserToAddRows = false;
            this.dgvOS.AllowUserToDeleteRows = false;
            this.dgvOS.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvNoSE,
            this.dgvNomOS,
            this.dgvEditionOS,
            this.dgvVersionSE});
            this.dgvOS.Location = new System.Drawing.Point(198, 152);
            this.dgvOS.MultiSelect = false;
            this.dgvOS.Name = "dgvOS";
            this.dgvOS.RowHeadersWidth = 40;
            this.dgvOS.RowTemplate.Height = 24;
            this.dgvOS.Size = new System.Drawing.Size(411, 130);
            this.dgvOS.TabIndex = 37;
            // 
            // dgvNoSE
            // 
            this.dgvNoSE.HeaderText = "No";
            this.dgvNoSE.Name = "dgvNoSE";
            // 
            // dgvNomOS
            // 
            this.dgvNomOS.FillWeight = 1F;
            this.dgvNomOS.HeaderText = "Nom";
            this.dgvNomOS.Name = "dgvNomOS";
            this.dgvNomOS.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNomOS.Width = 165;
            // 
            // dgvEditionOS
            // 
            this.dgvEditionOS.HeaderText = "Edition";
            this.dgvEditionOS.Name = "dgvEditionOS";
            this.dgvEditionOS.Width = 165;
            // 
            // dgvVersionSE
            // 
            this.dgvVersionSE.HeaderText = "Version";
            this.dgvVersionSE.Name = "dgvVersionSE";
            // 
            // txtNomPlateforme
            // 
            this.txtNomPlateforme.Location = new System.Drawing.Point(198, 36);
            this.txtNomPlateforme.Name = "txtNomPlateforme";
            this.txtNomPlateforme.Size = new System.Drawing.Size(411, 22);
            this.txtNomPlateforme.TabIndex = 36;
            // 
            // cbTypePlateforme
            // 
            this.cbTypePlateforme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypePlateforme.FormattingEnabled = true;
            this.cbTypePlateforme.Location = new System.Drawing.Point(198, 92);
            this.cbTypePlateforme.Name = "cbTypePlateforme";
            this.cbTypePlateforme.Size = new System.Drawing.Size(411, 24);
            this.cbTypePlateforme.Sorted = true;
            this.cbTypePlateforme.TabIndex = 35;
            // 
            // rtbConfigPlateforme
            // 
            this.rtbConfigPlateforme.Location = new System.Drawing.Point(198, 303);
            this.rtbConfigPlateforme.Name = "rtbConfigPlateforme";
            this.rtbConfigPlateforme.Size = new System.Drawing.Size(411, 88);
            this.rtbConfigPlateforme.TabIndex = 34;
            this.rtbConfigPlateforme.Text = "";
            // 
            // btnModifierPLateforme
            // 
            this.btnModifierPLateforme.Location = new System.Drawing.Point(469, 413);
            this.btnModifierPLateforme.Name = "btnModifierPLateforme";
            this.btnModifierPLateforme.Size = new System.Drawing.Size(140, 37);
            this.btnModifierPLateforme.TabIndex = 33;
            this.btnModifierPLateforme.Text = "Modifier";
            this.btnModifierPLateforme.UseVisualStyleBackColor = true;
            this.btnModifierPLateforme.Click += new System.EventHandler(this.btnModifierPLateforme_Click);
            // 
            // lblSE
            // 
            this.lblSE.AutoSize = true;
            this.lblSE.Location = new System.Drawing.Point(25, 152);
            this.lblSE.Name = "lblSE";
            this.lblSE.Size = new System.Drawing.Size(148, 17);
            this.lblSE.TabIndex = 32;
            this.lblSE.Text = "Système d\'exploitation";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(25, 92);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(40, 17);
            this.lblType.TabIndex = 31;
            this.lblType.Text = "Type";
            // 
            // lblConfigPlateforme
            // 
            this.lblConfigPlateforme.AutoSize = true;
            this.lblConfigPlateforme.Location = new System.Drawing.Point(36, 303);
            this.lblConfigPlateforme.Name = "lblConfigPlateforme";
            this.lblConfigPlateforme.Size = new System.Drawing.Size(92, 17);
            this.lblConfigPlateforme.TabIndex = 30;
            this.lblConfigPlateforme.Text = "Configuration";
            // 
            // lblPlateforme
            // 
            this.lblPlateforme.AutoSize = true;
            this.lblPlateforme.Location = new System.Drawing.Point(25, 36);
            this.lblPlateforme.Name = "lblPlateforme";
            this.lblPlateforme.Size = new System.Drawing.Size(76, 17);
            this.lblPlateforme.TabIndex = 29;
            this.lblPlateforme.Text = "Plateforme";
            // 
            // frmModifierPlateforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 484);
            this.Controls.Add(this.dgvOS);
            this.Controls.Add(this.txtNomPlateforme);
            this.Controls.Add(this.cbTypePlateforme);
            this.Controls.Add(this.rtbConfigPlateforme);
            this.Controls.Add(this.btnModifierPLateforme);
            this.Controls.Add(this.lblSE);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblConfigPlateforme);
            this.Controls.Add(this.lblPlateforme);
            this.Name = "frmModifierPlateforme";
            this.Text = "Modifier une plateforme";
            this.Load += new System.EventHandler(this.frmModifierPlateforme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNoSE;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNomOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEditionOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvVersionSE;
        private System.Windows.Forms.TextBox txtNomPlateforme;
        private System.Windows.Forms.ComboBox cbTypePlateforme;
        private System.Windows.Forms.RichTextBox rtbConfigPlateforme;
        private System.Windows.Forms.Button btnModifierPLateforme;
        private System.Windows.Forms.Label lblSE;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblConfigPlateforme;
        private System.Windows.Forms.Label lblPlateforme;
    }
}