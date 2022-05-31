
namespace WFA_McAdam
{
    partial class Form1
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
            this.siparişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişYönetimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOluşturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekstraOluşturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişToolStripMenuItem,
            this.siparişYönetimToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1865, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // siparişToolStripMenuItem
            // 
            this.siparişToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.siparişToolStripMenuItem.Name = "siparişToolStripMenuItem";
            this.siparişToolStripMenuItem.Size = new System.Drawing.Size(182, 36);
            this.siparişToolStripMenuItem.Text = "Sipariş Oluştur";
            this.siparişToolStripMenuItem.Click += new System.EventHandler(this.siparişToolStripMenuItem_Click);
            // 
            // siparişYönetimToolStripMenuItem
            // 
            this.siparişYönetimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOluşturToolStripMenuItem,
            this.ekstraOluşturToolStripMenuItem,
            this.siparişlerToolStripMenuItem});
            this.siparişYönetimToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.siparişYönetimToolStripMenuItem.Name = "siparişYönetimToolStripMenuItem";
            this.siparişYönetimToolStripMenuItem.Size = new System.Drawing.Size(191, 36);
            this.siparişYönetimToolStripMenuItem.Text = "Sipariş Yönetim";
            // 
            // menuOluşturToolStripMenuItem
            // 
            this.menuOluşturToolStripMenuItem.Name = "menuOluşturToolStripMenuItem";
            this.menuOluşturToolStripMenuItem.Size = new System.Drawing.Size(250, 36);
            this.menuOluşturToolStripMenuItem.Text = "Menu Oluştur";
            this.menuOluşturToolStripMenuItem.Click += new System.EventHandler(this.menuOluşturToolStripMenuItem_Click);
            // 
            // ekstraOluşturToolStripMenuItem
            // 
            this.ekstraOluşturToolStripMenuItem.Name = "ekstraOluşturToolStripMenuItem";
            this.ekstraOluşturToolStripMenuItem.Size = new System.Drawing.Size(250, 36);
            this.ekstraOluşturToolStripMenuItem.Text = "Ekstra Oluştur";
            this.ekstraOluşturToolStripMenuItem.Click += new System.EventHandler(this.ekstraOluşturToolStripMenuItem_Click);
            // 
            // siparişlerToolStripMenuItem
            // 
            this.siparişlerToolStripMenuItem.Name = "siparişlerToolStripMenuItem";
            this.siparişlerToolStripMenuItem.Size = new System.Drawing.Size(250, 36);
            this.siparişlerToolStripMenuItem.Text = "Siparişler";
            this.siparişlerToolStripMenuItem.Click += new System.EventHandler(this.siparişlerToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1865, 969);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.ToolStripMenuItem siparişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişYönetimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuOluşturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekstraOluşturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişlerToolStripMenuItem;
    }
}

