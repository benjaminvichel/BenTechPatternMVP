﻿
namespace BenTechPatternMVP.View.Day
{
    partial class DayView
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelDisplayColorCode = new System.Windows.Forms.Panel();
            this.lblDays = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelDisplayColorCode
            // 
            this.panelDisplayColorCode.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDisplayColorCode.Location = new System.Drawing.Point(108, 0);
            this.panelDisplayColorCode.Name = "panelDisplayColorCode";
            this.panelDisplayColorCode.Size = new System.Drawing.Size(20, 108);
            this.panelDisplayColorCode.TabIndex = 12;
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDays.Location = new System.Drawing.Point(3, 7);
            this.lblDays.Margin = new System.Windows.Forms.Padding(0);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(21, 13);
            this.lblDays.TabIndex = 11;
            this.lblDays.Text = "00";
            // 
            // DayView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.panelDisplayColorCode);
            this.Controls.Add(this.lblDays);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(132, 112);
            this.MinimumSize = new System.Drawing.Size(132, 112);
            this.Name = "DayView";
            this.Size = new System.Drawing.Size(128, 108);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDisplayColorCode;
        private System.Windows.Forms.Label lblDays;
    }
}
