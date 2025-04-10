namespace ServerDesktopBingX
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            TB_KEY = new TextBox();
            label1 = new Label();
            TB_SECRET = new TextBox();
            label2 = new Label();
            BT_EDIT_KEY = new Button();
            BT_EDIT_SECRET = new Button();
            BT_CHECK_KEY = new Button();
            BT_CHECK_SECRET = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            TB_OPEN_LCO = new TextBox();
            TB_CLOSE_LCO = new TextBox();
            TB_MAX_LCO = new TextBox();
            TB_MIN_LCO = new TextBox();
            TB_OPEN_NG = new TextBox();
            TB_CLOSE_NG = new TextBox();
            TB_MAX_NG = new TextBox();
            TB_MIN_NG = new TextBox();
            TB_OPEN_S = new TextBox();
            TB_CLOSE_S = new TextBox();
            TB_MAX_S = new TextBox();
            TB_MIN_S = new TextBox();
            BT_ADD_ADD1 = new Button();
            TB_OPEN_ADD1 = new TextBox();
            TB_CLOSE_ADD1 = new TextBox();
            TB_MAX_ADD1 = new TextBox();
            TB_MIN_ADD1 = new TextBox();
            TB_NAME_ADD1 = new TextBox();
            BT_ADD_ADD2 = new Button();
            TB_OPEN_ADD2 = new TextBox();
            TB_CLOSE_ADD2 = new TextBox();
            TB_MAX_ADD2 = new TextBox();
            TB_MIN_ADD2 = new TextBox();
            TB_NAME_ADD2 = new TextBox();
            BT_EDIT_ADD1 = new Button();
            BT_EDIT_ADD2 = new Button();
            BT_CHECK_ADD1 = new Button();
            BT_CHECK_ADD2 = new Button();
            D1_LCO = new TextBox();
            D1_NG = new TextBox();
            D1_S = new TextBox();
            D1_ADD1 = new TextBox();
            D1_ADD2 = new TextBox();
            H4_LCO = new TextBox();
            H4_NG = new TextBox();
            H4_S = new TextBox();
            H4_ADD1 = new TextBox();
            H4_ADD2 = new TextBox();
            H1_LCO = new TextBox();
            H1_NG = new TextBox();
            H1_S = new TextBox();
            H1_ADD1 = new TextBox();
            H1_ADD2 = new TextBox();
            M5_ADD2 = new TextBox();
            M5_ADD1 = new TextBox();
            M5_S = new TextBox();
            M5_NG = new TextBox();
            M5_LCO = new TextBox();
            SW_LCO = new Controls.ToggleSwitch();
            SW_NG = new Controls.ToggleSwitch();
            SW_S = new Controls.ToggleSwitch();
            SW_ADD1 = new Controls.ToggleSwitch();
            SW_ADD2 = new Controls.ToggleSwitch();
            L_STATUS_LCO = new Label();
            L_STATUS_NG = new Label();
            L_STATUS_S = new Label();
            L_STATUS_ADD1 = new Label();
            L_STATUS_ADD2 = new Label();
            L_LOG_LCO = new Label();
            L_LOG_NG = new Label();
            L_LOG_S = new Label();
            L_LOG_ADD1 = new Label();
            L_LOG_ADD2 = new Label();
            L_BX_STATUS = new Label();
            L_BINGX_STATUS = new Label();
            SW_MAIN = new Controls.ToggleSwitch();
            label16 = new Label();
            L_VERSION = new Label();
            BT_DELETE_ADD1 = new Button();
            BT_DELETE_ADD2 = new Button();
            L_DATE = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // TB_KEY
            // 
            TB_KEY.Enabled = false;
            TB_KEY.Location = new Point(104, 45);
            TB_KEY.Name = "TB_KEY";
            TB_KEY.ReadOnly = true;
            TB_KEY.Size = new Size(833, 27);
            TB_KEY.TabIndex = 1;
            TB_KEY.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 48);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 2;
            label1.Text = "API KEY";
            // 
            // TB_SECRET
            // 
            TB_SECRET.Enabled = false;
            TB_SECRET.Location = new Point(104, 78);
            TB_SECRET.Name = "TB_SECRET";
            TB_SECRET.ReadOnly = true;
            TB_SECRET.Size = new Size(833, 27);
            TB_SECRET.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 81);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 4;
            label2.Text = "API SECRET";
            // 
            // BT_EDIT_KEY
            // 
            BT_EDIT_KEY.Image = (Image)resources.GetObject("BT_EDIT_KEY.Image");
            BT_EDIT_KEY.Location = new Point(943, 41);
            BT_EDIT_KEY.Name = "BT_EDIT_KEY";
            BT_EDIT_KEY.Size = new Size(32, 32);
            BT_EDIT_KEY.TabIndex = 5;
            BT_EDIT_KEY.UseVisualStyleBackColor = true;
            BT_EDIT_KEY.Click += BT_EDIT_KEY_Click;
            // 
            // BT_EDIT_SECRET
            // 
            BT_EDIT_SECRET.Image = (Image)resources.GetObject("BT_EDIT_SECRET.Image");
            BT_EDIT_SECRET.Location = new Point(943, 75);
            BT_EDIT_SECRET.Name = "BT_EDIT_SECRET";
            BT_EDIT_SECRET.Size = new Size(32, 32);
            BT_EDIT_SECRET.TabIndex = 6;
            BT_EDIT_SECRET.UseVisualStyleBackColor = true;
            BT_EDIT_SECRET.Click += BT_EDIT_SECRET_Click;
            // 
            // BT_CHECK_KEY
            // 
            BT_CHECK_KEY.Image = (Image)resources.GetObject("BT_CHECK_KEY.Image");
            BT_CHECK_KEY.Location = new Point(943, 41);
            BT_CHECK_KEY.Name = "BT_CHECK_KEY";
            BT_CHECK_KEY.Size = new Size(32, 32);
            BT_CHECK_KEY.TabIndex = 7;
            BT_CHECK_KEY.UseVisualStyleBackColor = true;
            BT_CHECK_KEY.Visible = false;
            BT_CHECK_KEY.Click += BT_CHECK_KEY_Click;
            // 
            // BT_CHECK_SECRET
            // 
            BT_CHECK_SECRET.Image = (Image)resources.GetObject("BT_CHECK_SECRET.Image");
            BT_CHECK_SECRET.Location = new Point(943, 75);
            BT_CHECK_SECRET.Name = "BT_CHECK_SECRET";
            BT_CHECK_SECRET.Size = new Size(32, 32);
            BT_CHECK_SECRET.TabIndex = 8;
            BT_CHECK_SECRET.UseVisualStyleBackColor = true;
            BT_CHECK_SECRET.Visible = false;
            BT_CHECK_SECRET.Click += BT_CHECK_SECRET_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(171, 134);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 11;
            label3.Text = "OPEN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(245, 134);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 12;
            label4.Text = "CLOSE";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(323, 134);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 13;
            label5.Text = "MAX";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(402, 134);
            label6.Name = "label6";
            label6.Size = new Size(37, 20);
            label6.TabIndex = 14;
            label6.Text = "MIN";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(479, 134);
            label7.Name = "label7";
            label7.Size = new Size(28, 20);
            label7.TabIndex = 15;
            label7.Text = "1D";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(509, 134);
            label8.Name = "label8";
            label8.Size = new Size(28, 20);
            label8.TabIndex = 16;
            label8.Text = "4H";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(538, 134);
            label9.Name = "label9";
            label9.Size = new Size(28, 20);
            label9.TabIndex = 17;
            label9.Text = "1H";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(568, 134);
            label10.Name = "label10";
            label10.Size = new Size(30, 20);
            label10.TabIndex = 18;
            label10.Text = "5M";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(636, 134);
            label11.Name = "label11";
            label11.Size = new Size(59, 20);
            label11.TabIndex = 19;
            label11.Text = "STATUS";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(831, 134);
            label12.Name = "label12";
            label12.Size = new Size(36, 20);
            label12.TabIndex = 20;
            label12.Text = "LOG";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(93, 160);
            label13.Name = "label13";
            label13.Size = new Size(64, 20);
            label13.TabIndex = 21;
            label13.Text = "LCOUSD";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(98, 190);
            label14.Name = "label14";
            label14.Size = new Size(59, 20);
            label14.TabIndex = 22;
            label14.Text = "NGUSD";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(75, 220);
            label15.Name = "label15";
            label15.Size = new Size(82, 20);
            label15.TabIndex = 23;
            label15.Text = "SILVERUSD";
            // 
            // TB_OPEN_LCO
            // 
            TB_OPEN_LCO.Enabled = false;
            TB_OPEN_LCO.Location = new Point(163, 157);
            TB_OPEN_LCO.Name = "TB_OPEN_LCO";
            TB_OPEN_LCO.ReadOnly = true;
            TB_OPEN_LCO.Size = new Size(64, 27);
            TB_OPEN_LCO.TabIndex = 24;
            TB_OPEN_LCO.TextAlign = HorizontalAlignment.Center;
            // 
            // TB_CLOSE_LCO
            // 
            TB_CLOSE_LCO.Enabled = false;
            TB_CLOSE_LCO.ForeColor = SystemColors.WindowText;
            TB_CLOSE_LCO.Location = new Point(238, 157);
            TB_CLOSE_LCO.Name = "TB_CLOSE_LCO";
            TB_CLOSE_LCO.ReadOnly = true;
            TB_CLOSE_LCO.Size = new Size(64, 27);
            TB_CLOSE_LCO.TabIndex = 25;
            TB_CLOSE_LCO.TextAlign = HorizontalAlignment.Center;
            // 
            // TB_MAX_LCO
            // 
            TB_MAX_LCO.Enabled = false;
            TB_MAX_LCO.Location = new Point(313, 157);
            TB_MAX_LCO.Name = "TB_MAX_LCO";
            TB_MAX_LCO.ReadOnly = true;
            TB_MAX_LCO.Size = new Size(64, 27);
            TB_MAX_LCO.TabIndex = 26;
            TB_MAX_LCO.TextAlign = HorizontalAlignment.Center;
            // 
            // TB_MIN_LCO
            // 
            TB_MIN_LCO.Enabled = false;
            TB_MIN_LCO.Location = new Point(388, 157);
            TB_MIN_LCO.Name = "TB_MIN_LCO";
            TB_MIN_LCO.ReadOnly = true;
            TB_MIN_LCO.Size = new Size(64, 27);
            TB_MIN_LCO.TabIndex = 27;
            TB_MIN_LCO.TextAlign = HorizontalAlignment.Center;
            // 
            // TB_OPEN_NG
            // 
            TB_OPEN_NG.Enabled = false;
            TB_OPEN_NG.Location = new Point(163, 187);
            TB_OPEN_NG.Name = "TB_OPEN_NG";
            TB_OPEN_NG.ReadOnly = true;
            TB_OPEN_NG.Size = new Size(64, 27);
            TB_OPEN_NG.TabIndex = 28;
            TB_OPEN_NG.TextAlign = HorizontalAlignment.Center;
            // 
            // TB_CLOSE_NG
            // 
            TB_CLOSE_NG.Enabled = false;
            TB_CLOSE_NG.Location = new Point(238, 187);
            TB_CLOSE_NG.Name = "TB_CLOSE_NG";
            TB_CLOSE_NG.ReadOnly = true;
            TB_CLOSE_NG.Size = new Size(64, 27);
            TB_CLOSE_NG.TabIndex = 29;
            TB_CLOSE_NG.TextAlign = HorizontalAlignment.Center;
            // 
            // TB_MAX_NG
            // 
            TB_MAX_NG.Enabled = false;
            TB_MAX_NG.Location = new Point(313, 187);
            TB_MAX_NG.Name = "TB_MAX_NG";
            TB_MAX_NG.ReadOnly = true;
            TB_MAX_NG.Size = new Size(64, 27);
            TB_MAX_NG.TabIndex = 30;
            TB_MAX_NG.TextAlign = HorizontalAlignment.Center;
            // 
            // TB_MIN_NG
            // 
            TB_MIN_NG.Enabled = false;
            TB_MIN_NG.Location = new Point(388, 187);
            TB_MIN_NG.Name = "TB_MIN_NG";
            TB_MIN_NG.ReadOnly = true;
            TB_MIN_NG.Size = new Size(64, 27);
            TB_MIN_NG.TabIndex = 31;
            TB_MIN_NG.TextAlign = HorizontalAlignment.Center;
            // 
            // TB_OPEN_S
            // 
            TB_OPEN_S.Enabled = false;
            TB_OPEN_S.Location = new Point(163, 217);
            TB_OPEN_S.Name = "TB_OPEN_S";
            TB_OPEN_S.ReadOnly = true;
            TB_OPEN_S.Size = new Size(64, 27);
            TB_OPEN_S.TabIndex = 32;
            TB_OPEN_S.TextAlign = HorizontalAlignment.Center;
            // 
            // TB_CLOSE_S
            // 
            TB_CLOSE_S.Enabled = false;
            TB_CLOSE_S.Location = new Point(238, 217);
            TB_CLOSE_S.Name = "TB_CLOSE_S";
            TB_CLOSE_S.ReadOnly = true;
            TB_CLOSE_S.Size = new Size(64, 27);
            TB_CLOSE_S.TabIndex = 33;
            TB_CLOSE_S.TextAlign = HorizontalAlignment.Center;
            // 
            // TB_MAX_S
            // 
            TB_MAX_S.Enabled = false;
            TB_MAX_S.Location = new Point(313, 217);
            TB_MAX_S.Name = "TB_MAX_S";
            TB_MAX_S.ReadOnly = true;
            TB_MAX_S.Size = new Size(64, 27);
            TB_MAX_S.TabIndex = 34;
            TB_MAX_S.TextAlign = HorizontalAlignment.Center;
            // 
            // TB_MIN_S
            // 
            TB_MIN_S.Enabled = false;
            TB_MIN_S.Location = new Point(388, 217);
            TB_MIN_S.Name = "TB_MIN_S";
            TB_MIN_S.ReadOnly = true;
            TB_MIN_S.Size = new Size(64, 27);
            TB_MIN_S.TabIndex = 35;
            TB_MIN_S.TextAlign = HorizontalAlignment.Center;
            // 
            // BT_ADD_ADD1
            // 
            BT_ADD_ADD1.Image = (Image)resources.GetObject("BT_ADD_ADD1.Image");
            BT_ADD_ADD1.Location = new Point(295, 247);
            BT_ADD_ADD1.Name = "BT_ADD_ADD1";
            BT_ADD_ADD1.Size = new Size(27, 27);
            BT_ADD_ADD1.TabIndex = 36;
            BT_ADD_ADD1.UseVisualStyleBackColor = true;
            BT_ADD_ADD1.Click += BT_ADD_ADD1_Click;
            // 
            // TB_OPEN_ADD1
            // 
            TB_OPEN_ADD1.Enabled = false;
            TB_OPEN_ADD1.Location = new Point(163, 247);
            TB_OPEN_ADD1.Name = "TB_OPEN_ADD1";
            TB_OPEN_ADD1.ReadOnly = true;
            TB_OPEN_ADD1.Size = new Size(64, 27);
            TB_OPEN_ADD1.TabIndex = 37;
            TB_OPEN_ADD1.TextAlign = HorizontalAlignment.Center;
            // 
            // TB_CLOSE_ADD1
            // 
            TB_CLOSE_ADD1.Enabled = false;
            TB_CLOSE_ADD1.Location = new Point(238, 247);
            TB_CLOSE_ADD1.Name = "TB_CLOSE_ADD1";
            TB_CLOSE_ADD1.ReadOnly = true;
            TB_CLOSE_ADD1.Size = new Size(64, 27);
            TB_CLOSE_ADD1.TabIndex = 38;
            TB_CLOSE_ADD1.TextAlign = HorizontalAlignment.Center;
            // 
            // TB_MAX_ADD1
            // 
            TB_MAX_ADD1.Enabled = false;
            TB_MAX_ADD1.Location = new Point(313, 247);
            TB_MAX_ADD1.Name = "TB_MAX_ADD1";
            TB_MAX_ADD1.ReadOnly = true;
            TB_MAX_ADD1.Size = new Size(64, 27);
            TB_MAX_ADD1.TabIndex = 39;
            TB_MAX_ADD1.TextAlign = HorizontalAlignment.Center;
            // 
            // TB_MIN_ADD1
            // 
            TB_MIN_ADD1.Enabled = false;
            TB_MIN_ADD1.Location = new Point(388, 247);
            TB_MIN_ADD1.Name = "TB_MIN_ADD1";
            TB_MIN_ADD1.ReadOnly = true;
            TB_MIN_ADD1.Size = new Size(64, 27);
            TB_MIN_ADD1.TabIndex = 40;
            TB_MIN_ADD1.TextAlign = HorizontalAlignment.Center;
            // 
            // TB_NAME_ADD1
            // 
            TB_NAME_ADD1.Enabled = false;
            TB_NAME_ADD1.Location = new Point(75, 247);
            TB_NAME_ADD1.Name = "TB_NAME_ADD1";
            TB_NAME_ADD1.ReadOnly = true;
            TB_NAME_ADD1.Size = new Size(80, 27);
            TB_NAME_ADD1.TabIndex = 41;
            // 
            // BT_ADD_ADD2
            // 
            BT_ADD_ADD2.Image = (Image)resources.GetObject("BT_ADD_ADD2.Image");
            BT_ADD_ADD2.Location = new Point(295, 278);
            BT_ADD_ADD2.Name = "BT_ADD_ADD2";
            BT_ADD_ADD2.Size = new Size(27, 27);
            BT_ADD_ADD2.TabIndex = 42;
            BT_ADD_ADD2.UseVisualStyleBackColor = true;
            BT_ADD_ADD2.Click += BT_ADD_ADD2_Click;
            // 
            // TB_OPEN_ADD2
            // 
            TB_OPEN_ADD2.Enabled = false;
            TB_OPEN_ADD2.Location = new Point(163, 277);
            TB_OPEN_ADD2.Name = "TB_OPEN_ADD2";
            TB_OPEN_ADD2.ReadOnly = true;
            TB_OPEN_ADD2.Size = new Size(64, 27);
            TB_OPEN_ADD2.TabIndex = 43;
            TB_OPEN_ADD2.TextAlign = HorizontalAlignment.Center;
            // 
            // TB_CLOSE_ADD2
            // 
            TB_CLOSE_ADD2.Enabled = false;
            TB_CLOSE_ADD2.Location = new Point(238, 277);
            TB_CLOSE_ADD2.Name = "TB_CLOSE_ADD2";
            TB_CLOSE_ADD2.ReadOnly = true;
            TB_CLOSE_ADD2.Size = new Size(64, 27);
            TB_CLOSE_ADD2.TabIndex = 44;
            TB_CLOSE_ADD2.TextAlign = HorizontalAlignment.Center;
            // 
            // TB_MAX_ADD2
            // 
            TB_MAX_ADD2.Enabled = false;
            TB_MAX_ADD2.Location = new Point(313, 277);
            TB_MAX_ADD2.Name = "TB_MAX_ADD2";
            TB_MAX_ADD2.ReadOnly = true;
            TB_MAX_ADD2.Size = new Size(64, 27);
            TB_MAX_ADD2.TabIndex = 45;
            TB_MAX_ADD2.TextAlign = HorizontalAlignment.Center;
            // 
            // TB_MIN_ADD2
            // 
            TB_MIN_ADD2.Enabled = false;
            TB_MIN_ADD2.Location = new Point(388, 277);
            TB_MIN_ADD2.Name = "TB_MIN_ADD2";
            TB_MIN_ADD2.ReadOnly = true;
            TB_MIN_ADD2.Size = new Size(64, 27);
            TB_MIN_ADD2.TabIndex = 46;
            TB_MIN_ADD2.TextAlign = HorizontalAlignment.Center;
            // 
            // TB_NAME_ADD2
            // 
            TB_NAME_ADD2.Enabled = false;
            TB_NAME_ADD2.Location = new Point(75, 277);
            TB_NAME_ADD2.Name = "TB_NAME_ADD2";
            TB_NAME_ADD2.ReadOnly = true;
            TB_NAME_ADD2.Size = new Size(80, 27);
            TB_NAME_ADD2.TabIndex = 47;
            // 
            // BT_EDIT_ADD1
            // 
            BT_EDIT_ADD1.Image = (Image)resources.GetObject("BT_EDIT_ADD1.Image");
            BT_EDIT_ADD1.Location = new Point(43, 246);
            BT_EDIT_ADD1.Name = "BT_EDIT_ADD1";
            BT_EDIT_ADD1.Size = new Size(27, 27);
            BT_EDIT_ADD1.TabIndex = 48;
            BT_EDIT_ADD1.UseVisualStyleBackColor = true;
            BT_EDIT_ADD1.Click += BT_EDIT_ADD1_Click;
            // 
            // BT_EDIT_ADD2
            // 
            BT_EDIT_ADD2.Image = (Image)resources.GetObject("BT_EDIT_ADD2.Image");
            BT_EDIT_ADD2.Location = new Point(42, 277);
            BT_EDIT_ADD2.Name = "BT_EDIT_ADD2";
            BT_EDIT_ADD2.Size = new Size(27, 27);
            BT_EDIT_ADD2.TabIndex = 49;
            BT_EDIT_ADD2.UseVisualStyleBackColor = true;
            BT_EDIT_ADD2.Click += BT_EDIT_ADD2_Click;
            // 
            // BT_CHECK_ADD1
            // 
            BT_CHECK_ADD1.Image = (Image)resources.GetObject("BT_CHECK_ADD1.Image");
            BT_CHECK_ADD1.Location = new Point(42, 247);
            BT_CHECK_ADD1.Name = "BT_CHECK_ADD1";
            BT_CHECK_ADD1.Size = new Size(27, 27);
            BT_CHECK_ADD1.TabIndex = 50;
            BT_CHECK_ADD1.UseVisualStyleBackColor = true;
            BT_CHECK_ADD1.Visible = false;
            BT_CHECK_ADD1.Click += BT_CHECK_ADD1_Click;
            // 
            // BT_CHECK_ADD2
            // 
            BT_CHECK_ADD2.Image = (Image)resources.GetObject("BT_CHECK_ADD2.Image");
            BT_CHECK_ADD2.Location = new Point(42, 277);
            BT_CHECK_ADD2.Name = "BT_CHECK_ADD2";
            BT_CHECK_ADD2.Size = new Size(27, 27);
            BT_CHECK_ADD2.TabIndex = 51;
            BT_CHECK_ADD2.UseVisualStyleBackColor = true;
            BT_CHECK_ADD2.Visible = false;
            BT_CHECK_ADD2.Click += BT_CHECK_ADD2_Click;
            // 
            // D1_LCO
            // 
            D1_LCO.Enabled = false;
            D1_LCO.Location = new Point(479, 157);
            D1_LCO.Name = "D1_LCO";
            D1_LCO.ReadOnly = true;
            D1_LCO.Size = new Size(27, 27);
            D1_LCO.TabIndex = 52;
            D1_LCO.TextAlign = HorizontalAlignment.Center;
            // 
            // D1_NG
            // 
            D1_NG.Enabled = false;
            D1_NG.Location = new Point(479, 187);
            D1_NG.Name = "D1_NG";
            D1_NG.ReadOnly = true;
            D1_NG.Size = new Size(27, 27);
            D1_NG.TabIndex = 53;
            D1_NG.TextAlign = HorizontalAlignment.Center;
            // 
            // D1_S
            // 
            D1_S.Enabled = false;
            D1_S.Location = new Point(479, 217);
            D1_S.Name = "D1_S";
            D1_S.ReadOnly = true;
            D1_S.Size = new Size(27, 27);
            D1_S.TabIndex = 54;
            D1_S.TextAlign = HorizontalAlignment.Center;
            // 
            // D1_ADD1
            // 
            D1_ADD1.Enabled = false;
            D1_ADD1.Location = new Point(479, 247);
            D1_ADD1.Name = "D1_ADD1";
            D1_ADD1.ReadOnly = true;
            D1_ADD1.Size = new Size(27, 27);
            D1_ADD1.TabIndex = 55;
            D1_ADD1.TextAlign = HorizontalAlignment.Center;
            // 
            // D1_ADD2
            // 
            D1_ADD2.Enabled = false;
            D1_ADD2.Location = new Point(479, 277);
            D1_ADD2.Name = "D1_ADD2";
            D1_ADD2.ReadOnly = true;
            D1_ADD2.Size = new Size(27, 27);
            D1_ADD2.TabIndex = 56;
            D1_ADD2.TextAlign = HorizontalAlignment.Center;
            // 
            // H4_LCO
            // 
            H4_LCO.Enabled = false;
            H4_LCO.Location = new Point(509, 157);
            H4_LCO.Name = "H4_LCO";
            H4_LCO.ReadOnly = true;
            H4_LCO.Size = new Size(27, 27);
            H4_LCO.TabIndex = 57;
            H4_LCO.TextAlign = HorizontalAlignment.Center;
            // 
            // H4_NG
            // 
            H4_NG.Enabled = false;
            H4_NG.Location = new Point(509, 187);
            H4_NG.Name = "H4_NG";
            H4_NG.ReadOnly = true;
            H4_NG.Size = new Size(27, 27);
            H4_NG.TabIndex = 58;
            H4_NG.TextAlign = HorizontalAlignment.Center;
            // 
            // H4_S
            // 
            H4_S.Enabled = false;
            H4_S.Location = new Point(509, 217);
            H4_S.Name = "H4_S";
            H4_S.ReadOnly = true;
            H4_S.Size = new Size(27, 27);
            H4_S.TabIndex = 59;
            H4_S.TextAlign = HorizontalAlignment.Center;
            // 
            // H4_ADD1
            // 
            H4_ADD1.Enabled = false;
            H4_ADD1.Location = new Point(509, 247);
            H4_ADD1.Name = "H4_ADD1";
            H4_ADD1.ReadOnly = true;
            H4_ADD1.Size = new Size(27, 27);
            H4_ADD1.TabIndex = 60;
            H4_ADD1.TextAlign = HorizontalAlignment.Center;
            // 
            // H4_ADD2
            // 
            H4_ADD2.Enabled = false;
            H4_ADD2.Location = new Point(510, 277);
            H4_ADD2.Name = "H4_ADD2";
            H4_ADD2.ReadOnly = true;
            H4_ADD2.Size = new Size(27, 27);
            H4_ADD2.TabIndex = 61;
            H4_ADD2.TextAlign = HorizontalAlignment.Center;
            // 
            // H1_LCO
            // 
            H1_LCO.Enabled = false;
            H1_LCO.Location = new Point(539, 157);
            H1_LCO.Name = "H1_LCO";
            H1_LCO.ReadOnly = true;
            H1_LCO.Size = new Size(27, 27);
            H1_LCO.TabIndex = 62;
            H1_LCO.TextAlign = HorizontalAlignment.Center;
            // 
            // H1_NG
            // 
            H1_NG.Enabled = false;
            H1_NG.Location = new Point(539, 187);
            H1_NG.Name = "H1_NG";
            H1_NG.ReadOnly = true;
            H1_NG.Size = new Size(27, 27);
            H1_NG.TabIndex = 63;
            H1_NG.TextAlign = HorizontalAlignment.Center;
            // 
            // H1_S
            // 
            H1_S.Enabled = false;
            H1_S.Location = new Point(539, 217);
            H1_S.Name = "H1_S";
            H1_S.ReadOnly = true;
            H1_S.Size = new Size(27, 27);
            H1_S.TabIndex = 64;
            H1_S.TextAlign = HorizontalAlignment.Center;
            // 
            // H1_ADD1
            // 
            H1_ADD1.Enabled = false;
            H1_ADD1.Location = new Point(539, 247);
            H1_ADD1.Name = "H1_ADD1";
            H1_ADD1.ReadOnly = true;
            H1_ADD1.Size = new Size(27, 27);
            H1_ADD1.TabIndex = 65;
            H1_ADD1.TextAlign = HorizontalAlignment.Center;
            // 
            // H1_ADD2
            // 
            H1_ADD2.Enabled = false;
            H1_ADD2.Location = new Point(539, 277);
            H1_ADD2.Name = "H1_ADD2";
            H1_ADD2.ReadOnly = true;
            H1_ADD2.Size = new Size(27, 27);
            H1_ADD2.TabIndex = 66;
            H1_ADD2.TextAlign = HorizontalAlignment.Center;
            // 
            // M5_ADD2
            // 
            M5_ADD2.Enabled = false;
            M5_ADD2.Location = new Point(569, 277);
            M5_ADD2.Name = "M5_ADD2";
            M5_ADD2.ReadOnly = true;
            M5_ADD2.Size = new Size(27, 27);
            M5_ADD2.TabIndex = 71;
            M5_ADD2.TextAlign = HorizontalAlignment.Center;
            // 
            // M5_ADD1
            // 
            M5_ADD1.Enabled = false;
            M5_ADD1.Location = new Point(569, 247);
            M5_ADD1.Name = "M5_ADD1";
            M5_ADD1.ReadOnly = true;
            M5_ADD1.Size = new Size(27, 27);
            M5_ADD1.TabIndex = 70;
            M5_ADD1.TextAlign = HorizontalAlignment.Center;
            // 
            // M5_S
            // 
            M5_S.Enabled = false;
            M5_S.Location = new Point(569, 217);
            M5_S.Name = "M5_S";
            M5_S.ReadOnly = true;
            M5_S.Size = new Size(27, 27);
            M5_S.TabIndex = 69;
            M5_S.TextAlign = HorizontalAlignment.Center;
            // 
            // M5_NG
            // 
            M5_NG.Enabled = false;
            M5_NG.Location = new Point(569, 187);
            M5_NG.Name = "M5_NG";
            M5_NG.ReadOnly = true;
            M5_NG.Size = new Size(27, 27);
            M5_NG.TabIndex = 68;
            M5_NG.TextAlign = HorizontalAlignment.Center;
            // 
            // M5_LCO
            // 
            M5_LCO.Enabled = false;
            M5_LCO.Location = new Point(569, 157);
            M5_LCO.Name = "M5_LCO";
            M5_LCO.ReadOnly = true;
            M5_LCO.Size = new Size(27, 27);
            M5_LCO.TabIndex = 67;
            M5_LCO.TextAlign = HorizontalAlignment.Center;
            // 
            // SW_LCO
            // 
            SW_LCO.BackColor = Color.White;
            SW_LCO.BackColorOFF = Color.Red;
            SW_LCO.BackColorON = Color.YellowGreen;
            SW_LCO.Checked = false;
            SW_LCO.Font = new Font("Verdana", 9F);
            SW_LCO.Location = new Point(965, 157);
            SW_LCO.Name = "SW_LCO";
            SW_LCO.Size = new Size(43, 27);
            SW_LCO.TabIndex = 72;
            SW_LCO.TextOnChecked = "";
            SW_LCO.Click += SW_LCO_Click;
            // 
            // SW_NG
            // 
            SW_NG.BackColor = Color.White;
            SW_NG.BackColorOFF = Color.Red;
            SW_NG.BackColorON = Color.YellowGreen;
            SW_NG.Checked = false;
            SW_NG.Font = new Font("Verdana", 9F);
            SW_NG.Location = new Point(965, 187);
            SW_NG.Name = "SW_NG";
            SW_NG.Size = new Size(43, 27);
            SW_NG.TabIndex = 73;
            SW_NG.TextOnChecked = "";
            SW_NG.Click += SW_NG_Click;
            // 
            // SW_S
            // 
            SW_S.BackColor = Color.White;
            SW_S.BackColorOFF = Color.Red;
            SW_S.BackColorON = Color.YellowGreen;
            SW_S.Checked = false;
            SW_S.Font = new Font("Verdana", 9F);
            SW_S.Location = new Point(965, 217);
            SW_S.Name = "SW_S";
            SW_S.Size = new Size(43, 27);
            SW_S.TabIndex = 74;
            SW_S.TextOnChecked = "";
            SW_S.Click += SW_S_Click;
            // 
            // SW_ADD1
            // 
            SW_ADD1.BackColor = Color.White;
            SW_ADD1.BackColorOFF = Color.Red;
            SW_ADD1.BackColorON = Color.YellowGreen;
            SW_ADD1.Checked = false;
            SW_ADD1.Font = new Font("Verdana", 9F);
            SW_ADD1.Location = new Point(965, 247);
            SW_ADD1.Name = "SW_ADD1";
            SW_ADD1.Size = new Size(43, 27);
            SW_ADD1.TabIndex = 75;
            SW_ADD1.TextOnChecked = "";
            SW_ADD1.Click += SW_ADD1_Click;
            // 
            // SW_ADD2
            // 
            SW_ADD2.BackColor = Color.White;
            SW_ADD2.BackColorOFF = Color.Red;
            SW_ADD2.BackColorON = Color.YellowGreen;
            SW_ADD2.Checked = false;
            SW_ADD2.Font = new Font("Verdana", 9F);
            SW_ADD2.Location = new Point(965, 277);
            SW_ADD2.Name = "SW_ADD2";
            SW_ADD2.Size = new Size(43, 27);
            SW_ADD2.TabIndex = 76;
            SW_ADD2.TextOnChecked = "";
            SW_ADD2.Click += SW_ADD2_Click;
            // 
            // L_STATUS_LCO
            // 
            L_STATUS_LCO.ForeColor = Color.Red;
            L_STATUS_LCO.Location = new Point(612, 160);
            L_STATUS_LCO.Name = "L_STATUS_LCO";
            L_STATUS_LCO.Size = new Size(110, 20);
            L_STATUS_LCO.TabIndex = 77;
            L_STATUS_LCO.Text = "Stopped";
            L_STATUS_LCO.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // L_STATUS_NG
            // 
            L_STATUS_NG.ForeColor = Color.Red;
            L_STATUS_NG.Location = new Point(612, 190);
            L_STATUS_NG.Name = "L_STATUS_NG";
            L_STATUS_NG.Size = new Size(110, 20);
            L_STATUS_NG.TabIndex = 78;
            L_STATUS_NG.Text = "Stopped";
            L_STATUS_NG.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // L_STATUS_S
            // 
            L_STATUS_S.ForeColor = Color.Red;
            L_STATUS_S.Location = new Point(612, 220);
            L_STATUS_S.Name = "L_STATUS_S";
            L_STATUS_S.Size = new Size(110, 20);
            L_STATUS_S.TabIndex = 79;
            L_STATUS_S.Text = "Stopped";
            L_STATUS_S.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // L_STATUS_ADD1
            // 
            L_STATUS_ADD1.ForeColor = Color.Red;
            L_STATUS_ADD1.Location = new Point(612, 250);
            L_STATUS_ADD1.Name = "L_STATUS_ADD1";
            L_STATUS_ADD1.Size = new Size(110, 20);
            L_STATUS_ADD1.TabIndex = 80;
            L_STATUS_ADD1.Text = "Stopped";
            L_STATUS_ADD1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // L_STATUS_ADD2
            // 
            L_STATUS_ADD2.ForeColor = Color.Red;
            L_STATUS_ADD2.Location = new Point(612, 281);
            L_STATUS_ADD2.Name = "L_STATUS_ADD2";
            L_STATUS_ADD2.Size = new Size(110, 20);
            L_STATUS_ADD2.TabIndex = 81;
            L_STATUS_ADD2.Text = "Stopped";
            L_STATUS_ADD2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // L_LOG_LCO
            // 
            L_LOG_LCO.AutoSize = true;
            L_LOG_LCO.Location = new Point(807, 160);
            L_LOG_LCO.Name = "L_LOG_LCO";
            L_LOG_LCO.Size = new Size(93, 20);
            L_LOG_LCO.TabIndex = 82;
            L_LOG_LCO.Text = "Connecting...";
            L_LOG_LCO.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // L_LOG_NG
            // 
            L_LOG_NG.AutoSize = true;
            L_LOG_NG.Location = new Point(807, 190);
            L_LOG_NG.Name = "L_LOG_NG";
            L_LOG_NG.Size = new Size(93, 20);
            L_LOG_NG.TabIndex = 83;
            L_LOG_NG.Text = "Connecting...";
            L_LOG_NG.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // L_LOG_S
            // 
            L_LOG_S.AutoSize = true;
            L_LOG_S.Location = new Point(807, 220);
            L_LOG_S.Name = "L_LOG_S";
            L_LOG_S.Size = new Size(93, 20);
            L_LOG_S.TabIndex = 84;
            L_LOG_S.Text = "Connecting...";
            L_LOG_S.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // L_LOG_ADD1
            // 
            L_LOG_ADD1.AutoSize = true;
            L_LOG_ADD1.Location = new Point(807, 251);
            L_LOG_ADD1.Name = "L_LOG_ADD1";
            L_LOG_ADD1.Size = new Size(93, 20);
            L_LOG_ADD1.TabIndex = 85;
            L_LOG_ADD1.Text = "Connecting...";
            L_LOG_ADD1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // L_LOG_ADD2
            // 
            L_LOG_ADD2.AutoSize = true;
            L_LOG_ADD2.Location = new Point(807, 280);
            L_LOG_ADD2.Name = "L_LOG_ADD2";
            L_LOG_ADD2.Size = new Size(93, 20);
            L_LOG_ADD2.TabIndex = 86;
            L_LOG_ADD2.Text = "Connecting...";
            L_LOG_ADD2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // L_BX_STATUS
            // 
            L_BX_STATUS.AutoSize = true;
            L_BX_STATUS.Location = new Point(156, 15);
            L_BX_STATUS.Name = "L_BX_STATUS";
            L_BX_STATUS.Size = new Size(203, 20);
            L_BX_STATUS.TabIndex = 87;
            L_BX_STATUS.Text = "BINGX CONNECTION STATUS";
            // 
            // L_BINGX_STATUS
            // 
            L_BINGX_STATUS.AutoSize = true;
            L_BINGX_STATUS.ForeColor = Color.Red;
            L_BINGX_STATUS.Location = new Point(359, 15);
            L_BINGX_STATUS.Name = "L_BINGX_STATUS";
            L_BINGX_STATUS.Size = new Size(66, 20);
            L_BINGX_STATUS.TabIndex = 88;
            L_BINGX_STATUS.Text = "Stopped";
            L_BINGX_STATUS.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SW_MAIN
            // 
            SW_MAIN.BackColor = Color.White;
            SW_MAIN.BackColorOFF = Color.Red;
            SW_MAIN.BackColorON = Color.YellowGreen;
            SW_MAIN.Checked = false;
            SW_MAIN.Font = new Font("Verdana", 9F);
            SW_MAIN.Location = new Point(55, 12);
            SW_MAIN.Name = "SW_MAIN";
            SW_MAIN.Size = new Size(43, 27);
            SW_MAIN.TabIndex = 89;
            SW_MAIN.TextOnChecked = "";
            SW_MAIN.Click += SW_MAIN_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label16.Location = new Point(705, 15);
            label16.Name = "label16";
            label16.Size = new Size(80, 20);
            label16.TabIndex = 90;
            label16.Text = "Версия от";
            // 
            // L_VERSION
            // 
            L_VERSION.AutoSize = true;
            L_VERSION.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            L_VERSION.Location = new Point(783, 16);
            L_VERSION.Name = "L_VERSION";
            L_VERSION.Size = new Size(79, 20);
            L_VERSION.TabIndex = 91;
            L_VERSION.Text = "10.04.2025";
            // 
            // BT_DELETE_ADD1
            // 
            BT_DELETE_ADD1.Image = (Image)resources.GetObject("BT_DELETE_ADD1.Image");
            BT_DELETE_ADD1.Location = new Point(13, 246);
            BT_DELETE_ADD1.Name = "BT_DELETE_ADD1";
            BT_DELETE_ADD1.Size = new Size(27, 27);
            BT_DELETE_ADD1.TabIndex = 92;
            BT_DELETE_ADD1.UseVisualStyleBackColor = true;
            BT_DELETE_ADD1.Visible = false;
            BT_DELETE_ADD1.Click += BT_DELETE_ADD1_Click;
            // 
            // BT_DELETE_ADD2
            // 
            BT_DELETE_ADD2.Image = (Image)resources.GetObject("BT_DELETE_ADD2.Image");
            BT_DELETE_ADD2.Location = new Point(12, 277);
            BT_DELETE_ADD2.Name = "BT_DELETE_ADD2";
            BT_DELETE_ADD2.Size = new Size(27, 27);
            BT_DELETE_ADD2.TabIndex = 93;
            BT_DELETE_ADD2.UseVisualStyleBackColor = true;
            BT_DELETE_ADD2.Visible = false;
            BT_DELETE_ADD2.Click += BT_DELETE_ADD2_Click;
            // 
            // L_DATE
            // 
            L_DATE.AutoSize = true;
            L_DATE.Location = new Point(13, 114);
            L_DATE.Name = "L_DATE";
            L_DATE.Size = new Size(0, 20);
            L_DATE.TabIndex = 94;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 312);
            Controls.Add(L_DATE);
            Controls.Add(BT_DELETE_ADD2);
            Controls.Add(BT_DELETE_ADD1);
            Controls.Add(L_VERSION);
            Controls.Add(label16);
            Controls.Add(BT_EDIT_ADD2);
            Controls.Add(L_LOG_ADD2);
            Controls.Add(TB_MAX_ADD2);
            Controls.Add(L_STATUS_ADD2);
            Controls.Add(M5_ADD2);
            Controls.Add(H1_ADD2);
            Controls.Add(H4_ADD2);
            Controls.Add(D1_ADD2);
            Controls.Add(TB_MIN_ADD2);
            Controls.Add(TB_CLOSE_ADD2);
            Controls.Add(TB_NAME_ADD2);
            Controls.Add(TB_OPEN_ADD2);
            Controls.Add(SW_MAIN);
            Controls.Add(L_BINGX_STATUS);
            Controls.Add(L_BX_STATUS);
            Controls.Add(L_LOG_ADD1);
            Controls.Add(L_LOG_S);
            Controls.Add(L_LOG_NG);
            Controls.Add(L_LOG_LCO);
            Controls.Add(L_STATUS_ADD1);
            Controls.Add(L_STATUS_S);
            Controls.Add(L_STATUS_NG);
            Controls.Add(SW_ADD2);
            Controls.Add(L_STATUS_LCO);
            Controls.Add(SW_ADD1);
            Controls.Add(SW_S);
            Controls.Add(SW_NG);
            Controls.Add(SW_LCO);
            Controls.Add(M5_ADD1);
            Controls.Add(M5_S);
            Controls.Add(M5_NG);
            Controls.Add(M5_LCO);
            Controls.Add(H1_ADD1);
            Controls.Add(H1_S);
            Controls.Add(H1_NG);
            Controls.Add(H1_LCO);
            Controls.Add(H4_ADD1);
            Controls.Add(H4_S);
            Controls.Add(H4_NG);
            Controls.Add(H4_LCO);
            Controls.Add(D1_ADD1);
            Controls.Add(D1_S);
            Controls.Add(D1_NG);
            Controls.Add(D1_LCO);
            Controls.Add(BT_EDIT_ADD1);
            Controls.Add(BT_ADD_ADD2);
            Controls.Add(TB_NAME_ADD1);
            Controls.Add(TB_MIN_ADD1);
            Controls.Add(TB_MAX_ADD1);
            Controls.Add(TB_CLOSE_ADD1);
            Controls.Add(TB_OPEN_ADD1);
            Controls.Add(BT_ADD_ADD1);
            Controls.Add(TB_MIN_S);
            Controls.Add(TB_MAX_S);
            Controls.Add(TB_CLOSE_S);
            Controls.Add(TB_OPEN_S);
            Controls.Add(TB_MIN_NG);
            Controls.Add(TB_MAX_NG);
            Controls.Add(TB_CLOSE_NG);
            Controls.Add(TB_OPEN_NG);
            Controls.Add(TB_MIN_LCO);
            Controls.Add(TB_MAX_LCO);
            Controls.Add(TB_CLOSE_LCO);
            Controls.Add(TB_OPEN_LCO);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(BT_EDIT_SECRET);
            Controls.Add(BT_EDIT_KEY);
            Controls.Add(label2);
            Controls.Add(TB_SECRET);
            Controls.Add(label1);
            Controls.Add(TB_KEY);
            Controls.Add(BT_CHECK_KEY);
            Controls.Add(BT_CHECK_SECRET);
            Controls.Add(BT_CHECK_ADD1);
            Controls.Add(BT_CHECK_ADD2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "CDA - Commodity Data Analysis";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TB_KEY;
        private Label label1;
        private TextBox TB_SECRET;
        private Label label2;
        private Button BT_EDIT_KEY;
        private Button BT_EDIT_SECRET;
        private Button BT_CHECK_KEY;
        private Button BT_CHECK_SECRET;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox TB_OPEN_LCO;
        private TextBox TB_CLOSE_LCO;
        private TextBox TB_MAX_LCO;
        private TextBox TB_MIN_LCO;
        private TextBox TB_OPEN_NG;
        private TextBox TB_CLOSE_NG;
        private TextBox TB_MAX_NG;
        private TextBox TB_MIN_NG;
        private TextBox TB_OPEN_S;
        private TextBox TB_CLOSE_S;
        private TextBox TB_MAX_S;
        private TextBox TB_MIN_S;
        private Button BT_ADD_ADD1;
        private TextBox TB_OPEN_ADD1;
        private TextBox TB_CLOSE_ADD1;
        private TextBox TB_MAX_ADD1;
        private TextBox TB_MIN_ADD1;
        private TextBox TB_NAME_ADD1;
        private Button BT_ADD_ADD2;
        private TextBox TB_OPEN_ADD2;
        private TextBox TB_CLOSE_ADD2;
        private TextBox TB_MAX_ADD2;
        private TextBox TB_MIN_ADD2;
        private TextBox TB_NAME_ADD2;
        private Button BT_EDIT_ADD1;
        private Button BT_EDIT_ADD2;
        private Button BT_CHECK_ADD1;
        private Button BT_CHECK_ADD2;
        private TextBox D1_LCO;
        private TextBox D1_NG;
        private TextBox D1_S;
        private TextBox D1_ADD1;
        private TextBox D1_ADD2;
        private TextBox H4_LCO;
        private TextBox H4_NG;
        private TextBox H4_S;
        private TextBox H4_ADD1;
        private TextBox H4_ADD2;
        private TextBox H1_LCO;
        private TextBox H1_NG;
        private TextBox H1_S;
        private TextBox H1_ADD1;
        private TextBox H1_ADD2;
        private TextBox M5_ADD2;
        private TextBox M5_ADD1;
        private TextBox M5_S;
        private TextBox M5_NG;
        private TextBox M5_LCO;
        private Controls.ToggleSwitch SW_LCO;
        private Controls.ToggleSwitch SW_NG;
        private Controls.ToggleSwitch SW_S;
        private Controls.ToggleSwitch SW_ADD1;
        private Controls.ToggleSwitch SW_ADD2;
        private Label L_STATUS_LCO;
        private Label L_STATUS_NG;
        private Label L_STATUS_S;
        private Label L_STATUS_ADD1;
        private Label L_STATUS_ADD2;
        private Label L_LOG_LCO;
        private Label L_LOG_NG;
        private Label L_LOG_S;
        private Label L_LOG_ADD1;
        private Label L_LOG_ADD2;
        private Label L_BX_STATUS;
        private Label L_BINGX_STATUS;
        private Controls.ToggleSwitch SW_MAIN;
        private Label label16;
        private Label L_VERSION;
        private Button BT_DELETE_ADD1;
        private Button BT_DELETE_ADD2;
        private Label L_DATE;
        private System.Windows.Forms.Timer timer1;
    }
}
