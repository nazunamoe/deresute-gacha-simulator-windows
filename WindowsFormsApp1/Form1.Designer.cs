namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.InformationButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.MainMenu = new System.Windows.Forms.TabControl();
            this.MoneyPage = new System.Windows.Forms.TabPage();
            this.JewelSet7Button = new System.Windows.Forms.Button();
            this.JewelSet6Button = new System.Windows.Forms.Button();
            this.JewelSet5Button = new System.Windows.Forms.Button();
            this.JewelSet4Button = new System.Windows.Forms.Button();
            this.JewelSet3Button = new System.Windows.Forms.Button();
            this.JewelSet2Button = new System.Windows.Forms.Button();
            this.JewelSet1Button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.YenGo = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GachaMenu = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GachaResultText = new System.Windows.Forms.RichTextBox();
            this.OKGachaButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SelectGachaBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FreeGachaToggle = new System.Windows.Forms.CheckBox();
            this.FesToggle = new System.Windows.Forms.CheckBox();
            this.LimitedSwitch = new System.Windows.Forms.CheckBox();
            this.Passion = new System.Windows.Forms.Label();
            this.Cool = new System.Windows.Forms.Label();
            this.Cute = new System.Windows.Forms.Label();
            this.R = new System.Windows.Forms.Label();
            this.SR = new System.Windows.Forms.Label();
            this.SSR = new System.Windows.Forms.Label();
            this.InfiniteGacha = new System.Windows.Forms.Button();
            this.TenGacha = new System.Windows.Forms.Button();
            this.GoldGacha = new System.Windows.Forms.Button();
            this.OneGacha = new System.Windows.Forms.Button();
            this.InfoMenu = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CardInfoCenterSkill = new System.Windows.Forms.Label();
            this.CardInfoSkill = new System.Windows.Forms.Label();
            this.CardInfoVisual = new System.Windows.Forms.Label();
            this.CardInfoDance = new System.Windows.Forms.Label();
            this.CardInfoTotal = new System.Windows.Forms.Label();
            this.CardInfoVocal = new System.Windows.Forms.Label();
            this.CardInfoRarity = new System.Windows.Forms.Label();
            this.CardInfoName = new System.Windows.Forms.Label();
            this.CardInfoList = new System.Windows.Forms.ListBox();
            this.YenStatus = new System.Windows.Forms.Label();
            this.JewelStatus = new System.Windows.Forms.Label();
            this.UsedJewelStatus = new System.Windows.Forms.Label();
            this.UsedYenStatus = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MainMenu.SuspendLayout();
            this.MoneyPage.SuspendLayout();
            this.GachaMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.InfoMenu.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(576, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "데레스테 가챠 시뮬레이터 리메이크 베타 4";
            // 
            // InformationButton
            // 
            this.InformationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InformationButton.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InformationButton.Location = new System.Drawing.Point(565, 374);
            this.InformationButton.Name = "InformationButton";
            this.InformationButton.Size = new System.Drawing.Size(75, 23);
            this.InformationButton.TabIndex = 1;
            this.InformationButton.Text = "정보";
            this.InformationButton.UseVisualStyleBackColor = true;
            this.InformationButton.Click += new System.EventHandler(this.InformationButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ExitButton.Location = new System.Drawing.Point(646, 374);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "종료";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.Controls.Add(this.MoneyPage);
            this.MainMenu.Controls.Add(this.GachaMenu);
            this.MainMenu.Controls.Add(this.InfoMenu);
            this.MainMenu.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MainMenu.Location = new System.Drawing.Point(16, 74);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.SelectedIndex = 0;
            this.MainMenu.Size = new System.Drawing.Size(710, 283);
            this.MainMenu.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.MainMenu.TabIndex = 3;
            // 
            // MoneyPage
            // 
            this.MoneyPage.Controls.Add(this.JewelSet7Button);
            this.MoneyPage.Controls.Add(this.JewelSet6Button);
            this.MoneyPage.Controls.Add(this.JewelSet5Button);
            this.MoneyPage.Controls.Add(this.JewelSet4Button);
            this.MoneyPage.Controls.Add(this.JewelSet3Button);
            this.MoneyPage.Controls.Add(this.JewelSet2Button);
            this.MoneyPage.Controls.Add(this.JewelSet1Button);
            this.MoneyPage.Controls.Add(this.label6);
            this.MoneyPage.Controls.Add(this.label5);
            this.MoneyPage.Controls.Add(this.YenGo);
            this.MoneyPage.Controls.Add(this.textBox1);
            this.MoneyPage.Location = new System.Drawing.Point(4, 24);
            this.MoneyPage.Name = "MoneyPage";
            this.MoneyPage.Padding = new System.Windows.Forms.Padding(3);
            this.MoneyPage.Size = new System.Drawing.Size(702, 255);
            this.MoneyPage.TabIndex = 0;
            this.MoneyPage.Text = "과금";
            this.MoneyPage.UseVisualStyleBackColor = true;
            // 
            // JewelSet7Button
            // 
            this.JewelSet7Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JewelSet7Button.ForeColor = System.Drawing.Color.Black;
            this.JewelSet7Button.Location = new System.Drawing.Point(498, 221);
            this.JewelSet7Button.Name = "JewelSet7Button";
            this.JewelSet7Button.Size = new System.Drawing.Size(192, 25);
            this.JewelSet7Button.TabIndex = 15;
            this.JewelSet7Button.Text = "G: 쥬엘 8400개 - 9800엔";
            this.JewelSet7Button.UseVisualStyleBackColor = true;
            this.JewelSet7Button.Click += new System.EventHandler(this.JewelSet7Button_Click);
            // 
            // JewelSet6Button
            // 
            this.JewelSet6Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JewelSet6Button.ForeColor = System.Drawing.Color.Black;
            this.JewelSet6Button.Location = new System.Drawing.Point(498, 191);
            this.JewelSet6Button.Name = "JewelSet6Button";
            this.JewelSet6Button.Size = new System.Drawing.Size(192, 25);
            this.JewelSet6Button.TabIndex = 14;
            this.JewelSet6Button.Text = "F: 쥬엘 4200개 - 5000엔";
            this.JewelSet6Button.UseVisualStyleBackColor = true;
            this.JewelSet6Button.Click += new System.EventHandler(this.JewelSet6Button_Click);
            // 
            // JewelSet5Button
            // 
            this.JewelSet5Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JewelSet5Button.ForeColor = System.Drawing.Color.Black;
            this.JewelSet5Button.Location = new System.Drawing.Point(498, 161);
            this.JewelSet5Button.Name = "JewelSet5Button";
            this.JewelSet5Button.Size = new System.Drawing.Size(192, 25);
            this.JewelSet5Button.TabIndex = 13;
            this.JewelSet5Button.Text = "E: 쥬엘 2650개 - 3200엔";
            this.JewelSet5Button.UseVisualStyleBackColor = true;
            this.JewelSet5Button.Click += new System.EventHandler(this.JewelSet5Button_Click);
            // 
            // JewelSet4Button
            // 
            this.JewelSet4Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JewelSet4Button.ForeColor = System.Drawing.Color.Black;
            this.JewelSet4Button.Location = new System.Drawing.Point(498, 131);
            this.JewelSet4Button.Name = "JewelSet4Button";
            this.JewelSet4Button.Size = new System.Drawing.Size(192, 25);
            this.JewelSet4Button.TabIndex = 12;
            this.JewelSet4Button.Text = "D: 쥬엘 1300개 - 1600엔";
            this.JewelSet4Button.UseVisualStyleBackColor = true;
            this.JewelSet4Button.Click += new System.EventHandler(this.JewelSet4Button_Click);
            // 
            // JewelSet3Button
            // 
            this.JewelSet3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JewelSet3Button.ForeColor = System.Drawing.Color.Black;
            this.JewelSet3Button.Location = new System.Drawing.Point(498, 101);
            this.JewelSet3Button.Name = "JewelSet3Button";
            this.JewelSet3Button.Size = new System.Drawing.Size(192, 25);
            this.JewelSet3Button.TabIndex = 11;
            this.JewelSet3Button.Text = "C: 쥬엘 760개 - 960엔";
            this.JewelSet3Button.UseVisualStyleBackColor = true;
            this.JewelSet3Button.Click += new System.EventHandler(this.JewelSet3Button_Click);
            // 
            // JewelSet2Button
            // 
            this.JewelSet2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JewelSet2Button.ForeColor = System.Drawing.Color.Black;
            this.JewelSet2Button.Location = new System.Drawing.Point(498, 71);
            this.JewelSet2Button.Name = "JewelSet2Button";
            this.JewelSet2Button.Size = new System.Drawing.Size(192, 25);
            this.JewelSet2Button.TabIndex = 10;
            this.JewelSet2Button.Text = "B: 쥬엘 360개 - 480엔";
            this.JewelSet2Button.UseVisualStyleBackColor = true;
            this.JewelSet2Button.Click += new System.EventHandler(this.JewelSet2Button_Click);
            // 
            // JewelSet1Button
            // 
            this.JewelSet1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JewelSet1Button.ForeColor = System.Drawing.Color.Black;
            this.JewelSet1Button.Location = new System.Drawing.Point(498, 41);
            this.JewelSet1Button.Name = "JewelSet1Button";
            this.JewelSet1Button.Size = new System.Drawing.Size(192, 25);
            this.JewelSet1Button.TabIndex = 9;
            this.JewelSet1Button.Text = "A : 쥬엘 60개 - 120엔";
            this.JewelSet1Button.UseVisualStyleBackColor = true;
            this.JewelSet1Button.Click += new System.EventHandler(this.JewelSet1Button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(595, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "쥬엘 메뉴";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(13, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "엔화 결제";
            // 
            // YenGo
            // 
            this.YenGo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.YenGo.Location = new System.Drawing.Point(13, 77);
            this.YenGo.Name = "YenGo";
            this.YenGo.Size = new System.Drawing.Size(115, 29);
            this.YenGo.TabIndex = 1;
            this.YenGo.Text = "엔화 결제";
            this.YenGo.UseVisualStyleBackColor = true;
            this.YenGo.Click += new System.EventHandler(this.YenGo_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // GachaMenu
            // 
            this.GachaMenu.Controls.Add(this.panel1);
            this.GachaMenu.Controls.Add(this.OKGachaButton);
            this.GachaMenu.Controls.Add(this.panel2);
            this.GachaMenu.Controls.Add(this.InfiniteGacha);
            this.GachaMenu.Controls.Add(this.TenGacha);
            this.GachaMenu.Controls.Add(this.GoldGacha);
            this.GachaMenu.Controls.Add(this.OneGacha);
            this.GachaMenu.Location = new System.Drawing.Point(4, 24);
            this.GachaMenu.Name = "GachaMenu";
            this.GachaMenu.Padding = new System.Windows.Forms.Padding(3);
            this.GachaMenu.Size = new System.Drawing.Size(702, 255);
            this.GachaMenu.TabIndex = 1;
            this.GachaMenu.Text = "가챠";
            this.GachaMenu.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.GachaResultText);
            this.panel1.Location = new System.Drawing.Point(251, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 194);
            this.panel1.TabIndex = 9;
            // 
            // GachaResultText
            // 
            this.GachaResultText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GachaResultText.Font = new System.Drawing.Font("돋움", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.GachaResultText.Location = new System.Drawing.Point(3, 3);
            this.GachaResultText.Name = "GachaResultText";
            this.GachaResultText.Size = new System.Drawing.Size(425, 184);
            this.GachaResultText.TabIndex = 0;
            this.GachaResultText.Text = "";
            // 
            // OKGachaButton
            // 
            this.OKGachaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKGachaButton.Location = new System.Drawing.Point(529, 218);
            this.OKGachaButton.Name = "OKGachaButton";
            this.OKGachaButton.Size = new System.Drawing.Size(120, 27);
            this.OKGachaButton.TabIndex = 8;
            this.OKGachaButton.Text = "확정 10회 가챠";
            this.OKGachaButton.UseVisualStyleBackColor = true;
            this.OKGachaButton.Click += new System.EventHandler(this.OKGachaButton_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.SelectGachaBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.FreeGachaToggle);
            this.panel2.Controls.Add(this.FesToggle);
            this.panel2.Controls.Add(this.LimitedSwitch);
            this.panel2.Controls.Add(this.Passion);
            this.panel2.Controls.Add(this.Cool);
            this.panel2.Controls.Add(this.Cute);
            this.panel2.Controls.Add(this.R);
            this.panel2.Controls.Add(this.SR);
            this.panel2.Controls.Add(this.SSR);
            this.panel2.Location = new System.Drawing.Point(18, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 194);
            this.panel2.TabIndex = 5;
            // 
            // SelectGachaBox
            // 
            this.SelectGachaBox.FormattingEnabled = true;
            this.SelectGachaBox.Location = new System.Drawing.Point(135, 115);
            this.SelectGachaBox.Name = "SelectGachaBox";
            this.SelectGachaBox.Size = new System.Drawing.Size(75, 23);
            this.SelectGachaBox.TabIndex = 16;
            this.SelectGachaBox.SelectedIndexChanged += new System.EventHandler(this.SelectGachaBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "셀렉트 가챠";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "가챠 설정";
            // 
            // FreeGachaToggle
            // 
            this.FreeGachaToggle.AutoSize = true;
            this.FreeGachaToggle.Location = new System.Drawing.Point(11, 168);
            this.FreeGachaToggle.Name = "FreeGachaToggle";
            this.FreeGachaToggle.Size = new System.Drawing.Size(53, 19);
            this.FreeGachaToggle.TabIndex = 9;
            this.FreeGachaToggle.Text = "공짜!";
            this.FreeGachaToggle.UseVisualStyleBackColor = true;
            this.FreeGachaToggle.CheckedChanged += new System.EventHandler(this.FreeGachaToggle_CheckedChanged);
            // 
            // FesToggle
            // 
            this.FesToggle.AutoSize = true;
            this.FesToggle.Location = new System.Drawing.Point(11, 143);
            this.FesToggle.Name = "FesToggle";
            this.FesToggle.Size = new System.Drawing.Size(74, 19);
            this.FesToggle.TabIndex = 8;
            this.FesToggle.Text = "신데페스";
            this.FesToggle.UseVisualStyleBackColor = true;
            this.FesToggle.CheckedChanged += new System.EventHandler(this.FesToggle_CheckedChanged);
            // 
            // LimitedSwitch
            // 
            this.LimitedSwitch.AutoSize = true;
            this.LimitedSwitch.Location = new System.Drawing.Point(11, 118);
            this.LimitedSwitch.Name = "LimitedSwitch";
            this.LimitedSwitch.Size = new System.Drawing.Size(78, 19);
            this.LimitedSwitch.TabIndex = 7;
            this.LimitedSwitch.Text = "한정 카드";
            this.LimitedSwitch.UseVisualStyleBackColor = true;
            // 
            // Passion
            // 
            this.Passion.AutoSize = true;
            this.Passion.Location = new System.Drawing.Point(82, 68);
            this.Passion.Name = "Passion";
            this.Passion.Size = new System.Drawing.Size(58, 15);
            this.Passion.TabIndex = 5;
            this.Passion.Text = "Passion : ";
            // 
            // Cool
            // 
            this.Cool.AutoSize = true;
            this.Cool.Location = new System.Drawing.Point(82, 41);
            this.Cool.Name = "Cool";
            this.Cool.Size = new System.Drawing.Size(43, 15);
            this.Cool.TabIndex = 4;
            this.Cool.Text = "Cool : ";
            // 
            // Cute
            // 
            this.Cute.AutoSize = true;
            this.Cute.Location = new System.Drawing.Point(82, 16);
            this.Cute.Name = "Cute";
            this.Cute.Size = new System.Drawing.Size(43, 15);
            this.Cute.TabIndex = 3;
            this.Cute.Text = "Cute : ";
            // 
            // R
            // 
            this.R.AutoSize = true;
            this.R.Location = new System.Drawing.Point(13, 68);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(25, 15);
            this.R.TabIndex = 2;
            this.R.Text = "R : ";
            // 
            // SR
            // 
            this.SR.AutoSize = true;
            this.SR.Location = new System.Drawing.Point(13, 41);
            this.SR.Name = "SR";
            this.SR.Size = new System.Drawing.Size(32, 15);
            this.SR.TabIndex = 1;
            this.SR.Text = "SR : ";
            // 
            // SSR
            // 
            this.SSR.AutoSize = true;
            this.SSR.Location = new System.Drawing.Point(13, 16);
            this.SSR.Name = "SSR";
            this.SSR.Size = new System.Drawing.Size(39, 15);
            this.SSR.TabIndex = 0;
            this.SSR.Text = "SSR : ";
            // 
            // InfiniteGacha
            // 
            this.InfiniteGacha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfiniteGacha.Location = new System.Drawing.Point(410, 218);
            this.InfiniteGacha.Name = "InfiniteGacha";
            this.InfiniteGacha.Size = new System.Drawing.Size(120, 27);
            this.InfiniteGacha.TabIndex = 3;
            this.InfiniteGacha.Text = "무한가챠";
            this.InfiniteGacha.UseVisualStyleBackColor = true;
            this.InfiniteGacha.Click += new System.EventHandler(this.InfiniteGacha_Click);
            // 
            // TenGacha
            // 
            this.TenGacha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TenGacha.Location = new System.Drawing.Point(173, 218);
            this.TenGacha.Name = "TenGacha";
            this.TenGacha.Size = new System.Drawing.Size(120, 27);
            this.TenGacha.TabIndex = 2;
            this.TenGacha.Text = "10회 가챠";
            this.TenGacha.UseVisualStyleBackColor = true;
            this.TenGacha.Click += new System.EventHandler(this.TenGacha_Click);
            // 
            // GoldGacha
            // 
            this.GoldGacha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoldGacha.Location = new System.Drawing.Point(291, 218);
            this.GoldGacha.Name = "GoldGacha";
            this.GoldGacha.Size = new System.Drawing.Size(120, 27);
            this.GoldGacha.TabIndex = 1;
            this.GoldGacha.Text = "연금가챠";
            this.GoldGacha.UseVisualStyleBackColor = true;
            this.GoldGacha.Click += new System.EventHandler(this.GoldGacha_Click);
            // 
            // OneGacha
            // 
            this.OneGacha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OneGacha.Location = new System.Drawing.Point(54, 218);
            this.OneGacha.Name = "OneGacha";
            this.OneGacha.Size = new System.Drawing.Size(120, 27);
            this.OneGacha.TabIndex = 0;
            this.OneGacha.Text = "1회 가챠";
            this.OneGacha.UseVisualStyleBackColor = true;
            this.OneGacha.Click += new System.EventHandler(this.OneGacha_Click);
            // 
            // InfoMenu
            // 
            this.InfoMenu.Controls.Add(this.panel4);
            this.InfoMenu.Controls.Add(this.panel3);
            this.InfoMenu.Controls.Add(this.CardInfoList);
            this.InfoMenu.Location = new System.Drawing.Point(4, 24);
            this.InfoMenu.Name = "InfoMenu";
            this.InfoMenu.Padding = new System.Windows.Forms.Padding(3);
            this.InfoMenu.Size = new System.Drawing.Size(702, 255);
            this.InfoMenu.TabIndex = 2;
            this.InfoMenu.Text = "정보";
            this.InfoMenu.UseVisualStyleBackColor = true;
            this.InfoMenu.Click += new System.EventHandler(this.InfoMenu_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.vScrollBar1);
            this.panel4.Location = new System.Drawing.Point(422, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(263, 109);
            this.panel4.TabIndex = 10;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(244, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 107);
            this.vScrollBar1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.CardInfoCenterSkill);
            this.panel3.Controls.Add(this.CardInfoSkill);
            this.panel3.Controls.Add(this.CardInfoVisual);
            this.panel3.Controls.Add(this.CardInfoDance);
            this.panel3.Controls.Add(this.CardInfoTotal);
            this.panel3.Controls.Add(this.CardInfoVocal);
            this.panel3.Controls.Add(this.CardInfoRarity);
            this.panel3.Controls.Add(this.CardInfoName);
            this.panel3.Location = new System.Drawing.Point(13, 132);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(672, 112);
            this.panel3.TabIndex = 9;
            // 
            // CardInfoCenterSkill
            // 
            this.CardInfoCenterSkill.AutoSize = true;
            this.CardInfoCenterSkill.Location = new System.Drawing.Point(7, 77);
            this.CardInfoCenterSkill.Name = "CardInfoCenterSkill";
            this.CardInfoCenterSkill.Size = new System.Drawing.Size(70, 15);
            this.CardInfoCenterSkill.TabIndex = 7;
            this.CardInfoCenterSkill.Text = "센터 스킬 : ";
            // 
            // CardInfoSkill
            // 
            this.CardInfoSkill.AutoSize = true;
            this.CardInfoSkill.Location = new System.Drawing.Point(7, 44);
            this.CardInfoSkill.Name = "CardInfoSkill";
            this.CardInfoSkill.Size = new System.Drawing.Size(42, 15);
            this.CardInfoSkill.TabIndex = 6;
            this.CardInfoSkill.Text = "스킬 : ";
            // 
            // CardInfoVisual
            // 
            this.CardInfoVisual.AutoSize = true;
            this.CardInfoVisual.Location = new System.Drawing.Point(326, 26);
            this.CardInfoVisual.Name = "CardInfoVisual";
            this.CardInfoVisual.Size = new System.Drawing.Size(54, 15);
            this.CardInfoVisual.TabIndex = 5;
            this.CardInfoVisual.Text = "비쥬얼 : ";
            // 
            // CardInfoDance
            // 
            this.CardInfoDance.AutoSize = true;
            this.CardInfoDance.Location = new System.Drawing.Point(326, 8);
            this.CardInfoDance.Name = "CardInfoDance";
            this.CardInfoDance.Size = new System.Drawing.Size(42, 15);
            this.CardInfoDance.TabIndex = 4;
            this.CardInfoDance.Text = "댄스 : ";
            // 
            // CardInfoTotal
            // 
            this.CardInfoTotal.AutoSize = true;
            this.CardInfoTotal.Location = new System.Drawing.Point(438, 26);
            this.CardInfoTotal.Name = "CardInfoTotal";
            this.CardInfoTotal.Size = new System.Drawing.Size(42, 15);
            this.CardInfoTotal.TabIndex = 3;
            this.CardInfoTotal.Text = "총합 : ";
            // 
            // CardInfoVocal
            // 
            this.CardInfoVocal.AutoSize = true;
            this.CardInfoVocal.Location = new System.Drawing.Point(438, 8);
            this.CardInfoVocal.Name = "CardInfoVocal";
            this.CardInfoVocal.Size = new System.Drawing.Size(42, 15);
            this.CardInfoVocal.TabIndex = 2;
            this.CardInfoVocal.Text = "보컬 : ";
            // 
            // CardInfoRarity
            // 
            this.CardInfoRarity.AutoSize = true;
            this.CardInfoRarity.Location = new System.Drawing.Point(7, 26);
            this.CardInfoRarity.Name = "CardInfoRarity";
            this.CardInfoRarity.Size = new System.Drawing.Size(42, 15);
            this.CardInfoRarity.TabIndex = 1;
            this.CardInfoRarity.Text = "등급 : ";
            // 
            // CardInfoName
            // 
            this.CardInfoName.AutoSize = true;
            this.CardInfoName.Location = new System.Drawing.Point(7, 8);
            this.CardInfoName.Name = "CardInfoName";
            this.CardInfoName.Size = new System.Drawing.Size(42, 15);
            this.CardInfoName.TabIndex = 0;
            this.CardInfoName.Text = "이름 : ";
            // 
            // CardInfoList
            // 
            this.CardInfoList.FormattingEnabled = true;
            this.CardInfoList.ItemHeight = 15;
            this.CardInfoList.Location = new System.Drawing.Point(13, 16);
            this.CardInfoList.Name = "CardInfoList";
            this.CardInfoList.Size = new System.Drawing.Size(403, 109);
            this.CardInfoList.TabIndex = 0;
            this.CardInfoList.SelectedIndexChanged += new System.EventHandler(this.CardInfoList_SelectedIndexChanged);
            // 
            // YenStatus
            // 
            this.YenStatus.AutoSize = true;
            this.YenStatus.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.YenStatus.Location = new System.Drawing.Point(22, 364);
            this.YenStatus.Name = "YenStatus";
            this.YenStatus.Size = new System.Drawing.Size(54, 17);
            this.YenStatus.TabIndex = 4;
            this.YenStatus.Text = "엔화 : 0";
            // 
            // JewelStatus
            // 
            this.JewelStatus.AutoSize = true;
            this.JewelStatus.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.JewelStatus.Location = new System.Drawing.Point(196, 364);
            this.JewelStatus.Name = "JewelStatus";
            this.JewelStatus.Size = new System.Drawing.Size(54, 17);
            this.JewelStatus.TabIndex = 5;
            this.JewelStatus.Text = "쥬엘 : 0";
            // 
            // UsedJewelStatus
            // 
            this.UsedJewelStatus.AutoSize = true;
            this.UsedJewelStatus.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.UsedJewelStatus.Location = new System.Drawing.Point(196, 385);
            this.UsedJewelStatus.Name = "UsedJewelStatus";
            this.UsedJewelStatus.Size = new System.Drawing.Size(98, 17);
            this.UsedJewelStatus.TabIndex = 6;
            this.UsedJewelStatus.Text = "사용한 쥬엘 : 0";
            // 
            // UsedYenStatus
            // 
            this.UsedYenStatus.AutoSize = true;
            this.UsedYenStatus.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.UsedYenStatus.Location = new System.Drawing.Point(23, 385);
            this.UsedYenStatus.Name = "UsedYenStatus";
            this.UsedYenStatus.Size = new System.Drawing.Size(98, 17);
            this.UsedYenStatus.TabIndex = 7;
            this.UsedYenStatus.Text = "사용한 엔화 : 0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label7.Location = new System.Drawing.Point(27, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Made by nazunamoe";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(738, 409);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.UsedYenStatus);
            this.Controls.Add(this.UsedJewelStatus);
            this.Controls.Add(this.JewelStatus);
            this.Controls.Add(this.YenStatus);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.InformationButton);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "-";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainMenu.ResumeLayout(false);
            this.MoneyPage.ResumeLayout(false);
            this.MoneyPage.PerformLayout();
            this.GachaMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.InfoMenu.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button InformationButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TabControl MainMenu;
        private System.Windows.Forms.TabPage MoneyPage;
        private System.Windows.Forms.TabPage GachaMenu;
        private System.Windows.Forms.TabPage InfoMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Passion;
        private System.Windows.Forms.Label Cool;
        private System.Windows.Forms.Label Cute;
        private System.Windows.Forms.Label R;
        private System.Windows.Forms.Label SR;
        private System.Windows.Forms.Label SSR;
        private System.Windows.Forms.Button InfiniteGacha;
        private System.Windows.Forms.Button TenGacha;
        private System.Windows.Forms.Button GoldGacha;
        private System.Windows.Forms.Button OneGacha;
        private System.Windows.Forms.CheckBox LimitedSwitch;
        private System.Windows.Forms.CheckBox FesToggle;
        private System.Windows.Forms.CheckBox FreeGachaToggle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SelectGachaBox;
        private System.Windows.Forms.Label YenStatus;
        private System.Windows.Forms.Label JewelStatus;
        private System.Windows.Forms.Button YenGo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button OKGachaButton;
        private System.Windows.Forms.Button JewelSet7Button;
        private System.Windows.Forms.Button JewelSet6Button;
        private System.Windows.Forms.Button JewelSet5Button;
        private System.Windows.Forms.Button JewelSet4Button;
        private System.Windows.Forms.Button JewelSet3Button;
        private System.Windows.Forms.Button JewelSet2Button;
        private System.Windows.Forms.Button JewelSet1Button;
        private System.Windows.Forms.Label UsedJewelStatus;
        private System.Windows.Forms.Label UsedYenStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox CardInfoList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label CardInfoName;
        private System.Windows.Forms.Label CardInfoRarity;
        private System.Windows.Forms.Label CardInfoVisual;
        private System.Windows.Forms.Label CardInfoDance;
        private System.Windows.Forms.Label CardInfoTotal;
        private System.Windows.Forms.Label CardInfoVocal;
        private System.Windows.Forms.Label CardInfoCenterSkill;
        private System.Windows.Forms.Label CardInfoSkill;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox GachaResultText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}

