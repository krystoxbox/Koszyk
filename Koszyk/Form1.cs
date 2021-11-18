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
        }

        private void klikaniePrzedmiotu(object sender, EventArgs e)
        {
            Button przycisk = (Button)sender;
            if (przycisk.BackColor == Color.White)
            {
                przycisk.BackColor = Color.LightGreen;
                dodajButton.Enabled = true;
                foreach (var item in buttonyPrzedmioty)
                {
                    if (item != przycisk)
                    {
                        item.Enabled = false;
                    }
                }
                zaktualizujLabelCeny(przycisk);
            }
            else
            {
                przycisk.BackColor = Color.White;
                dodajButton.Enabled = false;
                foreach (var item in buttonyPrzedmioty)
                {
                    item.Enabled = true;
                }
                cenaLbl.Text = "";
            }
            
        }

        private void zaktualizujLabelCeny(Button przyciskKlikniety)
        {
            switch (przyciskKlikniety.Text)
            {
                case "ORZECH":
                    cenaLbl.Text = "10 PLN";
                    break;
                case "JABŁKO":
                    cenaLbl.Text = "8 PLN";
                    break;
                case "WODA":
                    cenaLbl.Text = "1 PLN";
                    break;
                case "LÓD EKIPY":
                    cenaLbl.Text = "2 PLN";
                    break;
                case "MONSTER":
                    cenaLbl.Text = "6 PLN";
                    break;
                case "BUŁKA":
                    cenaLbl.Text = "1 PLN";
                    break;
                case "PIWO":
                    cenaLbl.Text = "4 PLN";
                    break;
                case "CHIPSY":
                    cenaLbl.Text = "5 PLN";
                    break;
                case "KONDOMY":
                    cenaLbl.Text = "20 PLN";
                    break;
                default:
                    cenaLbl.Text = "";
                    break;
            }   
        }
    }
}
