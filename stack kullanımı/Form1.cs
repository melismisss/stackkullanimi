using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stack_kullanımı
{
    public partial class Form1 : Form
    {
        Stack<string> musteri = new Stack<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            if(musteri.Count > 0)
            {
                lblAd.Text = musteri.Pop();
            }
            else
            {
                MessageBox.Show("İşin çok hızlı bitti aferim :)");
            }
        }
    }
}
