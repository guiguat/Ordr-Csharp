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
            this.components = new System.ComponentModel.Container();
            this.dgvRelatorios = new System.Windows.Forms.DataGridView();
            this.relatorioItemModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioItemModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRelatorios
            // 
            this.dgvRelatorios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvRelatorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelatorios.Location = new System.Drawing.Point(12, 116);
            this.dgvRelatorios.Name = "dgvRelatorios";
            this.dgvRelatorios.ReadOnly = true;
            this.dgvRelatorios.Size = new System.Drawing.Size(537, 265);
            this.dgvRelatorios.TabIndex = 0;
            // 
            // relatorioItemModelBindingSource
            // 
            this.relatorioItemModelBindingSource.DataSource = typeof(OrdrDesktop.models.RelatorioItemModel);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Location = new System.Drawing.Point(12, 87);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Atualizar";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FormRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 393);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvRelatorios);
            this.MinimumSize = new System.Drawing.Size(577, 432);
            this.Name = "FormRelatorio";
            this.Text = "FormRelatorio";
            this.Load += new System.EventHandler(this.FormRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioItemModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRelatorios;
        private System.Windows.Forms.BindingSource relatorioItemModelBindingSource;
        private System.Windows.Forms.Button btnRefresh;
    }
}