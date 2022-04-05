using System;
using System.Net;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GUI
{
    public partial class HighScores : Form
    {
        private Communicator m_communicator;

        public HighScores(ref Communicator communicator)
        {
            m_communicator = communicator;
            InitializeComponent();

            Response res = m_communicator.Talk(codes.HIGH_SCORES, "{\"status\":7}");

            if (res.status == codes.HIGH_SCORES)
            {
                ShowHighScores(res.buffer);
            }
            else
            {
                Back(0, null);
            }
        }

        private void Back(object sender, EventArgs e)
        {
            this.Hide();
            Menu win = new Menu(ref m_communicator);
            win.Show();
        }

        private void ShowHighScores(string buffer)
        {
            int begin = buffer.IndexOf("[");
            int limit = buffer.IndexOf("]");

            List<Player> players = JsonSerializer.Deserialize<List<Player>>(buffer.Substring(begin, limit - begin + 1));
            foreach (Player player in players)
            {
                scores_pannel.Controls.Add(player);
            }
        }
    }
}
