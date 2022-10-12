
namespace E_Automotriz_1
{
    partial class FmrMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.producto = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientas = new System.Windows.Forms.ToolStripMenuItem();
            this.mas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.producto,
            this.herramientas,
            this.mas});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(126, 409);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // producto
            // 
            this.producto.Name = "producto";
            this.producto.Size = new System.Drawing.Size(113, 19);
            this.producto.Text = "Productos";
            this.producto.Click += new System.EventHandler(this.producto_Click);
            // 
            // herramientas
            // 
            this.herramientas.Name = "herramientas";
            this.herramientas.Size = new System.Drawing.Size(113, 19);
            this.herramientas.Text = "Herramientas";
            this.herramientas.Click += new System.EventHandler(this.herramientas_Click);
            // 
            // mas
            // 
            this.mas.Name = "mas";
            this.mas.Size = new System.Drawing.Size(113, 19);
            this.mas.Text = "...";
            // 
            // FmrMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 409);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FmrMenu";
            this.Text = "FmrMenu";
            this.Load += new System.EventHandler(this.FmrMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem producto;
        private System.Windows.Forms.ToolStripMenuItem herramientas;
        private System.Windows.Forms.ToolStripMenuItem mas;
    }
}