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
        Boolean free;
        int SelectGacha = 0;

        int yen = 0;
        int usedyen = 0;
        int chargeyen;

        int jewel = 0;
        int usedjewel = 0;
        int chargejewel;
         
        int SSRvalue = 0;
        int SRvalue = 0;
        int Rvalue = 0;
        int Cutevalue = 0;
        int Coolvalue = 0;
        int Passionvalue = 0;

        double SSRp;
        double SRp;
        double Rp;

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

            SSRp = 3.0;
            SRp = 12.0;
            Rp = 85.0;
            InitializeComponent();
            Text = "데레스테 가챠 시뮬레이터";
            Init(1);
        }

        private void Init(int mode)
        {
            String log = "";
            StreamReader sr = new StreamReader("carddb.csv", Encoding.GetEncoding("UTF-8"));
            int i = 0;
            SelectGachaBox.Items.Add("All");
            SelectGachaBox.Items.Add("Cute");
            SelectGachaBox.Items.Add("Cool");
            SelectGachaBox.Items.Add("Passion");
            SelectGachaBox.SelectedIndex = 0;

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

                if (no < 900000 && temp[18] == "gacha")
                {
                    if (mode == 0)
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
                    } else if (mode == 1)
                    {
                        if (temp[10] == "usual")
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
            if(jewel > 250 || free == true)
            {
                if (free == false)
                {
                    jewel -= 250;
                    usedjewel += 250;
                }
                String GachaResult = "";
                Card resultCard;
                int number = r.Next(0, 1000);
                if (number < 30)
                {
                    resultCard = SSRGet(SelectGacha);
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
                GachaResult += "[" + resultCard.Rarity + "] " + resultCard.CardName;
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
                Cool.Text = "Cool : " + Coolvalue;
                Passion.Text = "Passion : " + Passionvalue;

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
            else
            {
                MessageBox.Show("쥬엘이 부족합니다.");
            }
        }


        private void TenGacha_Click(object sender, EventArgs e)
        {
            if (jewel > 2500 || free == true)
            {
                if (free == false)
                {
                    jewel -= 2500;
                    usedjewel += 2500;
                }
                updatestatus();
                Card[] resultCard = new Card[10];
                String GachaResult = "";
                int number = 0;
                for (int i = 0; i < 9; i++)
                {
                    number = r.Next(0, 999);
                    if (number < 999 * (SSRp * 0.01))
                    {
                        resultCard[i] = SSRGet(SelectGacha);
                        SSRvalue++;
                    }
                    else if (number < 999 * (SRp * 0.01))
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
                    if (i != 0)
                    {
                        GachaResult += "\n";
                    }
                    GachaResult += "[" + resultCard[i].Rarity + "] " + resultCard[i].CardName;
                }

                number = r.Next(0, 150);
                if (number < 149 * (SSRp / (SSRp + SRp)))
                {
                    resultCard[9] = SSRGet(SelectGacha);
                    SSRvalue++;
                }
                else
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


                GachaResult += "\n" + "[" + resultCard[9].Rarity + "] " + resultCard[9].CardName;
                GachaResultText.Text = GachaResult;

                Cute.Text = "Cute : " + Cutevalue;
                Cool.Text = "Cool : " + Coolvalue;
                Passion.Text = "Passion : " + Passionvalue;

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
            else
            {
                MessageBox.Show("쥬엘이 부족합니다.");
            }
        }

        private void LimitedSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if(LimitedSwitch.Checked == true)
            {
                Init(1);
            }
            else
            {
                Init(0);
            }
        }

        private void GoldGacha_Click(object sender, EventArgs e)
        {
            if(jewel > 60 || free == true)
            {
                if (free == false)
                {
                    jewel -= 60;
                    usedjewel += 60;
                }
                updatestatus();
                String GachaResult = "";
                Card resultCard;
                int number = r.Next(0, 999);
                if (number < 999 * (SSRp * 0.01))
                {
                    resultCard = SSRGet(0);
                    SSRvalue++;
                }
                else if (number < 999 * (SRp * 0.01))
                {
                    resultCard = SRGet(0);
                    SRvalue++;
                }
                else
                {
                    resultCard = RGet(0);
                    Rvalue++;
                }
                GachaResult += "[" + resultCard.Rarity + "] " + resultCard.CardName;
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
                Cool.Text = "Cool : " + Coolvalue;
                Passion.Text = "Passion : " + Passionvalue;

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
            else
            {
                MessageBox.Show("쥬엘이 부족합니다.");
            }
        }

        private void InfiniteGacha_Click(object sender, EventArgs e)
        {
            if (free)
            {
                int get = 0;
                int count = 0;
                String GachaResult = "";
                Card resultCard;
                while (true)
                {
                    int number = r.Next(0, 999);
                    if (number < 999 * (SSRp * 0.01))
                    {
                        resultCard = SSRGet(0);
                        SSRvalue++;
                        get = 1;
                    }
                    else if (number < 999 * (SRp * 0.01))
                    {
                        resultCard = SRGet(0);
                        SRvalue++;
                    }
                    else
                    {
                        resultCard = RGet(0);
                        Rvalue++;
                    }
                    if (count == 0)
                    {
                        GachaResult += "［" + resultCard.Rarity + "］" + resultCard.CardName;
                    }
                    else
                    {
                        GachaResult += "\n［" + resultCard.Rarity + "］" + resultCard.CardName;
                    }
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

                    count++;
                    if (get == 1)
                    {
                        break;
                    }
                }
                Cute.Text = "Cute : " + Cutevalue;
                Cool.Text = "Cool : " + Coolvalue;
                Passion.Text = "Passion : " + Passionvalue;

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
            else
            {
                MessageBox.Show("공짜 모드에서만 사용 가능합니다.");
            }
        }


        private void OKGachaButton_Click(object sender, EventArgs e)
        {
            if(jewel > 2500 || free == true)
            {
                if(free == false)
                {
                    jewel -= 2500;
                    usedjewel += 2500;
                }
                updatestatus();
                Card[] resultCard = new Card[10];
                String GachaResult = "";
                int number = 0;
                for (int i = 0; i < 9; i++)
                {
                    number = r.Next(0, 999);
                    if (number < 999 * (SSRp * 0.01))
                    {
                        resultCard[i] = SSRGet(SelectGacha);
                        SSRvalue++;
                    }
                    else if (number < 999 * (SRp * 0.01))
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
                    if (i != 0)
                    {
                        GachaResult += "\n";
                    }
                    GachaResult += "[" + resultCard[i].Rarity + "] " + resultCard[i].CardName;
                }

                resultCard[9] = SSRGet(SelectGacha);
                SSRvalue++;
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


                GachaResult += "\n" + "[" + resultCard[9].Rarity + "] " + resultCard[9].CardName;
                GachaResultText.Text = GachaResult;

                Cute.Text = "Cute : " + Cutevalue;
                Cool.Text = "Cool : " + Coolvalue;
                Passion.Text = "Passion : " + Passionvalue;

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
            else
            {
                MessageBox.Show("쥬엘이 부족합니다.");
            }
        }

        private void SelectGachaBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SelectGachaBox.SelectedItem)
            {
                case "All":
                    {
                        SelectGacha = 0;
                        break;
                    }
                case "Cute":
                    {
                        SelectGacha = 1;
                        break;
                    }
                case "Cool":
                    {
                        SelectGacha = 2;
                        break;
                    }
                case "Passion":
                    {
                        SelectGacha = 3;
                        break;
                    }
            }
        }

        private void FesToggle_CheckedChanged(object sender, EventArgs e)
        {
            if(FesToggle.Checked == false)
            {
                SSRp = 3.0;
                SRp = 12.0;
                Rp = 85.0;
            }else if (FesToggle.Checked == true)
            {
                SSRp = 6.0;
                SRp = 12.0;
                Rp = 82.0;
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    
            {
                e.Handled = true;
            }
        }

        private void YenGo_Click(object sender, EventArgs e)
        {
            try
            {
                chargeyen = int.Parse(textBox1.Text);
                if (yen < 1000000)
                {
                    yen += chargeyen;
                    usedyen += yen;
                    updatestatus();
                    
                }
                else
                {
                    MessageBox.Show("한도를 초과하셨습니다");
                }
                chargeyen = 0;
            }
            catch(FormatException ex)
            {
                MessageBox.Show("숫자 입력이 잘못되었습니다.");
            }
        }

        private void charge(int cyen, int cjewel)
        {
            if(yen > cyen)
            {
                if(jewel < 1000000)
                {
                    yen -= cyen;
                    chargejewel = cjewel;
                    jewel += chargejewel;
                    chargejewel = 0;
                    updatestatus();
                }
                else
                {
                    MessageBox.Show("한도를 초과하셨습니다");
                }
            }
            else
            {
                MessageBox.Show("쥬엘이 부족합니다, 충전해주세요");
            }
            
        }

        private void updatestatus()
        {
            YenStatus.Text = "엔화 : " + yen;
            JewelStatus.Text = "쥬엘 : " + jewel;
            UsedJewelStatus.Text = "사용한 쥬엘 " + usedjewel;
            UsedYenStatus.Text = "사용한 엔화 " + usedyen;
        }

        private void JewelSet1Button_Click(object sender, EventArgs e)
        {
            charge(120, 60);
        }

        private void JewelSet2Button_Click(object sender, EventArgs e)
        {
            charge(480,360);
        }

        private void JewelSet3Button_Click(object sender, EventArgs e)
        {
            charge(960,760);
        }

        private void JewelSet4Button_Click(object sender, EventArgs e)
        {
            charge(1600,1300);
        }

        private void JewelSet5Button_Click(object sender, EventArgs e)
        {
            charge(3200,2650);
        }

        private void JewelSet6Button_Click(object sender, EventArgs e)
        {
            charge(5000,4200);
        }

        private void JewelSet7Button_Click(object sender, EventArgs e)
        {
            charge(9800,8400);
        }

        private void FreeGachaToggle_CheckedChanged(object sender, EventArgs e)
        {
            if(FreeGachaToggle.Checked == false)
            {
                free = false;
            }else
            {
                free = true;
            }
        }

        private void GachaMenu_Click(object sender, EventArgs e)
        {

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