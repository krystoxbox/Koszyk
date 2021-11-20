using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Koszyk
{
    public partial class Form1 : Form
    {
        List<Button> buttonyPrzedmioty = new List<Button>();
        List<Przedmiot> listaDodanychPrzedmiotow = new List<Przedmiot>();
        int cenaProduktu = 0;
        int iloscProduktuw = 0;
        int dukiToGej = 0;
        Button przycisk;
        Przedmiot wybranyprzedmiot;
        //


        public Form1()
        {
            InitializeComponent();
            buttonyPrzedmioty.Add(button1);
            buttonyPrzedmioty.Add(button2);
            buttonyPrzedmioty.Add(button3);
            buttonyPrzedmioty.Add(button4);
            buttonyPrzedmioty.Add(button5);
            buttonyPrzedmioty.Add(button6);
            buttonyPrzedmioty.Add(button7);
            buttonyPrzedmioty.Add(button8);
            buttonyPrzedmioty.Add(button9);
            numericUpDown1.Enabled = false;
            zamienbutton.Enabled = false;
            aktualizujCeneTotal();
        }

        private void klikaniePrzedmiotu(object sender, EventArgs e)
        {
            przycisk = (Button)sender;
            zamienbutton.Enabled = false;
            if (przycisk.BackColor == Color.White)
            {
                przycisk.BackColor = Color.LightGreen;
                dodajButton.Enabled = true;
                numericUpDown1.Enabled = true;
                numericUpDown1.Value = 1;
                foreach (var item in buttonyPrzedmioty)
                {
                    if (item.BackColor == Color.White)
                    {
                        item.Enabled = false;
                    }
                }
                zaktualizujLabelCeny(przycisk);
                iloscProduktuw = (int)numericUpDown1.Value;
                dukiToGej = cenaProduktu * iloscProduktuw;
                cenaLbl.Text = dukiToGej + " PLN";
            }
            else
            {
                resetPoDodaniu();
            }

        }

        private void resetPoDodaniu()
        {
            przycisk.BackColor = Color.White;
            dodajButton.Enabled = false;
            numericUpDown1.Enabled = false;
            foreach (var item in buttonyPrzedmioty)
            {
                item.Enabled = true;
                item.BackColor = Color.White;
            }
            cenaLbl.Text = "";
            

        }

        private void zaktualizujLabelCeny(Button przyciskKlikniety)
        {
            switch (przyciskKlikniety.Text)
            {
                case "ORZECH":
                    cenaProduktu = 10;
                    cenaLbl.Text = cenaProduktu + " PLN";
                    break;
                case "JABŁKO":
                    cenaProduktu = 8;
                    cenaLbl.Text = cenaProduktu + " PLN";
                    break;
                case "WODA":
                    cenaProduktu = 1;
                    cenaLbl.Text = cenaProduktu + " PLN";
                    break;
                case "LÓD EKIPY":
                    cenaProduktu = 2;
                    cenaLbl.Text = cenaProduktu + " PLN";
                    break;
                case "MONSTER":
                    cenaProduktu = 6;
                    cenaLbl.Text = cenaProduktu + " PLN";
                    break;
                case "BUŁKA":
                    cenaProduktu = 1;
                    cenaLbl.Text = cenaProduktu + " PLN";
                    break;
                case "PIWO":
                    cenaProduktu = 4;
                    cenaLbl.Text = cenaProduktu + " PLN";
                    break;
                case "CHIPSY":
                    cenaProduktu = 5;
                    cenaLbl.Text = cenaProduktu + " PLN";
                    break;
                case "KONDOMY":
                    cenaProduktu = 20;
                    cenaLbl.Text = cenaProduktu + " PLN"; ;
                    break;
                default:
                    cenaLbl.Text = "";
                    break;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            iloscProduktuw = (int)numericUpDown1.Value;
            dukiToGej = cenaProduktu * iloscProduktuw;
            cenaLbl.Text = dukiToGej + " PLN";
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            kup.Enabled = true;
            Przedmiot przedmiot = new Przedmiot(przycisk.Text, dukiToGej, iloscProduktuw);
            listaDodanychPrzedmiotow.Add(przedmiot);
            listaZakupuw.Items.Add(przycisk.Text + " " + dukiToGej + " PLN " + iloscProduktuw + " x " + cenaProduktu);
            aktualizujCeneTotal();
            resetPoDodaniu();
        }

        private void aktualizujCeneTotal()
        {
            int cenaTotal = 0;
            foreach (var item in listaDodanychPrzedmiotow)
            {
                cenaTotal += item.cena;
            }
            cenaTotalLbl.Text = cenaTotal.ToString() + " PLN ";
        }

        private void listaZakupuw_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaZakupuw.SelectedIndex > -1)
            {
                resetPoDodaniu();
                wybranyprzedmiot = listaDodanychPrzedmiotow[listaZakupuw.SelectedIndex];
                numericUpDown1.Value = wybranyprzedmiot.ilosc;
                cenaProduktu = wybranyprzedmiot.cena;
                numericUpDown1.Enabled = true;
                foreach (var item in buttonyPrzedmioty)
                {
                    if (item.Text == wybranyprzedmiot.nazwa)
                    {
                        item.BackColor = Color.LightGreen;
                        zamienbutton.Enabled = true;
                        numericUpDown1.Enabled = true;
                        foreach (var item2 in buttonyPrzedmioty)
                        {
                            if (item2.BackColor == Color.White)
                            {
                                item2.Enabled = false;
                            }
                        }
                        zaktualizujLabelCeny(item);
                        iloscProduktuw = (int)numericUpDown1.Value;
                        dukiToGej = cenaProduktu * iloscProduktuw;
                        cenaLbl.Text = dukiToGej + " PLN";
                    }

                } 
            }
            //Uh nie
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listaDodanychPrzedmiotow[listaZakupuw.SelectedIndex].nazwa = wybranyprzedmiot.nazwa; 
            listaDodanychPrzedmiotow[listaZakupuw.SelectedIndex].cena = dukiToGej;
            listaDodanychPrzedmiotow[listaZakupuw.SelectedIndex].ilosc = iloscProduktuw;
            listaZakupuw.Items[listaZakupuw.SelectedIndex] = (wybranyprzedmiot.nazwa + " " + dukiToGej + " PLN " + iloscProduktuw + " x " + cenaProduktu);
            aktualizujCeneTotal();
            resetPoDodaniu();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kup_Click(object sender, EventArgs e)
        {
            listaDodanychPrzedmiotow.Clear();
            listaZakupuw.Items.Clear();
            aktualizujCeneTotal();
            resetPoDodaniu();
        }
    }
}
