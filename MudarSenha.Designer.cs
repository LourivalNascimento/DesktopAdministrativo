namespace DesktopAdministrativo
{
    partial class MudarSenha
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
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.labelData = new System.Windows.Forms.Label();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.labelQuantidade = new System.Windows.Forms.Label();
            this.textBoxNomeProduto = new System.Windows.Forms.TextBox();
            this.labelNomeProduto = new System.Windows.Forms.Label();
            this.textBoxNumOrdemDeProducao = new System.Windows.Forms.TextBox();
            this.labelCpf = new System.Windows.Forms.Label();
            this.labelNovaCadastro = new System.Windows.Forms.Label();
            this.pictureData = new System.Windows.Forms.PictureBox();
            this.pictureQuantidade = new System.Windows.Forms.PictureBox();
            this.pictureNomeProduto = new System.Windows.Forms.PictureBox();
            this.pictureNumOrdemDeProducao = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNomeProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNumOrdemDeProducao)).BeginInit();
            this.SuspendLayout();
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(232)))));
            this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(289, 240);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 17);
            this.maskedTextBox1.TabIndex = 67;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.labelData.Font = new System.Drawing.Font("Tw Cen MT", 15.75F);
            this.labelData.Location = new System.Drawing.Point(250, 206);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(53, 24);
            this.labelData.TabIndex = 65;
            this.labelData.Text = "Data";
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(232)))));
            this.textBoxQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxQuantidade.Font = new System.Drawing.Font("Tw Cen MT", 10F);
            this.textBoxQuantidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxQuantidade.Location = new System.Drawing.Point(38, 241);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(164, 15);
            this.textBoxQuantidade.TabIndex = 63;
            this.textBoxQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelQuantidade
            // 
            this.labelQuantidade.AutoSize = true;
            this.labelQuantidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.labelQuantidade.Font = new System.Drawing.Font("Tw Cen MT", 15.75F);
            this.labelQuantidade.Location = new System.Drawing.Point(33, 206);
            this.labelQuantidade.Name = "labelQuantidade";
            this.labelQuantidade.Size = new System.Drawing.Size(114, 24);
            this.labelQuantidade.TabIndex = 62;
            this.labelQuantidade.Text = "Quantidade";
            // 
            // textBoxNomeProduto
            // 
            this.textBoxNomeProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(232)))));
            this.textBoxNomeProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNomeProduto.Font = new System.Drawing.Font("Tw Cen MT", 10F);
            this.textBoxNomeProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxNomeProduto.Location = new System.Drawing.Point(37, 177);
            this.textBoxNomeProduto.Name = "textBoxNomeProduto";
            this.textBoxNomeProduto.Size = new System.Drawing.Size(382, 15);
            this.textBoxNomeProduto.TabIndex = 60;
            this.textBoxNomeProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelNomeProduto
            // 
            this.labelNomeProduto.AutoSize = true;
            this.labelNomeProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.labelNomeProduto.Font = new System.Drawing.Font("Tw Cen MT", 15.75F);
            this.labelNomeProduto.Location = new System.Drawing.Point(32, 142);
            this.labelNomeProduto.Name = "labelNomeProduto";
            this.labelNomeProduto.Size = new System.Drawing.Size(110, 24);
            this.labelNomeProduto.TabIndex = 59;
            this.labelNomeProduto.Text = "Nova senha";
            // 
            // textBoxNumOrdemDeProducao
            // 
            this.textBoxNumOrdemDeProducao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(232)))));
            this.textBoxNumOrdemDeProducao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNumOrdemDeProducao.Font = new System.Drawing.Font("Tw Cen MT", 10F);
            this.textBoxNumOrdemDeProducao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxNumOrdemDeProducao.Location = new System.Drawing.Point(38, 112);
            this.textBoxNumOrdemDeProducao.Name = "textBoxNumOrdemDeProducao";
            this.textBoxNumOrdemDeProducao.Size = new System.Drawing.Size(382, 15);
            this.textBoxNumOrdemDeProducao.TabIndex = 55;
            this.textBoxNumOrdemDeProducao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelCpf
            // 
            this.labelCpf.AutoSize = true;
            this.labelCpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.labelCpf.Font = new System.Drawing.Font("Tw Cen MT", 15.75F);
            this.labelCpf.Location = new System.Drawing.Point(33, 77);
            this.labelCpf.Name = "labelCpf";
            this.labelCpf.Size = new System.Drawing.Size(43, 24);
            this.labelCpf.TabIndex = 54;
            this.labelCpf.Text = "CPF";
            // 
            // labelNovaCadastro
            // 
            this.labelNovaCadastro.AutoSize = true;
            this.labelNovaCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.labelNovaCadastro.Font = new System.Drawing.Font("Tw Cen MT Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNovaCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(66)))), ((int)(((byte)(195)))));
            this.labelNovaCadastro.Location = new System.Drawing.Point(30, 15);
            this.labelNovaCadastro.Name = "labelNovaCadastro";
            this.labelNovaCadastro.Size = new System.Drawing.Size(192, 34);
            this.labelNovaCadastro.TabIndex = 53;
            this.labelNovaCadastro.Text = "NOVA CADASTRO";
            // 
            // pictureData
            // 
            this.pictureData.BackgroundImage = global::DesktopAdministrativo.Properties.Resources.fundo_branco;
            this.pictureData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureData.Location = new System.Drawing.Point(250, 233);
            this.pictureData.Name = "pictureData";
            this.pictureData.Size = new System.Drawing.Size(175, 30);
            this.pictureData.TabIndex = 66;
            this.pictureData.TabStop = false;
            // 
            // pictureQuantidade
            // 
            this.pictureQuantidade.BackgroundImage = global::DesktopAdministrativo.Properties.Resources.fundo_branco;
            this.pictureQuantidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureQuantidade.Location = new System.Drawing.Point(33, 233);
            this.pictureQuantidade.Name = "pictureQuantidade";
            this.pictureQuantidade.Size = new System.Drawing.Size(175, 30);
            this.pictureQuantidade.TabIndex = 64;
            this.pictureQuantidade.TabStop = false;
            // 
            // pictureNomeProduto
            // 
            this.pictureNomeProduto.BackgroundImage = global::DesktopAdministrativo.Properties.Resources.fundo_branco;
            this.pictureNomeProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureNomeProduto.Location = new System.Drawing.Point(32, 169);
            this.pictureNomeProduto.Name = "pictureNomeProduto";
            this.pictureNomeProduto.Size = new System.Drawing.Size(393, 30);
            this.pictureNomeProduto.TabIndex = 61;
            this.pictureNomeProduto.TabStop = false;
            // 
            // pictureNumOrdemDeProducao
            // 
            this.pictureNumOrdemDeProducao.BackgroundImage = global::DesktopAdministrativo.Properties.Resources.fundo_branco;
            this.pictureNumOrdemDeProducao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureNumOrdemDeProducao.Location = new System.Drawing.Point(33, 104);
            this.pictureNumOrdemDeProducao.Name = "pictureNumOrdemDeProducao";
            this.pictureNumOrdemDeProducao.Size = new System.Drawing.Size(393, 30);
            this.pictureNumOrdemDeProducao.TabIndex = 56;
            this.pictureNumOrdemDeProducao.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackgroundImage = global::DesktopAdministrativo.Properties.Resources.botão_cancelar_vermelho;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(200, 297);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 32);
            this.btnCancelar.TabIndex = 58;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.BackgroundImage = global::DesktopAdministrativo.Properties.Resources.botão_salvar;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(325, 297);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(121, 32);
            this.btnSalvar.TabIndex = 57;
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // MudarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Violet;
            this.ClientSize = new System.Drawing.Size(455, 343);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.pictureData);
            this.Controls.Add(this.textBoxQuantidade);
            this.Controls.Add(this.labelQuantidade);
            this.Controls.Add(this.pictureQuantidade);
            this.Controls.Add(this.textBoxNomeProduto);
            this.Controls.Add(this.labelNomeProduto);
            this.Controls.Add(this.pictureNomeProduto);
            this.Controls.Add(this.textBoxNumOrdemDeProducao);
            this.Controls.Add(this.labelCpf);
            this.Controls.Add(this.labelNovaCadastro);
            this.Controls.Add(this.pictureNumOrdemDeProducao);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MudarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MudarSenha";
            ((System.ComponentModel.ISupportInitialize)(this.pictureData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNomeProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNumOrdemDeProducao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.PictureBox pictureData;
        private System.Windows.Forms.TextBox textBoxQuantidade;
        private System.Windows.Forms.Label labelQuantidade;
        private System.Windows.Forms.PictureBox pictureQuantidade;
        private System.Windows.Forms.TextBox textBoxNomeProduto;
        private System.Windows.Forms.Label labelNomeProduto;
        private System.Windows.Forms.PictureBox pictureNomeProduto;
        private System.Windows.Forms.TextBox textBoxNumOrdemDeProducao;
        private System.Windows.Forms.Label labelCpf;
        private System.Windows.Forms.Label labelNovaCadastro;
        private System.Windows.Forms.PictureBox pictureNumOrdemDeProducao;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
    }
}