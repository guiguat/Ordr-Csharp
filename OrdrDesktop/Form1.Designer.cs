namespace OrdrDesktop
{
    partial class FormDashboard
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnCozinha = new System.Windows.Forms.Button();
            this.btnProd = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.panelMenu.Controls.Add(this.btnConfig);
            this.panelMenu.Controls.Add(this.btnCozinha);
            this.panelMenu.Controls.Add(this.btnProd);
            this.panelMenu.Controls.Add(this.btnRelatorio);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(186, 432);
            this.panelMenu.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 59);
            this.panel2.TabIndex = 0;
            // 
            // btnConfig
            // 
            this.btnConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.ForeColor = System.Drawing.Color.White;
            this.btnConfig.Location = new System.Drawing.Point(0, 239);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnConfig.Size = new System.Drawing.Size(186, 60);
            this.btnConfig.TabIndex = 3;
            this.btnConfig.Text = "Configuração";
            this.btnConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnCozinha
            // 
            this.btnCozinha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCozinha.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCozinha.FlatAppearance.BorderSize = 0;
            this.btnCozinha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCozinha.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCozinha.ForeColor = System.Drawing.Color.White;
            this.btnCozinha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCozinha.Location = new System.Drawing.Point(0, 179);
            this.btnCozinha.Name = "btnCozinha";
            this.btnCozinha.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCozinha.Size = new System.Drawing.Size(186, 60);
            this.btnCozinha.TabIndex = 2;
            this.btnCozinha.Text = "Cozinha";
            this.btnCozinha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCozinha.UseVisualStyleBackColor = true;
            this.btnCozinha.Click += new System.EventHandler(this.btnCozinha_Click);
            // 
            // btnProd
            // 
            this.btnProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProd.FlatAppearance.BorderSize = 0;
            this.btnProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProd.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProd.ForeColor = System.Drawing.Color.White;
            this.btnProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProd.Location = new System.Drawing.Point(0, 119);
            this.btnProd.Name = "btnProd";
            this.btnProd.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProd.Size = new System.Drawing.Size(186, 60);
            this.btnProd.TabIndex = 1;
            this.btnProd.Text = "Produtos";
            this.btnProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProd.UseVisualStyleBackColor = true;
            this.btnProd.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelatorio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRelatorio.FlatAppearance.BorderSize = 0;
            this.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorio.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.ForeColor = System.Drawing.Color.White;
            this.btnRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorio.Location = new System.Drawing.Point(0, 59);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRelatorio.Size = new System.Drawing.Size(186, 60);
            this.btnRelatorio.TabIndex = 0;
            this.btnRelatorio.Text = "Relatório";
            this.btnRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Image = global::OrdrDesktop.Properties.Resources.logo;
            this.btnHome.Location = new System.Drawing.Point(46, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(99, 41);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(763, 432);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(779, 471);
            this.Name = "FormDashboard";
            this.Text = "ORDR - Gerenciamento de Pedidos";
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnCozinha;
        private System.Windows.Forms.Button btnProd;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.PictureBox btnHome;
    }
}

