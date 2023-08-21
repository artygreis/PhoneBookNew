namespace PhoneBook.UserControls
{
    partial class CountryControl
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
            autoCompleteControlCountry = new AutoCompleteControl();
            lblCountry = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            SuspendLayout();
            // 
            // autoCompleteControlCountry
            // 
            autoCompleteControlCountry.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            autoCompleteControlCountry.AutoSize = true;
            autoCompleteControlCountry.BackColor = Color.FromArgb(0, 71, 160);
            autoCompleteControlCountry.Location = new Point(83, 0);
            autoCompleteControlCountry.Margin = new Padding(3, 2, 3, 2);
            autoCompleteControlCountry.MinimumSize = new Size(110, 26);
            autoCompleteControlCountry.Name = "autoCompleteControlCountry";
            autoCompleteControlCountry.Size = new Size(206, 26);
            autoCompleteControlCountry.TabIndex = 0;
            autoCompleteControlCountry.TextBoxFont = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            // 
            // lblCountry
            // 
            lblCountry.DX = -80;
            lblCountry.DY = 3;
            lblCountry.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCountry.ForeColor = Color.White;
            lblCountry.LabeledControl = autoCompleteControlCountry;
            lblCountry.Location = new Point(3, 3);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(76, 19);
            lblCountry.TabIndex = 1;
            lblCountry.Text = "Страна:";
            // 
            // CountryControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 71, 160);
            Controls.Add(lblCountry);
            Controls.Add(autoCompleteControlCountry);
            Margin = new Padding(0, 0, 5, 0);
            Name = "CountryControl";
            Size = new Size(292, 26);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AutoCompleteControl autoCompleteControlCountry;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblCountry;
    }
}
