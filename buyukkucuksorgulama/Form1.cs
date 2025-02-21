using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buyukkucuksorgulama
{
    public partial class Form1: Form
    {
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                string veri = textBox1.Text + "-";
                listBox1.Items.Add(textBox1.Text);
            }
            else
            {
                MessageBox.Show("LÜTFEN ALANLARI BOŞ BIRAKMAYIN..");
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string secilenKelime = listBox1.SelectedItem.ToString();
                string randomKelime = RandomHarfDegistir(secilenKelime);
                listBox2.Items.Add(randomKelime);

            }
            
        }

        private string RandomHarfDegistir(string secilenKelime)
        {
            StringBuilder yeniKelime = new StringBuilder();
            for (int i =0; i < secilenKelime.Length; i++)
            {
                if (random.Next(2) == 0)
                    yeniKelime.Append(char.ToLower(secilenKelime[i]));
                else
                    yeniKelime.Append(char.ToUpper(secilenKelime[i]));
            }
            return yeniKelime.ToString();

        }
    }
}
