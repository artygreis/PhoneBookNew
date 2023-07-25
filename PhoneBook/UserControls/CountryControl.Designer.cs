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
            this.autoCompleteControlCountry = new PhoneBook.UserControls.AutoCompleteControl();
            this.lblCountry = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.SuspendLayout();
            // 
            // autoCompleteControlCountry
            // 
            this.autoCompleteControlCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.autoCompleteControlCountry.AutoSize = true;
            this.autoCompleteControlCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.autoCompleteControlCountry.Location = new System.Drawing.Point(83, 0);
            this.autoCompleteControlCountry.MinimumSize = new System.Drawing.Size(150, 26);
            this.autoCompleteControlCountry.Name = "autoCompleteControlCountry";
            this.autoCompleteControlCountry.Size = new System.Drawing.Size(206, 26);
            this.autoCompleteControlCountry.TabIndex = 0;
            this.autoCompleteControlCountry.TextBoxFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            // 
            // lblCountry
            // 
            this.lblCountry.DX = -80;
            this.lblCountry.DY = 3;
            this.lblCountry.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCountry.ForeColor = System.Drawing.Color.White;
            this.lblCountry.LabeledControl = this.autoCompleteControlCountry;
            this.lblCountry.Location = new System.Drawing.Point(3, 3);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(76, 19);
            this.lblCountry.TabIndex = 1;
            this.lblCountry.Text = "Страна:";
            // 
            // CountryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.autoCompleteControlCountry);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.Name = "CountryControl";
            this.Size = new System.Drawing.Size(292, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AutoCompleteControl autoCompleteControlCountry;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblCountry;
    }
}
