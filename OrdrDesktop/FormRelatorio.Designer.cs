namespace OrdrDesktop
{
    partial class FormRelatorio
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
            this.dgvRelatorios = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnOpenRelatorio = new System.Windows.Forms.Button();
            this.panelButtons = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorios)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRelatorios
            // 
            this.dgvRelatorios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvRelatorios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRelatorios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvRelatorios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(46)))));
            this.dgvRelatorios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRelatorios.Location = new System.Drawing.Point(12, 67);
            this.dgvRelatorios.MaximumSize = new System.Drawing.Size(737, 514);
            this.dgvRelatorios.MinimumSize = new System.Drawing.Size(537, 314);
            this.dgvRelatorios.Name = "dgvRelatorios";
            this.dgvRelatorios.ReadOnly = true;
            this.dgvRelatorios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvRelatorios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvRelatorios.ShowEditingIcon = false;
            this.dgvRelatorios.ShowRowErrors = false;
            this.dgvRelatorios.Size = new System.Drawing.Size(537, 314);
            this.dgvRelatorios.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(132)))), ((int)(((byte)(139)))));
            this.btnRefresh.Location = new System.Drawing.Point(18, 21);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Atualizar";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnOpenRelatorio
            // 
            this.btnOpenRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.btnOpenRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenRelatorio.FlatAppearance.BorderSize = 0;
            this.btnOpenRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenRelatorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(132)))), ((int)(((byte)(139)))));
            this.btnOpenRelatorio.Location = new System.Drawing.Point(99, 21);
            this.btnOpenRelatorio.Name = "btnOpenRelatorio";
            this.btnOpenRelatorio.Size = new System.Drawing.Size(75, 23);
            this.btnOpenRelatorio.TabIndex = 2;
            this.btnOpenRelatorio.Text = "Abrir Caixa";
            this.btnOpenRelatorio.UseVisualStyleBackColor = false;
            this.btnOpenRelatorio.Click += new System.EventHandler(this.btnOpenRelatorio_Click);
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.panelButtons.Controls.Add(this.btnOpenRelatorio);
            this.panelButtons.Controls.Add(this.btnRefresh);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(561, 61);
            this.panelButtons.TabIndex = 3;
            // 
            // FormRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(561, 393);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.dgvRelatorios);
            this.MinimumSize = new System.Drawing.Size(577, 432);
            this.Name = "FormRelatorio";
            this.Text = "FormRelatorio";
            this.Load += new System.EventHandler(this.FormRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorios)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRelatorios;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnOpenRelatorio;
        private System.Windows.Forms.Panel panelButtons;
    }
}