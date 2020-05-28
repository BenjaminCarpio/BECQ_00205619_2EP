using System;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class DeleteUser : UserControl
    {
        public DeleteUser()
        {
            InitializeComponent();
        }

        private void btnDeleteUserFromBD_Click(object sender, EventArgs e)
        {
            var userlist = UserDAO.getList();
            cmbUserDelete.DataSource = null;
            cmbUserDelete.ValueMember = "iduser";
            cmbUserDelete.DisplayMember = "username";
            cmbUserDelete.DataSource = userlist;
            
        }
    }
}