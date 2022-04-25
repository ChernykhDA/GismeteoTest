namespace GismeteoWinForms.Components
{
    partial class WeatherControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPanel = new System.Windows.Forms.Panel();
            this.PrecipitationPanel = new System.Windows.Forms.Panel();
            this.PrecipitationLabel = new System.Windows.Forms.Label();
            this.WindSpeedPanel = new System.Windows.Forms.Panel();
            this.WindSpeedLabel = new System.Windows.Forms.Label();
            this.MinTempPanel = new System.Windows.Forms.Panel();
            this.MinTemp = new System.Windows.Forms.Label();
            this.MaxTempPanel = new System.Windows.Forms.Panel();
            this.MaxTemp = new System.Windows.Forms.Label();
            this.DataPanel = new System.Windows.Forms.Panel();
            this.DataLabel = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.PrecipitationPanel.SuspendLayout();
            this.WindSpeedPanel.SuspendLayout();
            this.MinTempPanel.SuspendLayout();
            this.MaxTempPanel.SuspendLayout();
            this.DataPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.MainPanel.Controls.Add(this.PrecipitationPanel);
            this.MainPanel.Controls.Add(this.WindSpeedPanel);
            this.MainPanel.Controls.Add(this.MinTempPanel);
            this.MainPanel.Controls.Add(this.MaxTempPanel);
            this.MainPanel.Controls.Add(this.DataPanel);
            this.MainPanel.Location = new System.Drawing.Point(3, 3);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(85, 296);
            this.MainPanel.TabIndex = 5;
            // 
            // PrecipitationPanel
            // 
            this.PrecipitationPanel.Controls.Add(this.PrecipitationLabel);
            this.PrecipitationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PrecipitationPanel.Location = new System.Drawing.Point(0, 245);
            this.PrecipitationPanel.Name = "PrecipitationPanel";
            this.PrecipitationPanel.Size = new System.Drawing.Size(85, 50);
            this.PrecipitationPanel.TabIndex = 14;
            // 
            // PrecipitationLabel
            // 
            this.PrecipitationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrecipitationLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PrecipitationLabel.Location = new System.Drawing.Point(0, 0);
            this.PrecipitationLabel.Name = "PrecipitationLabel";
            this.PrecipitationLabel.Size = new System.Drawing.Size(85, 50);
            this.PrecipitationLabel.TabIndex = 9;
            this.PrecipitationLabel.Text = "- мм";
            this.PrecipitationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WindSpeedPanel
            // 
            this.WindSpeedPanel.Controls.Add(this.WindSpeedLabel);
            this.WindSpeedPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.WindSpeedPanel.Location = new System.Drawing.Point(0, 195);
            this.WindSpeedPanel.Name = "WindSpeedPanel";
            this.WindSpeedPanel.Size = new System.Drawing.Size(85, 50);
            this.WindSpeedPanel.TabIndex = 13;
            // 
            // WindSpeedLabel
            // 
            this.WindSpeedLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WindSpeedLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WindSpeedLabel.Location = new System.Drawing.Point(0, 0);
            this.WindSpeedLabel.Name = "WindSpeedLabel";
            this.WindSpeedLabel.Size = new System.Drawing.Size(85, 50);
            this.WindSpeedLabel.TabIndex = 8;
            this.WindSpeedLabel.Text = "- м/с";
            this.WindSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MinTempPanel
            // 
            this.MinTempPanel.Controls.Add(this.MinTemp);
            this.MinTempPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MinTempPanel.Location = new System.Drawing.Point(0, 110);
            this.MinTempPanel.Name = "MinTempPanel";
            this.MinTempPanel.Size = new System.Drawing.Size(85, 85);
            this.MinTempPanel.TabIndex = 12;
            // 
            // MinTemp
            // 
            this.MinTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinTemp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MinTemp.Location = new System.Drawing.Point(0, 0);
            this.MinTemp.Name = "MinTemp";
            this.MinTemp.Size = new System.Drawing.Size(85, 85);
            this.MinTemp.TabIndex = 6;
            this.MinTemp.Text = "-";
            this.MinTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MaxTempPanel
            // 
            this.MaxTempPanel.Controls.Add(this.MaxTemp);
            this.MaxTempPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MaxTempPanel.Location = new System.Drawing.Point(0, 25);
            this.MaxTempPanel.Name = "MaxTempPanel";
            this.MaxTempPanel.Size = new System.Drawing.Size(85, 85);
            this.MaxTempPanel.TabIndex = 11;
            // 
            // MaxTemp
            // 
            this.MaxTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaxTemp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MaxTemp.Location = new System.Drawing.Point(0, 0);
            this.MaxTemp.Name = "MaxTemp";
            this.MaxTemp.Size = new System.Drawing.Size(85, 85);
            this.MaxTemp.TabIndex = 5;
            this.MaxTemp.Text = "-";
            this.MaxTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataPanel
            // 
            this.DataPanel.Controls.Add(this.DataLabel);
            this.DataPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DataPanel.Location = new System.Drawing.Point(0, 0);
            this.DataPanel.Name = "DataPanel";
            this.DataPanel.Size = new System.Drawing.Size(85, 25);
            this.DataPanel.TabIndex = 10;
            // 
            // DataLabel
            // 
            this.DataLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataLabel.Location = new System.Drawing.Point(0, 0);
            this.DataLabel.Name = "DataLabel";
            this.DataLabel.Size = new System.Drawing.Size(85, 25);
            this.DataLabel.TabIndex = 7;
            this.DataLabel.Text = "Нет данных";
            this.DataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WeatherControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.MainPanel);
            this.MaximumSize = new System.Drawing.Size(91, 302);
            this.MinimumSize = new System.Drawing.Size(91, 302);
            this.Name = "WeatherControl";
            this.Size = new System.Drawing.Size(91, 302);
            this.MainPanel.ResumeLayout(false);
            this.PrecipitationPanel.ResumeLayout(false);
            this.WindSpeedPanel.ResumeLayout(false);
            this.MinTempPanel.ResumeLayout(false);
            this.MaxTempPanel.ResumeLayout(false);
            this.DataPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label PrecipitationLabel;
        private System.Windows.Forms.Label WindSpeedLabel;
        private System.Windows.Forms.Label DataLabel;
        private System.Windows.Forms.Label MinTemp;
        private System.Windows.Forms.Label MaxTemp;
        private System.Windows.Forms.Panel DataPanel;
        private System.Windows.Forms.Panel MinTempPanel;
        private System.Windows.Forms.Panel MaxTempPanel;
        private System.Windows.Forms.Panel PrecipitationPanel;
        private System.Windows.Forms.Panel WindSpeedPanel;
    }
}
