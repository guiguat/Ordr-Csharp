namespace OrdrDesktop
{
    partial class FormProduto
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelForm = new System.Windows.Forms.Panel();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.numEstoque = new System.Windows.Forms.NumericUpDown();
            this.panel5 = new System.Windows.Forms.Panel();
            this.numPreco = new System.Windows.Forms.NumericUpDown();
            this.panel4 = new System.Windows.Forms.Panel();
            this.numCodigo = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbName = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbPrato = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEstoque)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPreco)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCodigo)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Produtos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 49);
            this.panel1.TabIndex = 1;
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.panelForm.Controls.Add(this.btnEstoque);
            this.panelForm.Controls.Add(this.btnAtualizar);
            this.panelForm.Controls.Add(this.panel6);
            this.panelForm.Controls.Add(this.panel5);
            this.panelForm.Controls.Add(this.panel4);
            this.panelForm.Controls.Add(this.panel3);
            this.panelForm.Controls.Add(this.btnDel);
            this.panelForm.Controls.Add(this.btnEdit);
            this.panelForm.Controls.Add(this.btnAdd);
            this.panelForm.Controls.Add(this.label6);
            this.panelForm.Controls.Add(this.cbPrato);
            this.panelForm.Controls.Add(this.label5);
            this.panelForm.Controls.Add(this.label4);
            this.panelForm.Controls.Add(this.label3);
            this.panelForm.Controls.Add(this.label2);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelForm.Location = new System.Drawing.Point(0, 49);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(561, 120);
            this.panelForm.TabIndex = 2;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.FlatAppearance.BorderSize = 0;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(132)))), ((int)(((byte)(139)))));
            this.btnAtualizar.Location = new System.Drawing.Point(411, 82);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 17;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(46)))));
            this.panel6.Controls.Add(this.numEstoque);
            this.panel6.Location = new System.Drawing.Point(277, 48);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(134, 23);
            this.panel6.TabIndex = 16;
            // 
            // numEstoque
            // 
            this.numEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(46)))));
            this.numEstoque.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numEstoque.ForeColor = System.Drawing.SystemColors.Window;
            this.numEstoque.Location = new System.Drawing.Point(7, 3);
            this.numEstoque.Name = "numEstoque";
            this.numEstoque.Size = new System.Drawing.Size(120, 16);
            this.numEstoque.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(46)))));
            this.panel5.Controls.Add(this.numPreco);
            this.panel5.Location = new System.Drawing.Point(56, 45);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(134, 23);
            this.panel5.TabIndex = 15;
            // 
            // numPreco
            // 
            this.numPreco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(46)))));
            this.numPreco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numPreco.DecimalPlaces = 2;
            this.numPreco.ForeColor = System.Drawing.SystemColors.Window;
            this.numPreco.Location = new System.Drawing.Point(7, 3);
            this.numPreco.Name = "numPreco";
            this.numPreco.Size = new System.Drawing.Size(120, 16);
            this.numPreco.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(46)))));
            this.panel4.Controls.Add(this.numCodigo);
            this.panel4.Location = new System.Drawing.Point(107, 14);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(134, 23);
            this.panel4.TabIndex = 14;
            // 
            // numCodigo
            // 
            this.numCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(46)))));
            this.numCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numCodigo.ForeColor = System.Drawing.SystemColors.Window;
            this.numCodigo.Location = new System.Drawing.Point(7, 3);
            this.numCodigo.Name = "numCodigo";
            this.numCodigo.Size = new System.Drawing.Size(120, 16);
            this.numCodigo.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(46)))));
            this.panel3.Controls.Add(this.txbName);
            this.panel3.Location = new System.Drawing.Point(301, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(187, 23);
            this.panel3.TabIndex = 13;
            // 
            // txbName
            // 
            this.txbName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(46)))));
            this.txbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbName.ForeColor = System.Drawing.SystemColors.Window;
            this.txbName.Location = new System.Drawing.Point(8, 3);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(165, 13);
            this.txbName.TabIndex = 1;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.ForeColor = System.Drawing.Color.Firebrick;
            this.btnDel.Location = new System.Drawing.Point(312, 82);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 12;
            this.btnDel.Text = "Deletar";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnEdit.Location = new System.Drawing.Point(114, 82);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_ClickAsync);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.Location = new System.Drawing.Point(15, 82);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(14, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Código (del/edit):";
            // 
            // cbPrato
            // 
            this.cbPrato.AutoSize = true;
            this.cbPrato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbPrato.FlatAppearance.BorderSize = 0;
            this.cbPrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPrato.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbPrato.Location = new System.Drawing.Point(481, 51);
            this.cbPrato.Name = "cbPrato";
            this.cbPrato.Size = new System.Drawing.Size(48, 17);
            this.cbPrato.TabIndex = 7;
            this.cbPrato.Text = "Prato";
            this.cbPrato.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(443, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tipo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(222, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Estoque:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Preço:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(257, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvProdutos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 169);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(561, 224);
            this.panel2.TabIndex = 3;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(46)))));
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProdutos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.dgvProdutos.Location = new System.Drawing.Point(0, 0);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.RowHeadersWidth = 75;
            this.dgvProdutos.Size = new System.Drawing.Size(561, 224);
            this.dgvProdutos.TabIndex = 0;
            this.dgvProdutos.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProdutos_RowHeaderMouseClick);
            // 
            // btnEstoque
            // 
            this.btnEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.btnEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstoque.FlatAppearance.BorderSize = 0;
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoque.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnEstoque.Location = new System.Drawing.Point(213, 82);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(75, 23);
            this.btnEstoque.TabIndex = 18;
            this.btnEstoque.Text = "Estocar";
            this.btnEstoque.UseVisualStyleBackColor = false;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // FormProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 393);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panel1);
            this.Name = "FormProduto";
            this.Text = "FormProduto";
            this.Load += new System.EventHandler(this.FormProduto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numEstoque)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numPreco)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numCodigo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbPrato;
        private System.Windows.Forms.NumericUpDown numCodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.NumericUpDown numEstoque;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.NumericUpDown numPreco;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnEstoque;
    }
}