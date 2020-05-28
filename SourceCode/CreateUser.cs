using System;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class CreateUser : UserControl
    {
        public CreateUser()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string Fullname = txtFullName.Text;
            string Username = txtUsername.Text;
            string boolAdmin = "";
            if (rbnYes.Checked)
            {
                boolAdmin = "true";
            }
            else
            {
                boolAdmin = "false";
            }
            string query =
                $"INSERT INTO APPUSER(fullname, username, password, userType) VALUES('{Fullname}', '{Username}', '{Username}', {boolAdmin});";
            MessageBox.Show(query);
            try
            {
                if (txtUsername.Text.Equals("") || txtFullName.Text.Equals(""))
                {
                    MessageBox.Show("No se permiten campos vacios.");
                }
                else if (txtFullName.Text.Length < 10 || txtUsername.Text.Length < 5)
                {
                    throw new UnreachedMinimumNumberOfCharacters("No alcanzó los requerimientos minimos." +
                                                                 "\nLongitud minima para el nombre: 10 caracteres." +
                                                                 "\nLongitud minima para el nombre de usuario: 5 caracteres.");
                }
                else
                {
                    ConnectionDB.ExecuteNonQuery(query);
                    MessageBox.Show("Cuenta creada exitosamente, volviendo a pantalla principal." +
                                    "\n Recordando: su clave es igual a su nombre de usuario.");
                    this.Hide();
                    Form1 Ventana = new Form1();
                    Ventana.ShowDialog();
                }
            }catch(UnreachedMinimumNumberOfCharacters exc){
                MessageBox.Show("Intente nuevamente.");
            }catch(Exception ex){
                MessageBox.Show("Intente nuevamente.");
            }
        }
    }
}