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
    public partial class FormTampilan : Form
    {
        public static int dataKeberapa = 0;
        public FormTampilan()
        {
            InitializeComponent();
           
        }

        private void textBoxTelp_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            FormTambah Form2 = new FormTambah();
            this.Hide();
            Form2.ShowDialog();
        }
        public void ambilData(int dataKeberapa)
        {
            textBoxNama.Text = FormTambah.dataOrang[dataKeberapa, 0];
            textBoxAlamat.Text = FormTambah.dataOrang[dataKeberapa, 1];
            textBoxTelp.Text = FormTambah.dataOrang[dataKeberapa, 2];
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataKeberapa = 0;
            ambilData(dataKeberapa);
        }
        
        private void btnNext_Click(object sender, EventArgs e)
        {
            dataKeberapa++;
            if (dataKeberapa > 9 || dataKeberapa > FormTambah.dataKeberapa-1)
            {
                MessageBox.Show("Data sudah data terakhir!");
                dataKeberapa--;
            }
            
            else
            {
                ambilData(dataKeberapa);
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            dataKeberapa--;
            if(dataKeberapa <0)
            {
                MessageBox.Show("Data sudah data pertama!");
                dataKeberapa++;
            }
            else
            {
                ambilData(dataKeberapa);
            }
            
        }
    }
}
