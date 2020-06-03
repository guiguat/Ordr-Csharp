namespace OrdrDesktop
{
    partial class FormConfig
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBaseURL = new System.Windows.Forms.Label();
            this.txbURL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSure = new System.Windows.Forms.Button();
            this.btnAlterarURL = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 393);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conexão";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(16, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "baseUrl atual:";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.btnAlterarURL);
            this.panel2.Controls.Add(this.btnSure);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txbURL);
            this.panel2.Controls.Add(this.lblBaseURL);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(123, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(344, 155);
            this.panel2.TabIndex = 2;
            // 
            // lblBaseURL
            // 
            this.lblBaseURL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBaseURL.AutoSize = true;
            this.lblBaseURL.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseURL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBaseURL.Location = new System.Drawing.Point(178, 12);
            this.lblBaseURL.Name = "lblBaseURL";
            this.lblBaseURL.Size = new System.Drawing.Size(0, 23);
            this.lblBaseURL.TabIndex = 2;
            // 
            // txbURL
            // 
            this.txbURL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.txbURL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbURL.ForeColor = System.Drawing.SystemColors.Window;
            this.txbURL.Location = new System.Drawing.Point(126, 59);
            this.txbURL.Multiline = true;
            this.txbURL.Name = "txbURL";
            this.txbURL.Size = new System.Drawing.Size(190, 20);
            this.txbURL.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(16, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nova baseUrl:";
            // 
            // btnSure
            // 
            this.btnSure.BackColor = System.Drawing.Color.Firebrick;
            this.btnSure.FlatAppearance.BorderSize = 0;
            this.btnSure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSure.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSure.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSure.Location = new System.Drawing.Point(20, 103);
            this.btnSure.Name = "btnSure";
            this.btnSure.Size = new System.Drawing.Size(296, 34);
            this.btnSure.TabIndex = 5;
            this.btnSure.Text = "Tem certeza?";
            this.btnSure.UseVisualStyleBackColor = false;
            this.btnSure.Click += new System.EventHandler(this.btnSure_Click);
            // 
            // btnAlterarURL
            // 
            this.btnAlterarURL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.btnAlterarURL.FlatAppearance.BorderSize = 0;
            this.btnAlterarURL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarURL.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarURL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAlterarURL.Location = new System.Drawing.Point(20, 103);
            this.btnAlterarURL.Name = "btnAlterarURL";
            this.btnAlterarURL.Size = new System.Drawing.Size(296, 34);
            this.btnAlterarURL.TabIndex = 6;
            this.btnAlterarURL.Text = "Alterar URL";
            this.btnAlterarURL.UseVisualStyleBackColor = false;
            this.btnAlterarURL.Click += new System.EventHandler(this.btnAlterarURL_Click);
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 393);
            this.Controls.Add(this.panel1);
            this.Name = "FormConfig";
            this.Text = "FormConfig";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAlterarURL;
        private System.Windows.Forms.Button btnSure;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbURL;
        private System.Windows.Forms.Label lblBaseURL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}