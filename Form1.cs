using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYSINHVIENUEF.Dbconnect;

namespace QUANLYSINHVIENUEF
{
    public partial class Form1 : Form
    {
        QLSVEntities db = new QLSVEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username =  txtUser.Text;
                string pass = txtPass.Text;
                tbLogin login = (tbLogin)db.tbLogins.Where(s => s.username == username && s.password == pass).FirstOrDefault();
                if(username != null)
                {
                    if(login.role =="admin")
                    {
                        frmUser frm = new frmUser();
                    }
                }
                else
                {
                    MessageBox.Show("Vui long kiem tra lai!");
                    txtUser.Focus();
                    return;
                }
            }
            catch
            {

            }
        }
    }
}
