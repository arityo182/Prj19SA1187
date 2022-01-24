
namespace Prj19SA1187
{
    partial class FormDataUser
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
            this.txtUserid = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtNamaUser = new System.Windows.Forms.TextBox();
            this.cbOtoritasUser = new System.Windows.Forms.ComboBox();
            this.dgvDataUser = new System.Windows.Forms.DataGridView();
            this.btInput = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btHapus = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataUser)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(51, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(51, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(51, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Otoritas";
            // 
            // txtUserid
            // 
            this.txtUserid.Location = new System.Drawing.Point(282, 100);
            this.txtUserid.Name = "txtUserid";
            this.txtUserid.Size = new System.Drawing.Size(241, 27);
            this.txtUserid.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(282, 160);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(241, 27);
            this.txtPassword.TabIndex = 5;
            // 
            // txtNamaUser
            // 
            this.txtNamaUser.Location = new System.Drawing.Point(282, 217);
            this.txtNamaUser.Name = "txtNamaUser";
            this.txtNamaUser.Size = new System.Drawing.Size(241, 27);
            this.txtNamaUser.TabIndex = 6;
            // 
            // cbOtoritasUser
            // 
            this.cbOtoritasUser.FormattingEnabled = true;
            this.cbOtoritasUser.Location = new System.Drawing.Point(282, 275);
            this.cbOtoritasUser.Name = "cbOtoritasUser";
            this.cbOtoritasUser.Size = new System.Drawing.Size(241, 28);
            this.cbOtoritasUser.TabIndex = 7;
            // 
            // dgvDataUser
            // 
            this.dgvDataUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataUser.Location = new System.Drawing.Point(1, 374);
            this.dgvDataUser.Name = "dgvDataUser";
            this.dgvDataUser.RowHeadersWidth = 51;
            this.dgvDataUser.RowTemplate.Height = 29;
            this.dgvDataUser.Size = new System.Drawing.Size(930, 204);
            this.dgvDataUser.TabIndex = 8;
            // 
            // btInput
            // 
            this.btInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btInput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btInput.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btInput.ForeColor = System.Drawing.Color.White;
            this.btInput.Location = new System.Drawing.Point(602, 100);
            this.btInput.Name = "btInput";
            this.btInput.Size = new System.Drawing.Size(108, 54);
            this.btInput.TabIndex = 9;
            this.btInput.Text = "Input";
            this.btInput.UseVisualStyleBackColor = false;
            this.btInput.Click += new System.EventHandler(this.btInput_Click);
            // 
            // btEdit
            // 
            this.btEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btEdit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btEdit.ForeColor = System.Drawing.Color.White;
            this.btEdit.Location = new System.Drawing.Point(602, 176);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(108, 54);
            this.btEdit.TabIndex = 10;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btHapus
            // 
            this.btHapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btHapus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btHapus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btHapus.ForeColor = System.Drawing.Color.White;
            this.btHapus.Location = new System.Drawing.Point(602, 249);
            this.btHapus.Name = "btHapus";
            this.btHapus.Size = new System.Drawing.Size(108, 54);
            this.btHapus.TabIndex = 11;
            this.btHapus.Text = "Hapus";
            this.btHapus.UseVisualStyleBackColor = false;
            this.btHapus.Click += new System.EventHandler(this.btHapus_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(392, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 34);
            this.label5.TabIndex = 12;
            this.label5.Text = "DATA USER";
            // 
            // FormDataUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(932, 583);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btHapus);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btInput);
            this.Controls.Add(this.dgvDataUser);
            this.Controls.Add(this.cbOtoritasUser);
            this.Controls.Add(this.txtNamaUser);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDataUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDataUser";
            this.Load += new System.EventHandler(this.FormDataUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserid;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtNamaUser;
        private System.Windows.Forms.ComboBox cbOtoritasUser;
        private System.Windows.Forms.DataGridView dgvDataUser;
        private System.Windows.Forms.Button btInput;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btHapus;
        private System.Windows.Forms.Label label5;
    }
}