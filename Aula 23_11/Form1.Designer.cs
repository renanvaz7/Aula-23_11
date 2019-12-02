namespace Aula_23_11
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel_header = new System.Windows.Forms.Panel();
            this.pictureBox_menu = new System.Windows.Forms.PictureBox();
            this.pictureBox_fechar = new System.Windows.Forms.PictureBox();
            this.pictureBox_minimizar = new System.Windows.Forms.PictureBox();
            this.pictureBox_restaurar = new System.Windows.Forms.PictureBox();
            this.pictureBox_maximizar = new System.Windows.Forms.PictureBox();
            this.panel_vertical = new System.Windows.Forms.Panel();
            this.btn_jogo = new System.Windows.Forms.Button();
            this.btn_historia = new System.Windows.Forms.Button();
            this.panel_conteudo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_fechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_maximizar)).BeginInit();
            this.panel_vertical.SuspendLayout();
            this.panel_conteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Controls.Add(this.panel_header);
            this.panel3.Controls.Add(this.panel_vertical);
            this.panel3.Controls.Add(this.panel_conteudo);
            this.panel3.Name = "panel3";
            // 
            // panel_header
            // 
            resources.ApplyResources(this.panel_header, "panel_header");
            this.panel_header.Controls.Add(this.pictureBox_menu);
            this.panel_header.Controls.Add(this.pictureBox_fechar);
            this.panel_header.Controls.Add(this.pictureBox_minimizar);
            this.panel_header.Controls.Add(this.pictureBox_restaurar);
            this.panel_header.Controls.Add(this.pictureBox_maximizar);
            this.panel_header.Name = "panel_header";
            this.panel_header.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_header_Paint);
            this.panel_header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mover);
            // 
            // pictureBox_menu
            // 
            resources.ApplyResources(this.pictureBox_menu, "pictureBox_menu");
            this.pictureBox_menu.Image = global::Aula_23_11.Properties.Resources.icons8_menu_50;
            this.pictureBox_menu.Name = "pictureBox_menu";
            this.pictureBox_menu.TabStop = false;
            this.pictureBox_menu.Click += new System.EventHandler(this.PictureBox_menu_Click_1);
            // 
            // pictureBox_fechar
            // 
            resources.ApplyResources(this.pictureBox_fechar, "pictureBox_fechar");
            this.pictureBox_fechar.Image = global::Aula_23_11.Properties.Resources.icons8_fechar_janela_32;
            this.pictureBox_fechar.Name = "pictureBox_fechar";
            this.pictureBox_fechar.TabStop = false;
            this.pictureBox_fechar.Click += new System.EventHandler(this.PictureBox_fechar_Click);
            // 
            // pictureBox_minimizar
            // 
            resources.ApplyResources(this.pictureBox_minimizar, "pictureBox_minimizar");
            this.pictureBox_minimizar.Image = global::Aula_23_11.Properties.Resources.icons8_minimize_window_32;
            this.pictureBox_minimizar.Name = "pictureBox_minimizar";
            this.pictureBox_minimizar.TabStop = false;
            this.pictureBox_minimizar.Click += new System.EventHandler(this.PictureBox_minimizar_Click);
            // 
            // pictureBox_restaurar
            // 
            resources.ApplyResources(this.pictureBox_restaurar, "pictureBox_restaurar");
            this.pictureBox_restaurar.Image = global::Aula_23_11.Properties.Resources.icons8_restaurar_janela_50;
            this.pictureBox_restaurar.Name = "pictureBox_restaurar";
            this.pictureBox_restaurar.TabStop = false;
            this.pictureBox_restaurar.Click += new System.EventHandler(this.PictureBox_restaurar_Click);
            // 
            // pictureBox_maximizar
            // 
            resources.ApplyResources(this.pictureBox_maximizar, "pictureBox_maximizar");
            this.pictureBox_maximizar.Image = global::Aula_23_11.Properties.Resources.icons8_maximize_window_32;
            this.pictureBox_maximizar.Name = "pictureBox_maximizar";
            this.pictureBox_maximizar.TabStop = false;
            this.pictureBox_maximizar.Click += new System.EventHandler(this.PictureBox_maximizar_Click);
            // 
            // panel_vertical
            // 
            resources.ApplyResources(this.panel_vertical, "panel_vertical");
            this.panel_vertical.BackColor = System.Drawing.Color.Salmon;
            this.panel_vertical.Controls.Add(this.btn_jogo);
            this.panel_vertical.Controls.Add(this.btn_historia);
            this.panel_vertical.Name = "panel_vertical";
            // 
            // btn_jogo
            // 
            resources.ApplyResources(this.btn_jogo, "btn_jogo");
            this.btn_jogo.FlatAppearance.BorderSize = 0;
            this.btn_jogo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_jogo.Image = global::Aula_23_11.Properties.Resources.jogo;
            this.btn_jogo.Name = "btn_jogo";
            this.btn_jogo.UseVisualStyleBackColor = true;
            this.btn_jogo.Click += new System.EventHandler(this.Btn_jogo_Click);
            // 
            // btn_historia
            // 
            resources.ApplyResources(this.btn_historia, "btn_historia");
            this.btn_historia.FlatAppearance.BorderSize = 0;
            this.btn_historia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_historia.Image = global::Aula_23_11.Properties.Resources.historia;
            this.btn_historia.Name = "btn_historia";
            this.btn_historia.UseVisualStyleBackColor = true;
            this.btn_historia.Click += new System.EventHandler(this.Btn_historia_Click);
            // 
            // panel_conteudo
            // 
            resources.ApplyResources(this.panel_conteudo, "panel_conteudo");
            this.panel_conteudo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_conteudo.Controls.Add(this.panel1);
            this.panel_conteudo.Controls.Add(this.pictureBox1);
            this.panel_conteudo.Name = "panel_conteudo";
            this.panel_conteudo.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_conteudo_Paint);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::Aula_23_11.Properties.Resources.play;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.panel3.ResumeLayout(false);
            this.panel_header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_fechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_maximizar)).EndInit();
            this.panel_vertical.ResumeLayout(false);
            this.panel_conteudo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel_conteudo;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.PictureBox pictureBox_fechar;
        private System.Windows.Forms.PictureBox pictureBox_minimizar;
        private System.Windows.Forms.PictureBox pictureBox_restaurar;
        private System.Windows.Forms.PictureBox pictureBox_maximizar;
        private System.Windows.Forms.Panel panel_vertical;
        private System.Windows.Forms.Button btn_historia;
        private System.Windows.Forms.Button btn_jogo;
        private System.Windows.Forms.PictureBox pictureBox_menu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}

