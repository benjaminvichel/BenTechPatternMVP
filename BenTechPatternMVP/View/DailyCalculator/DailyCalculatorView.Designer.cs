
namespace BenTechPatternMVP.View.DailyCalculator
{
    partial class DailyCalculatorView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyCalculatorView));
            this.panelTop = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnCalculatePrices = new System.Windows.Forms.Button();
            this.lblNumberOfDays = new System.Windows.Forms.Label();
            this.txtNumbOfDays = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txbDiscount = new System.Windows.Forms.TextBox();
            this.panelTopBlue = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.ibtnShowEmail = new FontAwesome.Sharp.IconButton();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblDailyPrice = new System.Windows.Forms.Label();
            this.PanelRight = new System.Windows.Forms.Panel();
            this.cbChild03To06 = new System.Windows.Forms.ComboBox();
            this.lblChild03To06 = new System.Windows.Forms.Label();
            this.lblSingle = new System.Windows.Forms.Label();
            this.lblChild07To10 = new System.Windows.Forms.Label();
            this.cbChild07To10 = new System.Windows.Forms.ComboBox();
            this.cbSingleCustom = new System.Windows.Forms.ComboBox();
            this.ctbDailyRateCouple = new BenTechPatternMVP.View.CustomTextBox.CustomTextBoxView();
            this.ctbDailyRateLuxuryCouple = new BenTechPatternMVP.View.CustomTextBox.CustomTextBoxView();
            this.ctbDailyRateQuadruple = new BenTechPatternMVP.View.CustomTextBox.CustomTextBoxView();
            this.ctbTotalValueQuadruple = new BenTechPatternMVP.View.CustomTextBox.CustomTextBoxView();
            this.ctbTotalValueQuintuple = new BenTechPatternMVP.View.CustomTextBox.CustomTextBoxView();
            this.ctbDailyRateQuintuple = new BenTechPatternMVP.View.CustomTextBox.CustomTextBoxView();
            this.ctbTotalValueTriple = new BenTechPatternMVP.View.CustomTextBox.CustomTextBoxView();
            this.ctbTotalValueSingle = new BenTechPatternMVP.View.CustomTextBox.CustomTextBoxView();
            this.ctbTotalValueLuxuryCouple = new BenTechPatternMVP.View.CustomTextBox.CustomTextBoxView();
            this.ctbTotalValueCouple = new BenTechPatternMVP.View.CustomTextBox.CustomTextBoxView();
            this.ctbDailyRateTriple = new BenTechPatternMVP.View.CustomTextBox.CustomTextBoxView();
            this.ctbDailyRateSingle = new BenTechPatternMVP.View.CustomTextBox.CustomTextBoxView();
            this.ctbTotalPriceCustom = new BenTechPatternMVP.View.CustomTextBox.CustomTextBoxView();
            this.ctbDailyPriceCustom = new BenTechPatternMVP.View.CustomTextBox.CustomTextBoxView();
            this.panelTop.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.PanelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.dateTimePicker1);
            this.panelTop.Controls.Add(this.dateTimePicker2);
            this.panelTop.Controls.Add(this.btnCalculatePrices);
            this.panelTop.Controls.Add(this.lblNumberOfDays);
            this.panelTop.Controls.Add(this.txtNumbOfDays);
            this.panelTop.Controls.Add(this.lblDiscount);
            this.panelTop.Controls.Add(this.txbDiscount);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1168, 100);
            this.panelTop.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.White;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(408, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(228, 20);
            this.dateTimePicker1.TabIndex = 51;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(657, 18);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(228, 20);
            this.dateTimePicker2.TabIndex = 52;
            // 
            // btnCalculatePrices
            // 
            this.btnCalculatePrices.BackColor = System.Drawing.Color.White;
            this.btnCalculatePrices.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.btnCalculatePrices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculatePrices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculatePrices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.btnCalculatePrices.Image = ((System.Drawing.Image)(resources.GetObject("btnCalculatePrices.Image")));
            this.btnCalculatePrices.Location = new System.Drawing.Point(531, 45);
            this.btnCalculatePrices.Name = "btnCalculatePrices";
            this.btnCalculatePrices.Size = new System.Drawing.Size(223, 39);
            this.btnCalculatePrices.TabIndex = 50;
            this.btnCalculatePrices.Text = "Calculate";
            this.btnCalculatePrices.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalculatePrices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalculatePrices.UseVisualStyleBackColor = false;
            // 
            // lblNumberOfDays
            // 
            this.lblNumberOfDays.AutoSize = true;
            this.lblNumberOfDays.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNumberOfDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfDays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.lblNumberOfDays.Location = new System.Drawing.Point(22, 19);
            this.lblNumberOfDays.Name = "lblNumberOfDays";
            this.lblNumberOfDays.Size = new System.Drawing.Size(92, 13);
            this.lblNumberOfDays.TabIndex = 54;
            this.lblNumberOfDays.Text = "Número de diárias";
            // 
            // txtNumbOfDays
            // 
            this.txtNumbOfDays.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumbOfDays.Location = new System.Drawing.Point(124, 20);
            this.txtNumbOfDays.Multiline = true;
            this.txtNumbOfDays.Name = "txtNumbOfDays";
            this.txtNumbOfDays.Size = new System.Drawing.Size(37, 16);
            this.txtNumbOfDays.TabIndex = 53;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.lblDiscount.Location = new System.Drawing.Point(22, 62);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(113, 13);
            this.lblDiscount.TabIndex = 55;
            this.lblDiscount.Text = "Desconto - max. 100%";
            // 
            // txbDiscount
            // 
            this.txbDiscount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbDiscount.Location = new System.Drawing.Point(145, 58);
            this.txbDiscount.Multiline = true;
            this.txbDiscount.Name = "txbDiscount";
            this.txbDiscount.Size = new System.Drawing.Size(90, 22);
            this.txbDiscount.TabIndex = 56;
            // 
            // panelTopBlue
            // 
            this.panelTopBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(178)))), ((int)(((byte)(237)))));
            this.panelTopBlue.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBlue.Location = new System.Drawing.Point(0, 100);
            this.panelTopBlue.Name = "panelTopBlue";
            this.panelTopBlue.Size = new System.Drawing.Size(1168, 4);
            this.panelTopBlue.TabIndex = 52;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panelLeft.Controls.Add(this.ctbDailyRateSingle);
            this.panelLeft.Controls.Add(this.ctbDailyRateTriple);
            this.panelLeft.Controls.Add(this.ctbTotalValueCouple);
            this.panelLeft.Controls.Add(this.ctbTotalValueLuxuryCouple);
            this.panelLeft.Controls.Add(this.ctbTotalValueSingle);
            this.panelLeft.Controls.Add(this.ctbTotalValueTriple);
            this.panelLeft.Controls.Add(this.ctbDailyRateQuintuple);
            this.panelLeft.Controls.Add(this.ctbTotalValueQuintuple);
            this.panelLeft.Controls.Add(this.ctbTotalValueQuadruple);
            this.panelLeft.Controls.Add(this.ctbDailyRateQuadruple);
            this.panelLeft.Controls.Add(this.ctbDailyRateLuxuryCouple);
            this.panelLeft.Controls.Add(this.ctbDailyRateCouple);
            this.panelLeft.Controls.Add(this.ibtnShowEmail);
            this.panelLeft.Controls.Add(this.lblTotalPrice);
            this.panelLeft.Controls.Add(this.lblDailyPrice);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 104);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(646, 654);
            this.panelLeft.TabIndex = 53;
            // 
            // ibtnShowEmail
            // 
            this.ibtnShowEmail.BackColor = System.Drawing.Color.White;
            this.ibtnShowEmail.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.ibtnShowEmail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ibtnShowEmail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.ibtnShowEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnShowEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnShowEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.ibtnShowEmail.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnShowEmail.IconColor = System.Drawing.Color.Black;
            this.ibtnShowEmail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnShowEmail.Location = new System.Drawing.Point(218, 426);
            this.ibtnShowEmail.Name = "ibtnShowEmail";
            this.ibtnShowEmail.Size = new System.Drawing.Size(223, 49);
            this.ibtnShowEmail.TabIndex = 62;
            this.ibtnShowEmail.Text = "Create Email";
            this.ibtnShowEmail.UseVisualStyleBackColor = false;
            this.ibtnShowEmail.Visible = false;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.lblTotalPrice.Location = new System.Drawing.Point(442, 7);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(69, 13);
            this.lblTotalPrice.TabIndex = 42;
            this.lblTotalPrice.Text = "Valor Total";
            // 
            // lblDailyPrice
            // 
            this.lblDailyPrice.AutoSize = true;
            this.lblDailyPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDailyPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.lblDailyPrice.Location = new System.Drawing.Point(131, 7);
            this.lblDailyPrice.Name = "lblDailyPrice";
            this.lblDailyPrice.Size = new System.Drawing.Size(40, 13);
            this.lblDailyPrice.TabIndex = 46;
            this.lblDailyPrice.Text = "Diária";
            // 
            // PanelRight
            // 
            this.PanelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.PanelRight.Controls.Add(this.ctbDailyPriceCustom);
            this.PanelRight.Controls.Add(this.ctbTotalPriceCustom);
            this.PanelRight.Controls.Add(this.cbChild03To06);
            this.PanelRight.Controls.Add(this.lblChild03To06);
            this.PanelRight.Controls.Add(this.lblSingle);
            this.PanelRight.Controls.Add(this.lblChild07To10);
            this.PanelRight.Controls.Add(this.cbChild07To10);
            this.PanelRight.Controls.Add(this.cbSingleCustom);
            this.PanelRight.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelRight.Location = new System.Drawing.Point(646, 104);
            this.PanelRight.Name = "PanelRight";
            this.PanelRight.Size = new System.Drawing.Size(534, 654);
            this.PanelRight.TabIndex = 54;
            // 
            // cbChild03To06
            // 
            this.cbChild03To06.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbChild03To06.FormattingEnabled = true;
            this.cbChild03To06.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbChild03To06.Location = new System.Drawing.Point(196, 55);
            this.cbChild03To06.Name = "cbChild03To06";
            this.cbChild03To06.Size = new System.Drawing.Size(73, 21);
            this.cbChild03To06.TabIndex = 26;
            // 
            // lblChild03To06
            // 
            this.lblChild03To06.AutoSize = true;
            this.lblChild03To06.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChild03To06.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.lblChild03To06.Location = new System.Drawing.Point(172, 39);
            this.lblChild03To06.Name = "lblChild03To06";
            this.lblChild03To06.Size = new System.Drawing.Size(128, 13);
            this.lblChild03To06.TabIndex = 20;
            this.lblChild03To06.Text = "Criança 03 a 06 anos";
            // 
            // lblSingle
            // 
            this.lblSingle.AutoSize = true;
            this.lblSingle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSingle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.lblSingle.Location = new System.Drawing.Point(59, 39);
            this.lblSingle.Name = "lblSingle";
            this.lblSingle.Size = new System.Drawing.Size(50, 13);
            this.lblSingle.TabIndex = 47;
            this.lblSingle.Text = "Solteiro";
            this.lblSingle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChild07To10
            // 
            this.lblChild07To10.AutoSize = true;
            this.lblChild07To10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChild07To10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.lblChild07To10.Location = new System.Drawing.Point(329, 39);
            this.lblChild07To10.Name = "lblChild07To10";
            this.lblChild07To10.Size = new System.Drawing.Size(128, 13);
            this.lblChild07To10.TabIndex = 21;
            this.lblChild07To10.Text = "Criança 07 a 10 anos";
            // 
            // cbChild07To10
            // 
            this.cbChild07To10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbChild07To10.FormattingEnabled = true;
            this.cbChild07To10.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbChild07To10.Location = new System.Drawing.Point(353, 55);
            this.cbChild07To10.Name = "cbChild07To10";
            this.cbChild07To10.Size = new System.Drawing.Size(73, 21);
            this.cbChild07To10.TabIndex = 24;
            // 
            // cbSingleCustom
            // 
            this.cbSingleCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSingleCustom.FormattingEnabled = true;
            this.cbSingleCustom.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbSingleCustom.Location = new System.Drawing.Point(51, 55);
            this.cbSingleCustom.Name = "cbSingleCustom";
            this.cbSingleCustom.Size = new System.Drawing.Size(73, 21);
            this.cbSingleCustom.TabIndex = 25;
            // 
            // ctbDailyRateCouple
            // 
            this.ctbDailyRateCouple.BackColor = System.Drawing.Color.White;
            this.ctbDailyRateCouple.ChangeTextBoxSize = true;
            this.ctbDailyRateCouple.CustomText = "Casal";
            this.ctbDailyRateCouple.CustomTextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ctbDailyRateCouple.Location = new System.Drawing.Point(12, 55);
            this.ctbDailyRateCouple.Name = "ctbDailyRateCouple";
            this.ctbDailyRateCouple.Password = false;
            this.ctbDailyRateCouple.Size = new System.Drawing.Size(289, 49);
            this.ctbDailyRateCouple.TabIndex = 63;
            // 
            // ctbDailyRateLuxuryCouple
            // 
            this.ctbDailyRateLuxuryCouple.BackColor = System.Drawing.Color.White;
            this.ctbDailyRateLuxuryCouple.ChangeTextBoxSize = true;
            this.ctbDailyRateLuxuryCouple.CustomText = "Casal Luxo";
            this.ctbDailyRateLuxuryCouple.CustomTextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ctbDailyRateLuxuryCouple.Location = new System.Drawing.Point(12, 110);
            this.ctbDailyRateLuxuryCouple.Name = "ctbDailyRateLuxuryCouple";
            this.ctbDailyRateLuxuryCouple.Password = false;
            this.ctbDailyRateLuxuryCouple.Size = new System.Drawing.Size(289, 49);
            this.ctbDailyRateLuxuryCouple.TabIndex = 64;
            // 
            // ctbDailyRateQuadruple
            // 
            this.ctbDailyRateQuadruple.BackColor = System.Drawing.Color.White;
            this.ctbDailyRateQuadruple.ChangeTextBoxSize = true;
            this.ctbDailyRateQuadruple.CustomText = "Quadruplo";
            this.ctbDailyRateQuadruple.CustomTextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ctbDailyRateQuadruple.Location = new System.Drawing.Point(12, 275);
            this.ctbDailyRateQuadruple.Name = "ctbDailyRateQuadruple";
            this.ctbDailyRateQuadruple.Password = false;
            this.ctbDailyRateQuadruple.Size = new System.Drawing.Size(289, 49);
            this.ctbDailyRateQuadruple.TabIndex = 65;
            // 
            // ctbTotalValueQuadruple
            // 
            this.ctbTotalValueQuadruple.BackColor = System.Drawing.Color.White;
            this.ctbTotalValueQuadruple.ChangeTextBoxSize = false;
            this.ctbTotalValueQuadruple.CustomText = "";
            this.ctbTotalValueQuadruple.CustomTextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ctbTotalValueQuadruple.Location = new System.Drawing.Point(335, 275);
            this.ctbTotalValueQuadruple.Name = "ctbTotalValueQuadruple";
            this.ctbTotalValueQuadruple.Password = false;
            this.ctbTotalValueQuadruple.Size = new System.Drawing.Size(289, 49);
            this.ctbTotalValueQuadruple.TabIndex = 66;
            // 
            // ctbTotalValueQuintuple
            // 
            this.ctbTotalValueQuintuple.BackColor = System.Drawing.Color.White;
            this.ctbTotalValueQuintuple.ChangeTextBoxSize = false;
            this.ctbTotalValueQuintuple.CustomText = "";
            this.ctbTotalValueQuintuple.CustomTextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ctbTotalValueQuintuple.Location = new System.Drawing.Point(335, 330);
            this.ctbTotalValueQuintuple.Name = "ctbTotalValueQuintuple";
            this.ctbTotalValueQuintuple.Password = false;
            this.ctbTotalValueQuintuple.Size = new System.Drawing.Size(289, 49);
            this.ctbTotalValueQuintuple.TabIndex = 67;
            // 
            // ctbDailyRateQuintuple
            // 
            this.ctbDailyRateQuintuple.BackColor = System.Drawing.Color.White;
            this.ctbDailyRateQuintuple.ChangeTextBoxSize = true;
            this.ctbDailyRateQuintuple.CustomText = "Quintuplo";
            this.ctbDailyRateQuintuple.CustomTextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ctbDailyRateQuintuple.Location = new System.Drawing.Point(12, 330);
            this.ctbDailyRateQuintuple.Name = "ctbDailyRateQuintuple";
            this.ctbDailyRateQuintuple.Password = false;
            this.ctbDailyRateQuintuple.Size = new System.Drawing.Size(289, 49);
            this.ctbDailyRateQuintuple.TabIndex = 68;
            // 
            // ctbTotalValueTriple
            // 
            this.ctbTotalValueTriple.BackColor = System.Drawing.Color.White;
            this.ctbTotalValueTriple.ChangeTextBoxSize = false;
            this.ctbTotalValueTriple.CustomText = "";
            this.ctbTotalValueTriple.CustomTextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ctbTotalValueTriple.Location = new System.Drawing.Point(335, 220);
            this.ctbTotalValueTriple.Name = "ctbTotalValueTriple";
            this.ctbTotalValueTriple.Password = false;
            this.ctbTotalValueTriple.Size = new System.Drawing.Size(289, 49);
            this.ctbTotalValueTriple.TabIndex = 69;
            // 
            // ctbTotalValueSingle
            // 
            this.ctbTotalValueSingle.BackColor = System.Drawing.Color.White;
            this.ctbTotalValueSingle.ChangeTextBoxSize = false;
            this.ctbTotalValueSingle.CustomText = "";
            this.ctbTotalValueSingle.CustomTextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ctbTotalValueSingle.Location = new System.Drawing.Point(335, 165);
            this.ctbTotalValueSingle.Name = "ctbTotalValueSingle";
            this.ctbTotalValueSingle.Password = false;
            this.ctbTotalValueSingle.Size = new System.Drawing.Size(289, 49);
            this.ctbTotalValueSingle.TabIndex = 70;
            // 
            // ctbTotalValueLuxuryCouple
            // 
            this.ctbTotalValueLuxuryCouple.BackColor = System.Drawing.Color.White;
            this.ctbTotalValueLuxuryCouple.ChangeTextBoxSize = false;
            this.ctbTotalValueLuxuryCouple.CustomText = "";
            this.ctbTotalValueLuxuryCouple.CustomTextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ctbTotalValueLuxuryCouple.Location = new System.Drawing.Point(335, 110);
            this.ctbTotalValueLuxuryCouple.Name = "ctbTotalValueLuxuryCouple";
            this.ctbTotalValueLuxuryCouple.Password = false;
            this.ctbTotalValueLuxuryCouple.Size = new System.Drawing.Size(289, 49);
            this.ctbTotalValueLuxuryCouple.TabIndex = 71;
            // 
            // ctbTotalValueCouple
            // 
            this.ctbTotalValueCouple.BackColor = System.Drawing.Color.White;
            this.ctbTotalValueCouple.ChangeTextBoxSize = false;
            this.ctbTotalValueCouple.CustomText = "";
            this.ctbTotalValueCouple.CustomTextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ctbTotalValueCouple.Location = new System.Drawing.Point(335, 55);
            this.ctbTotalValueCouple.Name = "ctbTotalValueCouple";
            this.ctbTotalValueCouple.Password = false;
            this.ctbTotalValueCouple.Size = new System.Drawing.Size(289, 49);
            this.ctbTotalValueCouple.TabIndex = 72;
            // 
            // ctbDailyRateTriple
            // 
            this.ctbDailyRateTriple.BackColor = System.Drawing.Color.White;
            this.ctbDailyRateTriple.ChangeTextBoxSize = true;
            this.ctbDailyRateTriple.CustomText = "Triplo";
            this.ctbDailyRateTriple.CustomTextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ctbDailyRateTriple.Location = new System.Drawing.Point(12, 220);
            this.ctbDailyRateTriple.Name = "ctbDailyRateTriple";
            this.ctbDailyRateTriple.Password = false;
            this.ctbDailyRateTriple.Size = new System.Drawing.Size(289, 49);
            this.ctbDailyRateTriple.TabIndex = 73;
            // 
            // ctbDailyRateSingle
            // 
            this.ctbDailyRateSingle.BackColor = System.Drawing.Color.White;
            this.ctbDailyRateSingle.ChangeTextBoxSize = true;
            this.ctbDailyRateSingle.CustomText = "Solteiro";
            this.ctbDailyRateSingle.CustomTextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ctbDailyRateSingle.Location = new System.Drawing.Point(12, 165);
            this.ctbDailyRateSingle.Name = "ctbDailyRateSingle";
            this.ctbDailyRateSingle.Password = false;
            this.ctbDailyRateSingle.Size = new System.Drawing.Size(289, 49);
            this.ctbDailyRateSingle.TabIndex = 74;
            // 
            // ctbTotalPriceCustom
            // 
            this.ctbTotalPriceCustom.BackColor = System.Drawing.Color.White;
            this.ctbTotalPriceCustom.ChangeTextBoxSize = true;
            this.ctbTotalPriceCustom.CustomText = "Total";
            this.ctbTotalPriceCustom.CustomTextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ctbTotalPriceCustom.Location = new System.Drawing.Point(100, 190);
            this.ctbTotalPriceCustom.Name = "ctbTotalPriceCustom";
            this.ctbTotalPriceCustom.Password = false;
            this.ctbTotalPriceCustom.Size = new System.Drawing.Size(289, 49);
            this.ctbTotalPriceCustom.TabIndex = 64;
            // 
            // ctbDailyPriceCustom
            // 
            this.ctbDailyPriceCustom.BackColor = System.Drawing.Color.White;
            this.ctbDailyPriceCustom.ChangeTextBoxSize = true;
            this.ctbDailyPriceCustom.CustomText = "Diária";
            this.ctbDailyPriceCustom.CustomTextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ctbDailyPriceCustom.Location = new System.Drawing.Point(100, 124);
            this.ctbDailyPriceCustom.Name = "ctbDailyPriceCustom";
            this.ctbDailyPriceCustom.Password = false;
            this.ctbDailyPriceCustom.Size = new System.Drawing.Size(289, 49);
            this.ctbDailyPriceCustom.TabIndex = 65;
            // 
            // DailyCalculatorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1168, 758);
            this.Controls.Add(this.PanelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTopBlue);
            this.Controls.Add(this.panelTop);
            this.MinimumSize = new System.Drawing.Size(1184, 797);
            this.Name = "DailyCalculatorView";
            this.Text = "DailyCalculatorView";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.PanelRight.ResumeLayout(false);
            this.PanelRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnCalculatePrices;
        private System.Windows.Forms.Label lblNumberOfDays;
        private System.Windows.Forms.TextBox txtNumbOfDays;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txbDiscount;
        private System.Windows.Forms.Panel panelTopBlue;
        private System.Windows.Forms.Panel panelLeft;
        private CustomTextBox.CustomTextBoxView ctbDailyRateSingle;
        private CustomTextBox.CustomTextBoxView ctbDailyRateTriple;
        private CustomTextBox.CustomTextBoxView ctbTotalValueCouple;
        private CustomTextBox.CustomTextBoxView ctbTotalValueLuxuryCouple;
        private CustomTextBox.CustomTextBoxView ctbTotalValueSingle;
        private CustomTextBox.CustomTextBoxView ctbTotalValueTriple;
        private CustomTextBox.CustomTextBoxView ctbDailyRateQuintuple;
        private CustomTextBox.CustomTextBoxView ctbTotalValueQuintuple;
        private CustomTextBox.CustomTextBoxView ctbTotalValueQuadruple;
        private CustomTextBox.CustomTextBoxView ctbDailyRateQuadruple;
        private CustomTextBox.CustomTextBoxView ctbDailyRateLuxuryCouple;
        private CustomTextBox.CustomTextBoxView ctbDailyRateCouple;
        private FontAwesome.Sharp.IconButton ibtnShowEmail;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblDailyPrice;
        private System.Windows.Forms.Panel PanelRight;
        private CustomTextBox.CustomTextBoxView ctbDailyPriceCustom;
        private CustomTextBox.CustomTextBoxView ctbTotalPriceCustom;
        private System.Windows.Forms.ComboBox cbChild03To06;
        private System.Windows.Forms.Label lblChild03To06;
        private System.Windows.Forms.Label lblSingle;
        private System.Windows.Forms.Label lblChild07To10;
        private System.Windows.Forms.ComboBox cbChild07To10;
        private System.Windows.Forms.ComboBox cbSingleCustom;
    }
}