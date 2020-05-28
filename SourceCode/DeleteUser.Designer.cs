using System.ComponentModel;

namespace SourceCode
{
    partial class DeleteUser
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUserDelete = new System.Windows.Forms.ComboBox();
            this.btnDeleteUserFromBD = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbUserDelete, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDeleteUserFromBD, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(640, 468);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Forte", 27.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(634, 156);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione el usuario a eliminar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Forte", 15.75F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 156);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de usuario a eliminar:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbUserDelete
            // 
            this.cmbUserDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbUserDelete.FormattingEnabled = true;
            this.cmbUserDelete.Location = new System.Drawing.Point(387, 222);
            this.cmbUserDelete.Name = "cmbUserDelete";
            this.cmbUserDelete.Size = new System.Drawing.Size(185, 23);
            this.cmbUserDelete.TabIndex = 2;
            // 
            // btnDeleteUserFromBD
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnDeleteUserFromBD, 2);
            this.btnDeleteUserFromBD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteUserFromBD.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnDeleteUserFromBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUserFromBD.Font = new System.Drawing.Font("Forte", 27.75F);
            this.btnDeleteUserFromBD.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUserFromBD.Location = new System.Drawing.Point(3, 315);
            this.btnDeleteUserFromBD.Name = "btnDeleteUserFromBD";
            this.btnDeleteUserFromBD.Size = new System.Drawing.Size(634, 150);
            this.btnDeleteUserFromBD.TabIndex = 3;
            this.btnDeleteUserFromBD.Text = "Eliminar";
            this.btnDeleteUserFromBD.UseVisualStyleBackColor = true;
            this.btnDeleteUserFromBD.Click += new System.EventHandler(this.btnDeleteUserFromBD_Click);
            // 
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DeleteUser";
            this.Size = new System.Drawing.Size(640, 468);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUserDelete;
        private System.Windows.Forms.Button btnDeleteUserFromBD;
    }
}