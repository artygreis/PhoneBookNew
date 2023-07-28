namespace PhoneBook.UserControls
{
    partial class TypeStreetControl
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
            this.lblTypeStreet = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoCompleteControlTypeStreet = new PhoneBook.UserControls.AutoCompleteControl();
            this.SuspendLayout();
            // 
            // lblTypeStreet
            // 
            this.lblTypeStreet.DY = -24;
            this.lblTypeStreet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTypeStreet.ForeColor = System.Drawing.Color.White;
            this.lblTypeStreet.Gap = 5;
            this.lblTypeStreet.LabeledControl = this.autoCompleteControlTypeStreet;
            this.lblTypeStreet.Location = new System.Drawing.Point(3, 2);
            this.lblTypeStreet.Name = "lblTypeStreet";
            this.lblTypeStreet.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
            this.lblTypeStreet.Size = new System.Drawing.Size(95, 19);
            this.lblTypeStreet.TabIndex = 8;
            this.lblTypeStreet.Text = "Тип улицы:";
            // 
            // autoCompleteControlTypeStreet
            // 
            this.autoCompleteControlTypeStreet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.autoCompleteControlTypeStreet.AutoSize = true;
            this.autoCompleteControlTypeStreet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.autoCompleteControlTypeStreet.Location = new System.Drawing.Point(3, 26);
            this.autoCompleteControlTypeStreet.MinimumSize = new System.Drawing.Size(100, 26);
            this.autoCompleteControlTypeStreet.Name = "autoCompleteControlTypeStreet";
            this.autoCompleteControlTypeStreet.Size = new System.Drawing.Size(141, 26);
            this.autoCompleteControlTypeStreet.TabIndex = 7;
            this.autoCompleteControlTypeStreet.TextBoxFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            // 
            // TypeStreetControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.Controls.Add(this.lblTypeStreet);
            this.Controls.Add(this.autoCompleteControlTypeStreet);
            this.Name = "TypeStreetControl";
            this.Size = new System.Drawing.Size(147, 54);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.AutoLabel lblTypeStreet;
        private AutoCompleteControl autoCompleteControlTypeStreet;
    }
}
