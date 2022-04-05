using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Menu : Form
    {
        private Communicator m_communicator;

        public Menu(ref Communicator communicator)
        {
            m_communicator = communicator;
            InitializeComponent();
        }

        private void SignOut(object sender, EventArgs e)
        {
            m_communicator.Talk(codes.SIGN_OUT, "{\"status\": 3}");

            this.Hide();
            Login win = new Login(ref m_communicator);
            win.Show();
        }

        private void Create(object sender, EventArgs e)
        {
            this.Hide();
            Create win = new Create(ref m_communicator);
            win.Show();
        }

        private void Join(object sender, EventArgs e)
        {
            this.Hide();
            Join win = new Join(ref m_communicator);
            win.Show();
        }

        private void GetHighScores(object sender, EventArgs e)
        {
            this.Hide();
            HighScores win = new HighScores(ref m_communicator);
            win.Show();
        }

        private void GetStatistics(object sender, EventArgs e)
        {
            this.Hide();
            Statistics win = new Statistics(ref m_communicator);
            win.Show();
        }
    }
}
