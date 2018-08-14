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
            this.GachaMenu = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.GachaResultTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.All = new System.Windows.Forms.RadioButton();
            this.PassionOnly = new System.Windows.Forms.RadioButton();
            this.CoolOnly = new System.Windows.Forms.RadioButton();
            this.CuteOnly = new System.Windows.Forms.RadioButton();
            this.FreeGachaToggle = new System.Windows.Forms.CheckBox();
            this.FesToggle = new System.Windows.Forms.CheckBox();
            this.LimitedSwitch = new System.Windows.Forms.CheckBox();
            this.Passion = new System.Windows.Forms.Label();
            this.Cool = new System.Windows.Forms.Label();
            this.Cute = new System.Windows.Forms.Label();
            this.R = new System.Windows.Forms.Label();
            this.SR = new System.Windows.Forms.Label();
            this.SSR = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GachaResultText = new System.Windows.Forms.RichTextBox();
            this.InfiniteGacha = new System.Windows.Forms.Button();
            this.TenGacha = new System.Windows.Forms.Button();
            this.GoldGacha = new System.Windows.Forms.Button();
            this.OneGacha = new System.Windows.Forms.Button();
            this.InfoMenu = new System.Windows.Forms.TabPage();
            this.MainMenu.SuspendLayout();
            this.GachaMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(572, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Deresute Gacha Simulator Remake Beta 2";
            // 
            // InformationButton
            // 
            this.InformationButton.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InformationButton.Location = new System.Drawing.Point(681, 484);
            this.InformationButton.Name = "InformationButton";
            this.InformationButton.Size = new System.Drawing.Size(75, 23);
            this.InformationButton.TabIndex = 1;
            this.InformationButton.Text = "정보";
            this.InformationButton.UseVisualStyleBackColor = true;
            this.InformationButton.Click += new System.EventHandler(this.InformationButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ExitButton.Location = new System.Drawing.Point(767, 484);
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
            this.MainMenu.Size = new System.Drawing.Size(830, 404);
            this.MainMenu.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.MainMenu.TabIndex = 3;
            // 
            // MoneyPage
            // 
            this.MoneyPage.Location = new System.Drawing.Point(4, 24);
            this.MoneyPage.Name = "MoneyPage";
            this.MoneyPage.Padding = new System.Windows.Forms.Padding(3);
            this.MoneyPage.Size = new System.Drawing.Size(822, 376);
            this.MoneyPage.TabIndex = 0;
            this.MoneyPage.Text = "과금";
            this.MoneyPage.UseVisualStyleBackColor = true;
            // 
            // GachaMenu
            // 
            this.GachaMenu.Controls.Add(this.label2);
            this.GachaMenu.Controls.Add(this.GachaResultTitle);
            this.GachaMenu.Controls.Add(this.panel2);
            this.GachaMenu.Controls.Add(this.panel1);
            this.GachaMenu.Controls.Add(this.InfiniteGacha);
            this.GachaMenu.Controls.Add(this.TenGacha);
            this.GachaMenu.Controls.Add(this.GoldGacha);
            this.GachaMenu.Controls.Add(this.OneGacha);
            this.GachaMenu.Location = new System.Drawing.Point(4, 24);
            this.GachaMenu.Name = "GachaMenu";
            this.GachaMenu.Padding = new System.Windows.Forms.Padding(3);
            this.GachaMenu.Size = new System.Drawing.Size(822, 376);
            this.GachaMenu.TabIndex = 1;
            this.GachaMenu.Text = "가챠";
            this.GachaMenu.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "가챠 메뉴 ";
            // 
            // GachaResultTitle
            // 
            this.GachaResultTitle.AutoSize = true;
            this.GachaResultTitle.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.GachaResultTitle.Location = new System.Drawing.Point(239, 54);
            this.GachaResultTitle.Name = "GachaResultTitle";
            this.GachaResultTitle.Size = new System.Drawing.Size(95, 25);
            this.GachaResultTitle.TabIndex = 6;
            this.GachaResultTitle.Text = "가챠 결과";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.All);
            this.panel2.Controls.Add(this.PassionOnly);
            this.panel2.Controls.Add(this.CoolOnly);
            this.panel2.Controls.Add(this.CuteOnly);
            this.panel2.Controls.Add(this.FreeGachaToggle);
            this.panel2.Controls.Add(this.FesToggle);
            this.panel2.Controls.Add(this.LimitedSwitch);
            this.panel2.Controls.Add(this.Passion);
            this.panel2.Controls.Add(this.Cool);
            this.panel2.Controls.Add(this.Cute);
            this.panel2.Controls.Add(this.R);
            this.panel2.Controls.Add(this.SR);
            this.panel2.Controls.Add(this.SSR);
            this.panel2.Location = new System.Drawing.Point(14, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(205, 228);
            this.panel2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 96);
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
            // All
            // 
            this.All.AutoSize = true;
            this.All.Location = new System.Drawing.Point(119, 192);
            this.All.Name = "All";
            this.All.Size = new System.Drawing.Size(49, 19);
            this.All.TabIndex = 13;
            this.All.TabStop = true;
            this.All.Text = "전체";
            this.All.UseVisualStyleBackColor = true;
            this.All.CheckedChanged += new System.EventHandler(this.All_CheckedChanged);
            // 
            // PassionOnly
            // 
            this.PassionOnly.AutoSize = true;
            this.PassionOnly.Location = new System.Drawing.Point(119, 167);
            this.PassionOnly.Name = "PassionOnly";
            this.PassionOnly.Size = new System.Drawing.Size(49, 19);
            this.PassionOnly.TabIndex = 12;
            this.PassionOnly.TabStop = true;
            this.PassionOnly.Text = "패션";
            this.PassionOnly.UseVisualStyleBackColor = true;
            this.PassionOnly.CheckedChanged += new System.EventHandler(this.PassionOnly_CheckedChanged);
            // 
            // CoolOnly
            // 
            this.CoolOnly.AutoSize = true;
            this.CoolOnly.Location = new System.Drawing.Point(119, 142);
            this.CoolOnly.Name = "CoolOnly";
            this.CoolOnly.Size = new System.Drawing.Size(37, 19);
            this.CoolOnly.TabIndex = 11;
            this.CoolOnly.TabStop = true;
            this.CoolOnly.Text = "쿨";
            this.CoolOnly.UseVisualStyleBackColor = true;
            this.CoolOnly.CheckedChanged += new System.EventHandler(this.CoolOnly_CheckedChanged);
            // 
            // CuteOnly
            // 
            this.CuteOnly.AutoSize = true;
            this.CuteOnly.Location = new System.Drawing.Point(119, 118);
            this.CuteOnly.Name = "CuteOnly";
            this.CuteOnly.Size = new System.Drawing.Size(49, 19);
            this.CuteOnly.TabIndex = 10;
            this.CuteOnly.TabStop = true;
            this.CuteOnly.Text = "큐트";
            this.CuteOnly.UseVisualStyleBackColor = true;
            this.CuteOnly.CheckedChanged += new System.EventHandler(this.CuteOnly_CheckedChanged);
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
            // 
            // FesToggle
            // 
            this.FesToggle.AutoSize = true;
            this.FesToggle.Location = new System.Drawing.Point(11, 143);
            this.FesToggle.Name = "FesToggle";
            this.FesToggle.Size = new System.Drawing.Size(102, 19);
            this.FesToggle.TabIndex = 8;
            this.FesToggle.Text = "신데페스 확률";
            this.FesToggle.UseVisualStyleBackColor = true;
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
            this.Passion.Location = new System.Drawing.Point(102, 65);
            this.Passion.Name = "Passion";
            this.Passion.Size = new System.Drawing.Size(58, 15);
            this.Passion.TabIndex = 5;
            this.Passion.Text = "Passion : ";
            // 
            // Cool
            // 
            this.Cool.AutoSize = true;
            this.Cool.Location = new System.Drawing.Point(102, 38);
            this.Cool.Name = "Cool";
            this.Cool.Size = new System.Drawing.Size(43, 15);
            this.Cool.TabIndex = 4;
            this.Cool.Text = "Cool : ";
            // 
            // Cute
            // 
            this.Cute.AutoSize = true;
            this.Cute.Location = new System.Drawing.Point(102, 13);
            this.Cute.Name = "Cute";
            this.Cute.Size = new System.Drawing.Size(43, 15);
            this.Cute.TabIndex = 3;
            this.Cute.Text = "Cute : ";
            // 
            // R
            // 
            this.R.AutoSize = true;
            this.R.Location = new System.Drawing.Point(8, 65);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(25, 15);
            this.R.TabIndex = 2;
            this.R.Text = "R : ";
            // 
            // SR
            // 
            this.SR.AutoSize = true;
            this.SR.Location = new System.Drawing.Point(8, 38);
            this.SR.Name = "SR";
            this.SR.Size = new System.Drawing.Size(32, 15);
            this.SR.TabIndex = 1;
            this.SR.Text = "SR : ";
            // 
            // SSR
            // 
            this.SSR.AutoSize = true;
            this.SSR.Location = new System.Drawing.Point(8, 13);
            this.SSR.Name = "SSR";
            this.SSR.Size = new System.Drawing.Size(39, 15);
            this.SSR.TabIndex = 0;
            this.SSR.Text = "SSR : ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.GachaResultText);
            this.panel1.Location = new System.Drawing.Point(231, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 268);
            this.panel1.TabIndex = 4;
            // 
            // GachaResultText
            // 
            this.GachaResultText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GachaResultText.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.GachaResultText.Location = new System.Drawing.Point(0, 1);
            this.GachaResultText.Name = "GachaResultText";
            this.GachaResultText.Size = new System.Drawing.Size(571, 265);
            this.GachaResultText.TabIndex = 0;
            this.GachaResultText.Text = "";
            // 
            // InfiniteGacha
            // 
            this.InfiniteGacha.Location = new System.Drawing.Point(120, 92);
            this.InfiniteGacha.Name = "InfiniteGacha";
            this.InfiniteGacha.Size = new System.Drawing.Size(100, 34);
            this.InfiniteGacha.TabIndex = 3;
            this.InfiniteGacha.Text = "무한가챠";
            this.InfiniteGacha.UseVisualStyleBackColor = true;
            this.InfiniteGacha.Click += new System.EventHandler(this.InfiniteGacha_Click);
            // 
            // TenGacha
            // 
            this.TenGacha.Location = new System.Drawing.Point(120, 52);
            this.TenGacha.Name = "TenGacha";
            this.TenGacha.Size = new System.Drawing.Size(100, 34);
            this.TenGacha.TabIndex = 2;
            this.TenGacha.Text = "10회 가챠";
            this.TenGacha.UseVisualStyleBackColor = true;
            this.TenGacha.Click += new System.EventHandler(this.TenGacha_Click);
            // 
            // GoldGacha
            // 
            this.GoldGacha.Location = new System.Drawing.Point(14, 92);
            this.GoldGacha.Name = "GoldGacha";
            this.GoldGacha.Size = new System.Drawing.Size(100, 34);
            this.GoldGacha.TabIndex = 1;
            this.GoldGacha.Text = "연금가챠";
            this.GoldGacha.UseVisualStyleBackColor = true;
            this.GoldGacha.Click += new System.EventHandler(this.GoldGacha_Click);
            // 
            // OneGacha
            // 
            this.OneGacha.Location = new System.Drawing.Point(14, 52);
            this.OneGacha.Name = "OneGacha";
            this.OneGacha.Size = new System.Drawing.Size(100, 34);
            this.OneGacha.TabIndex = 0;
            this.OneGacha.Text = "1회 가챠";
            this.OneGacha.UseVisualStyleBackColor = true;
            this.OneGacha.Click += new System.EventHandler(this.OneGacha_Click);
            // 
            // InfoMenu
            // 
            this.InfoMenu.Location = new System.Drawing.Point(4, 24);
            this.InfoMenu.Name = "InfoMenu";
            this.InfoMenu.Padding = new System.Windows.Forms.Padding(3);
            this.InfoMenu.Size = new System.Drawing.Size(822, 376);
            this.InfoMenu.TabIndex = 2;
            this.InfoMenu.Text = "정보";
            this.InfoMenu.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(854, 519);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.InformationButton);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainMenu.ResumeLayout(false);
            this.GachaMenu.ResumeLayout(false);
            this.GachaMenu.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button InfiniteGacha;
        private System.Windows.Forms.Button TenGacha;
        private System.Windows.Forms.Button GoldGacha;
        private System.Windows.Forms.Button OneGacha;
        private System.Windows.Forms.CheckBox LimitedSwitch;
        private System.Windows.Forms.Label GachaResultTitle;
        private System.Windows.Forms.CheckBox FesToggle;
        private System.Windows.Forms.RadioButton PassionOnly;
        private System.Windows.Forms.RadioButton CoolOnly;
        private System.Windows.Forms.RadioButton CuteOnly;
        private System.Windows.Forms.CheckBox FreeGachaToggle;
        private System.Windows.Forms.RadioButton All;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox GachaResultText;
    }
}

