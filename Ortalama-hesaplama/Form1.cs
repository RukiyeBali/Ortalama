using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ortalama_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            float y1, y2, ortalama;
            y1 = Convert.ToSingle(txtY1.Text);
            y2 = Convert.ToSingle(txtY2.Text);
            ortalama = (y1+y2)/2;
            txtOrtalama.Text=ortalama.ToString();
      
        }
    }
}
