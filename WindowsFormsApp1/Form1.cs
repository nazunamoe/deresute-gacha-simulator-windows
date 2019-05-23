using Info;
using System;
using System.Collections;
using System.IO;
using System.Text;
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

        string skill_name = "";
        string skill_explain = "";

        string leaderskill_name = "";
        string leaderskill_explain = "";

        string attr;

        int no = 0;
        int hp_min = 0;
        int vocal_min = 0;
        int dance_min = 0;
        int visual_min = 0;
        int total_min = 0;

        int hp_max = 0;
        int vocal_max = 0;
        int dance_max = 0;
        int visual_max = 0;
        int total_max = 0;

        int num = 0;
        int limited = 0;
        int fes = 0;

        double SSRp;
        double SRp;
        double Rp;

        String selectedIdol = "";

        Boolean SSROnly = false;
        Boolean SROnly = false;
        Boolean ROnly = false;
        Boolean NOnly = false;

        Boolean FesOnly = false;
        Boolean LimitedOnly = false;
        Boolean UsualOnly = false;
        Boolean EventOnly = false;

        Boolean CuteOnly = false;
        Boolean CoolOnly = false;
        Boolean PassionOnly = false;
        Boolean AllCardOnly = false;

        Boolean initexit = false;
        Boolean limitedgacha = false;

        Boolean AllRaritySwitch = false;
        Boolean AllTypeSwitch = false;

        ArrayList SSRList = new ArrayList();

        ArrayList SRList = new ArrayList();

        ArrayList RList = new ArrayList();

        ArrayList NList = new ArrayList();

        ArrayList AllCardList = new ArrayList();



        Random r = new Random();
        StreamReader sr;
        public Form1()
        {

            SSRp = 3.0;
            SRp = 12.0;
            Rp = 85.0;
            InitializeComponent();
            Text = "데레스테 가챠 시뮬레이터";
            Init(0);





        }

        private void Init(int mode)
        {

            SelectGachaBox.Items.Add("All");
            SelectGachaBox.Items.Add("Cute");
            SelectGachaBox.Items.Add("Cool");
            SelectGachaBox.Items.Add("Passion");
            SelectGachaBox.SelectedIndex = 0;
            sr = new StreamReader("card_info_availble.csv", Encoding.GetEncoding("UTF-8"));
            initCardInfoList(sr, mode);
        }

        private void updateCardInfoList()
        {
            //MessageBox.Show("SSROnly : " + SSROnly.ToString() + "\n" + "SROnly : " + SROnly.ToString() + "\n" + "ROnly : " + ROnly.ToString() + "\n" + "NOnly : " + NOnly.ToString());

            sr = new StreamReader("card_info_availble.csv", Encoding.GetEncoding("UTF-8"));
            CardInfoList.Items.Clear();
            initCardInfoList(sr, 1);
        }


        private void initCardInfoList(StreamReader sr, int mode)
        {
            int i = 0;
            while (!sr.EndOfStream)
            // 0 no . 1 cardname 2 charaname 3 rarity 4 attr
            { //5,6,7,8,9 = hp, vocal, dance, visual, total - min ; 10,11,12,13,14 = hp, vocal, dance, visual, total - max 15,16 - skill name, exp, 17,18 - leaderskill name, exp
                string s = sr.ReadLine();
                string[] temp = s.Split('	');

                i++;

                String rarity = "";

                switch (temp[3])
                {
                    case "1":
                        {
                            rarity = "NORMAL";
                            break;
                        }
                    case "2":
                        {
                            rarity = "NORMAL";
                            break;
                        }
                    case "3":
                        {
                            rarity = "RARE";
                            break;
                        }
                    case "4":
                        {
                            rarity = "RARE";
                            break;
                        }
                    case "5":
                        {
                            rarity = "S RARE";
                            break;
                        }
                    case "6":
                        {
                            rarity = "S RARE";
                            break;
                        }
                    case "7":
                        {
                            rarity = "SS RARE";
                            break;
                        }
                    case "8":
                        {
                            rarity = "SS RARE";
                            break;
                        }
                }

                num = int.Parse(temp[0]);

                hp_min = int.Parse(temp[5]);
                vocal_min = int.Parse(temp[6]);
                dance_min = int.Parse(temp[7]);
                visual_min = int.Parse(temp[8]);
                total_min = int.Parse(temp[9]);

                hp_max = int.Parse(temp[10]);
                vocal_max = int.Parse(temp[11]);
                dance_max = int.Parse(temp[12]);
                visual_max = int.Parse(temp[13]);
                total_max = int.Parse(temp[14]);

                switch (temp[4])
                {
                    case "1":
                        {
                            attr = "CUTE";
                            break;
                        }
                    case "2":
                        {
                            attr = "COOL";
                            break;
                        }
                    case "3":
                        {
                            attr = "PASSION";
                            break;
                        }
                }

                if (rarity != "NORMAL" || rarity != "NORMAL+")
                {
                    skill_name = temp[15];
                    skill_explain = temp[16];

                    leaderskill_name = temp[17];
                    leaderskill_explain = temp[18];
                }
                limited = int.Parse(temp[20]);
                fes = int.Parse(temp[21]);
                if (mode == 0)
                {
                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);

                    AllCardList.Add(new Card(num, temp[1], temp[2], rarity, attr, hp_min, vocal_min, dance_min, visual_min, hp_max, vocal_max, dance_max, visual_max, skill_name, skill_explain, leaderskill_name, leaderskill_explain, temp[19], limited, fes));
                    if (num % 2 == 1)
                    {
                        if (limited == 1)
                        {
                            LimitedSelectBox.Items.Add("［" + rarity + "］" + temp[1]);
                        }
                        if (i >= 2)
                        {
                            for (int x = 0; x < i; x++)
                            {
                                if (!CharaBox.Items.Contains("［" + attr + "］" + temp[2]))
                                {
                                    CharaBox.Items.Add("［" + attr + "］" + temp[2]);
                                }
                            }

                        }
                        else
                        {
                            CharaBox.Items.Add("［" + attr + "］" + temp[2]);
                        }
                        //  public Card(int num, string cardname, string charaname, string rarity, string Attr, int hp_min, int vo_min, int da_min, int vi_min, int hp_max, int vo_max, int da_max, int vi_max, string skill_name, string skill_explain, string leaderskill_name, string leaderskill_explain)

                        // SSRList
                        // SRList
                        // RList
                        if (temp[19] == "")
                        {
                            switch (rarity)
                            {
                                case "NORMAL":
                                    {
                                        NList.Add(new Card(num, temp[1], temp[2], rarity, attr, hp_min, vocal_min, dance_min, visual_min, hp_max, vocal_max, dance_max, visual_max, skill_name, skill_explain, leaderskill_name, leaderskill_explain, temp[19], limited, fes));
                                        break;
                                    }
                                case "RARE":
                                    {
                                        RList.Add(new Card(num, temp[1], temp[2], rarity, attr, hp_min, vocal_min, dance_min, visual_min, hp_max, vocal_max, dance_max, visual_max, skill_name, skill_explain, leaderskill_name, leaderskill_explain, temp[19], limited, fes));
                                        break;
                                    }
                                case "S RARE":
                                    {
                                        SRList.Add(new Card(num, temp[1], temp[2], rarity, attr, hp_min, vocal_min, dance_min, visual_min, hp_max, vocal_max, dance_max, visual_max, skill_name, skill_explain, leaderskill_name, leaderskill_explain, temp[19], limited, fes));
                                        break;
                                    }
                                case "SS RARE":
                                    {
                                        SSRList.Add(new Card(num, temp[1], temp[2], rarity, attr, hp_min, vocal_min, dance_min, visual_min, hp_max, vocal_max, dance_max, visual_max, skill_name, skill_explain, leaderskill_name, leaderskill_explain, temp[19], limited, fes));
                                        break;
                                    }
                            }
                        }
                    }
                }
                else if (mode == 1) // data update (info list only)
                {
                    String name = temp[2];
                    if (SSROnly && rarity == "SS RARE")
                    {
                        switch (temp[4])
                        {
                            case "1":
                                {
                                    if (CuteOnly)
                                    {
                                        if (selectedIdol == "")
                                        {
                                            if (LimitedOnly)
                                            {
                                                if (limited == 1)
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                            else if (FesOnly)
                                            {
                                                if (fes == 1)
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                            else if (EventOnly)
                                            {
                                                if (temp[19] != "")
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                            else if (UsualOnly)
                                            {
                                                if (fes == 0 && limited == 0 && temp[19] == "")
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                            else
                                            {
                                                CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                            }
                                        }
                                        else
                                        {
                                            if (name == selectedIdol)
                                            {
                                                if (LimitedOnly)
                                                {
                                                    if (limited == 1)
                                                    {
                                                        CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                    }
                                                }
                                                else if (FesOnly)
                                                {
                                                    if (fes == 1)
                                                    {
                                                        CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                    }
                                                }
                                                else if (EventOnly)
                                                {
                                                    if (temp[19] != "")
                                                    {
                                                        CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                    }
                                                }
                                                else if (UsualOnly)
                                                {
                                                    if (fes == 0 && limited == 0 && temp[19] == "")
                                                    {
                                                        CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                    }
                                                }
                                                else
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                        }
                                    }
                                    break;
                                }
                            case "2":
                                {
                                    if (CoolOnly)
                                    {
                                        if (selectedIdol == "")
                                        {
                                            if (LimitedOnly)
                                            {
                                                if (limited == 1)
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                            else if (FesOnly)
                                            {
                                                if (fes == 1)
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                            else if (EventOnly)
                                            {
                                                if (temp[19] != "")
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                            else if (UsualOnly)
                                            {
                                                if (fes == 0 && limited == 0 && temp[19] == "")
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                            else
                                            {
                                                CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                            }
                                        }
                                        else
                                        {
                                            if (name == selectedIdol)
                                            {
                                                if (LimitedOnly)
                                                {
                                                    if (limited == 1)
                                                    {
                                                        CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                    }
                                                }
                                                else if (FesOnly)
                                                {
                                                    if (fes == 1)
                                                    {
                                                        CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                    }
                                                }
                                                else if (EventOnly)
                                                {
                                                    if (temp[19] != "")
                                                    {
                                                        CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                    }
                                                }
                                                else if (UsualOnly)
                                                {
                                                    if (fes == 0 && limited == 0 && temp[19] == "")
                                                    {
                                                        CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                    }
                                                }
                                                else
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                        }
                                    }
                                    break;
                                }
                            case "3":
                                {
                                    if (PassionOnly)
                                    {
                                        if (selectedIdol == "")
                                        {
                                            if (LimitedOnly)
                                            {
                                                if (limited == 1)
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                            else if (FesOnly)
                                            {
                                                if (fes == 1)
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                            else if (EventOnly)
                                            {
                                                if (temp[19] != "")
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                            else if (UsualOnly)
                                            {
                                                if (fes == 0 && limited == 0 && temp[19] == "")
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                            else
                                            {
                                                CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                            }
                                        }
                                        else
                                        {
                                            if (name == selectedIdol)
                                            {
                                                if (LimitedOnly)
                                                {
                                                    if (limited == 1)
                                                    {
                                                        CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                    }
                                                }
                                                else if (FesOnly)
                                                {
                                                    if (fes == 1)
                                                    {
                                                        CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                    }
                                                }
                                                else if (EventOnly)
                                                {
                                                    if (temp[19] != "")
                                                    {
                                                        CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                    }
                                                }
                                                else if (UsualOnly)
                                                {
                                                    if (fes == 0 && limited == 0&& temp[19] == "")
                                                    {
                                                        CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                    }
                                                }
                                                else
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                        }
                                    }
                                    break;
                                }
                        }
                    }

                    if (SROnly && rarity == "S RARE")
                    {
                        switch (temp[4])
                        {
                            case "1":
                                {
                                    if (CuteOnly)
                                    {
                                        if (selectedIdol == "")
                                        {
                                            if (LimitedOnly)
                                            {
                                                if (limited == 1)
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                            else if (FesOnly)
                                            {
                                                if (fes == 1)
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                            else if (EventOnly)
                                            {
                                                if (temp[19] != "")
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                            else if (UsualOnly)
                                            {
                                                if (fes == 0 && limited == 0 && temp[19] == "")
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                            else
                                            {
                                                CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                            }
                                        }
                                        else
                                        {
                                            if (name == selectedIdol)
                                            {
                                                if (LimitedOnly)
                                                {
                                                    if (limited == 1)
                                                    {
                                                        CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                    }
                                                }
                                                else if (FesOnly)
                                                {
                                                    if (fes == 1)
                                                    {
                                                        CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                    }
                                                }
                                                else if (EventOnly)
                                                {
                                                    if (temp[19] != "")
                                                    {
                                                        CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                    }
                                                }
                                                else if (UsualOnly)
                                                {
                                                    if (fes == 0 && limited == 0 && temp[19] == "")
                                                    {
                                                        CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                    }
                                                }
                                                else
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                        }
                                    }
                                    break;
                                }
                            case "2":
                                {
                                    if (CoolOnly)
                                    {
                                        if (selectedIdol == "")
                                        {
                                            if (LimitedOnly)
                                            {
                                                if (limited == 1)
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                            else if (FesOnly)
                                            {
                                                if (fes == 1)
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                            else if (EventOnly)
                                            {
                                                if (temp[19] != "")
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                            else if (UsualOnly)
                                            {
                                                if (fes == 0 && limited == 0 && temp[19] == "")
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                            else
                                            {
                                                CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                            }
                                        }
                                        else
                                        {
                                            if (name == selectedIdol)
                                            {
                                                if (LimitedOnly)
                                                {
                                                    if (limited == 1)
                                                    {
                                                        CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                    }
                                                }
                                                else if (FesOnly)
                                                {
                                                    if (fes == 1)
                                                    {
                                                        CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                    }
                                                }
                                                else if (EventOnly)
                                                {
                                                    if (temp[19] != "")
                                                    {
                                                        CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                    }
                                                }
                                                else if (UsualOnly)
                                                {
                                                    if (fes == 0 && limited == 0 && temp[19] == "")
                                                    {
                                                        CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                    }
                                                }
                                                else
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                        }
                                    }
                                    break;
                                }
                            case "3":
                                {
                                    if (PassionOnly)
                                    {
                                        if (selectedIdol == "")
                                        {
                                            if (LimitedOnly)
                                            {
                                                if (limited == 1)
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                            else if (FesOnly)
                                            {
                                                if (fes == 1)
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                            else if (EventOnly)
                                            {
                                                if (temp[19] != "")
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                            else if (UsualOnly)
                                            {
                                                if (fes == 0 && limited == 0 && temp[19] == "")
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                            else
                                            {
                                                CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                            }
                                        }
                                        else
                                        {
                                            if (name == selectedIdol)
                                            {
                                                if (LimitedOnly)
                                                {
                                                    if (limited == 1)
                                                    {
                                                        CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                    }
                                                }
                                                else if (FesOnly)
                                                {
                                                    if (fes == 1)
                                                    {
                                                        CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                    }
                                                }
                                                else if (EventOnly)
                                                {
                                                    if (temp[19] != "")
                                                    {
                                                        CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                    }
                                                }
                                                else if (UsualOnly)
                                                {
                                                    if (fes == 0 && limited == 0 && temp[19] == "")
                                                    {
                                                        CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                    }
                                                }
                                                else
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                        }
                                    }
                                    break;
                                }
                        }
                    }

                    if (ROnly && rarity == "RARE")
                    {
                        switch (temp[4])
                        {
                            case "1":
                                {
                                    if (CuteOnly)
                                    {
                                        if (selectedIdol == "")
                                        {
                                            if (LimitedOnly)
                                            {
                                                if (limited == 1)
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                            else if (FesOnly)
                                            {
                                                if (fes == 1)
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                            else if (EventOnly)
                                            {
                                                if (temp[19] != "")
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                            else if (UsualOnly)
                                            {
                                                if (fes == 0 && limited == 0 && temp[19] == "")
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if (name == selectedIdol)
                                            {
                                                if (LimitedOnly)
                                                {
                                                    if (limited == 1)
                                                    {
                                                        CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                    }
                                                }
                                                else if (FesOnly)
                                                {
                                                    if (fes == 1)
                                                    {
                                                        CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                    }
                                                }
                                                else if (EventOnly)
                                                {
                                                    if (temp[19] != "")
                                                    {
                                                        CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                    }
                                                }
                                                else if (UsualOnly)
                                                {
                                                    if (fes == 0 && limited == 0 && temp[19] == "")
                                                    {
                                                        CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                    }
                                                }
                                                else
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                        }
                                    }
                                    break;
                                }
                            case "2":
                                {
                                    if (CoolOnly)
                                    {
                                        if (selectedIdol == "")
                                        {
                                            if (LimitedOnly)
                                            {
                                                if (limited == 1)
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                            else if (FesOnly)
                                            {
                                                if (fes == 1)
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                            else if (EventOnly)
                                            {
                                                if (temp[19] != "")
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                            else if (UsualOnly)
                                            {
                                                if (fes == 0 && limited == 0 && temp[19] == "")
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                            else
                                            {
                                                CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                            }
                                        }
                                        else
                                        {
                                            if (name == selectedIdol)
                                            {
                                                if (LimitedOnly)
                                                {
                                                    if (limited == 1)
                                                    {
                                                        CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                    }
                                                }
                                                else if (FesOnly)
                                                {
                                                    if (fes == 1)
                                                    {
                                                        CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                    }
                                                }
                                                else if (EventOnly)
                                                {
                                                    if (temp[19] != "")
                                                    {
                                                        CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                    }
                                                }
                                                else if (UsualOnly)
                                                {
                                                    if (fes == 0 && limited == 0 && temp[19] == "")
                                                    {
                                                        CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                    }
                                                }
                                                else
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                        }
                                    }
                                    break;
                                }
                            case "3":
                                {
                                    if (PassionOnly)
                                    {
                                        if (selectedIdol == "")
                                        {
                                            if (LimitedOnly)
                                            {
                                                if (limited == 1)
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                            else if (FesOnly)
                                            {
                                                if (fes == 1)
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                            else if (EventOnly)
                                            {
                                                if (temp[19] != "")
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                            else if (UsualOnly)
                                            {
                                                if (fes == 0 && limited == 0 && temp[19] == "")
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                            else
                                            {
                                                CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                            }
                                        }
                                        else
                                        {
                                            if (name == selectedIdol)
                                            {
                                                if (LimitedOnly)
                                                {
                                                    if (limited == 1)
                                                    {
                                                        CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                    }
                                                }
                                                else if (FesOnly)
                                                {
                                                    if (fes == 1)
                                                    {
                                                        CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                    }
                                                }
                                                else if (EventOnly)
                                                {
                                                    if (temp[19] != "")
                                                    {
                                                        CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                    }
                                                }
                                                else if (UsualOnly)
                                                {
                                                    if (fes == 0 && limited == 0 && temp[19] == "")
                                                    {
                                                        CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                    }
                                                }
                                                else
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                        }
                                    }
                                    break;
                                }
                        }
                    }
                    if (NOnly && rarity == "NORMAL")
                    {
                        switch (temp[4])
                        {
                            case "1":
                                {
                                    if (CuteOnly)
                                    {
                                        if (selectedIdol == "")
                                        {
                                            if (LimitedOnly)
                                            {
                                                if (limited == 1)
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                            else if (FesOnly)
                                            {
                                                if (fes == 1)
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                            else if (EventOnly)
                                            {
                                                if (temp[19] != "")
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                            else if (UsualOnly)
                                            {
                                                if (fes == 0 && limited == 0 && temp[19] == "")
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if (name == selectedIdol)
                                            {
                                                if (LimitedOnly)
                                                {
                                                    if (limited == 1)
                                                    {
                                                        CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                    }
                                                }
                                                else if (FesOnly)
                                                {
                                                    if (fes == 1)
                                                    {
                                                        CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                    }
                                                }
                                                else if (EventOnly)
                                                {
                                                    if (temp[19] != "")
                                                    {
                                                        CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                    }
                                                }
                                                else if (UsualOnly)
                                                {
                                                    if (fes == 0 && limited == 0 && temp[19] == "")
                                                    {
                                                        CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                    }
                                                }
                                                else
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                        }
                                    }
                                    break;
                                }
                            case "2":
                                {
                                    if (CoolOnly)
                                    {
                                        if (selectedIdol == "")
                                        {
                                            if (LimitedOnly)
                                            {
                                                if (limited == 1)
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                            else if (FesOnly)
                                            {
                                                if (fes == 1)
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                            else if (EventOnly)
                                            {
                                                if (temp[19] != "")
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                            else if (UsualOnly)
                                            {
                                                if (fes == 0 && limited == 0 && temp[19] == "")
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                            else
                                            {
                                                CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                            }
                                        }
                                        else
                                        {
                                            if (name == selectedIdol)
                                            {
                                                if (LimitedOnly)
                                                {
                                                    if (limited == 1)
                                                    {
                                                        CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                    }
                                                }
                                                else if (FesOnly)
                                                {
                                                    if (fes == 1)
                                                    {
                                                        CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                    }
                                                }
                                                else if (EventOnly)
                                                {
                                                    if (temp[19] != "")
                                                    {
                                                        CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                    }
                                                }
                                                else if (UsualOnly)
                                                {
                                                    if (fes == 0 && limited == 0 && temp[19] == "")
                                                    {
                                                        CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                    }
                                                }
                                                else
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                        }
                                    }
                                    break;
                                }
                            case "3":
                                {
                                    if (PassionOnly)
                                    {
                                        if (selectedIdol == "")
                                        {
                                            if (LimitedOnly)
                                            {
                                                if (limited == 1)
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                            else if (FesOnly)
                                            {
                                                if (fes == 1)
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                            else if (EventOnly)
                                            {
                                                if (temp[19] != "")
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                            else if (UsualOnly)
                                            {
                                                if (fes == 0 && limited == 0 && temp[19] == "")
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                            else
                                            {
                                                CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                            }
                                        }
                                        else
                                        {
                                            if (name == selectedIdol)
                                            {
                                                if (LimitedOnly)
                                                {
                                                    if (limited == 1)
                                                    {
                                                        CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                    }
                                                }
                                                else if (FesOnly)
                                                {
                                                    if (fes == 1)
                                                    {
                                                        CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                    }
                                                }
                                                else if (EventOnly)
                                                {
                                                    if (temp[19] != "")
                                                    {
                                                        CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                    }
                                                }
                                                else if (UsualOnly)
                                                {
                                                    if (fes == 0 && limited == 0 && temp[19] == "")
                                                    {
                                                        CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                    }
                                                }
                                                else
                                                {
                                                    CardInfoList.Items.Add("［" + rarity + "］" + temp[1]);
                                                }
                                            }
                                        }
                                    }
                                    break;
                                }
                        }
                    }
                }
                initexit = true;
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
            int number = 0;
            switch (attr)
            {
                case 0:
                    {
                        while (true)
                        {
                            number = r.Next(0, SSRList.Count);
                            returncard = (Card)SSRList[number];
                            if (!returncard.limited)
                            {
                                break;
                            }
                        }
                        break;
                    }
                case 1:
                    {
                        while (true)
                        {
                            number = r.Next(0, SSRList.Count);
                            returncard = (Card)SSRList[number];
                            if (returncard.Attr == "CUTE" && !returncard.limited)
                            {
                                break;
                            }
                        }
                        break;
                    }
                case 2:
                    {
                        while (true)
                        {
                            number = r.Next(0, SSRList.Count);
                            returncard = (Card)SSRList[number];
                            if (returncard.Attr == "COOL" && !returncard.limited)
                            {
                                break;
                            }
                        }
                        break;
                    }
                case 3:
                    {
                        while (true)
                        {
                            number = r.Next(0, SSRList.Count);
                            returncard = (Card)SSRList[number];
                            if (returncard.Attr == "PASSION" && !returncard.limited)
                            {
                                break;
                            }
                        }
                        break;
                    }
            }
            return returncard;
        }

        private Card SRGet(int attr)
        {
            int number = 0;
            Card returncard = null;
            switch (attr)
            {
                case 0:
                    {
                        while (true)
                        {
                            number = r.Next(0, SRList.Count);
                            returncard = (Card)SRList[number];
                            if (!returncard.limited)
                            {
                                break;
                            }
                        }
                        break;
                    }
                case 1:
                    {
                        while (true)
                        {
                            number = r.Next(0, SRList.Count);
                            returncard = (Card)SRList[number];
                            if (returncard.Attr == "CUTE" && !returncard.limited)
                            {
                                break;
                            }
                        }
                        break;
                    }
                case 2:
                    {
                        while (true)
                        {
                            number = r.Next(0, SRList.Count);
                            returncard = (Card)SRList[number];
                            if (returncard.Attr == "COOL" && !returncard.limited)
                            {
                                break;
                            }
                        }
                        break;
                    }
                case 3:
                    {
                        while (true)
                        {
                            number = r.Next(0, SRList.Count);
                            returncard = (Card)SRList[number];
                            if (returncard.Attr == "PASSION" && !returncard.limited)
                            {
                                break;
                            }
                        }
                        break;
                    }
                default:
                    {
                        while (true)
                        {
                            number = r.Next(0, SRList.Count);
                            returncard = (Card)SRList[number];
                            if (!returncard.limited)
                            {
                                break;
                            }
                        }
                        break;
                    }
            }
            return returncard;
        }

        private Card RGet(int attr)
        {
            int number = 0;
            Card returncard = null;
            switch (attr)
            {
                case 0:
                    {
                        number = r.Next(0, RList.Count);
                        returncard = (Card)RList[number];
                        break;
                    }
                case 1:
                    {
                        while (true)
                        {
                            number = r.Next(0, RList.Count);
                            returncard = (Card)RList[number];
                            if (returncard.Attr == "CUTE")
                            {
                                break;
                            }
                        }
                        break;
                    }
                case 2:
                    {
                        while (true)
                        {
                            number = r.Next(0, RList.Count);
                            returncard = (Card)RList[number];
                            if (returncard.Attr == "COOL")
                            {
                                break;
                            }
                        }
                        break;
                    }
                case 3:
                    {
                        while (true)
                        {
                            number = r.Next(0, RList.Count);
                            returncard = (Card)RList[number];
                            if (returncard.Attr == "PASSION")
                            {
                                break;
                            }
                        }
                        break;
                    }
                default:
                    {
                        number = r.Next(0, RList.Count);
                        returncard = (Card)RList[number];
                        break;
                    }
            }
            return returncard;
        }

        private void OneGacha_Click(object sender, EventArgs e)
        {
            if (jewel > 250 || free == true)
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
                    resultCard = SRGet(SelectGacha);
                    SRvalue++;
                }
                else
                {
                    resultCard = RGet(SelectGacha);
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
                        resultCard[i] = SRGet(SelectGacha);
                        SRvalue++;
                    }
                    else
                    {
                        resultCard[i] = RGet(SelectGacha);
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
                    resultCard[9] = SRGet(SelectGacha);
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

        private void GoldGacha_Click(object sender, EventArgs e)
        {
            if (jewel > 60 || free == true)
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
                    resultCard = SSRGet(SelectGacha);
                    SSRvalue++;
                }
                else if (number < 999 * (SRp * 0.01))
                {
                    resultCard = SRGet(SelectGacha);
                    SRvalue++;
                }
                else
                {
                    resultCard = RGet(SelectGacha);
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
                        resultCard = SSRGet(SelectGacha);
                        SSRvalue++;
                        get = 1;
                    }
                    else if (number < 999 * (SRp * 0.01))
                    {
                        resultCard = SRGet(SelectGacha);
                        SRvalue++;
                    }
                    else
                    {
                        resultCard = RGet(SelectGacha);
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
                        resultCard[i] = SRGet(SelectGacha);
                        SRvalue++;
                    }
                    else
                    {
                        resultCard[i] = RGet(SelectGacha);
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
            if (FesToggle.Checked == false)
            {
                SSRp = 3.0;
                SRp = 12.0;
                Rp = 85.0;
            }
            else if (FesToggle.Checked == true)
            {
                SSRp = 6.0;
                SRp = 12.0;
                Rp = 82.0;
            }
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
            catch (FormatException ex)
            {
                MessageBox.Show("숫자 입력이 잘못되었습니다.");
            }
        }

        private void charge(int cyen, int cjewel)
        {
            if (yen >= cyen)
            {
                if (jewel < 1000000)
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
            UsedJewelStatus.Text = "사용한 쥬엘 : " + usedjewel;
            UsedYenStatus.Text = "사용한 엔화 : " + usedyen;
        }

        private void JewelSet1Button_Click(object sender, EventArgs e)
        {
            charge(120, 60);
        }

        private void JewelSet2Button_Click(object sender, EventArgs e)
        {
            charge(480, 360);
        }

        private void JewelSet3Button_Click(object sender, EventArgs e)
        {
            charge(960, 760);
        }

        private void JewelSet4Button_Click(object sender, EventArgs e)
        {
            charge(1600, 1300);
        }

        private void JewelSet5Button_Click(object sender, EventArgs e)
        {
            charge(3200, 2650);
        }

        private void JewelSet6Button_Click(object sender, EventArgs e)
        {
            charge(5000, 4200);
        }

        private void JewelSet7Button_Click(object sender, EventArgs e)
        {
            charge(9800, 8400);
        }

        private void FreeGachaToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (FreeGachaToggle.Checked == false)
            {
                free = false;
            }
            else
            {
                free = true;
            }
        }

        private void CharaBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CardInfoList.Items.Clear();
            if (CharaBox.SelectedItem != null)
            {
                String tempcharaname = CharaBox.SelectedItem.ToString().Substring(CharaBox.SelectedItem.ToString().LastIndexOf("］") + 1);
                if (selectedIdol == "")
                {
                    selectedIdol = tempcharaname;
                }
                else if (selectedIdol == tempcharaname)
                {
                    selectedIdol = "";
                    CharaBox.SetSelected(CharaBox.SelectedIndex, false);
                }
                else
                {
                    selectedIdol = tempcharaname;
                }
            }
            updateCardInfoList();
        }

        private void updateCardInfoListMethod()
        {

            if (CharaBox.SelectedIndex == -1)
            {
                selectedIdol = "";
            }
            else
            {

            }
        }

        private void CardInfoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Card selected = returnByName(CardInfoList.SelectedItem.ToString(), 0);
            CardInfoName.Text = "Name : " + selected.CardName;
            CardInfoRarity.Text = "Rarity : " + selected.Rarity;

            CardInfoVocal.Text = "Vo : " + selected.Vocal_max;
            CardInfoDance.Text = "Da : " + selected.Dance_max;
            CardInfoVisual.Text = "Vi : " + selected.Visual_max;
            CardInfoTotal.Text = "Total : " + selected.Total_max;
            if (selected.Rarity == "NORMAL" || selected.Rarity == "NORMAL+")
            {
                SkillText.Text = "Skill : ";
                CardInfoCenterSkill.Text = "Center Skill : ";
            }
            else
            {
                if (selected.SkillExplain.Length >= 20)
                {
                    SkillText.Text = "Skill : ［" + selected.Skill + "］ " + selected.SkillExplain.Substring(0, 19) + "\n       " + selected.SkillExplain.Substring(19, selected.SkillExplain.Length - 19);
                }
                else
                {
                    SkillText.Text = "Skill : ［" + selected.Skill + "］ " + selected.SkillExplain;
                }

                if (selected.Center_SkillExplain.Length >= 20)
                {
                    CardInfoCenterSkill.Text = "Center Skill : ［" + selected.Center_Skill + "］ " + selected.Center_SkillExplain.Substring(0, 19) + "\n       " + selected.Center_SkillExplain.Substring(19, selected.Center_SkillExplain.Length - 19);
                }
                else
                {
                    CardInfoCenterSkill.Text = "Center Skill : ［" + selected.Center_Skill + "］ " + selected.Center_SkillExplain;
                }
            }

            EventNameTitle.Text = "Event : " + selected.eventname;

            HP.Text = "HP : " + selected.Hp_max;
            if (selected.limited)
            {
                LimitedLabel.Text = "Limited : Yes";
            }
            else
            {
                LimitedLabel.Text = "Limited : No";
            }

            if (selected.fes)
            {
                FesLimitedLabel.Text = "Fes : Yes";
            }
            else
            {
                FesLimitedLabel.Text = "Fes : No";
            }
        }

        private Card returnByName(String input, int mode)
        {
            Card card = null;
            switch (mode)
            {
                case 0:
                    {
                        for (int b = 0; b < AllCardList.Count; b++)
                        {
                            if (("［" + ((Card)AllCardList[b]).Rarity + "］" + ((Card)AllCardList[b]).CardName + "＋").Equals(input))
                            {
                                card = (Card)AllCardList[b];
                            }
                            else if (("［" + ((Card)AllCardList[b]).Rarity + "］" + ((Card)AllCardList[b]).CardName).Equals(input))
                            {
                                card = (Card)AllCardList[b];
                            }
                        }
                        break;
                    }
                case 1:
                    {
                        for (int b = 0; b < AllCardList.Count; b++)
                        {
                            if (("［" + ((Card)AllCardList[b]).Rarity + "］" + ((Card)AllCardList[b]).CardName + "＋").Equals(input))
                            {
                                card = (Card)AllCardList[b];
                            }
                            else if (("［" + ((Card)AllCardList[b]).Rarity + "］" + ((Card)AllCardList[b]).CardName).Equals(input))
                            {
                                card = (Card)AllCardList[b];
                            }
                        }
                        break;
                    }
            }

            return card;
        }



        private void SSROnlyButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!SSROnly) SSROnly = true;
            else
            {
                SSROnly = false;
            }
            updateCardInfoList();
        }

        private void SROnlyButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!SROnly) SROnly = true;
            else
            {
                SROnly = false;
            }
            updateCardInfoList();
        }

        private void ROnlyButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!ROnly) ROnly = true;
            else
            {
                ROnly = false;
            }
            updateCardInfoList();
        }

        private void NOnlyButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!NOnly) NOnly = true;
            else
            {
                NOnly = false;
            }
            updateCardInfoList();
        }

        private void CuteOnlyButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!CuteOnly) CuteOnly = true;
            else CuteOnly = false;
            updateCardInfoList();
        }

        private void CoolOnlyButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!CoolOnly) CoolOnly = true;
            else CoolOnly = false;
            updateCardInfoList();
        }

        private void PassionOnlyButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!PassionOnly) PassionOnly = true;
            else PassionOnly = false;
            updateCardInfoList();
        }
        private void LimitedSelectBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (LimitedSelectBox.SelectedItem == null)
            {
                int a = int.Parse(e.Index.ToString());
                MessageBox.Show(LimitedSelectBox.GetItemChecked(a).ToString());
            }
            else
            {
                Card selected = returnByName(LimitedSelectBox.SelectedItem.ToString(), 1);
                if (selected.limited)
                {
                    selected.limited = false;
                    MessageBox.Show(selected.CardName + "가 이제 한정이 아닙니다");
                }
                else
                {
                    selected.limited = true;
                    MessageBox.Show(selected.CardName + "가 이제 한정입니다");
                }
            }
        }

        private void LimitedOnlyToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (!LimitedOnly) LimitedOnly = true;
            else LimitedOnly = false;
            updateCardInfoList();
        }

        private void FesOnlyToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (!FesOnly) FesOnly = true;
            else FesOnly = false;
            updateCardInfoList();
        }

        private void UsualOnlyToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (!UsualOnly) UsualOnly = true;
            else UsualOnly = false;
            updateCardInfoList();
        }

        private void EventOnlyToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (!EventOnly) EventOnly = true;
            else EventOnly = false;
            updateCardInfoList();
        }

        private void EventNameTitle_Click(object sender, EventArgs e)
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

        public int Hp_min;
        public int Vocal_min;
        public int Dance_min;
        public int Visual_min;
        public int Total_min;

        public int Hp_max;
        public int Vocal_max;
        public int Dance_max;
        public int Visual_max;
        public int Total_max;

        public String Skill;
        public String SkillExplain;

        public String Center_Skill;
        public String Center_SkillExplain;

        public String eventname;

        public Boolean limited;
        public Boolean fes;
        public Card(int num, string cardname, string charaname, string rarity, string Attr, int hp_min, int vo_min, int da_min, int vi_min, int hp_max, int vo_max, int da_max, int vi_max, string skill_name, string skill_explain, string leaderskill_name, string leaderskill_explain, string eventname, int limited, int fes)
        {
            this.number = num;

            this.CardName = cardname;
            this.CharaName = charaname;
            this.Rarity = rarity;
            this.Attr = Attr;

            this.Hp_min = hp_min;
            this.Vocal_min = vo_min;
            this.Dance_min = da_min;
            this.Visual_min = vi_min;
            this.Total_min = vo_min + da_min + vi_min;

            this.Hp_max = hp_max;
            this.Vocal_max = vo_max;
            this.Dance_max = da_max;
            this.Visual_max = vi_max;
            this.Total_max = vo_max + da_max + vi_max;

            this.Skill = skill_name;
            this.SkillExplain = skill_explain;

            this.Center_Skill = leaderskill_name;
            this.Center_SkillExplain = leaderskill_explain;
            this.eventname = eventname;
            if (limited == 0)
            {
                this.limited = false;
            }
            else
            {
                this.limited = true;
            }
            if (fes == 0)
            {
                this.fes = false;
            }
            else
            {
                this.fes = true;
            }
        }
    }
}