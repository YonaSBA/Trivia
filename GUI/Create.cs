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
    public partial class Create : Form
    {
        private Communicator m_communicator;

        public Create(ref Communicator communicator)
        {
            m_communicator = communicator; 
            InitializeComponent();
        }

        private void CreateRoom(object sender, EventArgs e)
        {
            var req = new CreateRequset { name = name.Text, maxPlayers = Convert.ToUInt32(max_players.Text), answerTime = Convert.ToUInt32(answer_time.Text), questionNum = Convert.ToUInt32(question_count.Text) };
            Response res = m_communicator.Talk(codes.CREATE_ROOM, JsonSerializer.Serialize(req));

            if (res.status == codes.CREATE_ROOM)
            {
                m_communicator.success("The room was created");
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
            Menu win = new Menu(ref m_communicator);
            win.Show();
        }
    }

    public class CreateRequset
    {
        public codes id = codes.CREATE_ROOM;
        public string name { get; set; }
        public uint maxPlayers { get; set; }
        public uint answerTime { get; set; }
        public uint questionNum { get; set; }
    }
}
