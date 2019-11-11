using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sheetDND
{
    class Characteristics
    {
        private decimal str;
        private string bonusStr;
        private string dex;
        private string bonusDex;
        private string con;
        private string bonusCon;
        private string inte;
        private string bonusInte;
        private string wis;
        private string bonusWis;
        private string cha;
        private string bonusCha;

        public Characteristics()
        {
        }

        public decimal Str
        {
            get
            {
                return this.str;
            }
            set
            {
                this.str = value;
            }
        }
        public string BonusStr
        {
            get
            {
                return this.bonusStr;
            }
            set
            {
                this.bonusStr = value;
            }
        }

        public string Dex
        {
            get
            {
                return this.dex;
            }
            set
            {
                this.dex = value;
            }
        }
        public string BonusDex
        {
            get
            {
                return this.bonusDex;
            }
            set
            {
                this.bonusDex = value;
            }
        }

        public string Con
        {
            get
            {
                return this.con;
            }
            set
            {
                this.con = value;
            }
        }
        public string BonusCon
        {
            get
            {
                return this.bonusCon;
            }
            set
            {
                this.bonusCon = value;
            }
        }

        public string Inte
        {
            get
            {
                return this.inte;
            }
            set
            {
                this.inte = value;
            }
        }
        public string BonusInte
        {
            get
            {
                return this.bonusInte;
            }
            set
            {
                this.bonusInte = value;
            }
        }

        public string Wis
        {
            get
            {
                return this.wis;
            }
            set
            {
                this.wis = value;
            }
        }
        public string BonusWis
        {
            get
            {
                return this.bonusWis;
            }
            set
            {
                this.bonusWis = value;
            }
        }

        public string Cha
        {
            get
            {
                return this.cha;
            }
            set
            {
                this.cha = value;
            }
        }
        public string BonusCha
        {
            get
            {
                return this.bonusCha;
            }
            set
            {
                this.bonusCha = value;
            }
        }

        public string updateBonus(decimal v)
        {
            switch (v)
            {
                case 1:
                    return "-5";
                    break;
                case 2:
                    return "-4";
                    break;
                case 3:
                    return "-4";
                    break;
                case 4:
                    return "-3";
                    break;
                case 5:
                    return "-3";
                    break;
                case 6:
                    return "-2";
                    break;
                case 7:
                    return "-2";
                    break;
                case 8:
                    return "-1";
                    break;
                case 9:
                    return "-1";
                    break;
                case 10:
                    return "0";
                    break;
                case 11:
                    return "0";
                    break;
                case 12:
                    return "+1";
                    break;
                case 13:
                    return "+1";
                    break;
                case 14:
                    return "+2";
                    break;
                case 15:
                    return "+2";
                    break;
                case 16:
                    return "+3";
                    break;
                case 17:
                    return "+3";
                    break;
                case 18:
                    return "+4";
                    break;
                case 19:
                    return "+4";
                    break;
                case 20:
                    return "+5";
                    break;
                case 21:
                    return "+5";
                    break;
                case 22:
                    return "+6";
                    break;
                case 23:
                    return "+6";
                    break;
                case 24:
                    return "+7";
                    break;
                case 25:
                    return "+7";
                    break;
                case 26:
                    return "+8";
                    break;
                case 27:
                    return "+8";
                    break;
                case 28:
                    return "+9";
                    break;
                case 29:
                    return "+9";
                    break;
                case 30:
                    return "+10";
                    break;
            } 

                 return ""; 

        }


    }
}
