using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ogrenci_Not_Hesaplama_Programi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double ort, but, ort2;
            int vize, final;
            String adi, soyadi;
            adi = textBox8.Text;
            label21.Text = adi;
            soyadi = textBox9.Text;
            label22.Text = soyadi;
            vize = Convert.ToInt16(textBox11.Text);
            final = Convert.ToInt16(textBox12.Text);

            ort = vize * 0.4 + final * 0.6;

            textBox13.Text = ort.ToString();
            listBox2.Items.Add("ADI:" + textBox8.Text);
            listBox2.Items.Add("SOYADİ:" + textBox9.Text);
            listBox2.Items.Add("Vize Notu:" + textBox11.Text);
            listBox2.Items.Add("Final Notu:" + textBox12.Text);
            listBox2.Items.Add("Ortalama:" + textBox13.Text);

            if (ort >= 0 && ort < 20)
            {
                label17.Text = "Dersten kaldiniz.Harf Notunuz FF.Büte girmeniz gerekiyor.";
                listBox2.Items.Add("Gecdi/Kaldi:" + label17.Text);

            }
            else if (ort >= 20 && ort < 30)
            {
                label17.Text = "Dersten kaldiniz.Harf Notunuz FD.Büte girmeniz gerekiyor.";
                listBox2.Items.Add("Gecdi/Kaldi:" + label17.Text);
            }
            else if (ort >= 30 && ort < 40)
            {
                label17.Text = "Dersten kaldiniz.Harf Notunuz DD.Büte girmeniz gerekiyor.";
                listBox2.Items.Add("Gecdi/Kaldi:" + label17.Text);
            }
            else if (ort >= 40 && ort <= 45)
            {
                label17.Text = "Dersten kosullu gectiniz.Harf Notunuz DC.Büte girebilirsiniz. İsteğe bağlı.";
                listBox2.Items.Add("Gecdi/Kaldi:" + label17.Text);
            }
            else if (ort > 45 && ort < 60)
            {
                label17.Text = "Dersten  gectiniz.Harf Notunuz CC.Büte girebilirsiniz. İsteğe bağlı.";
                listBox2.Items.Add("Gecdi/Kaldi:" + label17.Text);
            }

            else if (ort >= 60 && ort < 70)
            {
                label17.Text = "Dersten gectiniz.Harf Notunuz CB.Büte girebilirsiniz. İsteğe bağlı.";
                listBox2.Items.Add("Gecdi/Kaldi:" + label17.Text);
            }

            else if (ort >= 70 && ort < 80)
            {
                label17.Text = "Dersten gectiniz.Harf Notunuz BB.Büte girebilirsiniz. İsteğe bağlı.";
                listBox2.Items.Add("Gecdi/Kaldi:" + label17.Text);
            }

            else if (ort >= 80 && ort < 90)
            {
                label17.Text = "Dersten gectiniz.Harf Notunuz AB.Büte girebilirsiniz. İsteğe bağlı.";
                listBox2.Items.Add("Gecdi/Kaldi:" + label17.Text);
            }

            else if (ort >= 90 && ort < 100)
            {
                label17.Text = "Dersten gectiniz.Harf Notunuz AA.Büte girebilirsiniz. İsteğe bağlı.";
                listBox2.Items.Add("Gecdi/Kaldi:" + label17.Text);
            }
            else
            {
                MessageBox.Show("Not Degerleri hatali tekrar giriniz.ortalama hesaplanamadi");
            }
        }
    }
    }




