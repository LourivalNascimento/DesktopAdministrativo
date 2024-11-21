namespace DesktopAdministrativo
{
    partial class TelaComprasAcompanhamento
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
            this.btnMenu = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureLogoMorangolandia = new System.Windows.Forms.PictureBox();
            this.btnEsc = new System.Windows.Forms.Button();
            this.pictureTop = new System.Windows.Forms.PictureBox();
            this.labelNomeFuncionario = new System.Windows.Forms.Label();
            this.labelAcompanhamentoCompras = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.panelResultado = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogoMorangolandia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTop)).BeginInit();
            this.SuspendLayout();
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
            this.btnMenu.TabIndex = 14;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnMenu_MouseClick);
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
            this.pictureBox2.TabIndex = 13;
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
            this.pictureLogoMorangolandia.TabIndex = 12;
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
            this.btnEsc.TabIndex = 10;
            this.btnEsc.UseVisualStyleBackColor = false;
            this.btnEsc.Click += new System.EventHandler(this.btnEsc_Click);
            // 
            // pictureTop
            // 
            this.pictureTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(66)))), ((int)(((byte)(195)))));
            this.pictureTop.Location = new System.Drawing.Point(-37, -2);
            this.pictureTop.Name = "pictureTop";
            this.pictureTop.Size = new System.Drawing.Size(1367, 63);
            this.pictureTop.TabIndex = 11;
            this.pictureTop.TabStop = false;
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
            this.labelNomeFuncionario.TabIndex = 15;
            this.labelNomeFuncionario.Text = "Olá, Beatriz!";
            // 
            // labelAcompanhamentoCompras
            // 
            this.labelAcompanhamentoCompras.AutoSize = true;
            this.labelAcompanhamentoCompras.Font = new System.Drawing.Font("Tw Cen MT Condensed", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAcompanhamentoCompras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(66)))), ((int)(((byte)(195)))));
            this.labelAcompanhamentoCompras.Location = new System.Drawing.Point(35, 70);
            this.labelAcompanhamentoCompras.Name = "labelAcompanhamentoCompras";
            this.labelAcompanhamentoCompras.Size = new System.Drawing.Size(437, 41);
            this.labelAcompanhamentoCompras.TabIndex = 16;
            this.labelAcompanhamentoCompras.Text = "ACOMPANHAMENTO DE COMPRAS";
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.AutoSize = true;
            this.btnNovo.BackColor = System.Drawing.Color.Transparent;
            this.btnNovo.BackgroundImage = global::DesktopAdministrativo.Properties.Resources.botão_novo;
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Location = new System.Drawing.Point(1095, 622);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(140, 40);
            this.btnNovo.TabIndex = 18;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // panelResultado
            // 
            this.panelResultado.Location = new System.Drawing.Point(42, 156);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(1173, 442);
            this.panelResultado.TabIndex = 19;
            // 
            // TelaComprasAcompanhamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.labelAcompanhamentoCompras);
            this.Controls.Add(this.labelNomeFuncionario);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureLogoMorangolandia);
            this.Controls.Add(this.btnEsc);
            this.Controls.Add(this.pictureTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "TelaComprasAcompanhamento";
            this.Text = "TelaComprasAcompanhamento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TelaComprasAcompanhamento_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TelaComprasAcompanhamento_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogoMorangolandia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureLogoMorangolandia;
        private System.Windows.Forms.Button btnEsc;
        private System.Windows.Forms.PictureBox pictureTop;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label labelNomeFuncionario;
        private System.Windows.Forms.Label labelAcompanhamentoCompras;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Panel panelResultado;
    }
}