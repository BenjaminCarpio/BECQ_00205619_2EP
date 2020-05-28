using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class PrincipalForm : Form
    {

        private bool AdminUser;
        private int UserId;

        public PrincipalForm(string name, bool admin)
        {
            
            InitializeComponent();
            AdminUser = admin;
            
            if (!AdminUser)
            {
                tabControl1.TabPages.Remove(tabPage4);
                tabControl1.TabPages.Remove(tabPage5);
                tabControl1.TabPages.Remove(tabPage6);
            }
            
        }



        private void ReloadControls()
        {
            Buisness actual = (Buisness) cmbNegocio.SelectedItem;
            int idBuis = actual.idbuisness;
            var productos = ProductDAO.getListProductsFromStore(idBuis);
            var negocios = BuisnessDAO.getList();
            var direcciones = AdressDAO.getListAdressUser(UserId);
            cmbNegocio.DataSource = null;
            cmbNegocio.ValueMember = "idbuisness";
            cmbNegocio.DisplayMember = "name";
            cmbNegocio.DataSource = negocios;
            cmbProducto.DataSource = null;
            cmbProducto.ValueMember = "idproduct";
            cmbProducto.DisplayMember = "name";
            cmbProducto.DataSource = productos;
            cmbLocation.DataSource = null;
            cmbLocation.ValueMember = "idproduct";
            cmbLocation.DisplayMember = "name";
            cmbLocation.DataSource = direcciones;
        }
        

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void btnInfoNegocio_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para realizar un pedido solaente debe seleccionar una opcion dentro de las cajas de texto(Combo Box)");        
            }

        private void btnRealizarPedido_Click(object sender, EventArgs e)
        {
            string query =
                $"INSERT INTO APPORDER(createDate, idProduct, idAddress) VALUES({DateTime.Now}, {cmbNegocio.ValueMember}, {cmbLocation.ValueMember});";
            try
            {
                if (cmbLocation == null || cmbNegocio == null || cmbProducto == null)
                {
                    MessageBox.Show("No se permiten campos vacios.");
                }
                else
                {
                    ConnectionDB.ExecuteNonQuery(query);
                    MessageBox.Show("Su pedido fue realizado con exito, gracias por preferirnos.");
                }
            }catch(Exception ex){
                MessageBox.Show("Intente nuevamente.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var lista = OrderDAO.getList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lista;
        }
    }
}