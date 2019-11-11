using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sheetDND.Races
{
    class Human
    {
        private string level;
        private string speed;

        private int thrash;

        public Human()
        {
            Level = "1";
            Speed = "30ft";
        }

        public string Level { get => level; set => level = value; }
        public string Speed { get => speed; set => speed = value; }

        public void update(TextBox TB_Speed, TextBox TB_Dexterity, TextBox TB_Strength, TextBox TB_Constitution, TextBox TB_Intelligence, TextBox TB_Wisdom, TextBox TB_Charisma)
        {
            TB_Speed.Text = this.Speed;
            if (int.TryParse(TB_Dexterity.Text, out thrash))
            {

            }
                
        }
    }
}
