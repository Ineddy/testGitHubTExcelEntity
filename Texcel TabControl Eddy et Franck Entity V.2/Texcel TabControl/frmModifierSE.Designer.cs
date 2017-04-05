namespace Texcel_TabControl
{
    partial class frmModifierSE
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
            this.btnModifierSE = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.txtVersionSE = new System.Windows.Forms.TextBox();
            this.txtEditionSE = new System.Windows.Forms.TextBox();
            this.lblEdition = new System.Windows.Forms.Label();
            this.txtNomSE = new System.Windows.Forms.TextBox();
            this.lblSE = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnModifierSE
            // 
            this.btnModifierSE.Location = new System.Drawing.Point(280, 232);
            this.btnModifierSE.Name = "btnModifierSE";
            this.btnModifierSE.Size = new System.Drawing.Size(112, 32);
            this.btnModifierSE.TabIndex = 20;
            this.btnModifierSE.Text = "Modifier";
            this.btnModifierSE.UseVisualStyleBackColor = true;
            this.btnModifierSE.Click += new System.EventHandler(this.btnModifierSE_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(46, 177);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(56, 17);
            this.lblVersion.TabIndex = 19;
            this.lblVersion.Text = "Version";
            // 
            // txtVersionSE
            // 
            this.txtVersionSE.Location = new System.Drawing.Point(211, 174);
            this.txtVersionSE.Name = "txtVersionSE";
            this.txtVersionSE.Size = new System.Drawing.Size(181, 22);
            this.txtVersionSE.TabIndex = 18;
            // 
            // txtEditionSE
            // 
            this.txtEditionSE.Location = new System.Drawing.Point(211, 120);
            this.txtEditionSE.Name = "txtEditionSE";
            this.txtEditionSE.Size = new System.Drawing.Size(181, 22);
            this.txtEditionSE.TabIndex = 17;
            // 
            // lblEdition
            // 
            this.lblEdition.AutoSize = true;
            this.lblEdition.Location = new System.Drawing.Point(46, 126);
            this.lblEdition.Name = "lblEdition";
            this.lblEdition.Size = new System.Drawing.Size(55, 17);
            this.lblEdition.TabIndex = 16;
            this.lblEdition.Text = "Édition ";
            // 
            // txtNomSE
            // 
            this.txtNomSE.Location = new System.Drawing.Point(211, 67);
            this.txtNomSE.Name = "txtNomSE";
            this.txtNomSE.Size = new System.Drawing.Size(181, 22);
            this.txtNomSE.TabIndex = 15;
            // 
            // lblSE
            // 
            this.lblSE.AutoSize = true;
            this.lblSE.Location = new System.Drawing.Point(43, 67);
            this.lblSE.Name = "lblSE";
            this.lblSE.Size = new System.Drawing.Size(148, 17);
            this.lblSE.TabIndex = 14;
            this.lblSE.Text = "Système d\'exploitation";
            // 
            // frmModifierSE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 331);
            this.Controls.Add(this.btnModifierSE);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.txtVersionSE);
            this.Controls.Add(this.txtEditionSE);
            this.Controls.Add(this.lblEdition);
            this.Controls.Add(this.txtNomSE);
            this.Controls.Add(this.lblSE);
            this.Name = "frmModifierSE";
            this.Text = "Modifier un OS";
            this.Load += new System.EventHandler(this.modifierSE_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModifierSE;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.TextBox txtVersionSE;
        private System.Windows.Forms.TextBox txtEditionSE;
        private System.Windows.Forms.Label lblEdition;
        private System.Windows.Forms.TextBox txtNomSE;
        private System.Windows.Forms.Label lblSE;
    }
}