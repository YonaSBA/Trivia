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
    public enum codes
    {
        ERROR = '0',

        SIGN_IN,
        SIGN_UP,
        SIGN_OUT,

        CREATE_ROOM,
        JOIN_ROOM,

        STATISTICS,
        HIGH_SCORES,

        GET_ROOMS,
        GET_PLAYERS
    }

    public struct Response
    {
        public codes status { get; set; }

        public string buffer { get; set; }

        public Response(byte[] data)
        {
            status = (codes)data[0];
            buffer = Encoding.ASCII.GetString(data.Skip(5).Take(1019).ToArray());     // Convert the part in the buffer bounded by "{}" to string. 
        }
    }

    public class Communicator
    {
        private int PORT = 1234;
        private Socket m_socket;

        public Communicator() 
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());     // Get computer addresses
            foreach (var address in host.AddressList)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    m_socket = new Socket(address.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                    m_socket.Connect(new IPEndPoint(address, PORT));
                    break;
                }
            }
        }

        ~Communicator()
        {
            m_socket.Shutdown(SocketShutdown.Both);
            m_socket.Close();
        }

        public Response Talk(codes id, string json)
        {
            byte[] buffer = new byte[1024];

            buffer[0] = (byte)id;
            Encoding.ASCII.GetBytes(json.Length.ToString() + json).CopyTo(buffer, 5 - json.Length.ToString().Length);

            m_socket.Send(buffer);
            Array.Clear(buffer, 0, buffer.Length);

            m_socket.Receive(buffer);
            return new Response(buffer);
        }

        public void error(string err)
        {
            MessageBox.Show(String.Format("ERROR: {0}.", err.Substring(12, err.IndexOf(".") -12)), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void success(string suc)
        {
            MessageBox.Show(String.Format("{0} successfully!", suc), "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}