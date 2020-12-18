using LoginClient_991396063.BusServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginClient_991396063
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AuthenticateUserServiceClient client = new AuthenticateUserServiceClient("NetTcpBinding_AuthenticateUserService");

            lblMessage.Text = client.AuthenticateUser(tbName.Text, tbPassword.Text);
        }
    }
}
