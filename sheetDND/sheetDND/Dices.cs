using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sheetDND
{
    public partial class Dices : Form
    {
        Random rand = new Random();
        public Dices()
        {
            InitializeComponent();
        }

        private void Dices_Load(object sender, EventArgs e)
        {

        }

        private void Button_D4_Click(object sender, EventArgs e)
        {
            throwDice(1, 5, TB_D4);
        }
        private void Button_D6_Click(object sender, EventArgs e)
        {
            throwDice(1, 7, TB_D6);
        }
        private void Button_D8_Click(object sender, EventArgs e)
        {
            throwDice(1, 9, TB_D8);
        }
        private void Button_D10_Click(object sender, EventArgs e)
        {
            throwDice(1, 11, TB_D10);
        }
        private void Button_D12_Click(object sender, EventArgs e)
        {
            throwDice(1, 13, TB_D12);
        }
        private void Button_D20_Click(object sender, EventArgs e)
        {
            throwDice(1, 21, TB_D20);
        }

        private void Button_Clear_Click(object sender, EventArgs e)
        {
            TB_Results.Text = "";
            TB_D4.Text = "";
            TB_D6.Text = "";
            TB_D8.Text = "";
            TB_D10.Text = "";
            TB_D12.Text = "";
            TB_D20.Text = "";
            TB_NewCharacteristics.Text = "";
        }
        private void Button_ThrowAll_Click(object sender, EventArgs e)
        {
            bool esPosible = false;
            int total = 0;
            int thrash;

            esPosible = int.TryParse(TB_D4.Text, out thrash);
            if (esPosible)
            {
                for (int i = 0; i < Int32.Parse(TB_D4.Text); i++)
                {
                    int numRand = rand.Next(1, 5);
                    total += numRand;
                    TB_Results.Text += numRand.ToString() + "  ";
                    
                }
            }
            esPosible = int.TryParse(TB_D6.Text, out thrash);
            if (esPosible)
            {
                for (int i = 0; i < Int32.Parse(TB_D6.Text); i++)
                {
                    int numRand = rand.Next(1, 7);
                    total += numRand;
                    TB_Results.Text += numRand.ToString() + "  ";
                }
            }
            esPosible = int.TryParse(TB_D8.Text, out thrash);
            if (esPosible)
            {
                for (int i = 0; i < Int32.Parse(TB_D8.Text); i++)
                {
                    int numRand = rand.Next(1, 9);
                    total += numRand;
                    TB_Results.Text += numRand.ToString() + "  ";
                }
            }
            esPosible = int.TryParse(TB_D10.Text, out thrash);
            if (esPosible)
            {
                for (int i = 0; i < Int32.Parse(TB_D10.Text); i++)
                {
                    int numRand = rand.Next(1, 11);
                    total += numRand;
                    TB_Results.Text += numRand.ToString() + "  ";
                }
            }
            esPosible = int.TryParse(TB_D12.Text, out thrash);
            if (esPosible)
            {
                for (int i = 0; i < Int32.Parse(TB_D12.Text); i++)
                {
                    int numRand = rand.Next(1, 13);
                    total += numRand;
                    TB_Results.Text += numRand.ToString() + "  ";
                }
            }

            esPosible = int.TryParse(TB_D20.Text, out thrash);
            if (esPosible)
            {
                for (int i = 0; i < Int32.Parse(TB_D20.Text); i++)
                {
                    int numRand = rand.Next(1, 21);
                    total += numRand;
                    TB_Results.Text += numRand.ToString() + "  ";
                }
            }

            TB_Results.Text += "(Total = " + total.ToString() + ")" + Environment.NewLine;
        }
        private void Button_GenerateCharacteristics_Click(object sender, EventArgs e)
        {
            TB_NewCharacteristics.Text = "";
            int[] valores = { 0, 0, 0, 0, 0, 0 };
            int total;
            for (int i = 0; i < 6; i++)
            {
                total = rand.Next(9, 19);
                valores[i] = total;
                TB_NewCharacteristics.Text += valores[i].ToString() + "  ";
            }
        }
       
        private void Button_Back_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Hide();
        }

        private void throwDice(int minimo, int maximo, TextBox t)
        {
            int total = 0;
            int thrash;
            if (int.TryParse(t.Text, out thrash) && Int32.Parse(t.Text) != 0)
            {
                for (int i = 0; i < Int32.Parse(t.Text); i++)
                {
                    int numRand = rand.Next(minimo, maximo);
                    total += numRand;
                    TB_Results.Text += numRand.ToString() + "  ";
                }
                TB_Results.Text += "(Total = " + total.ToString() + ")" + Environment.NewLine;
            }
            else
            {
                int numRand = rand.Next(minimo, maximo);
                TB_Results.Text += numRand.ToString() + Environment.NewLine;
            }
        }
    }
}
