namespace GismeteoWinForms
{
    partial class MainForm
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
            this.TextUpdateTimeLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.UpdateTime = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.cityBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.weatherControl10 = new GismeteoWinForms.Components.WeatherControl();
            this.weatherControl9 = new GismeteoWinForms.Components.WeatherControl();
            this.weatherControl8 = new GismeteoWinForms.Components.WeatherControl();
            this.weatherControl7 = new GismeteoWinForms.Components.WeatherControl();
            this.weatherControl6 = new GismeteoWinForms.Components.WeatherControl();
            this.weatherControl5 = new GismeteoWinForms.Components.WeatherControl();
            this.weatherControl4 = new GismeteoWinForms.Components.WeatherControl();
            this.weatherControl3 = new GismeteoWinForms.Components.WeatherControl();
            this.weatherControl2 = new GismeteoWinForms.Components.WeatherControl();
            this.weatherControl1 = new GismeteoWinForms.Components.WeatherControl();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextUpdateTimeLabel
            // 
            this.TextUpdateTimeLabel.AutoSize = true;
            this.TextUpdateTimeLabel.Location = new System.Drawing.Point(86, 13);
            this.TextUpdateTimeLabel.Name = "TextUpdateTimeLabel";
            this.TextUpdateTimeLabel.Size = new System.Drawing.Size(184, 15);
            this.TextUpdateTimeLabel.TabIndex = 1;
            this.TextUpdateTimeLabel.Text = "Последнее обновление погоды:";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(5, 5);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(76, 27);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Обновить";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // UpdateTime
            // 
            this.UpdateTime.AutoSize = true;
            this.UpdateTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpdateTime.Location = new System.Drawing.Point(272, 9);
            this.UpdateTime.Name = "UpdateTime";
            this.UpdateTime.Size = new System.Drawing.Size(16, 21);
            this.UpdateTime.TabIndex = 3;
            this.UpdateTime.Text = "-";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cityBox);
            this.panel2.Controls.Add(this.UpdateTime);
            this.panel2.Controls.Add(this.TextUpdateTimeLabel);
            this.panel2.Controls.Add(this.updateButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1089, 38);
            this.panel2.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(749, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Город:";
            // 
            // cityBox
            // 
            this.cityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cityBox.FormattingEnabled = true;
            this.cityBox.Location = new System.Drawing.Point(798, 7);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(285, 23);
            this.cityBox.TabIndex = 4;
            this.cityBox.SelectedIndexChanged += new System.EventHandler(this.cityBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.weatherControl10);
            this.panel1.Controls.Add(this.weatherControl9);
            this.panel1.Controls.Add(this.weatherControl8);
            this.panel1.Controls.Add(this.weatherControl7);
            this.panel1.Controls.Add(this.weatherControl6);
            this.panel1.Controls.Add(this.weatherControl5);
            this.panel1.Controls.Add(this.weatherControl4);
            this.panel1.Controls.Add(this.weatherControl3);
            this.panel1.Controls.Add(this.weatherControl2);
            this.panel1.Controls.Add(this.weatherControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1089, 313);
            this.panel1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(5, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 27);
            this.label5.TabIndex = 12;
            this.label5.Text = "Осадки:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(5, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 48);
            this.label4.TabIndex = 11;
            this.label4.Text = "Скорость ветра";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(5, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 48);
            this.label3.TabIndex = 10;
            this.label3.Text = "Минимум температуры";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 48);
            this.label2.TabIndex = 7;
            this.label2.Text = "Максимум температуры";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "День:";
            // 
            // weatherControl10
            // 
            this.weatherControl10.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.weatherControl10.Day = null;
            this.weatherControl10.Location = new System.Drawing.Point(992, 6);
            this.weatherControl10.MaximumSize = new System.Drawing.Size(91, 302);
            this.weatherControl10.MaxTemperature = null;
            this.weatherControl10.MinimumSize = new System.Drawing.Size(91, 302);
            this.weatherControl10.MinTemperature = null;
            this.weatherControl10.Name = "weatherControl10";
            this.weatherControl10.Precipitation = null;
            this.weatherControl10.Size = new System.Drawing.Size(91, 302);
            this.weatherControl10.TabIndex = 9;
            this.weatherControl10.WindSpeed = null;
            // 
            // weatherControl9
            // 
            this.weatherControl9.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.weatherControl9.Day = null;
            this.weatherControl9.Location = new System.Drawing.Point(895, 6);
            this.weatherControl9.MaximumSize = new System.Drawing.Size(91, 302);
            this.weatherControl9.MaxTemperature = null;
            this.weatherControl9.MinimumSize = new System.Drawing.Size(91, 302);
            this.weatherControl9.MinTemperature = null;
            this.weatherControl9.Name = "weatherControl9";
            this.weatherControl9.Precipitation = null;
            this.weatherControl9.Size = new System.Drawing.Size(91, 302);
            this.weatherControl9.TabIndex = 8;
            this.weatherControl9.WindSpeed = null;
            // 
            // weatherControl8
            // 
            this.weatherControl8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.weatherControl8.Day = null;
            this.weatherControl8.Location = new System.Drawing.Point(798, 6);
            this.weatherControl8.MaximumSize = new System.Drawing.Size(91, 302);
            this.weatherControl8.MaxTemperature = null;
            this.weatherControl8.MinimumSize = new System.Drawing.Size(91, 302);
            this.weatherControl8.MinTemperature = null;
            this.weatherControl8.Name = "weatherControl8";
            this.weatherControl8.Precipitation = null;
            this.weatherControl8.Size = new System.Drawing.Size(91, 302);
            this.weatherControl8.TabIndex = 7;
            this.weatherControl8.WindSpeed = null;
            // 
            // weatherControl7
            // 
            this.weatherControl7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.weatherControl7.Day = null;
            this.weatherControl7.Location = new System.Drawing.Point(701, 6);
            this.weatherControl7.MaximumSize = new System.Drawing.Size(91, 302);
            this.weatherControl7.MaxTemperature = null;
            this.weatherControl7.MinimumSize = new System.Drawing.Size(91, 302);
            this.weatherControl7.MinTemperature = null;
            this.weatherControl7.Name = "weatherControl7";
            this.weatherControl7.Precipitation = null;
            this.weatherControl7.Size = new System.Drawing.Size(91, 302);
            this.weatherControl7.TabIndex = 6;
            this.weatherControl7.WindSpeed = null;
            // 
            // weatherControl6
            // 
            this.weatherControl6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.weatherControl6.Day = null;
            this.weatherControl6.Location = new System.Drawing.Point(604, 6);
            this.weatherControl6.MaximumSize = new System.Drawing.Size(91, 302);
            this.weatherControl6.MaxTemperature = null;
            this.weatherControl6.MinimumSize = new System.Drawing.Size(91, 302);
            this.weatherControl6.MinTemperature = null;
            this.weatherControl6.Name = "weatherControl6";
            this.weatherControl6.Precipitation = null;
            this.weatherControl6.Size = new System.Drawing.Size(91, 302);
            this.weatherControl6.TabIndex = 5;
            this.weatherControl6.WindSpeed = null;
            // 
            // weatherControl5
            // 
            this.weatherControl5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.weatherControl5.Day = null;
            this.weatherControl5.Location = new System.Drawing.Point(507, 6);
            this.weatherControl5.MaximumSize = new System.Drawing.Size(91, 302);
            this.weatherControl5.MaxTemperature = null;
            this.weatherControl5.MinimumSize = new System.Drawing.Size(91, 302);
            this.weatherControl5.MinTemperature = null;
            this.weatherControl5.Name = "weatherControl5";
            this.weatherControl5.Precipitation = null;
            this.weatherControl5.Size = new System.Drawing.Size(91, 302);
            this.weatherControl5.TabIndex = 4;
            this.weatherControl5.WindSpeed = null;
            // 
            // weatherControl4
            // 
            this.weatherControl4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.weatherControl4.Day = null;
            this.weatherControl4.Location = new System.Drawing.Point(410, 6);
            this.weatherControl4.MaximumSize = new System.Drawing.Size(91, 302);
            this.weatherControl4.MaxTemperature = null;
            this.weatherControl4.MinimumSize = new System.Drawing.Size(91, 302);
            this.weatherControl4.MinTemperature = null;
            this.weatherControl4.Name = "weatherControl4";
            this.weatherControl4.Precipitation = null;
            this.weatherControl4.Size = new System.Drawing.Size(91, 302);
            this.weatherControl4.TabIndex = 3;
            this.weatherControl4.WindSpeed = null;
            // 
            // weatherControl3
            // 
            this.weatherControl3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.weatherControl3.Day = null;
            this.weatherControl3.Location = new System.Drawing.Point(313, 6);
            this.weatherControl3.MaximumSize = new System.Drawing.Size(91, 302);
            this.weatherControl3.MaxTemperature = null;
            this.weatherControl3.MinimumSize = new System.Drawing.Size(91, 302);
            this.weatherControl3.MinTemperature = null;
            this.weatherControl3.Name = "weatherControl3";
            this.weatherControl3.Precipitation = null;
            this.weatherControl3.Size = new System.Drawing.Size(91, 302);
            this.weatherControl3.TabIndex = 2;
            this.weatherControl3.WindSpeed = null;
            // 
            // weatherControl2
            // 
            this.weatherControl2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.weatherControl2.Day = null;
            this.weatherControl2.Location = new System.Drawing.Point(216, 6);
            this.weatherControl2.MaximumSize = new System.Drawing.Size(91, 302);
            this.weatherControl2.MaxTemperature = null;
            this.weatherControl2.MinimumSize = new System.Drawing.Size(91, 302);
            this.weatherControl2.MinTemperature = null;
            this.weatherControl2.Name = "weatherControl2";
            this.weatherControl2.Precipitation = null;
            this.weatherControl2.Size = new System.Drawing.Size(91, 302);
            this.weatherControl2.TabIndex = 1;
            this.weatherControl2.Tag = "";
            this.weatherControl2.WindSpeed = null;
            // 
            // weatherControl1
            // 
            this.weatherControl1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.weatherControl1.Day = null;
            this.weatherControl1.Location = new System.Drawing.Point(119, 6);
            this.weatherControl1.MaximumSize = new System.Drawing.Size(91, 302);
            this.weatherControl1.MaxTemperature = null;
            this.weatherControl1.MinimumSize = new System.Drawing.Size(91, 302);
            this.weatherControl1.MinTemperature = null;
            this.weatherControl1.Name = "weatherControl1";
            this.weatherControl1.Precipitation = null;
            this.weatherControl1.Size = new System.Drawing.Size(91, 302);
            this.weatherControl1.TabIndex = 0;
            this.weatherControl1.WindSpeed = null;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 351);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MaximumSize = new System.Drawing.Size(1105, 390);
            this.MinimumSize = new System.Drawing.Size(1105, 390);
            this.Name = "MainForm";
            this.Text = "Погода";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label TextUpdateTimeLabel;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label UpdateTime;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Components.WeatherControl weatherControl10;
        private Components.WeatherControl weatherControl9;
        private Components.WeatherControl weatherControl8;
        private Components.WeatherControl weatherControl7;
        private Components.WeatherControl weatherControl6;
        private Components.WeatherControl weatherControl5;
        private Components.WeatherControl weatherControl4;
        private Components.WeatherControl weatherControl3;
        private Components.WeatherControl weatherControl2;
        private Components.WeatherControl weatherControl1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cityBox;
    }
}
