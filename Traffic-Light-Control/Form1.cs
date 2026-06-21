using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trafic_light
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ctrlTraficLight1.Start();
        }

        private void ctrlTraficLight1_RedLightOn(object sender, ctrlTraficLight.TraficLightEventArgs e)
        {
            MessageBox.Show(e.CurrentLight.ToString());
        }

        private void ctrlTraficLight1_OrangeLightOn(object sender, ctrlTraficLight.TraficLightEventArgs e)
        {
            MessageBox.Show(e.CurrentLight.ToString());
        }

        private void ctrlTraficLight1_GreenLightOn(object sender, ctrlTraficLight.TraficLightEventArgs e)
        {
            MessageBox.Show(e.CurrentLight.ToString());
        }
    }
}
