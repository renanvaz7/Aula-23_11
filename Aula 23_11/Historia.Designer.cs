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
            this.label_historia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_historia
            // 
            this.label_historia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_historia.AutoSize = true;
            this.label_historia.Font = new System.Drawing.Font("Press Start 2P", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_historia.Location = new System.Drawing.Point(288, 129);
            this.label_historia.Name = "label_historia";
            this.label_historia.Size = new System.Drawing.Size(169, 19);
            this.label_historia.TabIndex = 0;
            this.label_historia.Text = "História";
            this.label_historia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Historia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 563);
            this.Controls.Add(this.label_historia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Historia";
            this.Text = "Historia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_historia;
    }
}