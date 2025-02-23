
namespace BenTechPatternMVP.View.Calendar
{
    partial class CalendarView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalendarView));
            this.calendarPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panelCalendarMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pbtnNextMonth = new System.Windows.Forms.PictureBox();
            this.pbtnPreviousMonth = new System.Windows.Forms.PictureBox();
            this.dateTimePickerCalendar = new System.Windows.Forms.DateTimePicker();
            this.panelPredefinedPrices = new System.Windows.Forms.Panel();
            this.fpanelPredefinedPricesInner = new System.Windows.Forms.FlowLayoutPanel();
            this.ibtnCreateNewPredefinedValues = new FontAwesome.Sharp.IconButton();
            this.panelCalendarMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbtnNextMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtnPreviousMonth)).BeginInit();
            this.panelPredefinedPrices.SuspendLayout();
            this.SuspendLayout();
            // 
            // calendarPanel
            // 
            this.calendarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.calendarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendarPanel.Location = new System.Drawing.Point(0, 100);
            this.calendarPanel.MaximumSize = new System.Drawing.Size(968, 665);
            this.calendarPanel.MinimumSize = new System.Drawing.Size(968, 665);
            this.calendarPanel.Name = "calendarPanel";
            this.calendarPanel.Size = new System.Drawing.Size(968, 665);
            this.calendarPanel.TabIndex = 6;
            // 
            // panelCalendarMenu
            // 
            this.panelCalendarMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelCalendarMenu.Controls.Add(this.label1);
            this.panelCalendarMenu.Controls.Add(this.label16);
            this.panelCalendarMenu.Controls.Add(this.label11);
            this.panelCalendarMenu.Controls.Add(this.label15);
            this.panelCalendarMenu.Controls.Add(this.label12);
            this.panelCalendarMenu.Controls.Add(this.label14);
            this.panelCalendarMenu.Controls.Add(this.label13);
            this.panelCalendarMenu.Controls.Add(this.pbtnNextMonth);
            this.panelCalendarMenu.Controls.Add(this.pbtnPreviousMonth);
            this.panelCalendarMenu.Controls.Add(this.dateTimePickerCalendar);
            this.panelCalendarMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCalendarMenu.Location = new System.Drawing.Point(0, 0);
            this.panelCalendarMenu.Name = "panelCalendarMenu";
            this.panelCalendarMenu.Size = new System.Drawing.Size(968, 100);
            this.panelCalendarMenu.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.label1.Location = new System.Drawing.Point(41, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "sunday";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.label16.Location = new System.Drawing.Point(864, 84);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "Saturday";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.label11.Location = new System.Drawing.Point(179, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Monday";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.label15.Location = new System.Drawing.Point(727, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "Friday";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.label12.Location = new System.Drawing.Point(317, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Tuesday";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.label14.Location = new System.Drawing.Point(589, 84);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Thursday";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.label13.Location = new System.Drawing.Point(450, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Wednesday";
            // 
            // pbtnNextMonth
            // 
            this.pbtnNextMonth.Image = ((System.Drawing.Image)(resources.GetObject("pbtnNextMonth.Image")));
            this.pbtnNextMonth.Location = new System.Drawing.Point(594, 10);
            this.pbtnNextMonth.Name = "pbtnNextMonth";
            this.pbtnNextMonth.Size = new System.Drawing.Size(55, 49);
            this.pbtnNextMonth.TabIndex = 11;
            this.pbtnNextMonth.TabStop = false;
            this.pbtnNextMonth.Click += new System.EventHandler(this.pbtnNextMonth_Click);
            // 
            // pbtnPreviousMonth
            // 
            this.pbtnPreviousMonth.Image = ((System.Drawing.Image)(resources.GetObject("pbtnPreviousMonth.Image")));
            this.pbtnPreviousMonth.Location = new System.Drawing.Point(322, 10);
            this.pbtnPreviousMonth.Name = "pbtnPreviousMonth";
            this.pbtnPreviousMonth.Size = new System.Drawing.Size(55, 49);
            this.pbtnPreviousMonth.TabIndex = 9;
            this.pbtnPreviousMonth.TabStop = false;
            this.pbtnPreviousMonth.Click += new System.EventHandler(this.pbtnPreviousMonth_Click);
            // 
            // dateTimePickerCalendar
            // 
            this.dateTimePickerCalendar.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerCalendar.CustomFormat = "";
            this.dateTimePickerCalendar.Location = new System.Drawing.Point(380, 25);
            this.dateTimePickerCalendar.Name = "dateTimePickerCalendar";
            this.dateTimePickerCalendar.Size = new System.Drawing.Size(208, 20);
            this.dateTimePickerCalendar.TabIndex = 10;
            this.dateTimePickerCalendar.CloseUp += new System.EventHandler(this.dateTimePickerCalendar_CloseUp);
            this.dateTimePickerCalendar.ValueChanged += new System.EventHandler(this.dateTimePickerCalendar_ValueChanged);
            // 
            // panelPredefinedPrices
            // 
            this.panelPredefinedPrices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelPredefinedPrices.Controls.Add(this.fpanelPredefinedPricesInner);
            this.panelPredefinedPrices.Controls.Add(this.ibtnCreateNewPredefinedValues);
            this.panelPredefinedPrices.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelPredefinedPrices.Location = new System.Drawing.Point(968, 0);
            this.panelPredefinedPrices.Margin = new System.Windows.Forms.Padding(0);
            this.panelPredefinedPrices.Name = "panelPredefinedPrices";
            this.panelPredefinedPrices.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panelPredefinedPrices.Size = new System.Drawing.Size(200, 765);
            this.panelPredefinedPrices.TabIndex = 4;
            // 
            // fpanelPredefinedPricesInner
            // 
            this.fpanelPredefinedPricesInner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.fpanelPredefinedPricesInner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpanelPredefinedPricesInner.Location = new System.Drawing.Point(0, 50);
            this.fpanelPredefinedPricesInner.Name = "fpanelPredefinedPricesInner";
            this.fpanelPredefinedPricesInner.Size = new System.Drawing.Size(200, 715);
            this.fpanelPredefinedPricesInner.TabIndex = 1;
            // 
            // ibtnCreateNewPredefinedValues
            // 
            this.ibtnCreateNewPredefinedValues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(178)))), ((int)(((byte)(237)))));
            this.ibtnCreateNewPredefinedValues.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnCreateNewPredefinedValues.FlatAppearance.BorderSize = 0;
            this.ibtnCreateNewPredefinedValues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnCreateNewPredefinedValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnCreateNewPredefinedValues.ForeColor = System.Drawing.Color.White;
            this.ibtnCreateNewPredefinedValues.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnCreateNewPredefinedValues.IconColor = System.Drawing.Color.Black;
            this.ibtnCreateNewPredefinedValues.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnCreateNewPredefinedValues.Location = new System.Drawing.Point(0, 5);
            this.ibtnCreateNewPredefinedValues.Name = "ibtnCreateNewPredefinedValues";
            this.ibtnCreateNewPredefinedValues.Size = new System.Drawing.Size(200, 45);
            this.ibtnCreateNewPredefinedValues.TabIndex = 0;
            this.ibtnCreateNewPredefinedValues.Text = "Add predefined values";
            this.ibtnCreateNewPredefinedValues.UseVisualStyleBackColor = false;
            // 
            // CalendarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 765);
            this.Controls.Add(this.calendarPanel);
            this.Controls.Add(this.panelCalendarMenu);
            this.Controls.Add(this.panelPredefinedPrices);
            this.MinimumSize = new System.Drawing.Size(1184, 804);
            this.Name = "CalendarView";
            this.Text = "CalendarView";
            this.panelCalendarMenu.ResumeLayout(false);
            this.panelCalendarMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbtnNextMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtnPreviousMonth)).EndInit();
            this.panelPredefinedPrices.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel calendarPanel;
        private System.Windows.Forms.Panel panelCalendarMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pbtnNextMonth;
        private System.Windows.Forms.PictureBox pbtnPreviousMonth;
        private System.Windows.Forms.DateTimePicker dateTimePickerCalendar;
        private System.Windows.Forms.Panel panelPredefinedPrices;
        private System.Windows.Forms.FlowLayoutPanel fpanelPredefinedPricesInner;
        private FontAwesome.Sharp.IconButton ibtnCreateNewPredefinedValues;
    }
}