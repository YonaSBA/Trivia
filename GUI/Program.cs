using System;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace GUI
{
    public class Program
    {
        static void Main()
        {
            Communicator communicator = new Communicator();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login(ref communicator));
        }
    }
}
