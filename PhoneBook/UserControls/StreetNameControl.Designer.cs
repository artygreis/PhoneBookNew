namespace PhoneBook.UserControls
{
    partial class StreetNameControl
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
            this.lblStreetName = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoCompleteControlStreetName = new PhoneBook.UserControls.AutoCompleteControl();
            this.SuspendLayout();
            // 
            // lblStreetName
            // 
            this.lblStreetName.DY = -24;
            this.lblStreetName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStreetName.ForeColor = System.Drawing.Color.White;
            this.lblStreetName.Gap = 5;
            this.lblStreetName.LabeledControl = this.autoCompleteControlStreetName;
            this.lblStreetName.Location = new System.Drawing.Point(3, 2);
            this.lblStreetName.Name = "lblStreetName";
            this.lblStreetName.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
            this.lblStreetName.Size = new System.Drawing.Size(193, 19);
            this.lblStreetName.TabIndex = 8;
            this.lblStreetName.Text = "Наименование улицы:";
            // 
            // autoCompleteControlStreetName
            // 
            this.autoCompleteControlStreetName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.autoCompleteControlStreetName.AutoSize = true;
            this.autoCompleteControlStreetName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.autoCompleteControlStreetName.Location = new System.Drawing.Point(3, 26);
            this.autoCompleteControlStreetName.MinimumSize = new System.Drawing.Size(150, 26);
            this.autoCompleteControlStreetName.Name = "autoCompleteControlStreetName";
            this.autoCompleteControlStreetName.Size = new System.Drawing.Size(253, 26);
            this.autoCompleteControlStreetName.TabIndex = 7;
            this.autoCompleteControlStreetName.TextBoxFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            // 
            // StreetNameControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.Controls.Add(this.lblStreetName);
            this.Controls.Add(this.autoCompleteControlStreetName);
            this.Name = "StreetNameControl";
            this.Size = new System.Drawing.Size(259, 54);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.AutoLabel lblStreetName;
        private AutoCompleteControl autoCompleteControlStreetName;
    }
}
