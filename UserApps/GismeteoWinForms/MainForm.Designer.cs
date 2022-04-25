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
            this.weatherControl20 = new GismeteoWinForms.Components.WeatherControl();
            this.weatherControl19 = new GismeteoWinForms.Components.WeatherControl();
            this.weatherControl18 = new GismeteoWinForms.Components.WeatherControl();
            this.weatherControl17 = new GismeteoWinForms.Components.WeatherControl();
            this.weatherControl16 = new GismeteoWinForms.Components.WeatherControl();
            this.weatherControl15 = new GismeteoWinForms.Components.WeatherControl();
            this.weatherControl14 = new GismeteoWinForms.Components.WeatherControl();
            this.weatherControl13 = new GismeteoWinForms.Components.WeatherControl();
            this.weatherControl12 = new GismeteoWinForms.Components.WeatherControl();
            this.weatherControl11 = new GismeteoWinForms.Components.WeatherControl();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextUpdateTimeLabel
            // 
            this.TextUpdateTimeLabel.AutoSize = true;
            this.TextUpdateTimeLabel.Location = new System.Drawing.Point(39, 11);
            this.TextUpdateTimeLabel.Name = "TextUpdateTimeLabel";
            this.TextUpdateTimeLabel.Size = new System.Drawing.Size(184, 15);
            this.TextUpdateTimeLabel.TabIndex = 1;
            this.TextUpdateTimeLabel.Text = "Последнее обновление погоды:";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(5, 5);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(28, 27);
            this.updateButton.TabIndex = 2;
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // UpdateTime
            // 
            this.UpdateTime.AutoSize = true;
            this.UpdateTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpdateTime.Location = new System.Drawing.Point(225, 7);
            this.UpdateTime.Name = "UpdateTime";
            this.UpdateTime.Size = new System.Drawing.Size(195, 21);
            this.UpdateTime.TabIndex = 3;
            this.UpdateTime.Text = "24 апреля 2022 г. 13 : 03";
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
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.weatherControl20);
            this.panel1.Controls.Add(this.weatherControl19);
            this.panel1.Controls.Add(this.weatherControl18);
            this.panel1.Controls.Add(this.weatherControl17);
            this.panel1.Controls.Add(this.weatherControl16);
            this.panel1.Controls.Add(this.weatherControl15);
            this.panel1.Controls.Add(this.weatherControl14);
            this.panel1.Controls.Add(this.weatherControl13);
            this.panel1.Controls.Add(this.weatherControl12);
            this.panel1.Controls.Add(this.weatherControl11);
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
            // weatherControl20
            // 
            this.weatherControl20.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.weatherControl20.Day = new System.DateTime(((long)(0)));
            this.weatherControl20.Location = new System.Drawing.Point(992, 6);
            this.weatherControl20.MaximumSize = new System.Drawing.Size(91, 302);
            this.weatherControl20.MaxTemperature = null;
            this.weatherControl20.MinimumSize = new System.Drawing.Size(91, 302);
            this.weatherControl20.MinTemperature = null;
            this.weatherControl20.Name = "weatherControl20";
            this.weatherControl20.Precipitation = null;
            this.weatherControl20.Size = new System.Drawing.Size(91, 302);
            this.weatherControl20.TabIndex = 9;
            this.weatherControl20.WindSpeed = null;
            // 
            // weatherControl19
            // 
            this.weatherControl19.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.weatherControl19.Day = new System.DateTime(((long)(0)));
            this.weatherControl19.Location = new System.Drawing.Point(895, 6);
            this.weatherControl19.MaximumSize = new System.Drawing.Size(91, 302);
            this.weatherControl19.MaxTemperature = null;
            this.weatherControl19.MinimumSize = new System.Drawing.Size(91, 302);
            this.weatherControl19.MinTemperature = null;
            this.weatherControl19.Name = "weatherControl19";
            this.weatherControl19.Precipitation = null;
            this.weatherControl19.Size = new System.Drawing.Size(91, 302);
            this.weatherControl19.TabIndex = 8;
            this.weatherControl19.WindSpeed = null;
            // 
            // weatherControl18
            // 
            this.weatherControl18.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.weatherControl18.Day = new System.DateTime(((long)(0)));
            this.weatherControl18.Location = new System.Drawing.Point(798, 6);
            this.weatherControl18.MaximumSize = new System.Drawing.Size(91, 302);
            this.weatherControl18.MaxTemperature = null;
            this.weatherControl18.MinimumSize = new System.Drawing.Size(91, 302);
            this.weatherControl18.MinTemperature = null;
            this.weatherControl18.Name = "weatherControl18";
            this.weatherControl18.Precipitation = null;
            this.weatherControl18.Size = new System.Drawing.Size(91, 302);
            this.weatherControl18.TabIndex = 7;
            this.weatherControl18.WindSpeed = null;
            // 
            // weatherControl17
            // 
            this.weatherControl17.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.weatherControl17.Day = new System.DateTime(((long)(0)));
            this.weatherControl17.Location = new System.Drawing.Point(701, 6);
            this.weatherControl17.MaximumSize = new System.Drawing.Size(91, 302);
            this.weatherControl17.MaxTemperature = null;
            this.weatherControl17.MinimumSize = new System.Drawing.Size(91, 302);
            this.weatherControl17.MinTemperature = null;
            this.weatherControl17.Name = "weatherControl17";
            this.weatherControl17.Precipitation = null;
            this.weatherControl17.Size = new System.Drawing.Size(91, 302);
            this.weatherControl17.TabIndex = 6;
            this.weatherControl17.WindSpeed = null;
            // 
            // weatherControl16
            // 
            this.weatherControl16.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.weatherControl16.Day = new System.DateTime(((long)(0)));
            this.weatherControl16.Location = new System.Drawing.Point(604, 6);
            this.weatherControl16.MaximumSize = new System.Drawing.Size(91, 302);
            this.weatherControl16.MaxTemperature = null;
            this.weatherControl16.MinimumSize = new System.Drawing.Size(91, 302);
            this.weatherControl16.MinTemperature = null;
            this.weatherControl16.Name = "weatherControl16";
            this.weatherControl16.Precipitation = null;
            this.weatherControl16.Size = new System.Drawing.Size(91, 302);
            this.weatherControl16.TabIndex = 5;
            this.weatherControl16.WindSpeed = null;
            // 
            // weatherControl15
            // 
            this.weatherControl15.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.weatherControl15.Day = new System.DateTime(((long)(0)));
            this.weatherControl15.Location = new System.Drawing.Point(507, 6);
            this.weatherControl15.MaximumSize = new System.Drawing.Size(91, 302);
            this.weatherControl15.MaxTemperature = null;
            this.weatherControl15.MinimumSize = new System.Drawing.Size(91, 302);
            this.weatherControl15.MinTemperature = null;
            this.weatherControl15.Name = "weatherControl15";
            this.weatherControl15.Precipitation = null;
            this.weatherControl15.Size = new System.Drawing.Size(91, 302);
            this.weatherControl15.TabIndex = 4;
            this.weatherControl15.WindSpeed = null;
            // 
            // weatherControl14
            // 
            this.weatherControl14.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.weatherControl14.Day = new System.DateTime(((long)(0)));
            this.weatherControl14.Location = new System.Drawing.Point(410, 6);
            this.weatherControl14.MaximumSize = new System.Drawing.Size(91, 302);
            this.weatherControl14.MaxTemperature = null;
            this.weatherControl14.MinimumSize = new System.Drawing.Size(91, 302);
            this.weatherControl14.MinTemperature = null;
            this.weatherControl14.Name = "weatherControl14";
            this.weatherControl14.Precipitation = null;
            this.weatherControl14.Size = new System.Drawing.Size(91, 302);
            this.weatherControl14.TabIndex = 3;
            this.weatherControl14.WindSpeed = null;
            // 
            // weatherControl13
            // 
            this.weatherControl13.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.weatherControl13.Day = new System.DateTime(((long)(0)));
            this.weatherControl13.Location = new System.Drawing.Point(313, 6);
            this.weatherControl13.MaximumSize = new System.Drawing.Size(91, 302);
            this.weatherControl13.MaxTemperature = null;
            this.weatherControl13.MinimumSize = new System.Drawing.Size(91, 302);
            this.weatherControl13.MinTemperature = null;
            this.weatherControl13.Name = "weatherControl13";
            this.weatherControl13.Precipitation = null;
            this.weatherControl13.Size = new System.Drawing.Size(91, 302);
            this.weatherControl13.TabIndex = 2;
            this.weatherControl13.WindSpeed = null;
            // 
            // weatherControl12
            // 
            this.weatherControl12.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.weatherControl12.Day = new System.DateTime(((long)(0)));
            this.weatherControl12.Location = new System.Drawing.Point(216, 6);
            this.weatherControl12.MaximumSize = new System.Drawing.Size(91, 302);
            this.weatherControl12.MaxTemperature = null;
            this.weatherControl12.MinimumSize = new System.Drawing.Size(91, 302);
            this.weatherControl12.MinTemperature = null;
            this.weatherControl12.Name = "weatherControl12";
            this.weatherControl12.Precipitation = null;
            this.weatherControl12.Size = new System.Drawing.Size(91, 302);
            this.weatherControl12.TabIndex = 1;
            this.weatherControl12.Tag = "";
            this.weatherControl12.WindSpeed = null;
            // 
            // weatherControl11
            // 
            this.weatherControl11.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.weatherControl11.Day = new System.DateTime(2021, 4, 14, 0, 0, 0, 0);
            this.weatherControl11.Location = new System.Drawing.Point(119, 6);
            this.weatherControl11.MaximumSize = new System.Drawing.Size(91, 302);
            this.weatherControl11.MaxTemperature = 11D;
            this.weatherControl11.MinimumSize = new System.Drawing.Size(91, 302);
            this.weatherControl11.MinTemperature = null;
            this.weatherControl11.Name = "weatherControl11";
            this.weatherControl11.Precipitation = null;
            this.weatherControl11.Size = new System.Drawing.Size(91, 302);
            this.weatherControl11.TabIndex = 0;
            this.weatherControl11.WindSpeed = null;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 351);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
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
        private Components.WeatherControl weatherControl20;
        private Components.WeatherControl weatherControl19;
        private Components.WeatherControl weatherControl18;
        private Components.WeatherControl weatherControl17;
        private Components.WeatherControl weatherControl16;
        private Components.WeatherControl weatherControl15;
        private Components.WeatherControl weatherControl14;
        private Components.WeatherControl weatherControl13;
        private Components.WeatherControl weatherControl12;
        private Components.WeatherControl weatherControl11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cityBox;
    }
}
