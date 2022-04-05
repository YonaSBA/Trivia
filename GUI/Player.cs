using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Player : UserControl
    {
        public string name { get => name_label.Text; set => name_label.Text = value; }
        public double best { get => Convert.ToDouble(score_label.Text); set => score_label.Text = value.ToString(); }

        public Player()
        {
            InitializeComponent();
        }
    }
}
