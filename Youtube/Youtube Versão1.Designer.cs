namespace Youtube
{
    partial class frYoutube
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frYoutube));
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.CmbQualidade = new System.Windows.Forms.ComboBox();
            this.rdMp3 = new System.Windows.Forms.RadioButton();
            this.rdMp4 = new System.Windows.Forms.RadioButton();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnDownload = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.Sair = new System.Windows.Forms.Button();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.Avanco = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMostrar.Location = new System.Drawing.Point(845, 5);
            this.BtnMostrar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(116, 42);
            this.BtnMostrar.TabIndex = 0;
            this.BtnMostrar.Text = "Mostrar";
            this.BtnMostrar.UseVisualStyleBackColor = false;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrl.Location = new System.Drawing.Point(16, 5);
            this.txtUrl.Margin = new System.Windows.Forms.Padding(4);
            this.txtUrl.Multiline = true;
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(821, 42);
            this.txtUrl.TabIndex = 1;
            // 
            // CmbQualidade
            // 
            this.CmbQualidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbQualidade.FormattingEnabled = true;
            this.CmbQualidade.Location = new System.Drawing.Point(195, 55);
            this.CmbQualidade.Margin = new System.Windows.Forms.Padding(4);
            this.CmbQualidade.Name = "CmbQualidade";
            this.CmbQualidade.Size = new System.Drawing.Size(256, 33);
            this.CmbQualidade.TabIndex = 2;
            this.CmbQualidade.Text = "Selecione a Qualidade";
            // 
            // rdMp3
            // 
            this.rdMp3.AutoSize = true;
            this.rdMp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMp3.Location = new System.Drawing.Point(16, 55);
            this.rdMp3.Margin = new System.Windows.Forms.Padding(4);
            this.rdMp3.Name = "rdMp3";
            this.rdMp3.Size = new System.Drawing.Size(83, 33);
            this.rdMp3.TabIndex = 3;
            this.rdMp3.TabStop = true;
            this.rdMp3.Text = "MP3";
            this.rdMp3.UseVisualStyleBackColor = true;
            this.rdMp3.CheckedChanged += new System.EventHandler(this.rdMp3_CheckedChanged);
            // 
            // rdMp4
            // 
            this.rdMp4.AutoSize = true;
            this.rdMp4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMp4.Location = new System.Drawing.Point(104, 55);
            this.rdMp4.Margin = new System.Windows.Forms.Padding(4);
            this.rdMp4.Name = "rdMp4";
            this.rdMp4.Size = new System.Drawing.Size(83, 33);
            this.rdMp4.TabIndex = 4;
            this.rdMp4.TabStop = true;
            this.rdMp4.Text = "MP4";
            this.rdMp4.UseVisualStyleBackColor = true;
            this.rdMp4.CheckedChanged += new System.EventHandler(this.rdMp4_CheckedChanged);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(845, 94);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(119, 42);
            this.BtnGuardar.TabIndex = 5;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnDownload
            // 
            this.BtnDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDownload.Location = new System.Drawing.Point(13, 144);
            this.BtnDownload.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDownload.Name = "BtnDownload";
            this.BtnDownload.Size = new System.Drawing.Size(118, 39);
            this.BtnDownload.TabIndex = 6;
            this.BtnDownload.Text = "Download";
            this.BtnDownload.UseVisualStyleBackColor = false;
            this.BtnDownload.Click += new System.EventHandler(this.BtnDownload_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpar.Location = new System.Drawing.Point(139, 144);
            this.BtnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(100, 39);
            this.BtnLimpar.TabIndex = 7;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = false;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // Sair
            // 
            this.Sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sair.Location = new System.Drawing.Point(247, 144);
            this.Sair.Margin = new System.Windows.Forms.Padding(4);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(100, 39);
            this.Sair.TabIndex = 8;
            this.Sair.Text = "Sair";
            this.Sair.UseVisualStyleBackColor = false;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // txtCaminho
            // 
            this.txtCaminho.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCaminho.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaminho.Location = new System.Drawing.Point(13, 94);
            this.txtCaminho.Margin = new System.Windows.Forms.Padding(4);
            this.txtCaminho.Multiline = true;
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(824, 42);
            this.txtCaminho.TabIndex = 9;
            // 
            // Avanco
            // 
            this.Avanco.Location = new System.Drawing.Point(13, 190);
            this.Avanco.Name = "Avanco";
            this.Avanco.Size = new System.Drawing.Size(951, 35);
            this.Avanco.TabIndex = 10;
            // 
            // frYoutube
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(991, 237);
            this.Controls.Add(this.Avanco);
            this.Controls.Add(this.txtCaminho);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnDownload);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.rdMp4);
            this.Controls.Add(this.rdMp3);
            this.Controls.Add(this.CmbQualidade);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.BtnMostrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frYoutube";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Youtube Versão1 DevJoel Portugal 2024 ©";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.ComboBox CmbQualidade;
        private System.Windows.Forms.RadioButton rdMp3;
        private System.Windows.Forms.RadioButton rdMp4;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnDownload;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.ProgressBar Avanco;
    }
}
