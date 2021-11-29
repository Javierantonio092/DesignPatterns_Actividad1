
namespace DesingPattern_Singleton
{
    partial class menuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ventana1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventana1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ventana2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventana1ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(827, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ventana1ToolStripMenuItem
            // 
            this.ventana1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventana1ToolStripMenuItem1,
            this.ventana2ToolStripMenuItem});
            this.ventana1ToolStripMenuItem.Name = "ventana1ToolStripMenuItem";
            this.ventana1ToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.ventana1ToolStripMenuItem.Text = "Opciones";
            this.ventana1ToolStripMenuItem.Click += new System.EventHandler(this.ventana1ToolStripMenuItem_Click);
            // 
            // ventana1ToolStripMenuItem1
            // 
            this.ventana1ToolStripMenuItem1.Name = "ventana1ToolStripMenuItem1";
            this.ventana1ToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.ventana1ToolStripMenuItem1.Text = "Ventana Azul";
            this.ventana1ToolStripMenuItem1.Click += new System.EventHandler(this.ventana1ToolStripMenuItem1_Click);
            // 
            // ventana2ToolStripMenuItem
            // 
            this.ventana2ToolStripMenuItem.Name = "ventana2ToolStripMenuItem";
            this.ventana2ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.ventana2ToolStripMenuItem.Text = "Ventana Verde";
            this.ventana2ToolStripMenuItem.Click += new System.EventHandler(this.ventana2ToolStripMenuItem_Click);
            // 
            // menuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 465);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menuPrincipal";
            this.Text = "Menú Principal";
            this.Load += new System.EventHandler(this.menuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ventana1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventana1ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ventana2ToolStripMenuItem;
    }
}

