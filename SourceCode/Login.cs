using System;
using System.Data;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }


        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            
            if (txtClave.Text.Equals("") || txtUsername.Text.Equals(("")))
            {
                MessageBox.Show("No se permiten campos vacios");
            }
            else
            {
                try
                {
                    string query = $"SELECT username, usertype FROM APPUSER WHERE username = '{txtUsername.Text}' AND password = '{txtClave.Text}'";
                    var cmd = ConnectionDB.ExecuteQuery(query);


                    DataTableReader dr, dr2;
                    dr = cmd.CreateDataReader();
                    string user;
                    bool adminUser = false;
                    
                    if (dr.Read())
                    {
                        adminUser = dr.GetBoolean(1);
                        user = dr.GetString(0);
                        
                        
                        if (adminUser == true)
                        {
                            MessageBox.Show("Bienvenido Administrador " + user);
                        }
                        else
                        {
                            MessageBox.Show("Bienvenido " + user);
                            
                        }
                        this.Hide();
                        this.Close();
                        PrincipalForm ventanaMain= new PrincipalForm(user, adminUser);
                        ventanaMain.ShowDialog();

                    } else 
                        MessageBox.Show("Credenciales erroneas");
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }

               
            }
        }
    }
}