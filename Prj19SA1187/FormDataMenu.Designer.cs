
namespace Prj19SA1187
{
    partial class FormDataMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDataMenu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btInputMenu = new System.Windows.Forms.ToolStripButton();
            this.btEditMenu = new System.Windows.Forms.ToolStripButton();
            this.btDeleteMenu = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtSearchMenu = new System.Windows.Forms.ToolStripTextBox();
            this.btSearchMenu = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdMenu = new System.Windows.Forms.TextBox();
            this.txtNmMenu = new System.Windows.Forms.TextBox();
            this.txtHrgBeli = new System.Windows.Forms.TextBox();
            this.txtHrgJual = new System.Windows.Forms.TextBox();
            this.txtStnMenu = new System.Windows.Forms.TextBox();
            this.txtStokMenu = new System.Windows.Forms.TextBox();
            this.dgvDataMenu = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btInputMenu,
            this.btEditMenu,
            this.btDeleteMenu,
            this.toolStripLabel1,
            this.txtSearchMenu,
            this.btSearchMenu});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(932, 67);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btInputMenu
            // 
            this.btInputMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btInputMenu.ForeColor = System.Drawing.Color.Black;
            this.btInputMenu.Image = ((System.Drawing.Image)(resources.GetObject("btInputMenu.Image")));
            this.btInputMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btInputMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btInputMenu.Name = "btInputMenu";
            this.btInputMenu.Size = new System.Drawing.Size(64, 64);
            this.btInputMenu.Text = "Masukan Menu";
            this.btInputMenu.Click += new System.EventHandler(this.btInputMenu_Click);
            // 
            // btEditMenu
            // 
            this.btEditMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btEditMenu.Image = ((System.Drawing.Image)(resources.GetObject("btEditMenu.Image")));
            this.btEditMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btEditMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btEditMenu.Name = "btEditMenu";
            this.btEditMenu.Size = new System.Drawing.Size(54, 64);
            this.btEditMenu.Text = "Edit Menu";
            this.btEditMenu.Click += new System.EventHandler(this.btEditMenu_Click);
            // 
            // btDeleteMenu
            // 
            this.btDeleteMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btDeleteMenu.Image = ((System.Drawing.Image)(resources.GetObject("btDeleteMenu.Image")));
            this.btDeleteMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btDeleteMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btDeleteMenu.Name = "btDeleteMenu";
            this.btDeleteMenu.Size = new System.Drawing.Size(64, 64);
            this.btDeleteMenu.Text = "Delete Menu";
            this.btDeleteMenu.Click += new System.EventHandler(this.btDeleteMenu_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(105, 64);
            this.toolStripLabel1.Text = "Search :";
            // 
            // txtSearchMenu
            // 
            this.txtSearchMenu.BackColor = System.Drawing.Color.White;
            this.txtSearchMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchMenu.Name = "txtSearchMenu";
            this.txtSearchMenu.Size = new System.Drawing.Size(250, 67);
            // 
            // btSearchMenu
            // 
            this.btSearchMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btSearchMenu.Image = ((System.Drawing.Image)(resources.GetObject("btSearchMenu.Image")));
            this.btSearchMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btSearchMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSearchMenu.Name = "btSearchMenu";
            this.btSearchMenu.Size = new System.Drawing.Size(64, 64);
            this.btSearchMenu.Text = "Cari";
            this.btSearchMenu.Click += new System.EventHandler(this.btSearchMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id Menu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama Menu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Harga Beli";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(503, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Harga Jual";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(503, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Satuan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(503, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Stok";
            // 
            // txtIdMenu
            // 
            this.txtIdMenu.Location = new System.Drawing.Point(194, 133);
            this.txtIdMenu.Name = "txtIdMenu";
            this.txtIdMenu.Size = new System.Drawing.Size(261, 27);
            this.txtIdMenu.TabIndex = 7;
            // 
            // txtNmMenu
            // 
            this.txtNmMenu.Location = new System.Drawing.Point(194, 204);
            this.txtNmMenu.Name = "txtNmMenu";
            this.txtNmMenu.Size = new System.Drawing.Size(261, 27);
            this.txtNmMenu.TabIndex = 8;
            // 
            // txtHrgBeli
            // 
            this.txtHrgBeli.Location = new System.Drawing.Point(194, 280);
            this.txtHrgBeli.Name = "txtHrgBeli";
            this.txtHrgBeli.Size = new System.Drawing.Size(261, 27);
            this.txtHrgBeli.TabIndex = 9;
            // 
            // txtHrgJual
            // 
            this.txtHrgJual.Location = new System.Drawing.Point(616, 138);
            this.txtHrgJual.Name = "txtHrgJual";
            this.txtHrgJual.Size = new System.Drawing.Size(261, 27);
            this.txtHrgJual.TabIndex = 10;
            // 
            // txtStnMenu
            // 
            this.txtStnMenu.Location = new System.Drawing.Point(616, 204);
            this.txtStnMenu.Name = "txtStnMenu";
            this.txtStnMenu.Size = new System.Drawing.Size(261, 27);
            this.txtStnMenu.TabIndex = 11;
            // 
            // txtStokMenu
            // 
            this.txtStokMenu.Location = new System.Drawing.Point(616, 283);
            this.txtStokMenu.Name = "txtStokMenu";
            this.txtStokMenu.Size = new System.Drawing.Size(261, 27);
            this.txtStokMenu.TabIndex = 12;
            // 
            // dgvDataMenu
            // 
            this.dgvDataMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataMenu.Location = new System.Drawing.Point(0, 410);
            this.dgvDataMenu.Name = "dgvDataMenu";
            this.dgvDataMenu.RowHeadersWidth = 51;
            this.dgvDataMenu.RowTemplate.Height = 29;
            this.dgvDataMenu.Size = new System.Drawing.Size(932, 178);
            this.dgvDataMenu.TabIndex = 13;
            // 
            // FormDataMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(932, 583);
            this.Controls.Add(this.dgvDataMenu);
            this.Controls.Add(this.txtStokMenu);
            this.Controls.Add(this.txtStnMenu);
            this.Controls.Add(this.txtHrgJual);
            this.Controls.Add(this.txtHrgBeli);
            this.Controls.Add(this.txtNmMenu);
            this.Controls.Add(this.txtIdMenu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormDataMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDataMenu";
            this.Load += new System.EventHandler(this.FormDataMenu_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btInputMenu;
        private System.Windows.Forms.ToolStripButton btEditMenu;
        private System.Windows.Forms.ToolStripButton btDeleteMenu;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtSearchMenu;
        private System.Windows.Forms.ToolStripButton btSearchMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdMenu;
        private System.Windows.Forms.TextBox txtNmMenu;
        private System.Windows.Forms.TextBox txtHrgBeli;
        private System.Windows.Forms.TextBox txtHrgJual;
        private System.Windows.Forms.TextBox txtStnMenu;
        private System.Windows.Forms.TextBox txtStokMenu;
        private System.Windows.Forms.DataGridView dgvDataMenu;
    }
}