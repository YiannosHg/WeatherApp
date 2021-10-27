using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class Weather : Form
    {
        public Weather()
        {
            InitializeComponent();
        }

        Settings settings = new Settings();

        private void settingsButton_Click(object sender, EventArgs e)
        {
            settings.ShowDialog();
        }
    }
}
