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
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
        }

        public static string[] makanan = new string[100];
        public static string[] minuman = new string[100];
        public static int countermakan = 4;
        public static int counterminum = 3;

        private void FormUtama_Load(object sender, EventArgs e)
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
                        minuman[counterminum] = textBoxInput.Text;
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
            for (int i = 0; i < listBoxKiri.SelectedIndices.Count; i++)
            {
                if (!listBoxKanan.Items.Contains(listBoxKiri.SelectedItems[i]))
                {
                    listBoxKanan.Items.Add(listBoxKiri.SelectedItems[i]);
                }
            }
            listBoxKiri.ClearSelected();
            checkBoxMakan.Checked = false;
            checkBoxMakan.Checked = false;
        }
        private void buttonHapus_Click(object sender, EventArgs e)
        {
            if (listBoxKanan.SelectedItems.Count == 0)
            {
                listBoxKanan.Items.Clear();
            }
            else
            {
                for (int i = listBoxKanan.SelectedIndices.Count - 1; i>= 0; i--)
                {
                    listBoxKanan.Items.Remove(listBoxKanan.SelectedItems[i]);
                }
                
            }
            listBoxKanan.ClearSelected();
        }

        private void checkBoxMakan_CheckedChanged(object sender, EventArgs e)
        {
            int counter = 0;

            int counter2 = 0;
            int[] posisimakanan = new int[100];
            if (checkBoxMakan.Checked == true)
            {
                try
                {
                    foreach (var menu in listBoxKiri.Items)
                    {
                        for (int i = 0; i < 100; i++)
                        {
                            if (makanan[i] == menu.ToString())
                            {
                                posisimakanan[counter2] = counter;
                                counter2++;
                            }
                        }
                        counter++;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                for (int i = 0; i < 100; i++)
                {
                    listBoxKiri.SetSelected(posisimakanan[i], true);
                }
            }
            if (checkBoxMakan.Checked == false)
            {
                listBoxKiri.ClearSelected();
            }


        }
        private void checkBoxMinum_CheckedChanged(object sender, EventArgs e)
        {
            int counter = 0;
            int counter2 = 0;
            int[] posisiminum = new int[100];
            if (checkBoxMinum.Checked == true)
            {
                try
                {
                    foreach (var menu in listBoxKiri.Items)
                    {
                        for (int i = 0; i < 100; i++)
                        {

                            if (minuman[i] == menu.ToString())
                            {
                                posisiminum[counter2] = counter;
                                counter2++;
                            }
                        }
                        counter++;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                for (int i = 0; i < 100; i++)
                {
                    listBoxKiri.SetSelected(posisiminum[i], true);
                }
            }
            if (checkBoxMinum.Checked == false)
            {
                listBoxKiri.ClearSelected();
            }
        }
    }
}
