namespace HallgatoFelvetel
{
    partial class MainForm
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
            this.hallgatókBeolvasásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hallgatókListájaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.időpontFoglalásokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hallgatókBeolvasásaToolStripMenuItem,
            this.hallgatókListájaToolStripMenuItem,
            this.időpontFoglalásokToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(772, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hallgatókBeolvasásaToolStripMenuItem
            // 
            this.hallgatókBeolvasásaToolStripMenuItem.Name = "hallgatókBeolvasásaToolStripMenuItem";
            this.hallgatókBeolvasásaToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.hallgatókBeolvasásaToolStripMenuItem.Text = "Hallgatók beolvasása";
            this.hallgatókBeolvasásaToolStripMenuItem.Click += new System.EventHandler(this.hallgatókBeolvasásaToolStripMenuItem_Click);
            // 
            // hallgatókListájaToolStripMenuItem
            // 
            this.hallgatókListájaToolStripMenuItem.Name = "hallgatókListájaToolStripMenuItem";
            this.hallgatókListájaToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.hallgatókListájaToolStripMenuItem.Text = "Hallgatók listája";
            this.hallgatókListájaToolStripMenuItem.Click += new System.EventHandler(this.hallgatókListájaToolStripMenuItem_Click);
            // 
            // időpontFoglalásokToolStripMenuItem
            // 
            this.időpontFoglalásokToolStripMenuItem.Name = "időpontFoglalásokToolStripMenuItem";
            this.időpontFoglalásokToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.időpontFoglalásokToolStripMenuItem.Text = "Időpont foglalások";
            this.időpontFoglalásokToolStripMenuItem.Click += new System.EventHandler(this.időpontFoglalásokToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 309);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hallgatókBeolvasásaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hallgatókListájaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem időpontFoglalásokToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

