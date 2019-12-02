namespace Aula_23_11
{
    partial class Historia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historia));
            this.label_título = new System.Windows.Forms.Label();
            this.label_texto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_título
            // 
            this.label_título.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_título.AutoSize = true;
            this.label_título.Font = new System.Drawing.Font("Press Start 2P", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_título.Location = new System.Drawing.Point(258, 81);
            this.label_título.Name = "label_título";
            this.label_título.Size = new System.Drawing.Size(169, 19);
            this.label_título.TabIndex = 0;
            this.label_título.Text = "História";
            this.label_título.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_texto
            // 
            this.label_texto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_texto.AutoSize = true;
            this.label_texto.Font = new System.Drawing.Font("Press Start 2P", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_texto.Location = new System.Drawing.Point(65, 192);
            this.label_texto.Name = "label_texto";
            this.label_texto.Size = new System.Drawing.Size(599, 120);
            this.label_texto.TabIndex = 1;
            this.label_texto.Text = resources.GetString("label_texto.Text");
            this.label_texto.Click += new System.EventHandler(this.Label_texto_Click);
            // 
            // Historia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(734, 505);
            this.Controls.Add(this.label_texto);
            this.Controls.Add(this.label_título);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Historia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Historia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_título;
        private System.Windows.Forms.Label label_texto;
    }
}