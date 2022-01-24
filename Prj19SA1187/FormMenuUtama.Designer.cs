
namespace Prj19SA1187
{
    partial class FormMenuUtama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuUtama));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.btAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.btCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.btMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btTransaksi = new System.Windows.Forms.ToolStripMenuItem();
            this.btLaporan = new System.Windows.Forms.ToolStripMenuItem();
            this.btKeluar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btAdmin,
            this.btCustomer,
            this.btMenu,
            this.btTransaksi,
            this.btLaporan,
            this.btKeluar});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1006, 72);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // btAdmin
            // 
            this.btAdmin.BackColor = System.Drawing.Color.Transparent;
            this.btAdmin.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btAdmin.ForeColor = System.Drawing.Color.White;
            this.btAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btAdmin.Image")));
            this.btAdmin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btAdmin.Name = "btAdmin";
            this.btAdmin.Size = new System.Drawing.Size(140, 68);
            this.btAdmin.Text = "Admin";
            this.btAdmin.Click += new System.EventHandler(this.btAdmin_Click_1);
            // 
            // btCustomer
            // 
            this.btCustomer.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCustomer.ForeColor = System.Drawing.Color.White;
            this.btCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btCustomer.Image")));
            this.btCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btCustomer.Name = "btCustomer";
            this.btCustomer.Size = new System.Drawing.Size(178, 68);
            this.btCustomer.Text = "Custemer";
            this.btCustomer.Click += new System.EventHandler(this.btCustomer_Click);
            // 
            // btMenu
            // 
            this.btMenu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btMenu.ForeColor = System.Drawing.Color.White;
            this.btMenu.Image = ((System.Drawing.Image)(resources.GetObject("btMenu.Image")));
            this.btMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btMenu.Name = "btMenu";
            this.btMenu.Size = new System.Drawing.Size(129, 68);
            this.btMenu.Text = "Menu";
            this.btMenu.Click += new System.EventHandler(this.btMenu_Click);
            // 
            // btTransaksi
            // 
            this.btTransaksi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btTransaksi.ForeColor = System.Drawing.Color.White;
            this.btTransaksi.Image = ((System.Drawing.Image)(resources.GetObject("btTransaksi.Image")));
            this.btTransaksi.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btTransaksi.Name = "btTransaksi";
            this.btTransaksi.Size = new System.Drawing.Size(179, 68);
            this.btTransaksi.Text = "Transaksi";
            this.btTransaksi.Click += new System.EventHandler(this.btTransaksi_Click);
            // 
            // btLaporan
            // 
            this.btLaporan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btLaporan.ForeColor = System.Drawing.Color.White;
            this.btLaporan.Image = ((System.Drawing.Image)(resources.GetObject("btLaporan.Image")));
            this.btLaporan.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btLaporan.Name = "btLaporan";
            this.btLaporan.Size = new System.Drawing.Size(163, 68);
            this.btLaporan.Text = "Laporan";
            this.btLaporan.Click += new System.EventHandler(this.btLaporan_Click);
            // 
            // btKeluar
            // 
            this.btKeluar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btKeluar.ForeColor = System.Drawing.Color.White;
            this.btKeluar.Image = ((System.Drawing.Image)(resources.GetObject("btKeluar.Image")));
            this.btKeluar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btKeluar.Name = "btKeluar";
            this.btKeluar.Size = new System.Drawing.Size(152, 68);
            this.btKeluar.Text = "Keluar";
            this.btKeluar.Click += new System.EventHandler(this.btKeluar_Click);
            // 
            // FormMenuUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.menuStrip2);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FormMenuUtama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenuUtama";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem btAdmin;
        private System.Windows.Forms.ToolStripMenuItem btCustomer;
        private System.Windows.Forms.ToolStripMenuItem btMenu;
        private System.Windows.Forms.ToolStripMenuItem btTransaksi;
        private System.Windows.Forms.ToolStripMenuItem btLaporan;
        private System.Windows.Forms.ToolStripMenuItem btKeluar;
    }
}