using System.Globalization;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double s1 = Convert.ToDouble(txtSayi1.Text);
                double s2 = Convert.ToDouble(txtSayi2.Text);
                if (s2 != 0)
                {
                    double sonuc = s1 / s2;
                    lstSonuclar.Items.Add($"{s1} / {s2} = {sonuc}");
                }
                else if ((s2 == 0) && (s1 == 0))
                {
                    lstSonuclar.Items.Add("BEL�RS�Z");
                }
                else if (s2 == 0)
                {
                    lstSonuclar.Items.Add("HATA: Say� s�f�ra b�l�nmez TANIMSIZ!!!");
                }
                
               
            }
            catch (Exception ex)
            {

                Console.WriteLine("HATA:" + ex.Message);
            }

          
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            try
            {
                double s1 = Convert.ToDouble(txtSayi1.Text);
                double s2 = Convert.ToDouble(txtSayi2.Text);
                double sonuc = s1 + s2;
                lstSonuclar.Items.Add($"{s1} + {s2} = {sonuc}");
            }
            catch (Exception ex)
            {

                 Console.WriteLine("HATA:" +ex.Message);
            }
            
        }

        private void btnCikarma_Click(object sender, EventArgs e)
        {
            try
            {
                double s1 = Convert.ToDouble(txtSayi1.Text);
                double s2 = Convert.ToDouble(txtSayi2.Text);
                double sonuc = s1 - s2;
                lstSonuclar.Items.Add($"{s1} - {s2} = {sonuc}");

            }
            catch (Exception ex)
            {

                Console.WriteLine("HATA: "+ex.Message);
            }
           
        }

        private void btnCarpma_Click(object sender, EventArgs e)
        {
            try
            {
                double s1 = Convert.ToDouble(txtSayi1.Text);
                double s2 = Convert.ToDouble(txtSayi2.Text);
                double sonuc = s1 * s2;
                lstSonuclar.Items.Add($"{s1} * {s2} = {sonuc}");
            }
            catch (Exception ex)
            {

                Console.WriteLine( "HATA:" + ex.Message);
            }
            
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtSayi1.Clear();
            txtSayi2.Clear();
            lstSonuclar.Items.Clear();
            txtSayi1.Focus();
        }
    }
}
