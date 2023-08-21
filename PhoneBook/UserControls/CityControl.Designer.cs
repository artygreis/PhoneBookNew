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
            lblCity = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoCompleteControlCity = new AutoCompleteControl();
            SuspendLayout();
            // 
            // lblCity
            // 
            lblCity.DX = -65;
            lblCity.DY = 3;
            lblCity.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCity.ForeColor = Color.White;
            lblCity.LabeledControl = autoCompleteControlCity;
            lblCity.Location = new Point(3, 3);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(61, 19);
            lblCity.TabIndex = 3;
            lblCity.Text = "Город:";
            // 
            // autoCompleteControlCity
            // 
            autoCompleteControlCity.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            autoCompleteControlCity.AutoSize = true;
            autoCompleteControlCity.BackColor = Color.FromArgb(0, 71, 160);
            autoCompleteControlCity.Location = new Point(68, 0);
            autoCompleteControlCity.Margin = new Padding(3, 2, 3, 2);
            autoCompleteControlCity.MinimumSize = new Size(150, 26);
            autoCompleteControlCity.Name = "autoCompleteControlCity";
            autoCompleteControlCity.Size = new Size(210, 26);
            autoCompleteControlCity.TabIndex = 2;
            autoCompleteControlCity.TextBoxFont = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            // 
            // CityControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 71, 160);
            Controls.Add(lblCity);
            Controls.Add(autoCompleteControlCity);
            Margin = new Padding(0, 0, 5, 0);
            Name = "CityControl";
            Size = new Size(281, 26);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.AutoLabel lblCity;
        private AutoCompleteControl autoCompleteControlCity;
    }
}
