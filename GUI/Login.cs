using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Text.Json;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GUI
{
    public partial class Login : Form
    {
        private Communicator m_communicator;

        public Login(ref Communicator communicator)
        {
            m_communicator = communicator;
            InitializeComponent();  // Defines everything you see on the form
        }

        private void SignIn(object sender, EventArgs e)
        {
            var req = new LoginRequset { username = username.Text, password = password.Text };
            Response res = m_communicator.Talk(codes.SIGN_IN, JsonSerializer.Serialize(req));

            if (res.status == codes.SIGN_IN)
            {
                m_communicator.success("Login");

                this.Hide();
                Menu win = new Menu(ref m_communicator);
                win.Show();
            }
            else
            {
                m_communicator.error(res.buffer);
            }
        }

        private void SignUp(object sender, EventArgs e)
        {
            this.Hide();
            SignUp win = new SignUp(ref m_communicator);
            win.Show();
        }
    }

    public class LoginRequset
    {
        public codes status = codes.SIGN_IN;
        public string username { get; set; }
        public string password { get; set; }
    }
}
