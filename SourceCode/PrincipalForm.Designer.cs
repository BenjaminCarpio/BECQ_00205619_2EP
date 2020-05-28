using System.ComponentModel;

namespace SourceCode
{
    partial class PrincipalForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(PrincipalForm));
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.addNegocio1 = new SourceCode.AddNegocio();
            this.buisnessList1 = new SourceCode.BuisnessList();
            this.deleteBuisness1 = new SourceCode.DeleteBuisness();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.createUser1 = new SourceCode.CreateUser();
            this.deleteUser1 = new SourceCode.DeleteUser();
            this.userList1 = new SourceCode.UserList();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCambiarClave = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.changePassword1 = new SourceCode.ChangePassword();
            this.verpedidos1 = new SourceCode.Verpedidos();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbNegocio = new System.Windows.Forms.ComboBox();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.btnInfoNegocio = new System.Windows.Forms.Button();
            this.btnRealizarPedido = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCloseApp = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.deleteLocation1 = new SourceCode.DeleteLocation();
            this.addLocation1 = new SourceCode.AddLocation();
            this.ubicacion1 = new SourceCode.Ubicacion();
            this.tabPage6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.Indigo;
            this.tabPage6.Controls.Add(this.tableLayoutPanel7);
            this.tabPage6.Location = new System.Drawing.Point(4, 24);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1013, 617);
            this.tabPage6.TabIndex = 6;
            this.tabPage6.Text = "Ordenes";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel7.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1013, 617);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Forte", 21.75F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1007, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Actualizar lista";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1007, 550);
            this.dataGridView1.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.Indigo;
            this.tabPage5.Controls.Add(this.tableLayoutPanel6);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1013, 617);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "Negocios";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.Controls.Add(this.label13, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.label12, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.addNegocio1, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.buisnessList1, 2, 1);
            this.tableLayoutPanel6.Controls.Add(this.deleteBuisness1, 1, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1013, 617);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Forte", 27.75F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(677, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(333, 61);
            this.label13.TabIndex = 2;
            this.label13.Text = "Ver lista";
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Forte", 27.75F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(340, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(331, 61);
            this.label12.TabIndex = 1;
            this.label12.Text = "Eliminar";
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Forte", 27.75F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(331, 61);
            this.label11.TabIndex = 0;
            this.label11.Text = "Agregar";
            // 
            // addNegocio1
            // 
            this.addNegocio1.BackColor = System.Drawing.Color.Indigo;
            this.addNegocio1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addNegocio1.Location = new System.Drawing.Point(3, 64);
            this.addNegocio1.Name = "addNegocio1";
            this.addNegocio1.Size = new System.Drawing.Size(331, 550);
            this.addNegocio1.TabIndex = 3;
            // 
            // buisnessList1
            // 
            this.buisnessList1.BackColor = System.Drawing.Color.Indigo;
            this.buisnessList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buisnessList1.Location = new System.Drawing.Point(677, 64);
            this.buisnessList1.Name = "buisnessList1";
            this.buisnessList1.Size = new System.Drawing.Size(333, 550);
            this.buisnessList1.TabIndex = 4;
            // 
            // deleteBuisness1
            // 
            this.deleteBuisness1.BackColor = System.Drawing.Color.Indigo;
            this.deleteBuisness1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteBuisness1.Location = new System.Drawing.Point(340, 64);
            this.deleteBuisness1.Name = "deleteBuisness1";
            this.deleteBuisness1.Size = new System.Drawing.Size(331, 550);
            this.deleteBuisness1.TabIndex = 5;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Indigo;
            this.tabPage4.Controls.Add(this.tableLayoutPanel3);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1013, 617);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Usuarios";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.Controls.Add(this.label7, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.createUser1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.deleteUser1, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.userList1, 2, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Font = new System.Drawing.Font("Forte", 21.75F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tableLayoutPanel3.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1013, 617);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(677, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(333, 61);
            this.label7.TabIndex = 2;
            this.label7.Text = "UserList";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(340, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(331, 61);
            this.label6.TabIndex = 1;
            this.label6.Text = "Delete User";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(331, 61);
            this.label5.TabIndex = 0;
            this.label5.Text = "Create User";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createUser1
            // 
            this.createUser1.BackColor = System.Drawing.Color.Indigo;
            this.createUser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createUser1.Location = new System.Drawing.Point(8, 68);
            this.createUser1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.createUser1.Name = "createUser1";
            this.createUser1.Size = new System.Drawing.Size(321, 542);
            this.createUser1.TabIndex = 3;
            // 
            // deleteUser1
            // 
            this.deleteUser1.BackColor = System.Drawing.Color.Indigo;
            this.deleteUser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteUser1.Location = new System.Drawing.Point(345, 68);
            this.deleteUser1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.deleteUser1.Name = "deleteUser1";
            this.deleteUser1.Size = new System.Drawing.Size(321, 542);
            this.deleteUser1.TabIndex = 4;
            // 
            // userList1
            // 
            this.userList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userList1.Location = new System.Drawing.Point(682, 68);
            this.userList1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.userList1.Name = "userList1";
            this.userList1.Size = new System.Drawing.Size(323, 542);
            this.userList1.TabIndex = 5;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Indigo;
            this.tabPage3.Controls.Add(this.tableLayoutPanel4);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1013, 617);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Configuracion ";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99999F));
            this.tableLayoutPanel4.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.btnCambiarClave, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnPedidos, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.changePassword1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.verpedidos1, 1, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Font = new System.Drawing.Font("Forte", 20.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tableLayoutPanel4.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1013, 617);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // btnCambiarClave
            // 
            this.btnCambiarClave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCambiarClave.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnCambiarClave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarClave.Location = new System.Drawing.Point(3, 3);
            this.btnCambiarClave.Name = "btnCambiarClave";
            this.btnCambiarClave.Size = new System.Drawing.Size(500, 55);
            this.btnCambiarClave.TabIndex = 0;
            this.btnCambiarClave.Text = "Cambiar contraseña";
            this.btnCambiarClave.UseVisualStyleBackColor = true;
            // 
            // btnPedidos
            // 
            this.btnPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPedidos.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedidos.Location = new System.Drawing.Point(509, 3);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(501, 55);
            this.btnPedidos.TabIndex = 2;
            this.btnPedidos.Text = "Ver pedidos";
            this.btnPedidos.UseVisualStyleBackColor = true;
            // 
            // changePassword1
            // 
            this.changePassword1.BackColor = System.Drawing.Color.Indigo;
            this.changePassword1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changePassword1.Location = new System.Drawing.Point(8, 68);
            this.changePassword1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.changePassword1.Name = "changePassword1";
            this.changePassword1.Size = new System.Drawing.Size(490, 542);
            this.changePassword1.TabIndex = 3;
            // 
            // verpedidos1
            // 
            this.verpedidos1.BackColor = System.Drawing.Color.Indigo;
            this.verpedidos1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.verpedidos1.Location = new System.Drawing.Point(514, 68);
            this.verpedidos1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.verpedidos1.Name = "verpedidos1";
            this.verpedidos1.Size = new System.Drawing.Size(491, 542);
            this.verpedidos1.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Indigo;
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1013, 617);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Realizar pedido";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.cmbNegocio, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.cmbProducto, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnInfoNegocio, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnRealizarPedido, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label14, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.cmbLocation, 1, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1007, 611);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Forte", 48F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(798, 122);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ventana de pedidos!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(807, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Forte", 27.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(396, 122);
            this.label2.TabIndex = 2;
            this.label2.Text = "Negocio:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Forte", 27.75F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(396, 122);
            this.label3.TabIndex = 3;
            this.label3.Text = "Producto:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbNegocio
            // 
            this.cmbNegocio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbNegocio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNegocio.FormattingEnabled = true;
            this.cmbNegocio.Location = new System.Drawing.Point(464, 171);
            this.cmbNegocio.Name = "cmbNegocio";
            this.cmbNegocio.Size = new System.Drawing.Size(277, 23);
            this.cmbNegocio.TabIndex = 4;
            // 
            // cmbProducto
            // 
            this.cmbProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(464, 293);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(277, 23);
            this.cmbProducto.TabIndex = 5;
            // 
            // btnInfoNegocio
            // 
            this.btnInfoNegocio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInfoNegocio.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnInfoNegocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfoNegocio.Font = new System.Drawing.Font("Forte", 48F);
            this.btnInfoNegocio.ForeColor = System.Drawing.Color.White;
            this.btnInfoNegocio.Location = new System.Drawing.Point(807, 125);
            this.btnInfoNegocio.Name = "btnInfoNegocio";
            this.btnInfoNegocio.Size = new System.Drawing.Size(197, 116);
            this.btnInfoNegocio.TabIndex = 7;
            this.btnInfoNegocio.Text = "?";
            this.btnInfoNegocio.UseVisualStyleBackColor = true;
            this.btnInfoNegocio.Click += new System.EventHandler(this.btnInfoNegocio_Click);
            // 
            // btnRealizarPedido
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.btnRealizarPedido, 3);
            this.btnRealizarPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRealizarPedido.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnRealizarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealizarPedido.Font = new System.Drawing.Font("Forte", 48F);
            this.btnRealizarPedido.ForeColor = System.Drawing.Color.White;
            this.btnRealizarPedido.Location = new System.Drawing.Point(3, 491);
            this.btnRealizarPedido.Name = "btnRealizarPedido";
            this.btnRealizarPedido.Size = new System.Drawing.Size(1001, 117);
            this.btnRealizarPedido.TabIndex = 6;
            this.btnRealizarPedido.Text = "Realizar pedido";
            this.btnRealizarPedido.UseVisualStyleBackColor = true;
            this.btnRealizarPedido.Click += new System.EventHandler(this.btnRealizarPedido_Click);
            // 
            // label14
            // 
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Forte", 27.75F);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(3, 366);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(396, 122);
            this.label14.TabIndex = 8;
            this.label14.Text = "Ubicacion:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbLocation
            // 
            this.cmbLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Location = new System.Drawing.Point(479, 415);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(248, 23);
            this.cmbLocation.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Indigo;
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1013, 617);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCloseApp, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1007, 611);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label4
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.label4, 2);
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Forte", 48F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1001, 305);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bienvenido a mini Hugo, puede empezar a navegar por las pestañas!!!";
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCloseApp.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseApp.Font = new System.Drawing.Font("Forte", 48F);
            this.btnCloseApp.ForeColor = System.Drawing.Color.White;
            this.btnCloseApp.Location = new System.Drawing.Point(506, 308);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(498, 300);
            this.btnCloseApp.TabIndex = 1;
            this.btnCloseApp.Text = "Salir";
            this.btnCloseApp.UseVisualStyleBackColor = true;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::SourceCode.Properties.Resources.WhatsApp_Image_2020_05_27_at_3;
            this.pictureBox2.Location = new System.Drawing.Point(3, 308);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(497, 300);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1021, 645);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.Indigo;
            this.tabPage7.Controls.Add(this.tableLayoutPanel5);
            this.tabPage7.Location = new System.Drawing.Point(4, 24);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1013, 617);
            this.tabPage7.TabIndex = 7;
            this.tabPage7.Text = "Ubicacion";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Controls.Add(this.label10, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.label9, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.deleteLocation1, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.addLocation1, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.ubicacion1, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1013, 617);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Forte", 21.75F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(677, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(333, 61);
            this.label10.TabIndex = 2;
            this.label10.Text = "Eliminar ubicacion";
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Forte", 21.75F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(340, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(331, 61);
            this.label9.TabIndex = 1;
            this.label9.Text = "Agregar ubicacion";
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Forte", 21.75F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(331, 61);
            this.label8.TabIndex = 0;
            this.label8.Text = "Cambiar ubicacion";
            // 
            // deleteLocation1
            // 
            this.deleteLocation1.BackColor = System.Drawing.Color.Indigo;
            this.deleteLocation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteLocation1.Location = new System.Drawing.Point(677, 64);
            this.deleteLocation1.Name = "deleteLocation1";
            this.deleteLocation1.Size = new System.Drawing.Size(333, 550);
            this.deleteLocation1.TabIndex = 3;
            // 
            // addLocation1
            // 
            this.addLocation1.BackColor = System.Drawing.Color.Indigo;
            this.addLocation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addLocation1.Location = new System.Drawing.Point(340, 64);
            this.addLocation1.Name = "addLocation1";
            this.addLocation1.Size = new System.Drawing.Size(331, 550);
            this.addLocation1.TabIndex = 4;
            // 
            // ubicacion1
            // 
            this.ubicacion1.BackColor = System.Drawing.Color.Indigo;
            this.ubicacion1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ubicacion1.Location = new System.Drawing.Point(3, 64);
            this.ubicacion1.Name = "ubicacion1";
            this.ubicacion1.Size = new System.Drawing.Size(331, 550);
            this.ubicacion1.TabIndex = 5;
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1021, 645);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "PrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiniHugo";
            this.tabPage6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbNegocio;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Button btnInfoNegocio;
        private System.Windows.Forms.Button btnRealizarPedido;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnCambiarClave;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCloseApp;
        //private SourceCode.UserList userList1;
        //private SourceCode.DeleteUser deleteUser1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private SourceCode.UserList userList1;
        private SourceCode.DeleteUser deleteUser1;
        private SourceCode.CreateUser createUser1;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbLocation;
        private SourceCode.Verpedidos verpedidos1;
        private SourceCode.ChangePassword changePassword1;
        private SourceCode.AddNegocio addNegocio1;
        private SourceCode.Ubicacion ubicacion1;
        private SourceCode.AddLocation addLocation1;
        private SourceCode.DeleteLocation deleteLocation1;
        private SourceCode.DeleteBuisness deleteBuisness1;
        private SourceCode.BuisnessList buisnessList1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}