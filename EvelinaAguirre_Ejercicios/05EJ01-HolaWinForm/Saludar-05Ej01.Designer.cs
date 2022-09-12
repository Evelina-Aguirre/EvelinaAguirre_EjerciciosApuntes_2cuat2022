
namespace _05EJ01_HolaWinForm
{
    partial class Saludar_05Ej01
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
            this.lbl_fijo = new System.Windows.Forms.Label();
            this.lbl_saludoPersonalizado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_fijo
            // 
            this.lbl_fijo.AutoSize = true;
            this.lbl_fijo.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_fijo.Location = new System.Drawing.Point(145, 29);
            this.lbl_fijo.Name = "lbl_fijo";
            this.lbl_fijo.Size = new System.Drawing.Size(161, 25);
            this.lbl_fijo.TabIndex = 0;
            this.lbl_fijo.Text = "¡Hola Win Foms!";
            // 
            // lbl_saludoPersonalizado
            // 
            this.lbl_saludoPersonalizado.AutoSize = true;
            this.lbl_saludoPersonalizado.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_saludoPersonalizado.Location = new System.Drawing.Point(50, 70);
            this.lbl_saludoPersonalizado.Name = "lbl_saludoPersonalizado";
            this.lbl_saludoPersonalizado.Size = new System.Drawing.Size(161, 25);
            this.lbl_saludoPersonalizado.TabIndex = 1;
            this.lbl_saludoPersonalizado.Text = "¡Hola Win Foms!";
            // 
            // Saludar_05Ej01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 167);
            this.Controls.Add(this.lbl_saludoPersonalizado);
            this.Controls.Add(this.lbl_fijo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Saludar_05Ej01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saludo";
            this.Load += new System.EventHandler(this.Saludar_05Ej01_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_fijo;
        private System.Windows.Forms.Label lbl_saludoPersonalizado;
    }
}