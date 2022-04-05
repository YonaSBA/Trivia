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
    public partial class SignUp : Form
    {
        private Communicator m_communicator;

        public SignUp(ref Communicator communicator)
        {
            m_communicator = communicator;
            InitializeComponent();
        }

        private void SignUpB(object sender, EventArgs e)
        {
            var req = new SignUpRequset { username = username.Text, password = password.Text, email = email.Text };
            Response res = m_communicator.Talk(codes.SIGN_UP, JsonSerializer.Serialize(req));

            if (res.status == codes.SIGN_UP)
            {
                m_communicator.success("Sign up");
                Back(sender, e);
            }
            else
            {
                m_communicator.error(res.buffer);
            }
        }

        private void Back(object sender, EventArgs e)
        {
            this.Hide();
            Login win = new Login(ref m_communicator);
            win.Show();
        }
    }

    public class SignUpRequset
    {
        public codes status = codes.SIGN_UP;
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
    }
}
