using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasWeek15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string[] makanan = new string[100];
        public static string[] minuman = new string[100];
        public static int countermakan = 4;
        public static int counterminum = 3;

        private void Form1_Load(object sender, EventArgs e)
        {
            makanan[0] = "Mie Instan";
            makanan[1] = "Telor";
            makanan[2] = "Roti";
            makanan[3] = "Keju";
            makanan[4] = "Daging Giling";

            minuman[0] = "Susu Sapi";
            minuman[1] = "Kopi";
            minuman[2] = "Teh";
            minuman[3] = "Bir";

            for (int i = 0; i < 5; i++)
            {
                listBoxKiri.Items.Add(makanan[i]);
            }
            for (int i = 0; i < 4; i++)
            {
                listBoxKiri.Items.Add(minuman[i]);
            }
        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            if (textBoxInput.Text == "")
            {
                MessageBox.Show("Masukkan inputtan dengan benar!!");
                radioButtonMakan.Checked = false;
                radioButtonMinum.Checked = false;
            }
            else
            {
                if (radioButtonMinum.Checked == false && radioButtonMakan.Checked == false)
                {
                    MessageBox.Show("Pilih salah satu kategori inputtan!!");
                    textBoxInput.Text = "";
                }
                if (radioButtonMakan.Checked == true)
                {
                    if (listBoxKiri.Items.Contains(textBoxInput.Text))
                    {
                        MessageBox.Show("Inputtan sudah ada di dalam list!!");
                        textBoxInput.Text = "";
                        radioButtonMakan.Checked = false;
                        radioButtonMinum.Checked = false;
                    }
                    else
                    {
                        countermakan++;
                        makanan[countermakan] = textBoxInput.Text;
                        listBoxKiri.Items.Add(textBoxInput.Text);
                        textBoxInput.Text = "";
                        radioButtonMakan.Checked = false;
                        radioButtonMinum.Checked = false;
                    }
                    
                }
                if (radioButtonMinum.Checked == true)
                {
                    if (listBoxKiri.Items.Contains(textBoxInput.Text))
                    {
                        MessageBox.Show("Inputtan sudah ada di dalam list!!");
                        textBoxInput.Text = "";
                        radioButtonMakan.Checked = false;
                        radioButtonMinum.Checked = false;
                    }
                    else
                    {
                        counterminum++;
                        makanan[counterminum] = textBoxInput.Text;
                        listBoxKiri.Items.Add(textBoxInput.Text);
                        textBoxInput.Text = "";
                        radioButtonMakan.Checked = false;
                        radioButtonMinum.Checked = false;
                    }
                }
                
            }
            
        }

        private void buttonMasukin_Click(object sender, EventArgs e)
        {
            foreach (object beverage in listBoxKiri.SelectedItems)
            {
                listBoxKanan.Items.Add(beverage);
            }

        }
        private void buttonHapus_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxMakan_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMakan.Checked == true)
            {
                for (int i = 0; i < minuman.Length; i++)
                {
                    listBoxKiri.Items.Remove(minuman[i]);
                }
                
            }
            if (checkBoxMakan.Checked == false)
            {
                for (int i = 0; i < minuman.Length; i++)
                {
                    listBoxKiri.Items.Add(minuman[i]);
                }

            }
        }

        private void checkBoxMinum_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
