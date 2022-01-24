
namespace Prj19SA1187
{
    partial class FormDataTransaksi
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
            this.txtIdTransaksi = new System.Windows.Forms.TextBox();
            this.txtTglTransaksi = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.btInputTransaksi = new System.Windows.Forms.Button();
            this.btEditTransaksi = new System.Windows.Forms.Button();
            this.brDeleteTransaksi = new System.Windows.Forms.Button();
            this.cbIdCustomer = new System.Windows.Forms.ComboBox();
            this.dgvDataTransaksi = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataTransaksi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 105);
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
            this.label2.Location = new System.Drawing.Point(72, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tanggal Transaksi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(72, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id Customer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(72, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "User Id";
            // 
            // txtIdTransaksi
            // 
            this.txtIdTransaksi.Location = new System.Drawing.Point(251, 100);
            this.txtIdTransaksi.Name = "txtIdTransaksi";
            this.txtIdTransaksi.Size = new System.Drawing.Size(248, 27);
            this.txtIdTransaksi.TabIndex = 4;
            // 
            // txtTglTransaksi
            // 
            this.txtTglTransaksi.Location = new System.Drawing.Point(251, 143);
            this.txtTglTransaksi.Name = "txtTglTransaksi";
            this.txtTglTransaksi.Size = new System.Drawing.Size(248, 27);
            this.txtTglTransaksi.TabIndex = 5;
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(251, 234);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(248, 27);
            this.txtUserId.TabIndex = 7;
            // 
            // btInputTransaksi
            // 
            this.btInputTransaksi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btInputTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btInputTransaksi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btInputTransaksi.ForeColor = System.Drawing.Color.White;
            this.btInputTransaksi.Location = new System.Drawing.Point(134, 298);
            this.btInputTransaksi.Name = "btInputTransaksi";
            this.btInputTransaksi.Size = new System.Drawing.Size(106, 41);
            this.btInputTransaksi.TabIndex = 8;
            this.btInputTransaksi.Text = "Input";
            this.btInputTransaksi.UseVisualStyleBackColor = false;
            this.btInputTransaksi.Click += new System.EventHandler(this.btInputTransaksi_Click);
            // 
            // btEditTransaksi
            // 
            this.btEditTransaksi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btEditTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btEditTransaksi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btEditTransaksi.ForeColor = System.Drawing.Color.White;
            this.btEditTransaksi.Location = new System.Drawing.Point(356, 298);
            this.btEditTransaksi.Name = "btEditTransaksi";
            this.btEditTransaksi.Size = new System.Drawing.Size(106, 41);
            this.btEditTransaksi.TabIndex = 9;
            this.btEditTransaksi.Text = "Edit";
            this.btEditTransaksi.UseVisualStyleBackColor = false;
            this.btEditTransaksi.Click += new System.EventHandler(this.btEditTransaksi_Click);
            // 
            // brDeleteTransaksi
            // 
            this.brDeleteTransaksi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.brDeleteTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.brDeleteTransaksi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.brDeleteTransaksi.ForeColor = System.Drawing.Color.White;
            this.brDeleteTransaksi.Location = new System.Drawing.Point(566, 298);
            this.brDeleteTransaksi.Name = "brDeleteTransaksi";
            this.brDeleteTransaksi.Size = new System.Drawing.Size(106, 41);
            this.brDeleteTransaksi.TabIndex = 10;
            this.brDeleteTransaksi.Text = "Delete";
            this.brDeleteTransaksi.UseVisualStyleBackColor = false;
            this.brDeleteTransaksi.Click += new System.EventHandler(this.brDeleteTransaksi_Click);
            // 
            // cbIdCustomer
            // 
            this.cbIdCustomer.FormattingEnabled = true;
            this.cbIdCustomer.Location = new System.Drawing.Point(251, 187);
            this.cbIdCustomer.Name = "cbIdCustomer";
            this.cbIdCustomer.Size = new System.Drawing.Size(248, 28);
            this.cbIdCustomer.TabIndex = 12;
            this.cbIdCustomer.SelectedIndexChanged += new System.EventHandler(this.cbIdCustomer_SelectedIndexChanged);
            // 
            // dgvDataTransaksi
            // 
            this.dgvDataTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataTransaksi.Location = new System.Drawing.Point(-1, 370);
            this.dgvDataTransaksi.Name = "dgvDataTransaksi";
            this.dgvDataTransaksi.RowHeadersWidth = 51;
            this.dgvDataTransaksi.RowTemplate.Height = 29;
            this.dgvDataTransaksi.Size = new System.Drawing.Size(934, 212);
            this.dgvDataTransaksi.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(356, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 34);
            this.label5.TabIndex = 14;
            this.label5.Text = "DATA TRANSAKSI";
            // 
            // FormDataTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(932, 583);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvDataTransaksi);
            this.Controls.Add(this.cbIdCustomer);
            this.Controls.Add(this.brDeleteTransaksi);
            this.Controls.Add(this.btEditTransaksi);
            this.Controls.Add(this.btInputTransaksi);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.txtTglTransaksi);
            this.Controls.Add(this.txtIdTransaksi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDataTransaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDataTransaksi";
            this.Load += new System.EventHandler(this.FormDataTransaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataTransaksi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdTransaksi;
        private System.Windows.Forms.TextBox txtTglTransaksi;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Button btInputTransaksi;
        private System.Windows.Forms.Button btEditTransaksi;
        private System.Windows.Forms.Button brDeleteTransaksi;
        private System.Windows.Forms.ComboBox cbIdCustomer;
        private System.Windows.Forms.DataGridView dgvDataTransaksi;
        private System.Windows.Forms.Label label5;
    }
}