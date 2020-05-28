using System;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class AddLocation : UserControl
    {
        public AddLocation()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string Location = txtNewLocation.Text;
            int iduser = 0;
            string query =
                $"INSERT INTO ADDRESS(idUser, address) INSERT INTO ADDRESS({iduser}, '{Location}')";
            try
            {
                if (txtNewLocation.Text.Equals("") )
                {
                    MessageBox.Show("No se permiten campos vacios.");
                }
                else if (txtNewLocation.Text.Length < 6)
                {
                    throw new UnreachedMinimumNumberOfCharacters("No alcanzó los requerimientos minimos." +
                                                                 "\nLongitud minima para la direccion: 6 caracteres.");
                }
                else
                {
                    ConnectionDB.ExecuteNonQuery(query);
                    MessageBox.Show("Ubicacion agregada exitosamente!!");
                }
            }catch(UnreachedMinimumNumberOfCharacters exc){
                MessageBox.Show("Intente nuevamente.");
            }catch(Exception ex){
                MessageBox.Show("Intente nuevamente.");
            }
        }
    }
}