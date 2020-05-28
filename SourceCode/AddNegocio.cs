using System;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class AddNegocio : UserControl
    {
        public AddNegocio()
        {
            InitializeComponent();
        }

        private void btnAddBuisness_Click(object sender, EventArgs e)
        {
            string name = txtNameBuisness.Text;
            string description = txtdescripcion.Text;
            int iduser = 0;
            string query =
                $"INSERT INTO BUSINESS(name, description) VALUES ('{name}', '{description}');";
            try
            {
                if (txtNameBuisness.Text.Equals("") || txtdescripcion.Text.Equals("") )
                {
                    MessageBox.Show("No se permiten campos vacios.");
                }
                else if (txtNameBuisness.Text.Length < 3 || txtdescripcion.Text.Length < 10)
                {
                    throw new UnreachedMinimumNumberOfCharacters("No alcanzó los requerimientos minimos." +
                                                                 "\nLongitud minima para el nombre de la empresa: 3 caracteres." +
                                                                 "\nLongitud minima para la descripcion del negocio: 10 caracteres.");
                }
                else
                {
                    ConnectionDB.ExecuteNonQuery(query);
                    MessageBox.Show("Negocion agregado con exito!!");
                }
            }catch(UnreachedMinimumNumberOfCharacters exc){
                MessageBox.Show("Intente nuevamente.");
            }catch(Exception ex){
                MessageBox.Show("Intente nuevamente.");
            }
                }

        
    }
}