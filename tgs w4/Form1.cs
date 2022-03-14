using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tgs_w4
{
    public partial class FormTambah : Form
    {
        public static string[,] dataOrang = new string[10,3];
        public static int dataKeberapa = 0;
        public FormTambah()
        {
            InitializeComponent();
        }
        
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (dataKeberapa < 10 )
            {
                dataOrang[dataKeberapa, 0] = textBoxNama.Text;
                dataOrang[dataKeberapa, 1] = textBoxAlamat.Text;
                dataOrang[dataKeberapa, 2] = textBoxTelp.Text;
                dataKeberapa++;
            }
            else
            {
                MessageBox.Show("Data Telah Penuh!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnLihatData_Click(object sender, EventArgs e)
        {
            FormTampilan form2 = new FormTampilan();
            this.Hide();
            form2.ShowDialog();
            
        }

        private void textBoxTelp_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTelp_Click(object sender, EventArgs e)
        {
           
        }

        private void textBoxTelp_KeyPress(object sender, KeyPressEventArgs e)
        {
            char angka = e.KeyChar;
            if (!Char.IsDigit(angka) && angka!= Convert.ToChar(Keys.Back))
            {
                MessageBox.Show("Inputan harus berupa angka!");
                e.Handled = true;
            }
            
        }
    }
}
