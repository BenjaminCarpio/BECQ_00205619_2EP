using System;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }


        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            string Fullname = txtFullName.Text;
            string Username = txtUsername.Text;
            string query =
                $"INSERT INTO APPUSER(fullname, username, password, userType) VALUES('{Fullname}', '{Username}', '{Username}', false);";
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
                }
            }catch(UnreachedMinimumNumberOfCharacters exc){
             MessageBox.Show("Intente nuevamente.");
            }catch(Exception ex){
            MessageBox.Show("Intente nuevamente.");
            }
        }


        private void btnInfo_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string info;
            if (username == "")
            {
                 info = "Al crear su cuenta se le otorgaran ciertos valores por defecto.\n" +
                                          "La clave será su nombre de usuario, el cual se ingresa en la caja de texto mostrada abajo" 
                                          + "\nSin derechos de administrador y sin ubicacion actual." 
                                          + "\nLos cambios podran ser solicitados a un administrador posteriormente.";
            }else{
            info = "Al crear su cuenta se le otorgaran ciertos valores por defecto.\n" +
                          "Clave: " + username + "\n Sin derechos de administrador y sin ubicacion actual." +
                          "\nLos cambios podran ser solicitados a un administrador posteriormente.";
                          }
            MessageBox.Show(info);
        }
    }
}