using System.ComponentModel;

namespace SourceCode
{
    partial class AddNegocio
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
            this.btnAddBuisness = new System.Windows.Forms.Button();
            this.txtNameBuisness = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
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
            this.tableLayoutPanel1.Controls.Add(this.btnAddBuisness, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtNameBuisness, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtdescripcion, 1, 1);
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
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(419, 462);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Forte", 20.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 154);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Forte", 20.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 154);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddBuisness
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnAddBuisness, 2);
            this.btnAddBuisness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddBuisness.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnAddBuisness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBuisness.Font = new System.Drawing.Font("Forte", 20.25F);
            this.btnAddBuisness.ForeColor = System.Drawing.Color.White;
            this.btnAddBuisness.Location = new System.Drawing.Point(3, 311);
            this.btnAddBuisness.Name = "btnAddBuisness";
            this.btnAddBuisness.Size = new System.Drawing.Size(413, 148);
            this.btnAddBuisness.TabIndex = 2;
            this.btnAddBuisness.Text = "Agregar negocio";
            this.btnAddBuisness.UseVisualStyleBackColor = true;
            this.btnAddBuisness.Click += new System.EventHandler(this.btnAddBuisness_Click);
            // 
            // txtNameBuisness
            // 
            this.txtNameBuisness.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNameBuisness.Location = new System.Drawing.Point(238, 65);
            this.txtNameBuisness.Name = "txtNameBuisness";
            this.txtNameBuisness.Size = new System.Drawing.Size(151, 23);
            this.txtNameBuisness.TabIndex = 3;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtdescripcion.Location = new System.Drawing.Point(239, 219);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(149, 23);
            this.txtdescripcion.TabIndex = 4;
            // 
            // AddNegocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddNegocio";
            this.Size = new System.Drawing.Size(419, 462);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameBuisness;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Button btnAddBuisness;
    }
}