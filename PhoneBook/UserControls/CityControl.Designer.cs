namespace PhoneBook.UserControls
{
    partial class CityControl
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
            this.lblCity = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoCompleteControlCity = new PhoneBook.UserControls.AutoCompleteControl();
            this.SuspendLayout();
            // 
            // lblCity
            // 
            this.lblCity.DX = -65;
            this.lblCity.DY = 3;
            this.lblCity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCity.ForeColor = System.Drawing.Color.White;
            this.lblCity.LabeledControl = this.autoCompleteControlCity;
            this.lblCity.Location = new System.Drawing.Point(3, 3);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(61, 19);
            this.lblCity.TabIndex = 3;
            this.lblCity.Text = "Город:";
            // 
            // autoCompleteControlCity
            // 
            this.autoCompleteControlCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.autoCompleteControlCity.AutoSize = true;
            this.autoCompleteControlCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.autoCompleteControlCity.Location = new System.Drawing.Point(68, 0);
            this.autoCompleteControlCity.MinimumSize = new System.Drawing.Size(150, 26);
            this.autoCompleteControlCity.Name = "autoCompleteControlCity";
            this.autoCompleteControlCity.Size = new System.Drawing.Size(210, 26);
            this.autoCompleteControlCity.TabIndex = 2;
            this.autoCompleteControlCity.TextBoxFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            // 
            // CityControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.autoCompleteControlCity);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.Name = "CityControl";
            this.Size = new System.Drawing.Size(281, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.AutoLabel lblCity;
        private AutoCompleteControl autoCompleteControlCity;
    }
}
