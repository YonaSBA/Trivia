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
    public partial class Join : Form
    {
        private Timer m_refresher;
        private Communicator m_communicator;

        public Join(ref Communicator communicator)
        {
            m_refresher = new Timer();
            m_communicator = communicator;
            InitializeComponent();

            m_refresher.Interval = 3000;
            m_refresher.Tick += new EventHandler(GetRooms);
            m_refresher.Start();
        }

        private void Back(object sender, EventArgs e)
        {
            m_refresher.Stop();
            this.Hide(); 
            Menu win = new Menu(ref m_communicator);
            win.Show();
        }

        private void GetRooms(object sender, EventArgs e)
        {
            Response res = m_communicator.Talk(codes.GET_ROOMS, "{\"status\":8}");
            if (res.status == codes.GET_ROOMS)
            {
                label.Hide();
                rooms_pannel.Controls.Clear();
                ShowRooms(res.buffer);
            }
            else
            {
                label.Text = "No rooms available!";
                label.Show();
            }
        }

        private void ShowRooms(string buffer)
        {
            int begin = buffer.IndexOf("[");
            int limit = buffer.IndexOf("]");

            List<Room> rooms = JsonSerializer.Deserialize<List<Room>>(buffer.Substring(begin, limit - begin + 1)); 
            foreach (Room room in rooms)
            {
                room.m_communicator = m_communicator;
                rooms_pannel.Controls.Add(room);
            }

            rooms_pannel.AutoScroll = true;
        }
    }
}
