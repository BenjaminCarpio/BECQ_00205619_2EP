using System.ComponentModel;

namespace SourceCode
{
    partial class Ubicacion
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
            this.btnChangeLocation = new System.Windows.Forms.Button();
            this.cmbUbicacionAModificar = new System.Windows.Forms.ComboBox();
            this.txtNewLocation = new System.Windows.Forms.TextBox();
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
            this.tableLayoutPanel1.Controls.Add(this.btnChangeLocation, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbUbicacionAModificar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNewLocation, 1, 1);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(491, 519);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Forte", 20.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 173);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ubicacion a modificar:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Forte", 20.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 173);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ubicacion nueva: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnChangeLocation
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnChangeLocation, 2);
            this.btnChangeLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChangeLocation.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnChangeLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeLocation.Font = new System.Drawing.Font("Forte", 20.25F);
            this.btnChangeLocation.ForeColor = System.Drawing.Color.White;
            this.btnChangeLocation.Location = new System.Drawing.Point(3, 349);
            this.btnChangeLocation.Name = "btnChangeLocation";
            this.btnChangeLocation.Size = new System.Drawing.Size(485, 167);
            this.btnChangeLocation.TabIndex = 2;
            this.btnChangeLocation.Text = "Cambiar";
            this.btnChangeLocation.UseVisualStyleBackColor = true;
            // 
            // cmbUbicacionAModificar
            // 
            this.cmbUbicacionAModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbUbicacionAModificar.FormattingEnabled = true;
            this.cmbUbicacionAModificar.Location = new System.Drawing.Point(270, 75);
            this.cmbUbicacionAModificar.Margin = new System.Windows.Forms.Padding(0);
            this.cmbUbicacionAModificar.Name = "cmbUbicacionAModificar";
            this.cmbUbicacionAModificar.Size = new System.Drawing.Size(196, 23);
            this.cmbUbicacionAModificar.TabIndex = 3;
            // 
            // txtNewLocation
            // 
            this.txtNewLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNewLocation.Location = new System.Drawing.Point(277, 248);
            this.txtNewLocation.Name = "txtNewLocation";
            this.txtNewLocation.Size = new System.Drawing.Size(181, 23);
            this.txtNewLocation.TabIndex = 4;
            // 
            // Ubicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Ubicacion";
            this.Size = new System.Drawing.Size(491, 519);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUbicacionAModificar;
        private System.Windows.Forms.TextBox txtNewLocation;
        private System.Windows.Forms.Button btnChangeLocation;
    }
}