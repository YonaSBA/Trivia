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
    public partial class Room : UserControl
    {
        public Communicator m_communicator;

        public uint id { get; set; }
        public uint isActive { get; set; }
        public string name { get => name_button.Text; set => name_button.Text = value;}
        public uint maxPlayers { get => Convert.ToUInt32(max_players_label.Text); set => max_players_label.Text = value.ToString(); }
        public uint answerTime { get => Convert.ToUInt32(answer_time_label.Text); set => answer_time_label.Text = value.ToString(); }
        public uint questionsNum { get => Convert.ToUInt32(questions_num_label.Text); set => questions_num_label.Text = value.ToString(); }

        public Room()
        {
            InitializeComponent();
        }

        private void JoinRoom(object sender, EventArgs e)
        {
            var req = new JoinRequest { ID = id };
            Response res = m_communicator.Talk(codes.JOIN_ROOM, JsonSerializer.Serialize(req));

            if (res.status == codes.JOIN_ROOM)
            {
                m_communicator.success("Joining the room");
            }
            else
            {
                m_communicator.error(res.buffer);
            }
        }
    }

    public class JoinRequest
    {
        public codes status = codes.JOIN_ROOM;
        public uint ID { get; set; }
    }
}
