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
    public partial class Statistics : Form
    {
        private Communicator m_communicator;
        public Statistics(ref Communicator communicator)
        {
            m_communicator = communicator;
            InitializeComponent();

            Response res = m_communicator.Talk(codes.STATISTICS, "{\"status\":6}");

            if (res.status == codes.STATISTICS)
            {
                ShowStatistics(res.buffer);
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

        private void ShowStatistics(string buffer)
        {
            int limit = buffer.IndexOf("},");
            int begin = buffer.IndexOf(":{") + 1;

            statistics_pannel.Controls.Add(JsonSerializer.Deserialize<StatisticsResponse>(buffer.Substring(begin, limit - begin + 1)));
        }
    }
}
