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
    public partial class Sheet : Form
    {
        Characteristics characteristics = new Characteristics();
       
        
        public Sheet()
        {
            InitializeComponent();                    
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }


        private void TB_Strength_TextChanged(object sender, EventArgs e)
        {
            //characteristics.Str = TB_Strength.Text;
            characteristics.BonusStr = characteristics.updateBonus(characteristics.Str);
            TB_BonusStrength.Text = characteristics.updateBonus(characteristics.Str);            
        }
        private void TB_BonusStrength_TextChanged(object sender, EventArgs e)
        {

        }
        private void TB_Dexterity_TextChanged(object sender, EventArgs e)
        {
            characteristics.Dex = TB_Dexterity.Text;
            //characteristics.BonusDex = characteristics.updateBonus(characteristics.Dex);
            //TB_BonusDexterity.Text = characteristics.updateBonus(characteristics.Dex);
            //TB_Initiative.Text = characteristics.updateBonus(characteristics.Dex);
        }
        private void TB_Constitution_TextChanged(object sender, EventArgs e)
        {
            characteristics.Con = TB_Constitution.Text;
            //characteristics.BonusCon = characteristics.updateBonus(characteristics.Con);
            //TB_BonusConstitution.Text = characteristics.updateBonus(characteristics.Con);
        }
        private void TB_Intelligence_TextChanged(object sender, EventArgs e)
        {
            characteristics.Inte = TB_Intelligence.Text;
           // characteristics.BonusInte = characteristics.updateBonus(characteristics.Inte);
           // TB_BonusIntelligence.Text = characteristics.updateBonus(characteristics.Inte);
        }
        private void TB_Wisdom_TextChanged(object sender, EventArgs e)
        {
            characteristics.Wis = TB_Wisdom.Text;
          //  characteristics.BonusWis = characteristics.updateBonus(characteristics.Wis);
           // TB_BonusWisdom.Text = characteristics.updateBonus(characteristics.Wis);
        }
        private void TB_Charisma_TextChanged(object sender, EventArgs e)
        {
            characteristics.Cha = TB_Charisma.Text;
           // characteristics.BonusCha = characteristics.updateBonus(characteristics.Cha);
           // TB_BonusCharisma.Text = characteristics.updateBonus(characteristics.Cha);
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Hide();
        }


        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void CB_Classes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CB_Race_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CB_Race.Text)
            {
                case "Humano":
                    Races.Human human = new Races.Human();
                    human.update(TB_Speed, TB_Dexterity, TB_Strength, TB_Constitution, TB_Intelligence, TB_Wisdom, TB_Charisma);
                    break;
            }
        }

        private void NUD_Strength_ValueChanged(object sender, EventArgs e)
        {
            decimal strValue = NUD_Strength.Value;           
            characteristics.Str = strValue;
            characteristics.BonusStr = characteristics.updateBonus(characteristics.Str);
            TB_BonusStrength.Text = characteristics.BonusStr;
        }
    }


}
