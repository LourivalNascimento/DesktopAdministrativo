namespace DesktopAdministrativo
{
    partial class TelaOrdemDeProducao
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
            this.labelNomeFuncionario = new System.Windows.Forms.Label();
            this.panelCadastroDadosCompra = new System.Windows.Forms.Panel();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.groupBoxStatusOp = new System.Windows.Forms.GroupBox();
            this.radioBtnEmProducao = new System.Windows.Forms.RadioButton();
            this.radioBtnEmFila = new System.Windows.Forms.RadioButton();
            this.labelStatus = new System.Windows.Forms.Label();
            this.textBoxNumOrdemProducao = new System.Windows.Forms.TextBox();
            this.pictureNumOrdemProducao = new System.Windows.Forms.PictureBox();
            this.labelNumOrdemProducao = new System.Windows.Forms.Label();
            this.labelOrdemDeProducao = new System.Windows.Forms.Label();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureLogoMorangolandia = new System.Windows.Forms.PictureBox();
            this.btnEsc = new System.Windows.Forms.Button();
            this.pictureTop = new System.Windows.Forms.PictureBox();
            this.panelCadastroDadosCompra.SuspendLayout();
            this.groupBoxStatusOp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNumOrdemProducao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogoMorangolandia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTop)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNomeFuncionario
            // 
            this.labelNomeFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNomeFuncionario.AutoEllipsis = true;
            this.labelNomeFuncionario.AutoSize = true;
            this.labelNomeFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(66)))), ((int)(((byte)(195)))));
            this.labelNomeFuncionario.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeFuncionario.ForeColor = System.Drawing.Color.White;
            this.labelNomeFuncionario.Location = new System.Drawing.Point(990, 19);
            this.labelNomeFuncionario.Name = "labelNomeFuncionario";
            this.labelNomeFuncionario.Size = new System.Drawing.Size(120, 24);
            this.labelNomeFuncionario.TabIndex = 37;
            this.labelNomeFuncionario.Text = "Olá, Beatriz!";
            // 
            // panelCadastroDadosCompra
            // 
            this.panelCadastroDadosCompra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCadastroDadosCompra.AutoSize = true;
            this.panelCadastroDadosCompra.Controls.Add(this.btnFiltrar);
            this.panelCadastroDadosCompra.Controls.Add(this.groupBoxStatusOp);
            this.panelCadastroDadosCompra.Controls.Add(this.labelStatus);
            this.panelCadastroDadosCompra.Controls.Add(this.textBoxNumOrdemProducao);
            this.panelCadastroDadosCompra.Controls.Add(this.pictureNumOrdemProducao);
            this.panelCadastroDadosCompra.Controls.Add(this.labelNumOrdemProducao);
            this.panelCadastroDadosCompra.Location = new System.Drawing.Point(55, 129);
            this.panelCadastroDadosCompra.Name = "panelCadastroDadosCompra";
            this.panelCadastroDadosCompra.Size = new System.Drawing.Size(1194, 138);
            this.panelCadastroDadosCompra.TabIndex = 54;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFiltrar.BackgroundImage = global::DesktopAdministrativo.Properties.Resources.botão_filtrar;
            this.btnFiltrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Location = new System.Drawing.Point(1057, 97);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(130, 32);
            this.btnFiltrar.TabIndex = 87;
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // groupBoxStatusOp
            // 
            this.groupBoxStatusOp.Controls.Add(this.radioBtnEmProducao);
            this.groupBoxStatusOp.Controls.Add(this.radioBtnEmFila);
            this.groupBoxStatusOp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxStatusOp.Location = new System.Drawing.Point(116, 3);
            this.groupBoxStatusOp.Name = "groupBoxStatusOp";
            this.groupBoxStatusOp.Size = new System.Drawing.Size(193, 42);
            this.groupBoxStatusOp.TabIndex = 47;
            this.groupBoxStatusOp.TabStop = false;
            // 
            // radioBtnEmProducao
            // 
            this.radioBtnEmProducao.AutoSize = true;
            this.radioBtnEmProducao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioBtnEmProducao.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.radioBtnEmProducao.Location = new System.Drawing.Point(73, 7);
            this.radioBtnEmProducao.Name = "radioBtnEmProducao";
            this.radioBtnEmProducao.Size = new System.Drawing.Size(110, 23);
            this.radioBtnEmProducao.TabIndex = 1;
            this.radioBtnEmProducao.Text = "Em produção";
            this.radioBtnEmProducao.UseVisualStyleBackColor = true;
            this.radioBtnEmProducao.CheckedChanged += new System.EventHandler(this.radioBtnEmProducao_CheckedChanged);
            // 
            // radioBtnEmFila
            // 
            this.radioBtnEmFila.AutoSize = true;
            this.radioBtnEmFila.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioBtnEmFila.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.radioBtnEmFila.Location = new System.Drawing.Point(6, 7);
            this.radioBtnEmFila.Name = "radioBtnEmFila";
            this.radioBtnEmFila.Size = new System.Drawing.Size(69, 23);
            this.radioBtnEmFila.TabIndex = 0;
            this.radioBtnEmFila.Text = "Em fila";
            this.radioBtnEmFila.UseVisualStyleBackColor = true;
            this.radioBtnEmFila.CheckedChanged += new System.EventHandler(this.radioBtnEmFila_CheckedChanged);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.labelStatus.Location = new System.Drawing.Point(70, 11);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(50, 19);
            this.labelStatus.TabIndex = 46;
            this.labelStatus.Text = "Status:";
            // 
            // textBoxNumOrdemProducao
            // 
            this.textBoxNumOrdemProducao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.textBoxNumOrdemProducao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNumOrdemProducao.Font = new System.Drawing.Font("Tw Cen MT", 11.25F);
            this.textBoxNumOrdemProducao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxNumOrdemProducao.Location = new System.Drawing.Point(127, 55);
            this.textBoxNumOrdemProducao.Name = "textBoxNumOrdemProducao";
            this.textBoxNumOrdemProducao.Size = new System.Drawing.Size(143, 17);
            this.textBoxNumOrdemProducao.TabIndex = 34;
            // 
            // pictureNumOrdemProducao
            // 
            this.pictureNumOrdemProducao.BackgroundImage = global::DesktopAdministrativo.Properties.Resources.n_nota;
            this.pictureNumOrdemProducao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureNumOrdemProducao.Location = new System.Drawing.Point(122, 51);
            this.pictureNumOrdemProducao.Name = "pictureNumOrdemProducao";
            this.pictureNumOrdemProducao.Size = new System.Drawing.Size(152, 24);
            this.pictureNumOrdemProducao.TabIndex = 33;
            this.pictureNumOrdemProducao.TabStop = false;
            // 
            // labelNumOrdemProducao
            // 
            this.labelNumOrdemProducao.AutoSize = true;
            this.labelNumOrdemProducao.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.labelNumOrdemProducao.Location = new System.Drawing.Point(59, 52);
            this.labelNumOrdemProducao.Name = "labelNumOrdemProducao";
            this.labelNumOrdemProducao.Size = new System.Drawing.Size(61, 19);
            this.labelNumOrdemProducao.TabIndex = 27;
            this.labelNumOrdemProducao.Text = "Nº O.P.:";
            // 
            // labelOrdemDeProducao
            // 
            this.labelOrdemDeProducao.AutoSize = true;
            this.labelOrdemDeProducao.Font = new System.Drawing.Font("Tw Cen MT Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrdemDeProducao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(66)))), ((int)(((byte)(195)))));
            this.labelOrdemDeProducao.Location = new System.Drawing.Point(61, 89);
            this.labelOrdemDeProducao.Name = "labelOrdemDeProducao";
            this.labelOrdemDeProducao.Size = new System.Drawing.Size(267, 38);
            this.labelOrdemDeProducao.TabIndex = 56;
            this.labelOrdemDeProducao.Text = "ORDEM DE PRODUÇÃO";
            // 
            // panelResultado
            // 
            this.panelResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelResultado.Location = new System.Drawing.Point(54, 273);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(1193, 310);
            this.panelResultado.TabIndex = 55;
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.BackgroundImage = global::DesktopAdministrativo.Properties.Resources.botão_novo;
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Location = new System.Drawing.Point(1112, 629);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(140, 40);
            this.btnNovo.TabIndex = 88;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(66)))), ((int)(((byte)(195)))));
            this.btnMenu.BackgroundImage = global::DesktopAdministrativo.Properties.Resources.menu;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(66)))), ((int)(((byte)(195)))));
            this.btnMenu.Location = new System.Drawing.Point(33, 14);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(51, 32);
            this.btnMenu.TabIndex = 36;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(66)))), ((int)(((byte)(195)))));
            this.pictureBox2.BackgroundImage = global::DesktopAdministrativo.Properties.Resources.foto_perfil;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(1136, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 49);
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // pictureLogoMorangolandia
            // 
            this.pictureLogoMorangolandia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(66)))), ((int)(((byte)(195)))));
            this.pictureLogoMorangolandia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureLogoMorangolandia.Image = global::DesktopAdministrativo.Properties.Resources.logo_branca;
            this.pictureLogoMorangolandia.Location = new System.Drawing.Point(118, 3);
            this.pictureLogoMorangolandia.Name = "pictureLogoMorangolandia";
            this.pictureLogoMorangolandia.Size = new System.Drawing.Size(100, 54);
            this.pictureLogoMorangolandia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogoMorangolandia.TabIndex = 34;
            this.pictureLogoMorangolandia.TabStop = false;
            // 
            // btnEsc
            // 
            this.btnEsc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEsc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(66)))), ((int)(((byte)(195)))));
            this.btnEsc.BackgroundImage = global::DesktopAdministrativo.Properties.Resources.esc;
            this.btnEsc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEsc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEsc.FlatAppearance.BorderSize = 0;
            this.btnEsc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEsc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(66)))), ((int)(((byte)(195)))));
            this.btnEsc.Location = new System.Drawing.Point(1195, 13);
            this.btnEsc.Name = "btnEsc";
            this.btnEsc.Size = new System.Drawing.Size(36, 32);
            this.btnEsc.TabIndex = 33;
            this.btnEsc.UseVisualStyleBackColor = false;
            this.btnEsc.Click += new System.EventHandler(this.btnEsc_Click);
            // 
            // pictureTop
            // 
            this.pictureTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(66)))), ((int)(((byte)(195)))));
            this.pictureTop.Location = new System.Drawing.Point(-32, -2);
            this.pictureTop.Name = "pictureTop";
            this.pictureTop.Size = new System.Drawing.Size(1232, 63);
            this.pictureTop.TabIndex = 32;
            this.pictureTop.TabStop = false;
            // 
            // TelaOrdemDeProducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.panelCadastroDadosCompra);
            this.Controls.Add(this.labelOrdemDeProducao);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.labelNomeFuncionario);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureLogoMorangolandia);
            this.Controls.Add(this.btnEsc);
            this.Controls.Add(this.pictureTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "TelaOrdemDeProducao";
            this.Text = "TelaOrdemDeProducaoEmFila";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TelaOrdemDeProducaoEmFila_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TelaOrdemDeProducaoEmFila_MouseClick);
            this.panelCadastroDadosCompra.ResumeLayout(false);
            this.panelCadastroDadosCompra.PerformLayout();
            this.groupBoxStatusOp.ResumeLayout(false);
            this.groupBoxStatusOp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNumOrdemProducao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogoMorangolandia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureLogoMorangolandia;
        private System.Windows.Forms.Button btnEsc;
        private System.Windows.Forms.PictureBox pictureTop;
        private System.Windows.Forms.Label labelNomeFuncionario;
        private System.Windows.Forms.Panel panelCadastroDadosCompra;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.GroupBox groupBoxStatusOp;
        private System.Windows.Forms.RadioButton radioBtnEmProducao;
        private System.Windows.Forms.RadioButton radioBtnEmFila;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBoxNumOrdemProducao;
        private System.Windows.Forms.PictureBox pictureNumOrdemProducao;
        private System.Windows.Forms.Label labelNumOrdemProducao;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label labelOrdemDeProducao;
        private System.Windows.Forms.Panel panelResultado;
    }
}