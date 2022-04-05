using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace GUI
{
    public partial class StatisticsResponse : UserControl
    {
        public int games { get => Convert.ToInt32(games_label.Text); set => games_label.Text = value.ToString(); }
        public double best { get => Convert.ToDouble(best_label.Text); set => best_label.Text = value.ToString(); }
        public int wrongs { get => Convert.ToInt32(wrongs_label.Text); set => wrongs_label.Text = value.ToString(); }
        public int corrects { get => Convert.ToInt32(corrects_label.Text); set => corrects_label.Text = value.ToString(); }
        public double average { get => Convert.ToDouble(average_label.Text); set => average_label.Text = value.ToString(); }

        public StatisticsResponse()
        {
            InitializeComponent();
        }
    }
}
