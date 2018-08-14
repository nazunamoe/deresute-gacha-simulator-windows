using Info;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
         
        int SSRvalue = 0;
        int SRvalue = 0;
        int Rvalue = 0;
        int Cutevalue = 0;
        int Coolvalue = 0;
        int Passionvalue = 0;

        ArrayList SSRList = new ArrayList();
        ArrayList CuteSSRList = new ArrayList();
        ArrayList CoolSSRList = new ArrayList();
        ArrayList PassionSSRList = new ArrayList();

        ArrayList SRList = new ArrayList();
        ArrayList CuteSRList = new ArrayList();
        ArrayList CoolSRList = new ArrayList();
        ArrayList PassionSRList = new ArrayList();

        ArrayList RList = new ArrayList();
        ArrayList CuteRList = new ArrayList();
        ArrayList CoolRList = new ArrayList();
        ArrayList PassionRList = new ArrayList();

        ArrayList CardList = new ArrayList();


        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
            String log = "";
            StreamReader sr = new StreamReader("carddb.csv", Encoding.GetEncoding("UTF-8"));
            int i = 0;
            while (!sr.EndOfStream)
            {
                string s = sr.ReadLine();
                string[] temp = s.Split('	');
                i++;
                int no = int.Parse(temp[0]);
                int vocal = int.Parse(temp[5]);
                int dance = int.Parse(temp[6]);
                int visual = int.Parse(temp[7]);
                int total = int.Parse(temp[8]);
                CardList.Add(new Card(no, temp[1], temp[2], temp[3], temp[4], vocal, dance, visual, total, temp[11], temp[16]));
                if(no < 900000 && temp[18] == "gacha"&& temp[10] == "usual")
                {
                    if (temp[3] == "SS RARE")
                    {
                        SSRList.Add(new Card(no, temp[1], temp[2], temp[3], temp[4], vocal, dance, visual, total, temp[11], temp[16]));
                        if (temp[4] == "CUTE")
                        {
                            CuteSSRList.Add(new Card(no, temp[1], temp[2], temp[3], temp[4], vocal, dance, visual, total, temp[11], temp[16]));
                        }
                        else if (temp[4] == "COOL")
                        {
                            CoolSSRList.Add(new Card(no, temp[1], temp[2], temp[3], temp[4], vocal, dance, visual, total, temp[11], temp[16]));
                        }
                        else if (temp[4] == "PASSION")
                        {
                            PassionSSRList.Add(new Card(no, temp[1], temp[2], temp[3], temp[4], vocal, dance, visual, total, temp[11], temp[16]));
                        }
                    }
                    else if (temp[3] == "S RARE")
                    {
                        SRList.Add(new Card(no, temp[1], temp[2], temp[3], temp[4], vocal, dance, visual, total, temp[11], temp[16]));
                        if (temp[4] == "CUTE")
                        {
                            CuteSRList.Add(new Card(no, temp[1], temp[2], temp[3], temp[4], vocal, dance, visual, total, temp[11], temp[16]));
                        }
                        else if (temp[4] == "COOL")
                        {
                            CoolSRList.Add(new Card(no, temp[1], temp[2], temp[3], temp[4], vocal, dance, visual, total, temp[11], temp[16]));
                        }
                        else if (temp[4] == "PASSION")
                        {
                            PassionSRList.Add(new Card(no, temp[1], temp[2], temp[3], temp[4], vocal, dance, visual, total, temp[11], temp[16]));
                        }
                    }
                    else if (temp[3] == "RARE")
                    {

                        RList.Add(new Card(no, temp[1], temp[2], temp[3], temp[4], vocal, dance, visual, total, temp[11], temp[16]));
                        if (temp[4] == "CUTE")
                        {
                            CuteRList.Add(new Card(no, temp[1], temp[2], temp[3], temp[4], vocal, dance, visual, total, temp[11], temp[16]));
                        }
                        else if (temp[4] == "COOL")
                        {
                            CoolRList.Add(new Card(no, temp[1], temp[2], temp[3], temp[4], vocal, dance, visual, total, temp[11], temp[16]));
                        }
                        else if (temp[4] == "PASSION")
                        {
                            PassionRList.Add(new Card(no, temp[1], temp[2], temp[3], temp[4], vocal, dance, visual, total, temp[11], temp[16]));
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InformationButton_Click(object sender, EventArgs e)
        {

        }

        private Card SSRGet(int attr)
        {
            Card returncard = null;
            switch (attr)
            {
                case 0:
                    {
                        int number = r.Next(0, SSRList.Count);
                        returncard = (Card)SSRList[number];
                        break;
                    }
                case 1:
                    {
                        int number = r.Next(0, CuteSSRList.Count);
                        returncard = (Card)CuteSSRList[number];
                        break;
                    }
                case 2:
                    {
                        int number = r.Next(0, CoolSSRList.Count);
                        returncard = (Card)CoolSSRList[number];
                        break;
                    }
                case 3:
                    {
                        int number = r.Next(0, PassionSSRList.Count);
                        returncard = (Card)PassionSSRList[number];
                        break;
                    }
                default:
                    {
                        int number = r.Next(0, SSRList.Count);
                        returncard = (Card)SSRList[number];
                        break;
                        break;
                    }
            }
            return returncard;
        }

        private Card SRGet(int attr)
        {
            Card returncard = null;
            switch (attr)
            {
                case 0:
                    {
                        int number = r.Next(0, SRList.Count);
                        returncard = (Card)SRList[number];
                        break;
                    }
                case 1:
                    {
                        int number = r.Next(0, CuteSRList.Count);
                        returncard = (Card)CuteSRList[number];
                        break;
                    }
                case 2:
                    {
                        int number = r.Next(0, CoolSRList.Count);
                        returncard = (Card)CoolSRList[number];
                        break;
                    }
                case 3:
                    {
                        int number = r.Next(0, PassionSRList.Count);
                        returncard = (Card)PassionSRList[number];
                        break;
                    }
                default:
                    {
                        int number = r.Next(0, SRList.Count);
                        returncard = (Card)SRList[number];
                        break;
                        break;
                    }
            }
            return returncard;
        }

        private Card RGet(int attr)
        {
            Card returncard = null;
            switch (attr)
            {
                case 0:
                    {
                        int number = r.Next(0, RList.Count);
                        returncard = (Card)RList[number];
                        break;
                    }
                case 1:
                    {
                        int number = r.Next(0, CuteRList.Count);
                        returncard = (Card)CuteRList[number];
                        break;
                    }
                case 2:
                    {
                        int number = r.Next(0, CoolRList.Count);
                        returncard = (Card)CoolRList[number];
                        break;
                    }
                case 3:
                    {
                        int number = r.Next(0, PassionRList.Count);
                        returncard = (Card)PassionRList[number];
                        break;
                    }
                default:
                    {
                        int number = r.Next(0, RList.Count);
                        returncard = (Card)RList[number];
                        break;
                    }
            }
            return returncard;
        }

        private void OneGacha_Click(object sender, EventArgs e)
        {
            String GachaResult = "";
            Card resultCard;
            int number = r.Next(0, 1000);
            if (number < 30)
            {
                resultCard = SSRGet(0);
                SSRvalue++;
            }
            else if (number < 130)
            {
                resultCard = SRGet(0);
                SRvalue++;
            }
            else
            {
                resultCard = RGet(0);
                Rvalue++;
            }
            GachaResult += "［" + resultCard.Rarity + "］" + resultCard.CardName;
            switch (resultCard.Attr)
            {
                case "CUTE":
                    {
                        Cutevalue++;
                        break;
                    }
                case "COOL":
                    {
                        Coolvalue++;
                        break;
                    }
                case "PASSION":
                    {
                        Passionvalue++;
                        break;
                    }
            }
            Cute.Text = "Cute : " + Cutevalue;
            Cool.Text = "Cute : " + Coolvalue;
            Passion.Text = "Cute : " + Passionvalue;

            Cutevalue = 0;
            Coolvalue = 0;
            Passionvalue = 0;

            SSR.Text = "SSR : " + SSRvalue;
            SR.Text = "SR : " + SRvalue;
            R.Text = "R : " + Rvalue;

            SSRvalue = 0;
            SRvalue = 0;
            Rvalue = 0;

            GachaResultText.Text = GachaResult;

        }


        private void TenGacha_Click(object sender, EventArgs e)
        {
            Card[] resultCard = new Card[10];
            String GachaResult = "";
            int number = 0;
            for (int i = 0; i < 9; i++)
            {
                number = r.Next(0, 1000);
                if (number < 30)
                {
                    resultCard[i] = SSRGet(0);
                    SSRvalue++;
                }
                else if (number < 150)
                {
                    resultCard[i] = SRGet(0);
                    SRvalue++;
                }
                else
                {
                    resultCard[i] = RGet(0);
                    Rvalue++;
                }
                switch (resultCard[i].Attr)
                {
                    case "CUTE":
                        {
                            Cutevalue++;
                            break;
                        }
                    case "COOL":
                        {
                            Coolvalue++;
                            break;
                        }
                    case "PASSION":
                        {
                            Passionvalue++;
                            break;
                        }
                }
                if(i != 0)
                {
                    GachaResult += "\n";
                }
                GachaResult += "［" + resultCard[i].Rarity + "］" + resultCard[i].CardName;
            }

            number = r.Next(0, 150);

            if (number < 30)
            {
                resultCard[9] = SSRGet(0);
                SSRvalue++;
            }
            else if (number < 150)
            {
                resultCard[9] = SRGet(0);
                SRvalue++;
            }
            switch (resultCard[9].Attr)
            {
                case "CUTE":
                    {
                        Cutevalue++;
                        break;
                    }
                case "COOL":
                    {
                        Coolvalue++;
                        break;
                    }
                case "PASSION":
                    {
                        Passionvalue++;
                        break;
                    }
            }


            GachaResult += "\n" + "［" + resultCard[9].Rarity + "］" + resultCard[9].CardName;
            GachaResultText.Text = GachaResult;

            Cute.Text = "Cute : " + Cutevalue;
            Cool.Text = "Cute : " + Coolvalue;
            Passion.Text = "Cute : " + Passionvalue;

            Cutevalue = 0;
            Coolvalue = 0;
            Passionvalue = 0;

            SSR.Text = "SSR : " + SSRvalue;
            SR.Text = "SR : " + SRvalue;
            R.Text = "R : " + Rvalue;

            SSRvalue = 0;
            SRvalue = 0;
            Rvalue = 0;
        }
    }
}

namespace Info
{

    public class Card
    {
        public int number;

        public String CardName;
        public String CharaName;
        public String Rarity;
        public String Attr;

        public int Vocal;
        public int Dance;
        public int Visual;
        public int Total;

        public String Skill;
        public String Center_Skill;

        public Card(int num, string v1, string v2, string v3, string v4, int v5, int v6, int v7, int v8, string v9, string v10)
        {
            this.number = num;
            this.CardName = v1;
            this.CharaName = v2;
            this.Rarity = v3;
            this.Attr = v4;
            this.Vocal = v5;
            this.Dance = v6;
            this.Visual = v7;
            this.Total = v8;
            this.Skill = v9;
            this.Center_Skill = v10;
        }
    }
}