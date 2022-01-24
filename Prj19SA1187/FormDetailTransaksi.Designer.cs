
namespace Prj19SA1187
{
    partial class FormDetailTransaksi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHrgBeli = new System.Windows.Forms.TextBox();
            this.txtHrgJual = new System.Windows.Forms.TextBox();
            this.txtJumlahSatuan = new System.Windows.Forms.TextBox();
            this.btInput = new System.Windows.Forms.Button();
            this.brDelete = new System.Windows.Forms.Button();
            this.dgvDetailTransaksi = new System.Windows.Forms.DataGridView();
            this.cbIdTransaksi = new System.Windows.Forms.ComboBox();
            this.cbIdMenu = new System.Windows.Forms.ComboBox();
            this.brEdit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailTransaksi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(75, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Transaksi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(75, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id Menu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(75, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Harga Beli";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(75, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Harga Jual";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(75, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Jumlah Jual";
            // 
            // txtHrgBeli
            // 
            this.txtHrgBeli.Location = new System.Drawing.Point(208, 210);
            this.txtHrgBeli.Name = "txtHrgBeli";
            this.txtHrgBeli.Size = new System.Drawing.Size(205, 27);
            this.txtHrgBeli.TabIndex = 7;
            // 
            // txtHrgJual
            // 
            this.txtHrgJual.Location = new System.Drawing.Point(208, 261);
            this.txtHrgJual.Name = "txtHrgJual";
            this.txtHrgJual.Size = new System.Drawing.Size(205, 27);
            this.txtHrgJual.TabIndex = 8;
            // 
            // txtJumlahSatuan
            // 
            this.txtJumlahSatuan.Location = new System.Drawing.Point(208, 311);
            this.txtJumlahSatuan.Name = "txtJumlahSatuan";
            this.txtJumlahSatuan.Size = new System.Drawing.Size(205, 27);
            this.txtJumlahSatuan.TabIndex = 9;
            // 
            // btInput
            // 
            this.btInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btInput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btInput.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btInput.ForeColor = System.Drawing.Color.White;
            this.btInput.Location = new System.Drawing.Point(478, 103);
            this.btInput.Name = "btInput";
            this.btInput.Size = new System.Drawing.Size(113, 44);
            this.btInput.TabIndex = 10;
            this.btInput.Text = "Input";
            this.btInput.UseVisualStyleBackColor = false;
            this.btInput.Click += new System.EventHandler(this.btInput_Click);
            // 
            // brDelete
            // 
            this.brDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.brDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.brDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.brDelete.ForeColor = System.Drawing.Color.White;
            this.brDelete.Location = new System.Drawing.Point(478, 291);
            this.brDelete.Name = "brDelete";
            this.brDelete.Size = new System.Drawing.Size(113, 44);
            this.brDelete.TabIndex = 11;
            this.brDelete.Text = "Detele";
            this.brDelete.UseVisualStyleBackColor = false;
            this.brDelete.Click += new System.EventHandler(this.brDelete_Click);
            // 
            // dgvDetailTransaksi
            // 
            this.dgvDetailTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailTransaksi.Location = new System.Drawing.Point(1, 380);
            this.dgvDetailTransaksi.Name = "dgvDetailTransaksi";
            this.dgvDetailTransaksi.RowHeadersWidth = 51;
            this.dgvDetailTransaksi.RowTemplate.Height = 29;
            this.dgvDetailTransaksi.Size = new System.Drawing.Size(930, 204);
            this.dgvDetailTransaksi.TabIndex = 12;
            // 
            // cbIdTransaksi
            // 
            this.cbIdTransaksi.FormattingEnabled = true;
            this.cbIdTransaksi.Location = new System.Drawing.Point(208, 101);
            this.cbIdTransaksi.Name = "cbIdTransaksi";
            this.cbIdTransaksi.Size = new System.Drawing.Size(205, 28);
            this.cbIdTransaksi.TabIndex = 13;
            // 
            // cbIdMenu
            // 
            this.cbIdMenu.FormattingEnabled = true;
            this.cbIdMenu.Location = new System.Drawing.Point(208, 156);
            this.cbIdMenu.Name = "cbIdMenu";
            this.cbIdMenu.Size = new System.Drawing.Size(205, 28);
            this.cbIdMenu.TabIndex = 14;
            this.cbIdMenu.SelectedIndexChanged += new System.EventHandler(this.cbIdMenu_SelectedIndexChanged);
            // 
            // brEdit
            // 
            this.brEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.brEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.brEdit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.brEdit.ForeColor = System.Drawing.Color.White;
            this.brEdit.Location = new System.Drawing.Point(478, 199);
            this.brEdit.Name = "brEdit";
            this.brEdit.Size = new System.Drawing.Size(113, 44);
            this.brEdit.TabIndex = 15;
            this.brEdit.Text = "EDIT";
            this.brEdit.UseVisualStyleBackColor = false;
            this.brEdit.Click += new System.EventHandler(this.brEdit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(266, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(378, 34);
            this.label6.TabIndex = 16;
            this.label6.Text = "DATA DETAIL TRANSAKSI";
            // 
            // FormDetailTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(932, 583);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.brEdit);
            this.Controls.Add(this.cbIdMenu);
            this.Controls.Add(this.cbIdTransaksi);
            this.Controls.Add(this.dgvDetailTransaksi);
            this.Controls.Add(this.brDelete);
            this.Controls.Add(this.btInput);
            this.Controls.Add(this.txtJumlahSatuan);
            this.Controls.Add(this.txtHrgJual);
            this.Controls.Add(this.txtHrgBeli);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDetailTransaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDetailTransaksi";
            this.Load += new System.EventHandler(this.FormDetailTransaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailTransaksi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHrgBeli;
        private System.Windows.Forms.TextBox txtHrgJual;
        private System.Windows.Forms.TextBox txtJumlahSatuan;
        private System.Windows.Forms.Button btInput;
        private System.Windows.Forms.Button brDelete;
        private System.Windows.Forms.DataGridView dgvDetailTransaksi;
        private System.Windows.Forms.ComboBox cbIdTransaksi;
        private System.Windows.Forms.ComboBox cbIdMenu;
        private System.Windows.Forms.Button brEdit;
        private System.Windows.Forms.Label label6;
    }
}